using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace SeaNoteApp
{
    public partial class MaintenanceEngineerForm : Form
    {
        private long selectedMaintId = -1L;
        private List<Maintenance> maintList = new List<Maintenance>();
        private List<Ship> shipList = new List<Ship>();

        public MaintenanceEngineerForm()
        {
            InitializeComponent();
        }

        private void MaintenanceEngineerForm_Load(object sender, EventArgs e)
        {
            LoadKapalComboBox();
            LoadMaintenanceToGrid();
            ClearMaintForm();

            cbStatus.Items.Add("scheduled");
            cbStatus.Items.Add("in_progress");
            cbStatus.Items.Add("completed");
            cbStatus.Items.Add("cancelled");
            cbStatus.SelectedItem = "scheduled";
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
                        KapalId = Convert.ToInt64(reader["kapal_id"]),
                        Name = reader["name"].ToString() ?? ""
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

        private void LoadMaintenanceToGrid()
        {
            maintList.Clear();
            dataGridViewMaint.DataSource = null;

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                var sql = @"
                    SELECT * FROM public.maintenance 
                    WHERE status IN ('scheduled', 'in_progress') 
                    ORDER BY maintenance_date";
                using var cmd = new NpgsqlCommand(sql, conn);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maintList.Add(new Maintenance
                    {
                        MaintenanceId = Convert.ToInt64(reader["maintenance_id"]),
                        KapalId = Convert.ToInt64(reader["kapal_id"]),
                        MaintenanceTitle = reader["maintenance_title"].ToString() ?? "",
                        Description = reader["description"]?.ToString(),
                        Status = reader["status"].ToString() ?? "scheduled",
                        MaintenanceDate = reader["maintenance_date"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["maintenance_date"]
                    });
                }

                dataGridViewMaint.DataSource = maintList;

                if (dataGridViewMaint.Columns.Count > 0)
                {
                    dataGridViewMaint.Columns["MaintenanceId"].Visible = false;
                    dataGridViewMaint.Columns["KapalId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data maintenance: " + ex.Message);
            }
        }

        private void ClearMaintForm()
        {
            cbKapal.SelectedIndex = -1;
            tbMaintTitle.Text = "";
            tbMaintDescription.Text = "";
            dtpMaintenanceDate.Value = DateTime.Now;
            cbStatus.SelectedItem = "scheduled";
            selectedMaintId = -1L; 
            dataGridViewMaint.ClearSelection();

            tbMaintTitle.Enabled = true;
            tbMaintDescription.Enabled = true;
            cbKapal.Enabled = true;
            dtpMaintenanceDate.Enabled = true;
        }

        private void DataGridViewMaint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMaint.Rows[e.RowIndex];

                selectedMaintId = Convert.ToInt64(row.Cells["MaintenanceId"].Value);
                cbKapal.SelectedValue = Convert.ToInt64(row.Cells["KapalId"].Value);

                tbMaintTitle.Text = row.Cells["MaintenanceTitle"].Value.ToString();
                tbMaintDescription.Text = row.Cells["Description"]?.Value?.ToString();
                dtpMaintenanceDate.Value = (DateTime)(row.Cells["MaintenanceDate"].Value ?? DateTime.Now);
                cbStatus.SelectedItem = row.Cells["Status"].Value.ToString();

                tbMaintTitle.Enabled = false;
                tbMaintDescription.Enabled = false;
                cbKapal.Enabled = false;
                dtpMaintenanceDate.Enabled = false;
            }
        }

        private void BtnAddMaint_Click(object sender, EventArgs e)
        {
            if (cbKapal.SelectedValue == null) { MessageBox.Show("Pilih kapal"); return; }
            if (string.IsNullOrWhiteSpace(tbMaintTitle.Text)) { MessageBox.Show("Judul wajib diisi"); return; }

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                var sql = @"
                    INSERT INTO public.maintenance 
                    (kapal_id, maintenance_title, description, status, maintenance_date) 
                    VALUES 
            (@kapal_id, @title, @desc, CAST(@status AS maintenance_status), @date)";

                using var cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("kapal_id", NpgsqlDbType.Bigint) { Value = (long)cbKapal.SelectedValue });
                cmd.Parameters.AddWithValue("title", tbMaintTitle.Text);
                cmd.Parameters.AddWithValue("desc", string.IsNullOrEmpty(tbMaintDescription.Text) ? (object)DBNull.Value : tbMaintDescription.Text);
                cmd.Parameters.AddWithValue("status", cbStatus.SelectedItem?.ToString() ?? "scheduled");
                cmd.Parameters.AddWithValue("date", dtpMaintenanceDate.Value.Date);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Jadwal maintenance baru berhasil ditambah!");
                LoadMaintenanceToGrid();
                ClearMaintForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal nambah maintenance: " + ex.Message);
            }
        }

        private void BtnUpdateMaint_Click(object sender, EventArgs e)
        {
            if (selectedMaintId <= 0) { MessageBox.Show("Pilih data dulu"); return; }

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                var sql = @"
                    UPDATE public.maintenance 
            SET status = CAST(@status AS maintenance_status)
                    WHERE maintenance_id = @maint_id";

                using var cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("status", cbStatus.SelectedItem?.ToString() ?? "scheduled");
                cmd.Parameters.Add(new NpgsqlParameter("maint_id", NpgsqlDbType.Bigint) { Value = selectedMaintId });

                cmd.ExecuteNonQuery();

                MessageBox.Show("Status maintenance berhasil di-update!");
                LoadMaintenanceToGrid();
                ClearMaintForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update status: " + ex.Message);
            }
        }

    }
}