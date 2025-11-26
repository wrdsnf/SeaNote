using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;

namespace SeaNoteApp
{
    public partial class MaintenanceViewerOwnerForm : Form
    {
        private List<Maintenance> maintList = new List<Maintenance>();

        public MaintenanceViewerOwnerForm()
        {
            InitializeComponent();
        }

        private void MaintenanceViewerOwnerForm_Load(object sender, EventArgs e)
        {
            dataGridViewMaint.ReadOnly = true;
            dataGridViewMaint.AllowUserToAddRows = false;
            LoadMaintenanceToGrid();
        }

        private void LoadMaintenanceToGrid()
        {
            maintList.Clear();
            dataGridViewMaint.DataSource = null;

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                string sql = @"
                    SELECT maintenance_id, kapal_id, maintenance_title, description, status, maintenance_date 
                    FROM public.maintenance 
                    ORDER BY maintenance_date DESC";

                using var cmd = new NpgsqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var maintenance = new Maintenance
                    {
                        MaintenanceId = reader["maintenance_id"] != DBNull.Value ? Convert.ToInt64(reader["maintenance_id"]) : 0,
                        KapalId = reader["kapal_id"] != DBNull.Value ? Convert.ToInt64(reader["kapal_id"]) : 0,
                        MaintenanceTitle = reader["maintenance_title"]?.ToString() ?? "",
                        Description = reader["description"]?.ToString() ?? "",
                        Status = reader["status"]?.ToString() ?? "",
                        MaintenanceDate = reader["maintenance_date"] == DBNull.Value
                            ? (DateTime?)null
                            : Convert.ToDateTime(reader["maintenance_date"])
                    };

                    maintList.Add(maintenance);
                }

                dataGridViewMaint.DataSource = maintList;

                if (dataGridViewMaint.Columns.Count > 0)
                {
                    if (dataGridViewMaint.Columns.Contains("MaintenanceId"))
                        dataGridViewMaint.Columns["MaintenanceId"].Visible = false;

                    if (dataGridViewMaint.Columns.Contains("KapalId"))
                        dataGridViewMaint.Columns["KapalId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data maintenance: " + ex.Message);
            }
        }
    }
}