using SeaNote.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class TripViewerForm : Form
    {
        public TripViewerForm()
        {
            InitializeComponent();
            LoadTripsToGrid();
        }

        private void LoadTripsToGrid()
        {
            // Ambil data dari list global di TripManagementForm
            dataGridViewTrips.DataSource = null;
            dataGridViewTrips.DataSource = TripManagementForm.globalDummyTrips.ToList();

            dataGridViewTrips.Columns["TripID"].Width = 50;
            dataGridViewTrips.Columns["KodeTrip"].Width = 120;
            dataGridViewTrips.Columns["NamaKapal"].Width = 150;
            //dataGridViewTrips.Columns["Tasks"].Visible = false;
            //dataGridViewTrips.Columns["Logs"].Visible = false;
            //dataGridViewTrips.Columns["UserID"].Visible = false;
        }
    }
}
