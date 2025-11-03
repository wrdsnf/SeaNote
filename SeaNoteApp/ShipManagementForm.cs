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
    public partial class ShipManagementForm : Form
    {
        private long selectedShipId = -1L;
        private List<Ship> shipList = new List<Ship>();

        public ShipManagementForm()
        {
            InitializeComponent();
        }

        private void ShipManagementForm_Load(object sender, EventArgs e)
        {
            LoadShipsToGrid();
            ClearShipForm();
        }

        private void LoadShipsToGrid()
        {
            shipList.Clear();
            dataGridViewShips.DataSource = null;

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "SELECT * FROM public.kapal ORDER BY name";
                using var cmd = new NpgsqlCommand(sql, conn);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    shipList.Add(new Ship
                    {
                        KapalId = Convert.ToInt64(reader["kapal_id"]),
                        Name = reader["name"].ToString(),
                        Year = reader["year"] == DBNull.Value ? (int?)null : (int)reader["year"],
                        Capacity = reader["capacity"] == DBNull.Value ? (int?)null : (int)reader["capacity"],
                        TotalTrip = reader["total_trip"] == DBNull.Value ? (int?)null : (int)reader["total_trip"],
                        Fuel = reader["fuel"] == DBNull.Value ? null : reader["fuel"].ToString()
                    });
                }
                dataGridViewShips.DataSource = shipList;

                if (dataGridViewShips.Columns.Count > 0)
                {
                    dataGridViewShips.Columns["KapalId"].Width = 50;
                    dataGridViewShips.Columns["Name"].Width = 150;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data kapal: " + ex.Message);
            }
        }

        private void ClearShipForm()
        {
            tbShipName.Text = "";
            numYear.Value = 2000;
            numCapacity.Value = 100;
            tbFuel.Text = "";
            numTotalTrip.Value = 0;

            selectedShipId = -1L; 
            dataGridViewShips.ClearSelection();
        }

        private void dataGridViewShips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            var row = dataGridViewShips.Rows[e.RowIndex];

            selectedShipId = row.Cells["KapalId"].Value == null || row.Cells["KapalId"].Value == DBNull.Value
                ? 0L : Convert.ToInt64(row.Cells["KapalId"].Value);

            tbShipName.Text = row.Cells["Name"].Value?.ToString() ?? "";
            numYear.Value = row.Cells["Year"].Value == DBNull.Value || row.Cells["Year"].Value == null ? 2000 : Convert.ToInt32(row.Cells["Year"].Value);
            numCapacity.Value = row.Cells["Capacity"].Value == DBNull.Value || row.Cells["Capacity"].Value == null ? 0 : Convert.ToInt32(row.Cells["Capacity"].Value);
            tbFuel.Text = row.Cells["Fuel"].Value?.ToString() ?? "";
            numTotalTrip.Value = row.Cells["TotalTrip"].Value == DBNull.Value || row.Cells["TotalTrip"].Value == null ? 0 : Convert.ToInt32(row.Cells["TotalTrip"].Value);
        }


        private void btnAddShip_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = @"
                    INSERT INTO public.kapal (name, year, capacity, total_trip, fuel) 
                    VALUES (@name, @year, @capacity, @total_trip, @fuel)";
                using var cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("name", tbShipName.Text);
                cmd.Parameters.AddWithValue("year", (int)numYear.Value);
                cmd.Parameters.AddWithValue("capacity", (int)numCapacity.Value);
                cmd.Parameters.AddWithValue("total_trip", (int)numTotalTrip.Value);
                cmd.Parameters.AddWithValue("fuel", tbFuel.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kapal baru berhasil ditambah!");
                LoadShipsToGrid();
                ClearShipForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal nambah kapal: " + ex.Message);
            }
        }

        private void btnUpdateShip_Click(object sender, EventArgs e)
        {
            if (selectedShipId <= 0) { MessageBox.Show("Pilih kapal dulu"); return; }
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = @"
                    UPDATE public.kapal 
                    SET name = @name, year = @year, capacity = @capacity, 
                        total_trip = @total_trip, fuel = @fuel 
                    WHERE kapal_id = @kapal_id";
                using var cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("name", tbShipName.Text);
                cmd.Parameters.AddWithValue("year", (int)numYear.Value);
                cmd.Parameters.AddWithValue("capacity", (int)numCapacity.Value);
                cmd.Parameters.AddWithValue("total_trip", (int)numTotalTrip.Value);
                cmd.Parameters.AddWithValue("fuel", tbFuel.Text);

                cmd.Parameters.Add(new NpgsqlParameter("kapal_id", NpgsqlDbType.Bigint) { Value = selectedShipId });

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data kapal berhasil di-update!");
                LoadShipsToGrid();
                ClearShipForm();
            }
            catch (Exception ex) { MessageBox.Show("Gagal update kapal: " + ex.Message); }
        }

        private void btnDeleteShip_Click(object sender, EventArgs e)
        {
            if (selectedShipId <= 0) { MessageBox.Show("Pilih kapal dulu"); return; } 
            if (MessageBox.Show("Yakin mau hapus kapal ini? (Semua trip & maintenance kapal ini akan ikut terhapus!)",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "DELETE FROM public.kapal WHERE kapal_id = @kapal_id";
                using var cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("kapal_id", NpgsqlDbType.Bigint) { Value = selectedShipId });

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kapal berhasil dihapus.");
                LoadShipsToGrid();
                ClearShipForm();
            }
            catch (Exception ex) { MessageBox.Show("Gagal hapus kapal: " + ex.Message); }
        }
    }
}