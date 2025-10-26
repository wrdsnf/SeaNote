using SeaNote.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class LoginPage : Form
    {
        public static List<User> dummyUsers; // Bikin 'static' biar bisa diakses Form lain
        public static User loggedInUser; // Simpen siapa yang login

        // Constructor
        public LoginPage()
        {
            InitializeComponent();
            InitializeDummyUsers(); // Panggil method-nya
        }

        private void InitializeDummyUsers()
        {
            dummyUsers = new List<User>();

            var admin = new User { UserID = 1, Username = "admin", Role = "admin" };
            admin.SetPassword("123"); // Pake method dari User.cs
            dummyUsers.Add(admin);

            var owner = new User { UserID = 2, Username = "owner", Role = "owner" };
            owner.SetPassword("123");
            dummyUsers.Add(owner);

            var engineer = new User { UserID = 3, Username = "engineer", Role = "engineer" };
            engineer.SetPassword("123");
            dummyUsers.Add(engineer);
        }

        // Event handler
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            // 1. Cari user-nya
            User userToLogin = dummyUsers.Find(u => u.Username == username);

            // 2. Cek login pake method dari User.cs lu
            if (userToLogin != null && userToLogin.Login(username, password))
            {
                loggedInUser = userToLogin; // Simpen user-nya
                MessageBox.Show("Login Berhasil! Role Anda: " + loggedInUser.Role);

                // 3. Pindah Halaman
                if (loggedInUser.Role == "admin")
                {
                    DashboardAdminForm adminForm = new DashboardAdminForm();
                    adminForm.Show();
                }
                else if (loggedInUser.Role == "owner")
                {
                    DashboardOwnerForm ownerForm = new DashboardOwnerForm();
                    ownerForm.Show();
                }
                else if (loggedInUser.Role == "engineer")
                {
                    DashboardEngineerForm engineerForm = new DashboardEngineerForm();
                    engineerForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal! Username atau password salah.");
            }
        }

        // Event handler buat tombol Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
