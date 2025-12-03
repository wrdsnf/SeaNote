using Npgsql;
using SeaNoteWPF.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SeaNoteWPF.Pages
{
    public partial class EngineerHomePage : Page
    {
        public EngineerHomePage()
        {
            InitializeComponent();
            if (App.LoggedInUser != null) txtWelcome.Text = $"Halo, {App.LoggedInUser.Username}!";
            LoadData();
        }

        private void LoadData()
        {
            // blm load data
            try
            {
                using var conn = DbHelper.GetConnection(); conn.Open();
                long uid = App.LoggedInUser.Id;
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.maintenance WHERE user_id=@uid AND status='Pending'", conn)) lblPending.Text = cmd.ExecuteScalar().ToString();
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.maintenance WHERE user_id=@uid AND status='Completed'", conn)) lblCompleted.Text = cmd.ExecuteScalar().ToString();
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.maintenance WHERE user_id=@uid", conn)) lblAssigned.Text = cmd.ExecuteScalar().ToString();

                var sql = @"SELECT k.name, m.deskripsi, m.status, m.tanggal_selesai FROM public.maintenance m JOIN public.kapal k ON m.ship_id = k.kapal_id WHERE m.user_id = @uid ORDER BY m.tanggal_selesai DESC LIMIT 10";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("uid", uid);
                    DataTable dt = new DataTable(); new NpgsqlDataAdapter(cmd).Fill(dt);
                    var list = new List<dynamic>();
                    foreach (DataRow r in dt.Rows) list.Add(new { ShipName = r["name"], Description = r["deskripsi"], Status = r["status"], Date = Convert.ToDateTime(r["tanggal_selesai"]).ToString("dd MMM") });
                    dgActivity.ItemsSource = list;
                }
            }
            catch { }
        }
        private void BtnGemini_Click(object sender, RoutedEventArgs e) => GeminiOverlay.Visibility = Visibility.Visible;
        private void BtnCloseGemini_Click(object sender, RoutedEventArgs e) => GeminiOverlay.Visibility = Visibility.Collapsed;

        private async void BtnSendGemini_Click(object sender, RoutedEventArgs e)
        {
            string q = txtGeminiInput.Text;
            if (string.IsNullOrWhiteSpace(q)) return;
            txtGeminiOutput.AppendText($"YOU: {q}\n");
            txtGeminiInput.Clear();
            txtGeminiOutput.AppendText("Thinking...\n");
            string ans = await GeminiService.AskGemini(q);
            txtGeminiOutput.AppendText($"AI: {ans}\n\n---\n");
            txtGeminiOutput.ScrollToEnd();
        }
        private void TxtGeminiInput_KeyDown(object sender, KeyEventArgs e) { if (e.Key == Key.Enter) BtnSendGemini_Click(sender, e); }
    }
}