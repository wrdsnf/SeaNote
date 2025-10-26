using SeaNote.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class TripManagementForm : Form
    {
        public static List<Trip> globalDummyTrips = new List<Trip>
        {
            new Trip
            {
                TripID = 1, KodeTrip = "TRP-001", NamaKapal = "KM. Jaya Abadi",
                TanggalBerangkat = DateTime.Now.AddDays(-5), TanggalSampai = DateTime.Now.AddDays(-2),
                TitikBerangkat = "Pelabuhan A", Nakhoda = "Jono", UserID = 1
            },
            new Trip
            {
                TripID = 2, KodeTrip = "TRP-002", NamaKapal = "KM. Sinar Bahari",
                TanggalBerangkat = DateTime.Now.AddDays(-3), TanggalSampai = null,
                TitikBerangkat = "Pelabuhan B", Nakhoda = "Budi", UserID = 1
            }
        };

        private int selectedTripId = -1;

        public TripManagementForm()
        {
            InitializeComponent();
            LoadTripsToGrid();
        }

        private void LoadTripsToGrid()
        {
            dataGridViewTrips.DataSource = null;
            dataGridViewTrips.DataSource = globalDummyTrips.ToList();

            dataGridViewTrips.Columns["TripID"].Width = 50;
            dataGridViewTrips.Columns["KodeTrip"].Width = 120;
            dataGridViewTrips.Columns["NamaKapal"].Width = 150;
            //dataGridViewTrips.Columns["Tasks"].Visible = false;
            //dataGridViewTrips.Columns["Logs"].Visible = false;
            //dataGridViewTrips.Columns["UserID"].Visible = false;
        }

        private void ClearTripForm()
        {
            tbNamaKapal.Text = "";
            dtpTglBerangkat.Value = DateTime.Now;
            dtpTglSampai.Value = DateTime.Now.AddDays(1);
            tbTitikBerangkat.Text = "";
            tbNakhoda.Text = "";
            selectedTripId = -1;
            dataGridViewTrips.ClearSelection();
        }

        private void dataGridViewTrips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTrips.Rows[e.RowIndex];
                selectedTripId = (int)row.Cells["TripID"].Value;
                tbNamaKapal.Text = row.Cells["NamaKapal"].Value.ToString();
                dtpTglBerangkat.Value = (DateTime)row.Cells["TanggalBerangkat"].Value;

                if (row.Cells["TanggalSampai"].Value != null && row.Cells["TanggalSampai"].Value != DBNull.Value)
                {
                    dtpTglSampai.Value = (DateTime)row.Cells["TanggalSampai"].Value;
                }
                else
                {
                    dtpTglSampai.Value = dtpTglBerangkat.Value.AddDays(1);
                }

                tbTitikBerangkat.Text = row.Cells["TitikBerangkat"].Value.ToString();
                tbNakhoda.Text = row.Cells["Nakhoda"].Value.ToString();
            }
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            try
            {
                Trip newTrip = new Trip
                {
                    TripID = globalDummyTrips.Count > 0 ? globalDummyTrips.Max(t => t.TripID) + 1 : 1,
                    NamaKapal = tbNamaKapal.Text,
                    TanggalBerangkat = dtpTglBerangkat.Value,
                    TanggalSampai = dtpTglSampai.Value,
                    TitikBerangkat = tbTitikBerangkat.Text,
                    Nakhoda = tbNakhoda.Text,
                    UserID = (LoginPage.loggedInUser?.UserID) ?? -1
                };
                newTrip.KodeTrip = newTrip.GenerateKodeTrip();

                globalDummyTrips.Add(newTrip);
                LoadTripsToGrid();
                ClearTripForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Pastikan semua data diisi. \n" + ex.Message);
            }
        }

        private void btnUpdateTrip_Click(object sender, EventArgs e)
        {
            if (selectedTripId == -1) { MessageBox.Show("Pilih trip dulu"); return; }
            try
            {
                Trip? tripToUpdate = globalDummyTrips.Find(t => t.TripID == selectedTripId);
                if (tripToUpdate != null)
                {
                    tripToUpdate.EditTrip(
                        namaKapal: tbNamaKapal.Text,
                        tglBerangkat: dtpTglBerangkat.Value,
                        tglSampai: dtpTglSampai.Value,
                        titik: tbTitikBerangkat.Text,
                        nahkoda: tbNakhoda.Text
                    );
                }
                LoadTripsToGrid();
                ClearTripForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
