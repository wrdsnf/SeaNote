using SeaNote.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class MaintenanceHistoryEngineerForm : Form
    {
        public MaintenanceHistoryEngineerForm()
        {
            InitializeComponent();
            LoadMaintenanceHistory();
        }

        private void LoadMaintenanceHistory()
        {
            // Engineer liat history yg Selesai atau Gagal
            dataGridViewHistory.DataSource = null;
            dataGridViewHistory.DataSource = AddMaintenanceEngineerForm.globalDummyMaintenance
                .Where(m => m.Status == "Selesai" || m.Status == "Gagal")
                .ToList();

            if (dataGridViewHistory.Columns.Count > 0)
            {
                dataGridViewHistory.Columns["MaintenanceID"].Width = 50;
                dataGridViewHistory.Columns["ShipID"].Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DashboardEngineerForm().Show();
        }
    }
}