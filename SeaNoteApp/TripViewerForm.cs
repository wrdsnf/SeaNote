using SeaNote.Models;
using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace SeaNoteApp
{
    public partial class TripViewerForm : Form
    {
        public TripViewerForm()
        {
            InitializeComponent();
        }

        private void TripViewerForm_Load(object sender, EventArgs e)
        {
            dataGridViewTrips.ReadOnly = true;
            dataGridViewTrips.AllowUserToAddRows = false;
            LoadTripsToGrid();
        }

        private void LoadTripsToGrid()
        {
            dataGridViewTrips.DataSource = null;
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = @"
                    SELECT t.trip_id, k.name as nama_kapal, t.tanggal_berangkat, 
                           t.tanggal_sampai, t.titik_berangkat, t.nahkoda
                    FROM public.trips t
                    LEFT JOIN public.kapal k ON t.kapal_id = k.kapal_id
                    ORDER BY t.tanggal_berangkat DESC";

                using var cmd = new NpgsqlCommand(sql, conn);
                var dt = new DataTable();
                var adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridViewTrips.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Gagal ambil data trip: " + ex.Message); }
        }
    }
}