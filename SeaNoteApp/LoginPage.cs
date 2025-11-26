using SeaNote.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace SeaNoteApp
{
    public partial class LoginPage : Form
    {
        public static User? loggedInUser;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text; 

            User? userFromDb = null;
            string dbPassword = ""; 

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "SELECT * FROM public.users WHERE username = @username";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("username", username);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    userFromDb = new User
                    {
                        UserID = Convert.ToInt64(reader["user_id"]), 
                        Username = reader["username"].ToString(),
                        Role = reader["role"] == DBNull.Value ? null : reader["role"].ToString(),
                        NamaLengkap = reader["nama_lengkap"]?.ToString(),
                        Email = reader["email"]?.ToString(),
                        NomorTelepon = reader["no_handphone"]?.ToString()
                    };
                    dbPassword = reader["password"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal konek ke database: " + ex.Message);
                return;
            }

            if (userFromDb != null && password == dbPassword)
            {
                if (userFromDb.Role == null)
                {
                    MessageBox.Show("Login Berhasil, tapi Akun Anda belum memiliki role. Silakan tunggu Admin.");
                    return;
                }

                loggedInUser = userFromDb;
                MessageBox.Show("Login Berhasil! Role Anda: " + loggedInUser.Role);
                string role = loggedInUser.Role.ToLower();

                if (role == "admin") { new DashboardAdminForm().Show(); }
                else if (role == "owner") { new DashboardOwnerForm().Show(); }
                else if (role == "engineer") { new DashboardEngineerForm().Show(); }
                else
                {
                    MessageBox.Show("Role Anda tidak dikenali. Hubungi Admin.");
                    return;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal! Username atau password salah.");
            }
        }

        private void lnkSignUp_Click(object sender, EventArgs e)
        {
            new SignUpForm().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgotPasswordForm().ShowDialog();
        }
    }
}