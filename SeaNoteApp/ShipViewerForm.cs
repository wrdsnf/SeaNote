using SeaNote.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class ShipViewerForm : Form
    {
        public ShipViewerForm()
        {
            InitializeComponent();
            LoadShipsToGrid();
        }

        private void LoadShipsToGrid()
        {
            dataGridViewShips.DataSource = null;
            dataGridViewShips.DataSource = ShipManagementForm.globalDummyShips.ToList();

            dataGridViewShips.Columns["ShipID"].HeaderText = "ID";
            dataGridViewShips.Columns["ShipID"].Width = 50;
            dataGridViewShips.Columns["Name"].Width = 200;
            dataGridViewShips.Columns["TotalTrip"].HeaderText = "Total Trip";
        }
    }
}