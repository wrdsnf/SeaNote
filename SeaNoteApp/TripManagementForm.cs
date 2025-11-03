using SeaNote.Models;
using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using System.Collections.Generic;

namespace SeaNoteApp
{
    public partial class TripManagementForm : Form
    {
        private long selectedTripId = 0;
        private List<Ship> shipList = new List<Ship>();

        public TripManagementForm()
        {
            InitializeComponent();
        }

        private void TripManagementForm_Load(object sender, EventArgs e)
        {
            LoadKapalComboBox();
            LoadTripsToGrid();
            ClearTripForm();
        }

        private void LoadKapalComboBox()
        {
            shipList.Clear();
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "SELECT kapal_id, name FROM public.kapal ORDER BY name";
                using var cmd = new NpgsqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    shipList.Add(new Ship
                    {
                        KapalId = reader["kapal_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["kapal_id"]),
                        Name = reader["name"]?.ToString() ?? ""
                    });
                }

                cbKapal.DataSource = shipList;
                cbKapal.DisplayMember = "Name";
                cbKapal.ValueMember = "KapalId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data kapal: " + ex.Message);
            }
        }

        private void LoadTripsToGrid()
        {
            dataGridViewTrips.DataSource = null;
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = @"
                    SELECT 
                        t.trip_id, t.kapal_id, k.name AS nama_kapal, 
                        t.tanggal_berangkat, t.tanggal_sampai, 
                        t.titik_berangkat, t.nahkoda, t.notes
                    FROM public.trips t
                    LEFT JOIN public.kapal k ON t.kapal_id = k.kapal_id
                    ORDER BY t.tanggal_berangkat DESC";
                using var cmd = new NpgsqlCommand(sql, conn);
                var dt = new DataTable();
                var adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridViewTrips.DataSource = dt;

                if (dataGridViewTrips.Columns.Count > 0)
                {
                    if (dataGridViewTrips.Columns.Contains("trip_id")) dataGridViewTrips.Columns["trip_id"].Visible = false;
                    if (dataGridViewTrips.Columns.Contains("kapal_id")) dataGridViewTrips.Columns["kapal_id"].Visible = false;
                    if (dataGridViewTrips.Columns.Contains("nama_kapal")) dataGridViewTrips.Columns["nama_kapal"].HeaderText = "Nama Kapal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data trip: " + ex.Message);
            }
        }

        private void ClearTripForm()
        {
            cbKapal.SelectedIndex = -1;
            dtpTanggalBerangkat.Value = DateTime.Now;
            dtpTanggalSampai.Value = DateTime.Now.AddDays(1);
            tbTitikBerangkat.Text = "";
            tbNakhoda.Text = "";
            tbNotes.Text = "";

            selectedTripId = 0;
            dataGridViewTrips.ClearSelection();

            btnManageTasks.Enabled = false;
            btnManageLogs.Enabled = false;
        }

        private void DataGridViewTrips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridViewTrips.Rows[e.RowIndex];
            // safe convert
            selectedTripId = row.Cells["trip_id"].Value == DBNull.Value || row.Cells["trip_id"].Value == null
                ? 0L
                : Convert.ToInt64(row.Cells["trip_id"].Value);

            if (row.Cells["kapal_id"].Value != DBNull.Value && row.Cells["kapal_id"].Value != null)
                cbKapal.SelectedValue = Convert.ToInt64(row.Cells["kapal_id"].Value);
            else
                cbKapal.SelectedIndex = -1;

            dtpTanggalBerangkat.Value = row.Cells["tanggal_berangkat"].Value == DBNull.Value || row.Cells["tanggal_berangkat"].Value == null
                ? DateTime.Now : Convert.ToDateTime(row.Cells["tanggal_berangkat"].Value);

            dtpTanggalSampai.Value = row.Cells["tanggal_sampai"].Value == DBNull.Value || row.Cells["tanggal_sampai"].Value == null
                ? DateTime.Now.AddDays(1) : Convert.ToDateTime(row.Cells["tanggal_sampai"].Value);

            tbTitikBerangkat.Text = row.Cells["titik_berangkat"].Value?.ToString() ?? "";
            tbNakhoda.Text = row.Cells["nahkoda"].Value?.ToString() ?? "";
            tbNotes.Text = row.Cells["notes"].Value?.ToString() ?? "";

            btnManageTasks.Enabled = true;
            btnManageLogs.Enabled = true;
        }

        private void BtnAddTrip_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = @"
                    INSERT INTO public.trips 
                    (kapal_id, tanggal_berangkat, tanggal_sampai, titik_berangkat, nahkoda, notes) 
                    VALUES 
                    (@kapal_id, @tgl_berangkat, @tgl_sampai, @titik, @nahkoda, @notes)";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("kapal_id", NpgsqlDbType.Bigint) { Value = cbKapal.SelectedValue == null ? (object)DBNull.Value : Convert.ToInt64(cbKapal.SelectedValue) });
                cmd.Parameters.AddWithValue("tgl_berangkat", dtpTanggalBerangkat.Value);
                cmd.Parameters.AddWithValue("tgl_sampai", dtpTanggalSampai.Value);
                cmd.Parameters.AddWithValue("titik", tbTitikBerangkat.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("nahkoda", tbNakhoda.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("notes", tbNotes.Text ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Trip baru berhasil ditambah!");
                LoadTripsToGrid();
                ClearTripForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal nambah trip: " + ex.Message);
            }
        }

        private void BtnUpdateTrip_Click(object sender, EventArgs e)
        {
            if (selectedTripId == 0) { MessageBox.Show("Pilih trip dulu"); return; }
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = @"
                    UPDATE public.trips 
                    SET kapal_id = @kapal_id, tanggal_berangkat = @tgl_berangkat, 
                        tanggal_sampai = @tgl_sampai, titik_berangkat = @titik, 
                        nahkoda = @nahkoda, notes = @notes
                    WHERE trip_id = @trip_id";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("kapal_id", NpgsqlDbType.Bigint) { Value = cbKapal.SelectedValue == null ? (object)DBNull.Value : Convert.ToInt64(cbKapal.SelectedValue) });
                cmd.Parameters.AddWithValue("tgl_berangkat", dtpTanggalBerangkat.Value);
                cmd.Parameters.AddWithValue("tgl_sampai", dtpTanggalSampai.Value);
                cmd.Parameters.AddWithValue("titik", tbTitikBerangkat.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("nahkoda", tbNakhoda.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("notes", tbNotes.Text ?? (object)DBNull.Value);
                cmd.Parameters.Add(new NpgsqlParameter("trip_id", NpgsqlDbType.Bigint) { Value = selectedTripId });
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data trip berhasil di-update!");
                LoadTripsToGrid();
                ClearTripForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update trip: " + ex.Message);
            }
        }

        private void BtnDeleteTrip_Click(object sender, EventArgs e)
        {
            if (selectedTripId == 0) { MessageBox.Show("Pilih trip dulu"); return; }
            if (MessageBox.Show("Yakin mau hapus trip ini? (ON DELETE CASCADE!)", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "DELETE FROM public.trips WHERE trip_id = @trip_id";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("trip_id", NpgsqlDbType.Bigint) { Value = selectedTripId });
                cmd.ExecuteNonQuery();

                MessageBox.Show("Trip berhasil dihapus.");
                LoadTripsToGrid();
                ClearTripForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal hapus trip: " + ex.Message);
            }
        }

        private void BtnManageTasks_Click(object sender, EventArgs e)
        {
            if (selectedTripId == 0) return;
            var f = new TaskManagementForm(selectedTripId);
            f.ShowDialog();
        }

        private void BtnManageLogs_Click(object sender, EventArgs e)
        {
            if (selectedTripId == 0) return;
            var f = new LogManagementForm(selectedTripId);
            f.ShowDialog();
        }

        private void labelKapal_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
