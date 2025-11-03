using Npgsql;
using NpgsqlTypes;
using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class LogManagementForm : Form
    {
        private long _currentTripId;
        private long selectedLogId = 0;
        private List<Log> logList = new List<Log>();

        public LogManagementForm(long tripId)
        {
            InitializeComponent();
            _currentTripId = tripId;
            // Kita pake label3 buat nampilin info, jadi ini bisa dihapus/diganti
            this.Text = "Manage Logs for Trip ID: " + _currentTripId;
        }

        private void LogManagementForm_Load(object sender, EventArgs e)
        {
            LoadLogsToGrid();
            ClearLogForm();
        }

        private void LoadLogsToGrid()
        {
            logList.Clear();
            dataGridViewLogs.DataSource = null;
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string sql = "SELECT * FROM public.logs WHERE trip_id = @trip_id ORDER BY tanggal_log DESC";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("trip_id", NpgsqlDbType.Bigint) { Value = _currentTripId });
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    logList.Add(new Log
                    {
                        LogId = reader["log_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["log_id"]),
                        TripId = reader["trip_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["trip_id"]),
                        JenisLog = reader["jenis_log"]?.ToString(),
                        IsiLog = reader["isi_log"]?.ToString(),
                        TanggalLog = reader["tanggal_log"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["tanggal_log"])
                    });
                }
                dataGridViewLogs.DataSource = logList;
                if (dataGridViewLogs.Columns.Count > 0)
                {
                    if (dataGridViewLogs.Columns.Contains("LogId")) dataGridViewLogs.Columns["LogId"].Visible = false;
                    if (dataGridViewLogs.Columns.Contains("TripId")) dataGridViewLogs.Columns["TripId"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Gagal ambil data log: " + ex.Message); }
        }

        private void ClearLogForm()
        {
            tbJenisLog.Text = "";
            tbIsiLog.Text = "";
            dtpTanggalLog.Value = DateTime.Now;
            selectedLogId = 0;
            dataGridViewLogs.ClearSelection();

            // === KODE BUAT LABEL DINAMIS ===
            label3.Text = "Logs for Trip ID: " + _currentTripId;
        }

        private void DataGridViewLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridViewLogs.Rows[e.RowIndex];
            selectedLogId = row.Cells["LogId"].Value == DBNull.Value || row.Cells["LogId"].Value == null ? 0L : Convert.ToInt64(row.Cells["LogId"].Value);
            tbJenisLog.Text = row.Cells["JenisLog"].Value?.ToString() ?? "";
            tbIsiLog.Text = row.Cells["IsiLog"].Value?.ToString() ?? "";
            dtpTanggalLog.Value = row.Cells["TanggalLog"].Value == DBNull.Value || row.Cells["TanggalLog"].Value == null ? DateTime.Now : Convert.ToDateTime(row.Cells["TanggalLog"].Value);

            // === KODE BUAT LABEL DINAMIS ===
            label3.Text = "Selected Log: " + (tbJenisLog.Text ?? "Log ID " + selectedLogId);
        }

        private void BtnAddLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIsiLog.Text)) { MessageBox.Show("Isi log wajib diisi"); return; }
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string sql = @"
                    INSERT INTO public.logs (trip_id, jenis_log, isi_log, tanggal_log)
                    VALUES (@trip_id, @jenis_log, @isi_log, @tanggal_log)";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("trip_id", NpgsqlDbType.Bigint) { Value = _currentTripId });
                cmd.Parameters.AddWithValue("jenis_log", tbJenisLog.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("isi_log", tbIsiLog.Text);
                cmd.Parameters.AddWithValue("tanggal_log", dtpTanggalLog.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Log baru berhasil ditambah!");
                LoadLogsToGrid();
                ClearLogForm();
            }
            catch (Exception ex) { MessageBox.Show("Gagal nambah log: " + ex.Message); }
        }

        private void BtnUpdateLog_Click(object sender, EventArgs e)
        {
            if (selectedLogId == 0) { MessageBox.Show("Pilih log dulu"); return; }
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string sql = @"
                    UPDATE public.logs 
                    SET jenis_log = @jenis_log, isi_log = @isi_log, tanggal_log = @tanggal_log
                    WHERE log_id = @log_id";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("jenis_log", tbJenisLog.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("isi_log", tbIsiLog.Text);
                cmd.Parameters.AddWithValue("tanggal_log", dtpTanggalLog.Value);
                cmd.Parameters.Add(new NpgsqlParameter("log_id", NpgsqlDbType.Bigint) { Value = selectedLogId });
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data log berhasil di-update!");
                LoadLogsToGrid();
                ClearLogForm();
            }
            catch (Exception ex) { MessageBox.Show("Gagal update log: " + ex.Message); }
        }

        private void BtnDeleteLog_Click(object sender, EventArgs e)
        {
            if (selectedLogId == 0) { MessageBox.Show("Pilih log dulu"); return; }
            if (MessageBox.Show("Yakin mau hapus log ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                string sql = "DELETE FROM public.logs WHERE log_id = @log_id";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("log_id", NpgsqlDbType.Bigint) { Value = selectedLogId });
                cmd.ExecuteNonQuery();

                MessageBox.Show("Log berhasil dihapus.");
                LoadLogsToGrid();
                ClearLogForm();
            }
            catch (Exception ex) { MessageBox.Show("Gagal hapus log: " + ex.Message); }
        }
    }
}