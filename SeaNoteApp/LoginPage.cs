using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class LoginPage : Form
    {
        public static User? loggedInUser;

        public LoginPage()
        {
            InitializeComponent();
            UserData.InitializeDummyUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            User? userToLogin = UserData.dummyUsers.Find(u => u.Username == username);

            if (userToLogin != null && userToLogin.Login(username, password))
            {
                loggedInUser = userToLogin;
                MessageBox.Show("Login Berhasil! Role Anda: " + loggedInUser.Role);

                // --- INI PERBAIKANNYA ---
                // Kita pake ?.ToLower() biar gak peduli huruf besar/kecil

                if (loggedInUser.Role?.ToLower() == "admin")
                {
                    new DashboardAdminForm().Show();
                }
                else if (loggedInUser.Role?.ToLower() == "owner")
                {
                    new DashboardOwnerForm().Show();
                }
                else if (loggedInUser.Role?.ToLower() == "engineer")
                {
                    new DashboardEngineerForm().Show();
                }

                this.Hide();
            }
            else if (userToLogin != null && userToLogin.Role == null)
            {
                MessageBox.Show("Login Gagal! Akun Anda belum memiliki role. Silakan tunggu Admin.");
            }
            else
            {
                MessageBox.Show("Login Gagal! Username atau password salah.");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}