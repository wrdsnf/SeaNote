using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace SeaNoteWPF.Pages
{
    public partial class MaintenancePage : Page
    {
        private long _selectedId = 0;
        private string _currentFilter = "All";

        public MaintenancePage() { InitializeComponent(); LoadData(); }

        private void LoadData()
        {
            try
            {
                using var conn = DbHelper.GetConnection(); conn.Open();

                string sqlBase = @"SELECT m.maintenance_id, k.name as ship_name, u.nama_lengkap as engineer, m.deskripsi, m.status, m.tanggal_lapor
                                   FROM public.maintenance m
                                   JOIN public.kapal k ON m.ship_id = k.kapal_id
                                   LEFT JOIN public.users u ON m.user_id = u.user_id"; 

                if (_currentFilter != "All") sqlBase += $" WHERE m.status = '{_currentFilter}'";
                sqlBase += " ORDER BY m.tanggal_lapor DESC";

                using (var cmd = new NpgsqlCommand(sqlBase, conn))
                {
                    DataTable dt = new DataTable(); new NpgsqlDataAdapter(cmd).Fill(dt);
                    var list = new List<dynamic>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new
                        {
                            Id = row["maintenance_id"],
                            ShipName = row["ship_name"],
                            Engineer = row["engineer"] ?? "Unassigned",
                            Description = row["deskripsi"],
                            Status = row["status"],
                            Date = Convert.ToDateTime(row["tanggal_lapor"])
                        });
                    }
                    dgMaint.ItemsSource = list;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Filter_Click(object sender, RoutedEventArgs e) { var rb = sender as RadioButton; _currentFilter = rb.Content.ToString(); LoadData(); }
        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e) => LoadData();

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button; _selectedId = Convert.ToInt64(btn.Tag);
            dynamic item = btn.DataContext;
            tbShipName.Text = item.ShipName; tbIssue.Text = item.Description; cbStatus.Text = item.Status;
            ModalOverlay.Visibility = Visibility.Visible;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using var conn = DbHelper.GetConnection(); conn.Open();

                var sql = "UPDATE public.maintenance SET status = CAST(@status AS maintenance_status) WHERE maintenance_id = @id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("status", cbStatus.Text);
                    cmd.Parameters.AddWithValue("id", _selectedId);
                    cmd.ExecuteNonQuery();
                }
                ModalOverlay.Visibility = Visibility.Collapsed; LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e) { /* blm ada logic pls tolong */ }
        private void BtnCloseModal_Click(object sender, RoutedEventArgs e) => ModalOverlay.Visibility = Visibility.Collapsed;
    }
}