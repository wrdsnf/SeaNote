using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class MaintenanceAdminForm : Form
    {
        // Admin bisa liat semua data maintenance
        private int selectedMaintId = -1;

        public MaintenanceAdminForm()
        {
            InitializeComponent();
            LoadMaintenanceToGrid();
            LoadShipComboBox();
        }

        private void LoadMaintenanceToGrid()
        {
            dataGridViewMaint.DataSource = null;
            // Ambil data dari list global di form Engineer
            dataGridViewMaint.DataSource = AddMaintenanceEngineerForm.globalDummyMaintenance.ToList();

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
                    MaintenanceID = AddMaintenanceEngineerForm.globalDummyMaintenance.Count > 0 ? AddMaintenanceEngineerForm.globalDummyMaintenance.Max(m => m.MaintenanceID) + 1 : 1,
                    ShipID = selectedShip.ShipID,
                    ShipName = selectedShip.Name,
                    Description = tbDescription.Text,
                    DateScheduled = dtpDateScheduled.Value,
                    Status = cbStatus.SelectedItem.ToString() ?? "Pending"
                };

                AddMaintenanceEngineerForm.globalDummyMaintenance.Add(newMaint);
                LoadMaintenanceToGrid();
                ClearMaintForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUpdateMaint_Click(object sender, EventArgs e)
        {
            if (selectedMaintId == -1) { MessageBox.Show("Pilih data dulu"); return; }
            try
            {
                Maintenance? maintToUpdate = AddMaintenanceEngineerForm.globalDummyMaintenance.Find(m => m.MaintenanceID == selectedMaintId);
                if (maintToUpdate != null)
                {
                    // Admin bisa update semua
                    Ship selectedShip = (Ship)cbShips.SelectedItem;
                    maintToUpdate.ShipID = selectedShip.ShipID;
                    maintToUpdate.ShipName = selectedShip.Name;
                    maintToUpdate.Description = tbDescription.Text;
                    maintToUpdate.DateScheduled = dtpDateScheduled.Value;
                    maintToUpdate.Status = cbStatus.SelectedItem.ToString() ?? "Pending";
                }
                LoadMaintenanceToGrid();
                ClearMaintForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDeleteMaint_Click(object sender, EventArgs e)
        {
            if (selectedMaintId == -1) { MessageBox.Show("Pilih data dulu"); return; }
            var confirmResult = MessageBox.Show("Yakin mau hapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Maintenance? maintToDelete = AddMaintenanceEngineerForm.globalDummyMaintenance.Find(m => m.MaintenanceID == selectedMaintId);
                if (maintToDelete != null)
                {
                    AddMaintenanceEngineerForm.globalDummyMaintenance.Remove(maintToDelete);
                }
                LoadMaintenanceToGrid();
                ClearMaintForm();
            }
        }
    }
}
