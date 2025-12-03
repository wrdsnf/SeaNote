using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SeaNoteWPF
{
    public partial class UserManagementWindow : Window
    {
        private long _selectedId = 0;

        public UserManagementWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) { if (e.ChangedButton == MouseButton.Left) this.DragMove(); }
        private void BtnBack_Click(object sender, RoutedEventArgs e) => this.Close();

        private void LoadData()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                string search = string.IsNullOrWhiteSpace(tbSearch.Text) ? "" : $"WHERE username ILIKE '%{tbSearch.Text}%'";
                var sql = $"SELECT user_id, username, role, nama_lengkap, email FROM public.users {search} ORDER BY user_id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    new NpgsqlDataAdapter(cmd).Fill(dt);

                    var list = new List<dynamic>();
                    int engCount = 0;
                    int ownCount = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        string role = row["role"].ToString();
                        if (role == "engineer") engCount++;
                        if (role == "owner") ownCount++;

                        list.Add(new
                        {
                            Id = row["user_id"],
                            Username = row["username"],
                            Role = role,
                            FullName = row["nama_lengkap"],
                            Email = row["email"]
                        });
                    }
                    dgUsers.ItemsSource = list;
                    lblTotalUsers.Text = list.Count.ToString();
                    lblTotalEng.Text = engCount.ToString();
                    lblTotalOwn.Text = ownCount.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e) => LoadData();

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            _selectedId = 0;
            lblModalTitle.Text = "Add New User";
            tbUsername.Clear(); tbFullName.Clear(); tbEmail.Clear(); tbPassword.Clear();
            ModalOverlay.Visibility = Visibility.Visible;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            _selectedId = Convert.ToInt64(btn.Tag);
            dynamic item = btn.DataContext;

            tbUsername.Text = item.Username;
            tbFullName.Text = item.FullName;
            tbEmail.Text = item.Email;
            cbRole.Text = item.Role;
            tbPassword.Text = ""; // Kosongin password biar gak kereset kalo gak diisi

            lblModalTitle.Text = "Edit User";
            ModalOverlay.Visibility = Visibility.Visible;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            // Implementasi Delete SQL (sama kayak Ship)
            LoadData();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string sql = "";

                if (_selectedId == 0) // ADD
                    sql = "INSERT INTO public.users (username, password, role, nama_lengkap, email) VALUES (@user, @pass, @role, @name, @email)";
                else // UPDATE
                    sql = "UPDATE public.users SET username=@user, role=@role, nama_lengkap=@name, email=@email WHERE user_id=@id";
                // (Note: Password update butuh logic khusus biar gak ketimpa kosong)

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("user", tbUsername.Text);
                cmd.Parameters.AddWithValue("pass", tbPassword.Text); // Plain text sesuai request
                cmd.Parameters.AddWithValue("role", cbRole.Text);
                cmd.Parameters.AddWithValue("name", tbFullName.Text);
                cmd.Parameters.AddWithValue("email", tbEmail.Text);
                if (_selectedId != 0) cmd.Parameters.AddWithValue("id", _selectedId);

                cmd.ExecuteNonQuery();
                ModalOverlay.Visibility = Visibility.Collapsed;
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnCloseModal_Click(object sender, RoutedEventArgs e) => ModalOverlay.Visibility = Visibility.Collapsed;
    }
}