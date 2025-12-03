using Npgsql;
using SeaNote.Models;
using SeaNoteWPF.Utils;
using System;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace SeaNoteWPF
{
    public partial class LoginWindow : Window
    {
        public LoginWindow() { InitializeComponent(); }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) { if (e.ChangedButton == MouseButton.Left) this.DragMove(); }

        private void BtnClose_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.MaxHeight = SystemParameters.WorkArea.Height;
            this.WindowState = WindowState.Maximized;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using var conn = DbHelper.GetConnection(); conn.Open();
                var sql = "SELECT * FROM public.users WHERE username = @u";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("u", tbUsername.Text);
                using var rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    string dbPass = rdr["password"].ToString();
                    if (tbPassword.Password == dbPass)
                    {
                        App.LoggedInUser = new User
                        {
                            Id = Convert.ToInt64(rdr["user_id"]),
                            Username = rdr["username"].ToString(),
                            Role = rdr["role"].ToString()
                        };

                        if (App.LoggedInUser.Role == "admin") new DashboardAdminWindow().Show();
                        else if (App.LoggedInUser.Role == "engineer") new DashboardEngineerWindow().Show();
                        else if (App.LoggedInUser.Role == "owner") new DashboardOwnerWindow().Show();

                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Username/Password Salah!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LnkSignUp_Click(object sender, MouseButtonEventArgs e) => new SignUpWindow().ShowDialog();
        private void LnkForgot_Click(object sender, MouseButtonEventArgs e) => new ForgotPasswordWindow().ShowDialog();
    }
}