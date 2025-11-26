using Npgsql; 
using SeaNote.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class DashboardEngineerForm : Form
    {
        public DashboardEngineerForm()
        {
            InitializeComponent();
            if (LoginPage.loggedInUser != null)
            {
                this.Text = "Engineer Dashboard (" + LoginPage.loggedInUser.Username + ")";
            }
        }

        private async void DashboardEngineerForm_Load(object sender, EventArgs e)
        {
            if (LoginPage.loggedInUser == null)
            {
                MessageBox.Show("Sesi tidak ditemukan. Silakan login ulang.");
                this.Close();
                return;
            }

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

                // "Pending" = scheduled
                var sqlScheduled = "SELECT COUNT(*) FROM public.maintenance WHERE status = 'scheduled'";
                using (var cmdScheduled = new NpgsqlCommand(sqlScheduled, conn))
                {
                    var count = cmdScheduled.ExecuteScalar();
                    label3.Text = Convert.ToString(count);   // label pending
                }

                // "Completed" = completed
                var sqlCompleted = "SELECT COUNT(*) FROM public.maintenance WHERE status = 'completed'";
                using (var cmdCompleted = new NpgsqlCommand(sqlCompleted, conn))
                {
                    cmdCompleted.Parameters.AddWithValue("user_id", LoginPage.loggedInUser.UserID);
                    var count = cmdCompleted.ExecuteScalar();
                    label5.Text = Convert.ToString(count);   // label completed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data count: " + ex.Message);
                label3.Text = "-";
                label5.Text = "-";
            }
        }

        private void LoadRecentActivity()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                var sql = @"
                    SELECT 
                        'Maintenance' AS Tipe, 
                description AS Deskripsi, 
                maintenance_date AS Waktu      -- pakai kolom ini
                    FROM public.maintenance
            ORDER BY maintenance_date DESC    -- urut dari yang terbaru
                    LIMIT 5";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("user_id", LoginPage.loggedInUser.UserID);

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


        private void BtnMaintenanceEngineer_Click(object sender, EventArgs e)
        {
            new MaintenanceEngineerForm().Show();
        }

        private void BtnMaintenanceHistory_Click(object sender, EventArgs e)
        {
            new MaintenanceHistoryEngineerForm().Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage.loggedInUser = null;
            var loginForm = Application.OpenForms.OfType<LoginPage>().FirstOrDefault();
            if (loginForm != null) { loginForm.Show(); } else { new LoginPage().Show(); }
            this.Close();
        }
    }
}