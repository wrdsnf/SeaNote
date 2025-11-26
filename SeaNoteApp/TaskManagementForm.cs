using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace SeaNoteApp
{
    public partial class TaskManagementForm : Form
    {
        private long _currentTripId;
        private long selectedTaskId = 0;
        private List<TripTask> taskList = new List<TripTask>();

        public TaskManagementForm(long tripId)
        {
            InitializeComponent();
            _currentTripId = tripId;
            this.Text = "Manage Tasks for Trip: " + _currentTripId;
        }

        private void TaskManagementForm_Load(object sender, EventArgs e)
        {
            LoadTasksToGrid();
            ClearTaskForm(); // label3 bakal ke-set di sini pertama kali
        }

        private void LoadTasksToGrid()
        {
            taskList.Clear();
            dataGridViewTasks.DataSource = null;
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "SELECT * FROM public.tasks WHERE trip_id = @trip_id ORDER BY created_at";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("trip_id", NpgsqlDbType.Bigint) { Value = _currentTripId });
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    taskList.Add(new TripTask
                    {
                        TaskId = reader["task_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["task_id"]),
                        TripId = reader["trip_id"] == DBNull.Value ? 0L : Convert.ToInt64(reader["trip_id"]),
                        TaskName = reader["task_name"]?.ToString() ?? "",
                        Description = reader["description"]?.ToString(),
                        IsCompleted = reader["is_completed"] == DBNull.Value ? false : Convert.ToBoolean(reader["is_completed"])
                    });
                }
                dataGridViewTasks.DataSource = taskList;
                if (dataGridViewTasks.Columns.Count > 0)
                {
                    if (dataGridViewTasks.Columns.Contains("TaskId")) dataGridViewTasks.Columns["TaskId"].Visible = false;
                    if (dataGridViewTasks.Columns.Contains("TripId")) dataGridViewTasks.Columns["TripId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data task: " + ex.Message);
            }
        }

        private void ClearTaskForm()
        {
            tbTaskName.Text = "";
            tbTaskDescription.Text = "";
            chkIsCompleted.Checked = false;
            selectedTaskId = 0;
            dataGridViewTasks.ClearSelection();

            label3.Text = "Tasks for Trip ID: " + _currentTripId;
        }

        private void DataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridViewTasks.Rows[e.RowIndex];

            selectedTaskId = row.Cells["TaskId"].Value == DBNull.Value || row.Cells["TaskId"].Value == null ? 0L : Convert.ToInt64(row.Cells["TaskId"].Value);
            tbTaskName.Text = row.Cells["TaskName"].Value?.ToString() ?? "";
            tbTaskDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";
            chkIsCompleted.Checked = row.Cells["IsCompleted"].Value == DBNull.Value ? false : Convert.ToBoolean(row.Cells["IsCompleted"].Value);

            // Update label3 pake nama task yang lagi dipilih
            label3.Text = "Selected Task: " + tbTaskName.Text;
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTaskName.Text)) { MessageBox.Show("Nama task wajib diisi"); return; }
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = @"
                    INSERT INTO public.tasks 
                    (trip_id, task_name, description, is_completed) 
                    VALUES 
                    (@trip_id, @task_name, @description, @is_completed)";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("trip_id", NpgsqlDbType.Bigint) { Value = _currentTripId });
                cmd.Parameters.AddWithValue("task_name", tbTaskName.Text);
                cmd.Parameters.AddWithValue("description", tbTaskDescription.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("is_completed", chkIsCompleted.Checked);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Task baru berhasil ditambah!");
                LoadTasksToGrid();
                ClearTaskForm(); 
            }
            catch (Exception ex) { MessageBox.Show("Gagal nambah task: " + ex.Message); }
        }

        private void BtnUpdateTask_Click(object sender, EventArgs e)
        {
            if (selectedTaskId == 0) { MessageBox.Show("Pilih task dulu"); return; }
            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = @"
                    UPDATE public.tasks 
                    SET task_name = @task_name, description = @description, 
                        is_completed = @is_completed, completed_at = @completed_at
                    WHERE task_id = @task_id";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("task_name", tbTaskName.Text);
                cmd.Parameters.AddWithValue("description", tbTaskDescription.Text ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("is_completed", chkIsCompleted.Checked);
                if (chkIsCompleted.Checked) cmd.Parameters.AddWithValue("completed_at", DateTime.UtcNow);
                else cmd.Parameters.AddWithValue("completed_at", (object)DBNull.Value);
                cmd.Parameters.Add(new NpgsqlParameter("task_id", NpgsqlDbType.Bigint) { Value = selectedTaskId });
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data task berhasil di-update!");
                LoadTasksToGrid();
                ClearTaskForm(); 
            }
            catch (Exception ex) { MessageBox.Show("Gagal update task: " + ex.Message); }
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            if (selectedTaskId == 0) { MessageBox.Show("Pilih task dulu"); return; }
            if (MessageBox.Show("Yakin mau hapus task ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                var sql = "DELETE FROM public.tasks WHERE task_id = @task_id";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("task_id", NpgsqlDbType.Bigint) { Value = selectedTaskId });
                cmd.ExecuteNonQuery();
                MessageBox.Show("Task berhasil dihapus.");
                LoadTasksToGrid();
                ClearTaskForm();
            }
            catch (Exception ex) { MessageBox.Show("Gagal hapus task: " + ex.Message); }
        }
    }
}