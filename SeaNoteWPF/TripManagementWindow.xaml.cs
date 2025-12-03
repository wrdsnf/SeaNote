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
    public partial class TripManagementWindow : Window
    {
        private long _selectedTripId = 0;

        public TripManagementWindow()
        {
            InitializeComponent();
            LoadData();
            LoadShipsCombo();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) { if (e.ChangedButton == MouseButton.Left) this.DragMove(); }
        private void BtnBack_Click(object sender, RoutedEventArgs e) => this.Close();

        private void LoadData()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();

                // JOIN Tabel Trips & Kapal
                string search = string.IsNullOrWhiteSpace(tbSearch.Text) ? "" : $"WHERE k.name ILIKE '%{tbSearch.Text}%'";
                var sql = $@"SELECT t.trip_id, k.name as ship_name, t.tanggal_berangkat, t.tanggal_sampai, t.titik_berangkat, t.nahkoda, t.notes 
                             FROM public.trips t 
                             JOIN public.kapal k ON t.kapal_id = k.kapal_id 
                             {search} ORDER BY t.tanggal_berangkat DESC";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    new NpgsqlDataAdapter(cmd).Fill(dt);

                    var list = new List<dynamic>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new
                        {
                            Id = row["trip_id"],
                            ShipName = row["ship_name"],
                            DepartureDate = row["tanggal_berangkat"],
                            ArrivalDate = row["tanggal_sampai"],
                            DeparturePoint = row["titik_berangkat"],
                            Captain = row["nahkoda"],
                            Notes = row["notes"]
                        });
                    }
                    dgTrips.ItemsSource = list;
                    lblTotalTrips.Text = list.Count.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadShipsCombo()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "SELECT kapal_id, name FROM public.kapal ORDER BY name";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable();
                    new NpgsqlDataAdapter(cmd).Fill(dt);
                    cbShips.ItemsSource = dt.DefaultView;
                }
            }
            catch { }
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e) => LoadData();

        // MODAL LOGIC
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            _selectedTripId = 0;
            lblModalTitle.Text = "Add New Trip";
            btnSave.Content = "Add Trip";
            ClearForm();
            ModalOverlay.Visibility = Visibility.Visible;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            // Untuk Edit, idealnya query by ID, tapi ini shortcut dari Grid
            var btn = sender as Button;
            _selectedTripId = Convert.ToInt64(btn.Tag);
            dynamic item = btn.DataContext;

            // Note: ComboBox Ship agak tricky di-set manual tanpa Binding ID, 
            // tapi minimal data lain keisi:
            dpDepart.SelectedDate = (DateTime)item.DepartureDate;
            dpArrival.SelectedDate = (DateTime)item.ArrivalDate;
            tbDepartPoint.Text = item.DeparturePoint;
            tbCaptain.Text = item.Captain;
            tbNotes.Text = item.Notes;

            lblModalTitle.Text = "Edit Trip";
            btnSave.Content = "Update";
            ModalOverlay.Visibility = Visibility.Visible;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (cbShips.SelectedValue == null) { MessageBox.Show("Pilih kapal dulu!"); return; }

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string sql = "";

                if (_selectedTripId == 0)
                    sql = "INSERT INTO public.trips (kapal_id, tanggal_berangkat, tanggal_sampai, titik_berangkat, nahkoda, notes) VALUES (@kid, @tgl1, @tgl2, @titik, @capt, @note)";
                else
                    sql = "UPDATE public.trips SET kapal_id=@kid, tanggal_berangkat=@tgl1, tanggal_sampai=@tgl2, titik_berangkat=@titik, nahkoda=@capt, notes=@note WHERE trip_id=@id";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("kid", cbShips.SelectedValue);
                cmd.Parameters.AddWithValue("tgl1", dpDepart.SelectedDate ?? DateTime.Now);
                cmd.Parameters.AddWithValue("tgl2", dpArrival.SelectedDate ?? DateTime.Now);
                cmd.Parameters.AddWithValue("titik", tbDepartPoint.Text);
                cmd.Parameters.AddWithValue("capt", tbCaptain.Text);
                cmd.Parameters.AddWithValue("note", tbNotes.Text);
                if (_selectedTripId != 0) cmd.Parameters.AddWithValue("id", _selectedTripId);

                cmd.ExecuteNonQuery();
                ModalOverlay.Visibility = Visibility.Collapsed;
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnCloseModal_Click(object sender, RoutedEventArgs e) => ModalOverlay.Visibility = Visibility.Collapsed;

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            long id = Convert.ToInt64(btn.Tag);
            if (MessageBox.Show("Hapus trip ini?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // Code delete SQL here...
                LoadData();
            }
        }

        private void ClearForm()
        {
            cbShips.SelectedIndex = -1;
            tbDepartPoint.Clear(); tbCaptain.Clear(); tbNotes.Clear();
            dpDepart.SelectedDate = DateTime.Now;
            dpArrival.SelectedDate = DateTime.Now;
        }
    }
}