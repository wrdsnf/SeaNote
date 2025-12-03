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
    public partial class AdminHomePage : Page
    {
        public AdminHomePage()
        {
            InitializeComponent();
            if (App.LoggedInUser != null) txtWelcome.Text = $"Halo, {App.LoggedInUser.Username}!";
            txtDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            LoadData();
            UpdateWeather("Jakarta");
        }

        private async void UpdateWeather(string city)
        {
            txtTemp.Text = "Loading...";
            var (temp, cond) = await WeatherService.GetWeather(city);
            txtTemp.Text = $"{temp} {cond}";

            if (cond == "Sunny") txtWeatherIcon.Text = "☀️";
            else if (cond == "Cloudy") txtWeatherIcon.Text = "☁️";
            else if (cond == "Rainy") txtWeatherIcon.Text = "🌧️";
            else txtWeatherIcon.Text = "⛈️";
        }

        private void CbCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbCity.SelectedItem is ComboBoxItem item) UpdateWeather(item.Content.ToString());
        }

        private void LoadData()
        {
            try
            {
                using var conn = DbHelper.GetConnection(); conn.Open();

                var cmdS = new NpgsqlCommand("SELECT name, year, fuel FROM public.kapal ORDER BY name LIMIT 10", conn);
                DataTable dtS = new DataTable(); new NpgsqlDataAdapter(cmdS).Fill(dtS);
                var listS = new List<dynamic>();
                foreach (DataRow r in dtS.Rows) listS.Add(new { Name = r["name"], Year = r["year"], Fuel = r["fuel"] });
                dgShips.ItemsSource = listS;

                var cmdT = new NpgsqlCommand("SELECT k.name, t.titik_berangkat, t.tanggal_berangkat FROM public.trips t JOIN public.kapal k ON t.kapal_id = k.kapal_id ORDER BY t.tanggal_berangkat DESC LIMIT 10", conn);
                DataTable dtT = new DataTable(); new NpgsqlDataAdapter(cmdT).Fill(dtT);
                var listT = new List<dynamic>();
                foreach (DataRow r in dtT.Rows) listT.Add(new { ShipName = r["name"], Route = r["titik_berangkat"], Date = Convert.ToDateTime(r["tanggal_berangkat"]).ToString("dd MMM") });
                dgTrips.ItemsSource = listT;
            }
            catch { }
        }

        // GEMINI LOGIC
        private void BtnGemini_Click(object sender, RoutedEventArgs e) => GeminiOverlay.Visibility = Visibility.Visible;
        private void BtnCloseGemini_Click(object sender, RoutedEventArgs e) => GeminiOverlay.Visibility = Visibility.Collapsed;

        private async void BtnSendGemini_Click(object sender, RoutedEventArgs e)
        {
            string q = txtGeminiInput.Text;
            if (string.IsNullOrWhiteSpace(q)) return;
            txtGeminiOutput.AppendText($"YOU: {q}\nThinking...\n");
            txtGeminiInput.Clear();
            string ans = await GeminiService.AskGemini(q);
            txtGeminiOutput.AppendText($"AI: {ans}\n\n---\n");
            txtGeminiOutput.ScrollToEnd();
        }
        private void TxtGeminiInput_KeyDown(object sender, KeyEventArgs e) { if (e.Key == Key.Enter) BtnSendGemini_Click(sender, e); }
    }
}