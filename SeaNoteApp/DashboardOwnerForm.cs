using Npgsql; 
using SeaNote.Models; 
using System;
using System.Data; 
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class DashboardOwnerForm : Form
    {
        public DashboardOwnerForm()
        {
            InitializeComponent();
            if (LoginPage.loggedInUser != null)
            {
                this.Text = "Owner Dashboard (" + LoginPage.loggedInUser.Username + ")";
            }
        }

        private async void DashboardOwnerForm_Load(object sender, EventArgs e)
        {
            LoadDashboardCounts();
            LoadRecentActivity();
            await LoadWeatherAsync();
        }

        private void LoadDashboardCounts()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                using (var cmdShip = new NpgsqlCommand("SELECT COUNT(*) FROM public.kapal", conn))
                {
                    var count = cmdShip.ExecuteScalar();
                    label3.Text = Convert.ToString(count);
                }

                using (var cmdTrip = new NpgsqlCommand("SELECT COUNT(*) FROM public.trips", conn))
                {
                    var count = cmdTrip.ExecuteScalar();
                    label5.Text = Convert.ToString(count);
                }

                using (var cmdMaint = new NpgsqlCommand("SELECT COUNT(*) FROM public.maintenance WHERE status = 'scheduled'", conn))
                {
                    var count = cmdMaint.ExecuteScalar();
                    label7.Text = Convert.ToString(count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data count: " + ex.Message);
                label3.Text = "-";
                label5.Text = "-";
                label7.Text = "-";
            }
        }

        private void LoadRecentActivity()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                var sql = @"
                    (SELECT 'Log Baru' AS Tipe, isi_log AS Deskripsi, tanggal_log AS Waktu FROM public.logs ORDER BY tanggal_log DESC LIMIT 5)
                    UNION ALL
                    (SELECT 'Task Baru' AS Tipe, task_name AS Deskripsi, created_at AS Waktu FROM public.tasks ORDER BY created_at DESC LIMIT 5)
                    UNION ALL
                    (SELECT 'Trip Baru' AS Tipe, CONCAT('Nakhoda: ', nahkoda, ', Berangkat: ', titik_berangkat) AS Deskripsi, tanggal_berangkat AS Waktu FROM public.trips ORDER BY tanggal_berangkat DESC LIMIT 5)
                    
                    ORDER BY Waktu DESC
                    LIMIT 5";

                using var cmd = new NpgsqlCommand(sql, conn);
                var dt = new DataTable();
                var adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["Tipe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns["Deskripsi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns["Waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load aktivitas terakhir: " + ex.Message);
            }
        }

        private readonly WeatherService _weatherService = new WeatherService();

        private async Task LoadWeatherAsync()
        {
            try
            {
                var city = "Yogyakarta";

                var weather = await _weatherService.GetCurrentWeatherAsync(city);

                if (weather?.Current != null)
                {
                    labelWeatherCity.Text = weather.Location?.Name ?? city;
                    labelWeatherTemp.Text = $"{weather.Current.Temperature:0.0} °C";

                    string desc = "-";
                    if (weather.Current.Weather_Descriptions != null && weather.Current.Weather_Descriptions.Length > 0)
                    {
                        desc = weather.Current.Weather_Descriptions[0];
                    }

                    labelWeatherDesc.Text = desc;
                }
                else
                {
                    labelWeatherCity.Text = city;
                    labelWeatherTemp.Text = "-";
                    labelWeatherDesc.Text = "-";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data cuaca (Weatherstack): " + ex.Message);
                labelWeatherTemp.Text = "-";
                labelWeatherDesc.Text = "-";
            }
        }


        private void BtnShipViewer_Click(object sender, EventArgs e)
        {
            new ShipViewerForm().Show();
        }

        private void BtnTripViewer_Click(object sender, EventArgs e)
        {
            new TripViewerForm().Show();
        }

        private void BtnMaintenanceViewer_Click(object sender, EventArgs e)
        {
            new MaintenanceViewerOwnerForm().Show();
        }

        private void BtnReportOwner_Click(object sender, EventArgs e)
        {
            new ReportOwnerForm().Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage.loggedInUser = null;
            var loginForm = Application.OpenForms.OfType<LoginPage>().FirstOrDefault();
            if (loginForm != null) { loginForm.Show(); } else { new LoginPage().Show(); }
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}