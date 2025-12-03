using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Windows;
using System.Windows.Input;

namespace SeaNoteWPF
{
    public partial class ForgotPasswordWindow : Window
    {
        public ForgotPasswordWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) { if (e.ChangedButton == MouseButton.Left) this.DragMove(); }
        private void BtnClose_Click(object sender, RoutedEventArgs e) => this.Close();
        private void BtnVerify_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "SELECT COUNT(*) FROM public.users WHERE username=@u AND email=@e";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("u", tbUsername.Text);
                cmd.Parameters.AddWithValue("e", tbEmail.Text);

                long count = Convert.ToInt64(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // Kalo Valid: Kunci inputan atas, Munculin inputan bawah
                    tbUsername.IsEnabled = false;
                    tbEmail.IsEnabled = false;
                    btnVerify.IsEnabled = false;
                    btnVerify.Content = "Account Verified ✓";

                    // Munculin Panel Reset
                    PanelReset.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Username atau Email tidak ditemukan!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            if (tbNewPass.Text != tbConfirmPass.Text) { MessageBox.Show("Password tidak sama!"); return; }
            if (tbNewPass.Text.Length < 6) { MessageBox.Show("Minimal 6 karakter!"); return; }

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                // Update Password (Plain Text sesuai request)
                var sql = "UPDATE public.users SET password=@pass WHERE username=@u";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("pass", tbNewPass.Text);
                cmd.Parameters.AddWithValue("u", tbUsername.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Password berhasil diubah! Silakan Login.");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}