using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace SeaNoteWPF.Pages
{
    public partial class ShipPage : Page
    {
        private long _selectedId = 0;

        public ShipPage()
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
                string search = string.IsNullOrWhiteSpace(tbSearch.Text) ? "" : $"WHERE name ILIKE '%{tbSearch.Text}%'";
                var sql = $"SELECT * FROM public.kapal {search} ORDER BY name";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    new NpgsqlDataAdapter(cmd).Fill(dt);

                    var list = new List<dynamic>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new
                        {
                            Id = row["kapal_id"],
                            Name = row["name"],
                            Year = row["year"],
                            Capacity = row["capacity"],
                            Fuel = row["fuel"]
                        });
                    }
                    dgShips.ItemsSource = list;
                    lblCount.Text = list.Count.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e) => LoadData();
        private void BtnAdd_Click(object sender, RoutedEventArgs e) { _selectedId = 0; lblModalTitle.Text = "Add Ship"; btnSave.Content = "Add"; ClearForm(); ModalOverlay.Visibility = Visibility.Visible; }
        private void BtnCloseModal_Click(object sender, RoutedEventArgs e) => ModalOverlay.Visibility = Visibility.Collapsed;

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string sql = _selectedId == 0
                    ? "INSERT INTO public.kapal (name, year, capacity, fuel) VALUES (@name, @year, @cap, @fuel)"
                    : "UPDATE public.kapal SET name=@name, year=@year, capacity=@cap, fuel=@fuel WHERE kapal_id=@id";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("name", tbName.Text);
                cmd.Parameters.AddWithValue("year", int.Parse(tbYear.Text));
                cmd.Parameters.AddWithValue("cap", int.Parse(tbCapacity.Text));
                cmd.Parameters.AddWithValue("fuel", tbFuel.Text);
                if (_selectedId != 0) cmd.Parameters.AddWithValue("id", _selectedId);

                cmd.ExecuteNonQuery();
                ModalOverlay.Visibility = Visibility.Collapsed;
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            _selectedId = Convert.ToInt64(btn.Tag);
            dynamic item = btn.DataContext;
            tbName.Text = item.Name;
            tbYear.Text = item.Year.ToString();
            tbCapacity.Text = item.Capacity.ToString();
            tbFuel.Text = item.Fuel;
            lblModalTitle.Text = "Edit Ship";
            btnSave.Content = "Update";
            ModalOverlay.Visibility = Visibility.Visible;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            long id = Convert.ToInt64(btn.Tag);
            if (MessageBox.Show("Delete ship?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    using var conn = DbHelper.GetConnection(); conn.Open();
                    new NpgsqlCommand($"DELETE FROM public.kapal WHERE kapal_id={id}", conn).ExecuteNonQuery();
                    LoadData();
                }
                catch { }
            }
        }

        private void ClearForm() { tbName.Clear(); tbYear.Clear(); tbCapacity.Clear(); tbFuel.Clear(); }
    }
}