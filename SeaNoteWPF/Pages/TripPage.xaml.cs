using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace SeaNoteWPF.Pages
{
    public partial class TripPage : Page
    {
        private long _selectedId = 0;

        public TripPage()
        {
            InitializeComponent();
            LoadData();
            LoadShipsCombo();
        }

        private void LoadData()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string search = string.IsNullOrWhiteSpace(tbSearch.Text) ? "" : $"WHERE k.name ILIKE '%{tbSearch.Text}%'";
                var sql = $@"SELECT t.trip_id, k.name as ship_name, t.tanggal_berangkat, t.tanggal_sampai, t.titik_berangkat, t.nahkoda, t.notes 
                             FROM public.trips t JOIN public.kapal k ON t.kapal_id = k.kapal_id {search} ORDER BY t.tanggal_berangkat DESC";

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

        private void LoadShipsCombo() { /* blm ada plis */ }
        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e) => LoadData();

        // Modal Logic (blm lengkap hehe)
        private void BtnAdd_Click(object sender, RoutedEventArgs e) { _selectedId = 0; lblModalTitle.Text = "Add Trip"; btnSave.Content = "Add"; ClearForm(); ModalOverlay.Visibility = Visibility.Visible; }
        private void BtnCloseModal_Click(object sender, RoutedEventArgs e) => ModalOverlay.Visibility = Visibility.Collapsed;

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            // logic Save Trip disini
            // Jangan lupa panggil LoadData() setelah save
            ModalOverlay.Visibility = Visibility.Collapsed;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e) { /* Logic Edit */ ModalOverlay.Visibility = Visibility.Visible; }
        private void BtnDelete_Click(object sender, RoutedEventArgs e) { /* Logic Delete */ }
        private void ClearForm() { /* Clear inputs */ }
    }
}