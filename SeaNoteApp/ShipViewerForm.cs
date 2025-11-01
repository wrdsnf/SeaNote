using Npgsql;
using SeaNote.Models;
using SeaNoteApp.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SeaNoteApp
{
    public partial class ShipViewerForm : Form
    {
        private List<Ship> shipList = new List<Ship>();
        private long selectedShipId = 0;

        public ShipViewerForm()
        {
            InitializeComponent();
        }

        private void ShipViewerForm_Load(object sender, EventArgs e)
        {
            dataGridViewShips.ReadOnly = true;
            dataGridViewShips.AllowUserToAddRows = false;
            LoadShipsToGrid();
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
                        KapalId = DbUtils.SafeGetLong(reader["kapal_id"]),
                        Name = DbUtils.SafeGetString(reader["name"]),
                        Year = reader["year"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["year"]),
                        Capacity = reader["capacity"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["capacity"]),
                        TotalTrip = reader["total_trip"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["total_trip"]),
                        Fuel = reader["fuel"] == DBNull.Value ? null : reader["fuel"].ToString()
                    });
                }
                dataGridViewShips.DataSource = shipList;
                if (dataGridViewShips.Columns.Count > 0)
                {
                    if (dataGridViewShips.Columns.Contains("KapalId"))
                        dataGridViewShips.Columns["KapalId"].Width = 120;
                }
            }
            catch (Exception ex) { MessageBox.Show("Gagal ambil data kapal: " + ex.Message); }
        }

        private void dataGridViewShips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridViewShips.Rows[e.RowIndex];
            selectedShipId = DbUtils.SafeGetLong(row.Cells["KapalId"].Value);

            tbShipName.Text = row.Cells["Name"].Value?.ToString() ?? "";
            numYear.Value = row.Cells["Year"].Value == DBNull.Value ? 2000 : Convert.ToDecimal(row.Cells["Year"].Value ?? 2000);
            numCapacity.Value = row.Cells["Capacity"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["Capacity"].Value ?? 0);
            tbFuel.Text = row.Cells["Fuel"].Value?.ToString() ?? "";
            numTotalTrip.Value = row.Cells["TotalTrip"].Value == DBNull.Value ? 0 : Convert.ToDecimal(row.Cells["TotalTrip"].Value ?? 0);

            dataGridViewShips.ClearSelection();
            row.Selected = true;
        }
    }
}
