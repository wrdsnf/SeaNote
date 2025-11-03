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

        private void DashboardEngineerForm_Load(object sender, EventArgs e)
        {
            if (LoginPage.loggedInUser == null)
            {
                MessageBox.Show("Sesi tidak ditemukan. Silakan login ulang.");
                this.Close();
                return;
            }

            LoadDashboardCounts();
            LoadRecentActivity();
        }

        private void LoadDashboardCounts()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                var sqlPending = "SELECT COUNT(*) FROM public.maintenance WHERE user_id = @user_id AND status = 'Pending'";
                using (var cmdPending = new NpgsqlCommand(sqlPending, conn))
                {
                    cmdPending.Parameters.AddWithValue("user_id", LoginPage.loggedInUser.UserID);
                    var count = cmdPending.ExecuteScalar();
                    label3.Text = Convert.ToString(count); 
                }

                var sqlCompleted = "SELECT COUNT(*) FROM public.maintenance WHERE user_id = @user_id AND status = 'Completed'";
                using (var cmdCompleted = new NpgsqlCommand(sqlCompleted, conn))
                {
                    cmdCompleted.Parameters.AddWithValue("user_id", LoginPage.loggedInUser.UserID);
                    var count = cmdCompleted.ExecuteScalar();
                    label5.Text = Convert.ToString(count); 
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
                        deskripsi AS Deskripsi, 
                        tanggal_selesai AS Waktu 
                    FROM public.maintenance
                    WHERE user_id = @user_id -- <-- GANTI 'engineer_id' -> 'user_id'
                    ORDER BY tanggal_selesai DESC
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