using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class TaskManagementForm : Form
    {
        private Trip? selectedTrip;
        private int selectedTaskId = -1;

        public TaskManagementForm()
        {
            InitializeComponent();
            LoadTripComboBox();
        }

        private void LoadTripComboBox()
        {
            cbTrips.DataSource = TripManagementForm.globalDummyTrips;
            cbTrips.DisplayMember = "KodeTrip";
            cbTrips.ValueMember = "TripID";
            cbTrips.SelectedIndex = -1;
        }

        private void cbTrips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrips.SelectedItem != null)
            {
                selectedTrip = (Trip)cbTrips.SelectedItem;
                LoadTasksToGrid();
            }
            else
            {
                selectedTrip = null;
                dataGridViewTasks.DataSource = null;
            }
            ClearTaskForm();
        }

        private void LoadTasksToGrid()
        {
            if (selectedTrip == null) return;
            dataGridViewTasks.DataSource = null;
            dataGridViewTasks.DataSource = selectedTrip.Tasks.ToList();

            if (dataGridViewTasks.Columns.Count > 0)
            {
                dataGridViewTasks.Columns["TaskID"].Width = 50;
                dataGridViewTasks.Columns["TripID"].Visible = false;
            }
        }

        private void ClearTaskForm()
        {
            tbTaskName.Text = "";
            tbTaskDesc.Text = "";
            checkCompleted.Checked = false;
            selectedTaskId = -1;
            dataGridViewTasks.ClearSelection();
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && selectedTrip != null)
            {
                DataGridViewRow row = dataGridViewTasks.Rows[e.RowIndex];
                selectedTaskId = (int)row.Cells["TaskID"].Value;

                TripTask? task = selectedTrip.Tasks.Find(t => t.TaskID == selectedTaskId);
                if (task != null)
                {
                    tbTaskName.Text = task.NamaTask;
                    tbTaskDesc.Text = task.Deskripsi;
                    checkCompleted.Checked = task.IsCompleted;
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (selectedTrip == null) { MessageBox.Show("Pilih trip dulu"); return; }
            try
            {
                TripTask newTask = new TripTask
                {
                    TaskID = selectedTrip.Tasks.Count > 0 ? selectedTrip.Tasks.Max(t => t.TaskID) + 1 : 1,
                    NamaTask = tbTaskName.Text,
                    Deskripsi = tbTaskDesc.Text,
                    IsCompleted = checkCompleted.Checked,
                };

                selectedTrip.AddTask(newTask); // Pake method dari Trip.cs
                LoadTasksToGrid();
                ClearTaskForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            if (selectedTrip == null || selectedTaskId == -1) { MessageBox.Show("Pilih task dulu"); return; }
            try
            {
                TripTask? taskToUpdate = selectedTrip.Tasks.Find(t => t.TaskID == selectedTaskId);
                if (taskToUpdate != null)
                {
                    taskToUpdate.NamaTask = tbTaskName.Text;
                    taskToUpdate.Deskripsi = tbTaskDesc.Text;
                    taskToUpdate.IsCompleted = checkCompleted.Checked;
                }
                LoadTasksToGrid();
                ClearTaskForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}