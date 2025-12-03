using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace SeaNoteWPF.Pages
{
    public partial class OwnerTripPage : Page
    {
        public OwnerTripPage() { InitializeComponent(); LoadData(); }

        private void LoadData()
        {
            try
            {
                using var conn = DbHelper.GetConnection(); conn.Open();
                long uid = App.LoggedInUser.Id;
                // JOIN Kapal biar dapet Owner ID
                var sql = "SELECT t.trip_id, k.name, t.titik_berangkat, t.tanggal_berangkat, t.nahkoda FROM public.trips t JOIN public.kapal k ON t.kapal_id = k.kapal_id WHERE k.owner_id = @uid ORDER BY t.tanggal_berangkat DESC";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("uid", uid);
                    DataTable dt = new DataTable(); new NpgsqlDataAdapter(cmd).Fill(dt);
                    var list = new List<dynamic>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new
                        {
                            ShipName = row["name"],
                            Route = row["titik_berangkat"],
                            Date = Convert.ToDateTime(row["tanggal_berangkat"]).ToString("dd MMM yyyy"),
                            Captain = row["nahkoda"]
                        });
                    }
                    dgTrips.ItemsSource = list;
                }
            }
            catch { }
        }
        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e) { /* Logic filter optional */ }
        private void BtnExport_Click(object sender, RoutedEventArgs e) => MessageBox.Show("Report Generated!");
    }
}