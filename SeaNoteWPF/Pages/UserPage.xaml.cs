using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace SeaNoteWPF.Pages
{
    public partial class UserPage : Page
    {
        private long _selectedId = 0;

        public UserPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string search = string.IsNullOrWhiteSpace(tbSearch.Text) ? "" : $"WHERE username ILIKE '%{tbSearch.Text}%'";

                // Ambil data aman
                var sql = $"SELECT user_id, username, role, nama_lengkap, email, password FROM public.users {search} ORDER BY user_id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    new NpgsqlDataAdapter(cmd).Fill(dt);
                    var list = new List<dynamic>();
                    int engCount = 0, ownCount = 0;

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
                            Email = row["email"],
                            Password = row["password"]
                        });
                    }
                    dgUsers.ItemsSource = list;
                    lblTotal.Text = list.Count.ToString();
                    lblEng.Text = engCount.ToString();
                    lblOwn.Text = ownCount.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e) => LoadData();
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            _selectedId = 0; lblModalTitle.Text = "Add New User"; ClearForm(); ModalOverlay.Visibility = Visibility.Visible;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button; _selectedId = Convert.ToInt64(btn.Tag);
            dynamic item = btn.DataContext;
            tbUsername.Text = item.Username; tbFullName.Text = item.FullName; tbEmail.Text = item.Email;
            cbRole.Text = item.Role; tbPassword.Text = item.Password;
            lblModalTitle.Text = "Edit User"; ModalOverlay.Visibility = Visibility.Visible;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button; long id = Convert.ToInt64(btn.Tag);
            if (MessageBox.Show("Yakin hapus?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try { using var c = DbHelper.GetConnection(); c.Open(); new NpgsqlCommand($"DELETE FROM public.users WHERE user_id={id}", c).ExecuteNonQuery(); LoadData(); }
                catch { }
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text)) return;

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string sql = "";


                if (_selectedId == 0)
                    sql = "INSERT INTO public.users (username, password, role, nama_lengkap, email) VALUES (@user, @pass, CAST(@role AS user_role), @name, @email)";
                else
                    sql = "UPDATE public.users SET username=@user, password=@pass, role=CAST(@role AS user_role), nama_lengkap=@name, email=@email WHERE user_id=@id";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("user", tbUsername.Text);
                cmd.Parameters.AddWithValue("pass", tbPassword.Text);
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
        private void ClearForm() { tbUsername.Clear(); tbFullName.Clear(); tbEmail.Clear(); tbPassword.Clear(); cbRole.SelectedIndex = -1; }
    }
}