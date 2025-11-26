using SeaNote.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace SeaNoteApp
{
    public partial class DashboardAdminForm : Form
    {
        public DashboardAdminForm()
        {
            InitializeComponent();
            if (LoginPage.loggedInUser != null)
            {
                this.Text = "Admin Dashboard (" + LoginPage.loggedInUser.Username + ")";
            }
        }

        private async void DashboardAdminForm_Load(object sender, EventArgs e)
        {
            LoadRecentActivity();
            LoadDashboardCounts();
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

                using (var cmdUser = new NpgsqlCommand("SELECT COUNT(*) FROM public.users", conn))
                {
                    var count = cmdUser.ExecuteScalar();
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

        private void BtnShipManagement_Click(object sender, EventArgs e)
        {
            new ShipManagementForm().Show();
        }

        private void BtnTripManagement_Click(object sender, EventArgs e)
        {
            new TripManagementForm().Show();
        }


        private void BtnMaintenanceAdmin_Click(object sender, EventArgs e)
        {
            new MaintenanceAdminForm().Show();
        }

        private void BtnUserManagement_Click(object sender, EventArgs e)
        {
            new UserManagementForm().Show();
        }

        private void BtnExportReport_Click(object sender, EventArgs e)
        {
            new ExportReportForm().Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage.loggedInUser = null;
            var loginForm = Application.OpenForms.OfType<LoginPage>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                new LoginPage().Show();
            }
            this.Close();
        }

        private void btnTestPoli_Click(object sender, EventArgs e)
        {
            List<ReportableBase> kantongAjaib = new List<ReportableBase>();

            kantongAjaib.Add(new Ship { Name = "KM. Jaya", Year = 2020 });
            kantongAjaib.Add(new Trip { TitikBerangkat = "Surabaya", Nakhoda = "Budi" });

            string fullReport = "";

            foreach (var item in kantongAjaib)
            {
                fullReport += item.GetSummary() + "\n";
            }

            MessageBox.Show(fullReport);
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}