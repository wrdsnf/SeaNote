using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace SeaNoteWPF.Pages
{
    public partial class OwnerHomePage : Page
    {
        public OwnerHomePage()
        {
            InitializeComponent();
            if (App.LoggedInUser != null)
                txtWelcome.Text = $"Halo, {App.LoggedInUser.Username}!";
            LoadStats();
        }

        private void LoadStats()
        {
            try
            {
                using var conn = DbHelper.GetConnection(); conn.Open();
                long uid = App.LoggedInUser.Id;

                // Hitung Ships
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.kapal WHERE owner_id=@uid", conn))
                {
                    cmd.Parameters.AddWithValue("uid", uid);
                    lblShips.Text = cmd.ExecuteScalar().ToString();
                }
                // Hitung Trips
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.trips t JOIN public.kapal k ON t.kapal_id=k.kapal_id WHERE k.owner_id=@uid", conn))
                {
                    cmd.Parameters.AddWithValue("uid", uid);
                    lblTrips.Text = cmd.ExecuteScalar().ToString();
                }
                // Hitung Issues
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.maintenance m JOIN public.kapal k ON m.ship_id=k.kapal_id WHERE k.owner_id=@uid AND m.status='Pending'", conn))
                {
                    cmd.Parameters.AddWithValue("uid", uid);
                    lblIssues.Text = cmd.ExecuteScalar().ToString();
                }

                // Load Table Activity
                var sql = "SELECT jenis_log, isi_log, tanggal_log FROM public.logs ORDER BY tanggal_log DESC LIMIT 5";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    DataTable dt = new DataTable(); new NpgsqlDataAdapter(cmd).Fill(dt);
                    dgActivity.ItemsSource = dt.DefaultView;
                }
            }
            catch { }
        }

        // Logic Tombol Broadcast
        private void BtnBroadcast_Click(object sender, RoutedEventArgs e) => MsgOverlay.Visibility = Visibility.Visible;
        private void BtnCloseMsg_Click(object sender, RoutedEventArgs e) => MsgOverlay.Visibility = Visibility.Collapsed;

        private void BtnSendMsg_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMsg.Text)) return;
            string target = ((ComboBoxItem)cbTarget.SelectedItem).Content.ToString();
            if (target == "All Staff") target = "All";

            try
            {
                MessageService.SendMessage(App.LoggedInUser.Id, target, tbMsg.Text);
                MessageBox.Show("Pesan terkirim!");
                tbMsg.Clear();
                MsgOverlay.Visibility = Visibility.Collapsed;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}