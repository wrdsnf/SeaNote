using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace SeaNoteApp
{
    public partial class MaintenanceHistoryEngineerForm : Form
    {
        private List<Maintenance> maintList = new List<Maintenance>();

        public MaintenanceHistoryEngineerForm()
        {
            InitializeComponent();
        }

        private void MaintenanceHistoryEngineerForm_Load(object sender, EventArgs e)
        {
            dataGridViewMaintHistory.ReadOnly = true;
            dataGridViewMaintHistory.AllowUserToAddRows = false;
            LoadMaintenanceHistory();
        }

        private void LoadMaintenanceHistory()
        {
            maintList.Clear();
            dataGridViewMaintHistory.DataSource = null;
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                var sql = @"
                    SELECT * FROM public.maintenance 
                    WHERE status IN ('completed', 'cancelled') 
                    ORDER BY maintenance_date DESC";

                using var cmd = new NpgsqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    maintList.Add(new Maintenance
                    {
                        MaintenanceId = Convert.ToInt64(reader["maintenance_id"]),
                        KapalId = Convert.ToInt64(reader["kapal_id"]),
                        MaintenanceTitle = reader["maintenance_title"]?.ToString() ?? "",
                        Description = reader["description"]?.ToString(),
                        Status = reader["status"]?.ToString() ?? "",
                        MaintenanceDate = reader["maintenance_date"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["maintenance_date"]
                    });
                }

                dataGridViewMaintHistory.DataSource = maintList;

                if (dataGridViewMaintHistory.Columns.Count > 0)
                {
                    dataGridViewMaintHistory.Columns["MaintenanceId"].Visible = false;
                    dataGridViewMaintHistory.Columns["KapalId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data riwayat: " + ex.Message);
            }
        }
    }
}