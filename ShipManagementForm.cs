using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class ShipManagementForm : Form
    {
        public static List<Ship> globalDummyShips = new List<Ship>
        {
            new Ship
            {
                ShipID = 1, Name = "KM. Jaya Abadi", Year = 2015, Capacity = 500,
                Fuel = 10000, TotalTrip = 120, Maintenance = new DateTime(2025, 1, 15)
            },
            new Ship
            {
                ShipID = 2, Name = "KM. Sinar Bahari", Year = 2018, Capacity = 750,
                Fuel = 15000, TotalTrip = 88, Maintenance = new DateTime(2025, 3, 5)
            }
        };

        private int selectedShipId = -1;

        public ShipManagementForm()
        {
            InitializeComponent();
            LoadShipsToGrid();
        }

        private void LoadShipsToGrid()
        {
            dataGridViewShips.DataSource = null;
            dataGridViewShips.DataSource = globalDummyShips.ToList();

            dataGridViewShips.Columns["ShipID"].HeaderText = "ID";
            dataGridViewShips.Columns["ShipID"].Width = 50;
            dataGridViewShips.Columns["Name"].Width = 200;
            dataGridViewShips.Columns["TotalTrip"].HeaderText = "Total Trip";
        }

        private void ClearForm()
        {
            tbShipName.Text = "";
            tbShipYear.Text = "";
            tbShipCapacity.Text = "";
            tbShipFuel.Text = "";
            tbShipTotalTrip.Text = "";
            dtpMaintenance.Value = DateTime.Now;
            selectedShipId = -1;
            dataGridViewShips.ClearSelection();
        }

        private void dataGridViewShips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewShips.Rows[e.RowIndex];
                selectedShipId = (int)row.Cells["ShipID"].Value;
                tbShipName.Text = row.Cells["Name"].Value.ToString();
                tbShipYear.Text = row.Cells["Year"].Value.ToString();
                tbShipCapacity.Text = row.Cells["Capacity"].Value.ToString();
                tbShipFuel.Text = row.Cells["Fuel"].Value.ToString();
                tbShipTotalTrip.Text = row.Cells["TotalTrip"].Value.ToString();
                dtpMaintenance.Value = (DateTime)row.Cells["Maintenance"].Value;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Ship newShip = new Ship
                {
                    ShipID = globalDummyShips.Count > 0 ? globalDummyShips.Max(s => s.ShipID) + 1 : 1,
                    Name = tbShipName.Text,
                    Year = int.Parse(tbShipYear.Text),
                    Capacity = int.Parse(tbShipCapacity.Text),
                    Fuel = int.Parse(tbShipFuel.Text),
                    TotalTrip = int.Parse(tbShipTotalTrip.Text),
                    Maintenance = dtpMaintenance.Value
                };

                globalDummyShips.Add(newShip);
                LoadShipsToGrid();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Pastikan semua data diisi dengan benar. \n" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedShipId == -1) { MessageBox.Show("Pilih kapal dulu"); return; }
            try
            {
                Ship? shipToUpdate = globalDummyShips.Find(s => s.ShipID == selectedShipId);
                if (shipToUpdate != null)
                {
                    shipToUpdate.Name = tbShipName.Text;
                    shipToUpdate.Year = int.Parse(tbShipYear.Text);
                    shipToUpdate.Capacity = int.Parse(tbShipCapacity.Text);
                    shipToUpdate.Fuel = int.Parse(tbShipFuel.Text);
                    shipToUpdate.TotalTrip = int.Parse(tbShipTotalTrip.Text);
                    shipToUpdate.Maintenance = dtpMaintenance.Value;
                }
                LoadShipsToGrid();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedShipId == -1) { MessageBox.Show("Pilih kapal dulu"); return; }

            var confirmResult = MessageBox.Show("Yakin mau hapus kapal ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Ship? shipToDelete = globalDummyShips.Find(s => s.ShipID == selectedShipId);
                if (shipToDelete != null)
                {
                    globalDummyShips.Remove(shipToDelete);
                }
                LoadShipsToGrid();
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}