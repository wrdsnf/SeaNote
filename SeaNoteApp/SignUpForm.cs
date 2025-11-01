using System;
using System.Windows.Forms;
using Npgsql;

namespace SeaNoteApp
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnDoSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsernameSignUp.Text) ||
                string.IsNullOrWhiteSpace(tbPasswordSignUp.Text))
            {
                MessageBox.Show("Username dan Password wajib diisi!");
                return;
            }

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                var sql = @"
                    INSERT INTO public.users 
                    (username, password, nama_lengkap, email, no_handphone, role) 
                    VALUES 
                    (@username, @password, @nama_lengkap, @email, @no_handphone, NULL)";

                using var cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("nama_lengkap", tbNamaLengkap.Text);
                cmd.Parameters.AddWithValue("username", tbUsernameSignUp.Text);
                cmd.Parameters.AddWithValue("email", tbEmail.Text);
                cmd.Parameters.AddWithValue("password", tbPasswordSignUp.Text); 
                cmd.Parameters.AddWithValue("no_handphone", tbNomorTelepon.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Sign Up Berhasil! Silakan tunggu Admin meng-assign role.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sign Up Gagal! (Database Error)");
                }
            }
            catch (Npgsql.PostgresException pgEx)
            {
                if (pgEx.SqlState == "23505") // Unique violation
                {
                    MessageBox.Show("Sign Up Gagal: Username '" + tbUsernameSignUp.Text + "' sudah terpakai!");
                }
                else
                {
                    MessageBox.Show("Sign Up Gagal (DB Error): " + pgEx.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sign Up Gagal (Exception): " + ex.Message);
            }
        }

        private void btnCancelSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}