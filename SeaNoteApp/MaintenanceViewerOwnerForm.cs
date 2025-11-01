using SeaNote.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class MaintenanceViewerOwnerForm : Form
    {
        public MaintenanceViewerOwnerForm()
        {
            InitializeComponent();
            LoadMaintenanceToGrid();
        }

        private void LoadMaintenanceToGrid()
        {
            // Owner liat semua status
            dataGridViewMaint.DataSource = null;
            dataGridViewMaint.DataSource = AddMaintenanceEngineerForm.globalDummyMaintenance.ToList();

            if (dataGridViewMaint.Columns.Count > 0)
            {
                dataGridViewMaint.Columns["MaintenanceID"].Width = 50;
                dataGridViewMaint.Columns["ShipID"].Visible = false;
            }
        }
    }
}