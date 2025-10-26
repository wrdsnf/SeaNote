using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class LoginPage : Form
    {
        public static List<User> dummyUsers;
        public static User loggedInUser;

        public LoginPage()
        {
            InitializeComponent();
            InitializeDummyUsers();
        }

        private void InitializeDummyUsers()
        {
            dummyUsers = new List<User>();

            var admin = new User { UserID = 1, Username = "admin", Role = "admin" };
            admin.SetPassword("123");
            dummyUsers.Add(admin);

            var owner = new User { UserID = 2, Username = "owner", Role = "owner" };
            owner.SetPassword("123");
            dummyUsers.Add(owner);

            var engineer = new User { UserID = 3, Username = "engineer", Role = "engineer" };
            engineer.SetPassword("123");
            dummyUsers.Add(engineer);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            User userToLogin = dummyUsers.Find(u => u.Username == username);

            if (userToLogin != null && userToLogin.Login(username, password))
            {
                loggedInUser = userToLogin;
                MessageBox.Show("Login Berhasil! Role Anda: " + loggedInUser.Role);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

