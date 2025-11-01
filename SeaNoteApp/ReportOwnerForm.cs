using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace SeaNoteApp
{
    public partial class ReportOwnerForm : Form
    {
        public ReportOwnerForm()
        {
            InitializeComponent();
        }

        private void ReportOwnerForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddMonths(-1);
            dtpTo.Value = DateTime.Now;

            dataGridViewReports.ReadOnly = true;
            dataGridViewReports.AllowUserToAddRows = false;

            LoadReportData();
        }

        private void LoadReportData()
        {
            dataGridViewReports.DataSource = null;
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();


                var sql = @"
                    SELECT 
                        t.trip_id, 
                        k.name as nama_kapal, 
                        t.tanggal_berangkat, 
                        t.tanggal_sampai, 
                        t.titik_berangkat, 
                        t.nahkoda,
                        (SELECT COUNT(*) FROM public.tasks WHERE trip_id = t.trip_id) AS total_tasks,
                        (SELECT COUNT(*) FROM public.logs WHERE trip_id = t.trip_id) AS total_logs
                    FROM public.trips t
                    LEFT JOIN public.kapal k ON t.kapal_id = k.kapal_id
                    WHERE t.tanggal_berangkat BETWEEN @date_from AND @date_to
                    ORDER BY t.tanggal_berangkat DESC";

                using var cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.Add(new NpgsqlParameter("date_from", NpgsqlDbType.Timestamp) { Value = dtpFrom.Value.Date });
                cmd.Parameters.Add(new NpgsqlParameter("date_to", NpgsqlDbType.Timestamp) { Value = dtpTo.Value.Date.AddDays(1).AddSeconds(-1) }); // Sampai akhir hari

                var dt = new DataTable();
                var adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridViewReports.DataSource = dt;

                if (dataGridViewReports.Columns.Contains("trip_id"))
                    dataGridViewReports.Columns["trip_id"].Visible = false;
                if (dataGridViewReports.Columns.Contains("nama_kapal"))
                    dataGridViewReports.Columns["nama_kapal"].HeaderText = "Nama Kapal";
                if (dataGridViewReports.Columns.Contains("total_tasks"))
                    dataGridViewReports.Columns["total_tasks"].HeaderText = "Jml Tasks";
                if (dataGridViewReports.Columns.Contains("total_logs"))
                    dataGridViewReports.Columns["total_logs"].HeaderText = "Jml Logs";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data laporan trip: " + ex.Message);
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            LoadReportData();
        }
    }
}