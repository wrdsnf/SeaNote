using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace SeaNoteWPF.Pages
{
    public partial class OwnerShipPage : Page
    {
        public OwnerShipPage()
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
                long uid = App.LoggedInUser.Id;

                // Query Kapal milik Owner ini saja
                string search = string.IsNullOrWhiteSpace(tbSearch.Text) ? "" : $"AND name ILIKE '%{tbSearch.Text}%'";
                var sql = $"SELECT * FROM public.kapal WHERE owner_id = @uid {search} ORDER BY name";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("uid", uid);
                    DataTable dt = new DataTable();
                    new NpgsqlDataAdapter(cmd).Fill(dt);

                    var list = new List<dynamic>();
                    long totalCap = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new { Name = row["name"], Year = row["year"], Capacity = row["capacity"], Fuel = row["fuel"] });
                        totalCap += Convert.ToInt64(row["capacity"]);
                    }
                    dgShips.ItemsSource = list;
                    lblTotal.Text = list.Count.ToString();
                    lblCap.Text = totalCap.ToString("N0"); // Format angka (1,000)
                }
            }
            catch { }
        }
        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e) => LoadData();
        private void BtnExport_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Data exported to Excel/PDF (Simulasi)");
    }
}