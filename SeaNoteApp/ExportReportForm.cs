using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CsvHelper;
using Npgsql;

namespace SeaNoteApp
{
    public partial class ExportReportForm : Form
    {
        public ExportReportForm()
        {
            InitializeComponent();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (cbReportType.SelectedItem == null) { MessageBox.Show("Pilih jenis laporan dulu!"); return; }
            string reportType = cbReportType.SelectedItem.ToString();
            using var sfd = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*", FileName = $"Export_SeaNote_{reportType}_{DateTime.Now:yyyyMMdd}.csv" };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            string filePath = sfd.FileName;
            try
            {
                switch (reportType)
                {
                    case "Users": ExportUsers(filePath); break;
                    case "Kapal": ExportKapal(filePath); break;
                    case "Trips": ExportTrips(filePath); break;
                    case "Maintenance": ExportMaintenance(filePath); break;
                    case "Logs": ExportLogs(filePath); break;
                    default: MessageBox.Show("Jenis laporan tidak dikenali."); return;
                }
                MessageBox.Show($"Ekspor '{reportType}' berhasil!\nFile disimpan di: {filePath}", "Ekspor Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Gagal mengekspor data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ExportUsers(string filePath)
        {
            var userList = new List<User>();
            using var conn = DbHelper.GetConnection();
            conn.Open();
            string sql = @"SELECT user_id, username, role, nama_lengkap, email, no_handphone FROM public.users";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userList.Add(new User
                {
                    UserID = reader["user_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["user_id"]),
                    Username = reader["username"]?.ToString() ?? "",
                    Role = reader["role"]?.ToString(),
                    NamaLengkap = reader["nama_lengkap"]?.ToString(),
                    Email = reader["email"]?.ToString(),
                    NomorTelepon = reader["no_handphone"]?.ToString()
                });
            }
            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(userList);
        }

        private void ExportKapal(string filePath)
        {
            var list = new List<Ship>();
            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM public.kapal", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Ship
                {
                    KapalId = reader["kapal_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["kapal_id"]),
                    Name = reader["name"]?.ToString() ?? "",
                    Year = reader["year"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["year"]),
                    Capacity = reader["capacity"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["capacity"]),
                    TotalTrip = reader["total_trip"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["total_trip"]),
                    Fuel = reader["fuel"]?.ToString()
                });
            }
            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(list);
        }

        private void ExportTrips(string filePath)
        {
            var list = new List<Trip>();
            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM public.trips", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Trip
                {
                    TripId = reader["trip_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["trip_id"]),
                    KapalId = reader["kapal_id"] == DBNull.Value ? (long?)null : Convert.ToInt64(reader["kapal_id"]),
                    TanggalBerangkat = reader["tanggal_berangkat"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["tanggal_berangkat"]),
                    TanggalSampai = reader["tanggal_sampai"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["tanggal_sampai"]),
                    TitikBerangkat = reader["titik_berangkat"]?.ToString(),
                    Nakhoda = reader["nahkoda"]?.ToString(),
                    Notes = reader["notes"]?.ToString()
                });
            }
            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(list);
        }

        private void ExportMaintenance(string filePath)
        {
            var list = new List<Maintenance>();
            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM public.maintenance", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Maintenance
                {
                    MaintenanceId = reader["maintenance_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["maintenance_id"]),
                    KapalId = reader["kapal_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["kapal_id"]),
                    MaintenanceTitle = reader["maintenance_title"]?.ToString() ?? "",
                    Description = reader["description"]?.ToString(),
                    Status = reader["status"]?.ToString() ?? "scheduled",
                    MaintenanceDate = reader["maintenance_date"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["maintenance_date"])
                });
            }
            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(list);
        }

        private void ExportLogs(string filePath)
        {
            var list = new List<Log>();
            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM public.logs", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Log
                {
                    LogId = reader["log_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["log_id"]),
                    TripId = reader["trip_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["trip_id"]),
                    JenisLog = reader["jenis_log"]?.ToString(),
                    IsiLog = reader["isi_log"]?.ToString(),
                    TanggalLog = reader["tanggal_log"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["tanggal_log"])
                });
            }
            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(list);
        }
    }
}
