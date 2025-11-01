using SeaNote.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class AddMaintenanceEngineerForm : Form
    {
        // Database dummy
        public static List<Maintenance> globalDummyMaintenance = new List<Maintenance>
        {
            new Maintenance { MaintenanceID = 1, ShipID = 1, ShipName = "KM. Jaya Abadi",
                Description = "Ganti Oli Mesin", DateScheduled = DateTime.Now.AddDays(2), Status = "Pending" },
            new Maintenance { MaintenanceID = 2, ShipID = 2, ShipName = "KM. Sinar Bahari",
                Description = "Perbaikan Radar", DateScheduled = DateTime.Now.AddDays(-10), Status = "Selesai" }
        };

        private int selectedMaintId = -1;

        public AddMaintenanceEngineerForm()
        {
            InitializeComponent();
            LoadMaintenanceToGrid();
            LoadShipComboBox();
        }

        private void LoadMaintenanceToGrid()
        {
            // Engineer cuma liat yg Pending
            dataGridViewMaint.DataSource = null;
            dataGridViewMaint.DataSource = globalDummyMaintenance.Where(m => m.Status == "Pending").ToList();

            if (dataGridViewMaint.Columns.Count > 0)
            {
                dataGridViewMaint.Columns["MaintenanceID"].Width = 50;
                dataGridViewMaint.Columns["ShipID"].Visible = false;
            }
        }

        private void LoadShipComboBox()
        {
            cbShips.DataSource = ShipManagementForm.globalDummyShips;
            cbShips.DisplayMember = "Name";
            cbShips.ValueMember = "ShipID";
        }

        private void ClearMaintForm()
        {
            cbShips.SelectedIndex = -1;
            tbDescription.Text = "";
            dtpDateScheduled.Value = DateTime.Now;
            cbStatus.SelectedItem = "Pending";
            selectedMaintId = -1;
            dataGridViewMaint.ClearSelection();
        }

        private void dataGridViewMaint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMaint.Rows[e.RowIndex];
                selectedMaintId = (int)row.Cells["MaintenanceID"].Value;

                cbShips.SelectedValue = (int)row.Cells["ShipID"].Value;
                tbDescription.Text = row.Cells["Description"].Value.ToString();
                dtpDateScheduled.Value = (DateTime)row.Cells["DateScheduled"].Value;
                cbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnAddMaint_Click(object sender, EventArgs e)
        {
            if (cbShips.SelectedValue == null) { MessageBox.Show("Pilih kapal"); return; }
            try
            {
                Ship selectedShip = (Ship)cbShips.SelectedItem;

                Maintenance newMaint = new Maintenance
                {
                    MaintenanceID = globalDummyMaintenance.Count > 0 ? globalDummyMaintenance.Max(m => m.MaintenanceID) + 1 : 1,
                    ShipID = selectedShip.ShipID,
                    ShipName = selectedShip.Name,
                    Description = tbDescription.Text,
                    DateScheduled = dtpDateScheduled.Value,
                    Status = "Pending"
                };

                globalDummyMaintenance.Add(newMaint);
                LoadMaintenanceToGrid();
                ClearMaintForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUpdateMaint_Click(object sender, EventArgs e)
        {
            if (selectedMaintId == -1) { MessageBox.Show("Pilih data maintenance dulu"); return; }
            try
            {
                Maintenance? maintToUpdate = globalDummyMaintenance.Find(m => m.MaintenanceID == selectedMaintId);
                if (maintToUpdate != null)
                {
                    maintToUpdate.Status = cbStatus.SelectedItem.ToString() ?? "Pending";
                }
                LoadMaintenanceToGrid();
                ClearMaintForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}