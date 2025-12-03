using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Windows;
using System.Windows.Input;

namespace SeaNoteWPF
{
    public partial class SignUpWindow : Window
    {
        public SignUpWindow() { InitializeComponent(); }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e) { if (e.ChangedButton == MouseButton.Left) this.DragMove(); }
        private void BtnCancel_Click(object sender, RoutedEventArgs e) => this.Close();

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (tbPass.Text != tbConfirm.Text) { MessageBox.Show("Password tidak sama!"); return; }
            try
            {
                using var conn = DbHelper.GetConnection(); conn.Open();
                var sql = "INSERT INTO public.users (username, password, role, nama_lengkap) VALUES (@u, @p, @r, @n)";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("u", tbUser.Text);
                cmd.Parameters.AddWithValue("p", tbPass.Text);
                cmd.Parameters.AddWithValue("r", cbRole.Text);
                cmd.Parameters.AddWithValue("n", tbName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Akun berhasil dibuat!");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}