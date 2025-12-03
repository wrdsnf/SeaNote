using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace SeaNoteWPF.Pages
{
    public partial class EngineerTaskPage : Page
    {
        private string _currentFilter = "Pending";

        public EngineerTaskPage()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            if (rbPending.IsChecked == true) _currentFilter = "Pending";
            else _currentFilter = "Completed";
            LoadTasks();
        }

        private void LoadTasks()
        {
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                long uid = App.LoggedInUser.Id;

                var sql = @"SELECT m.maintenance_id, k.name, m.deskripsi, m.status, m.tanggal_lapor 
                            FROM public.maintenance m 
                            JOIN public.kapal k ON m.ship_id = k.kapal_id 
                            WHERE m.user_id = @uid AND m.status = @status
                            ORDER BY m.tanggal_lapor DESC";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("uid", uid);
                    cmd.Parameters.AddWithValue("status", _currentFilter);

                    DataTable dt = new DataTable();
                    new NpgsqlDataAdapter(cmd).Fill(dt);

                    var list = new List<dynamic>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add(new
                        {
                            Id = row["maintenance_id"],
                            ShipName = row["name"],
                            Description = row["deskripsi"],
                            Status = row["status"],
                            ReportDate = Convert.ToDateTime(row["tanggal_lapor"]).ToString("dd MMM yyyy"),
                            // Tombol Finish cuma muncul kalo Pending
                            ActionVisibility = _currentFilter == "Pending" ? Visibility.Visible : Visibility.Collapsed
                        });
                    }
                    dgTasks.ItemsSource = list;
                }
            }
            catch { }
        }

        private void BtnFinish_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            long id = Convert.ToInt64(btn.Tag);

            if (MessageBox.Show("Mark this task as Completed?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    using var conn = DbHelper.GetConnection(); conn.Open();
                    var sql = "UPDATE public.maintenance SET status='Completed', tanggal_selesai=NOW() WHERE maintenance_id=@id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                    }
                    // Kirim Notif WA/Email ke Owner (Optional)
                    NotificationHelper.SendWhatsApp("62812345", "Maintenance Selesai!");

                    LoadTasks(); // Refresh
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}