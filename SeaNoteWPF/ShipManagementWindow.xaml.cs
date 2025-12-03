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
    public partial class ShipManagementWindow : Window
    {
        private long _selectedId = 0; // 0 = Mode Add, >0 = Mode Edit

        public ShipManagementWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e) => this.Close(); 
        private void LoadData()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                // Load Table
                string search = string.IsNullOrWhiteSpace(tbSearch.Text) ? "" : $"WHERE name ILIKE '%{tbSearch.Text}%'";
                var sql = $"SELECT * FROM public.kapal {search} ORDER BY name";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    new NpgsqlDataAdapter(cmd).Fill(dt);

                    // Mapping manual biar rapi di Grid (Pake anonymous object)
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

                    // Update Stats (Real-time)
                    lblShipCount.Text = list.Count.ToString();
                    // Hitung total capacity manual dr list biar cepet
                    long totalCap = 0;
                    foreach (var item in list) totalCap += Convert.ToInt64(item.Capacity);
                    lblTotalCap.Text = totalCap.ToString();

                    // Total Trips (Query lagi)
                    using (var cmdTrip = new NpgsqlCommand("SELECT COUNT(*) FROM public.trips", conn))
                        lblTotalTrips.Text = cmdTrip.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e) => LoadData();

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            _selectedId = 0;
            lblModalTitle.Text = "Add New Ship";
            btnSave.Content = "Add Ship";
            ClearForm();
            ModalOverlay.Visibility = Visibility.Visible;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            long id = Convert.ToInt64(btn.Tag);
            _selectedId = id;

            // Ambil data dari row yang dipilih
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

            if (MessageBox.Show("Are you sure to delete this ship?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    using var conn = DbHelper.GetConnection();
                    conn.Open();
                    new NpgsqlCommand($"DELETE FROM public.kapal WHERE kapal_id={id}", conn).ExecuteNonQuery();
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text)) { MessageBox.Show("Name required!"); return; }

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string sql = "";

                if (_selectedId == 0) // INSERT
                    sql = "INSERT INTO public.kapal (name, year, capacity, fuel) VALUES (@name, @year, @cap, @fuel)";
                else // UPDATE
                    sql = "UPDATE public.kapal SET name=@name, year=@year, capacity=@cap, fuel=@fuel WHERE kapal_id=@id";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("name", tbName.Text);
                cmd.Parameters.AddWithValue("year", int.Parse(tbYear.Text));
                cmd.Parameters.AddWithValue("cap", int.Parse(tbCapacity.Text));
                cmd.Parameters.AddWithValue("fuel", tbFuel.Text);
                if (_selectedId != 0) cmd.Parameters.AddWithValue("id", _selectedId);

                cmd.ExecuteNonQuery();

                ModalOverlay.Visibility = Visibility.Collapsed;
                LoadData(); // Refresh UI
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnCloseModal_Click(object sender, RoutedEventArgs e)
        {
            ModalOverlay.Visibility = Visibility.Collapsed;
        }

        private void ClearForm()
        {
            tbName.Clear(); tbYear.Clear(); tbCapacity.Clear(); tbFuel.Clear();
        }
    }
}