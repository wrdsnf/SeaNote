using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SeaNoteApp
{
    public partial class ForgotPasswordForm : Form
    {
        private string verifiedUsername = "";

        public ForgotPasswordForm()
        {
            InitializeComponent();
            panelReset.Visible = false;

            this.Size = new System.Drawing.Size(696, 450);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string email = tbEmail.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Username dan Email wajib diisi.");
                return;
            }

            bool userExists = false;
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "SELECT COUNT(1) FROM public.users WHERE username = @username AND email = @email";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("email", email);

                var result = cmd.ExecuteScalar();
                if (result != null && Convert.ToInt64(result) == 1)
                {
                    userExists = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal cek user: " + ex.Message);
                return;
            }

            if (userExists)
            {
                MessageBox.Show("Verifikasi Berhasil! Silakan masukkan password baru Anda.");
                this.verifiedUsername = username;

                panelReset.Visible = true;

                this.Size = new System.Drawing.Size(696, 450);

                tbUsername.Enabled = false;
                tbEmail.Enabled = false;
                btnVerify.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifikasi Gagal. Username atau Email tidak ditemukan/cocok.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string newPassword = tbNewPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Password baru dan konfirmasi tidak cocok.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newPassword) || newPassword.Length < 6)
            {
                MessageBox.Show("Password minimal harus 6 karakter.");
                return;
            }

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "UPDATE public.users SET password = @newPassword WHERE username = @username";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("newPassword", newPassword);
                cmd.Parameters.AddWithValue("username", this.verifiedUsername);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password berhasil di-update! Silakan login dengan password baru Anda.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal update password. User tidak ditemukan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update password: " + ex.Message);
            }
        }
    }
}