using SeaNote.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDoSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbUsernameSignUp.Text) ||
                    string.IsNullOrWhiteSpace(tbPasswordSignUp.Text))
                {
                    MessageBox.Show("Username dan Password wajib diisi!");
                    return;
                }

                if (UserData.dummyUsers.Any(u => u.Username == tbUsernameSignUp.Text))
                {
                    MessageBox.Show("Username sudah terpakai!");
                    return;
                }

                User newUser = new User
                {
                    UserID = UserData.dummyUsers.Count > 0 ? UserData.dummyUsers.Max(u => u.UserID) + 1 : 1,
                    NamaLengkap = tbNamaLengkap.Text,
                    Username = tbUsernameSignUp.Text,
                    Email = tbEmail.Text,
                    NomorTelepon = tbNomorTelepon.Text,
                    Role = null
                };
                newUser.SetPassword(tbPasswordSignUp.Text);

                UserData.dummyUsers.Add(newUser);

                MessageBox.Show("Sign Up Berhasil! Silakan login SETELAH Admin meng-assign role Anda.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sign Up Gagal: " + ex.Message);
            }
        }

        private void btnCancelSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
