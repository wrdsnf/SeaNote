using SeaNote.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SeaNoteApp
{
    public partial class LogManagementForm : Form
    {
        private Trip? selectedTrip;
        private int selectedLogId = -1;

        public LogManagementForm()
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
                LoadLogsToGrid();
            }
            else
            {
                selectedTrip = null;
                dataGridViewLogs.DataSource = null;
            }
            ClearLogForm();
        }

        private void LoadLogsToGrid()
        {
            if (selectedTrip == null) return;
            dataGridViewLogs.DataSource = null;
            dataGridViewLogs.DataSource = selectedTrip.Logs.ToList();

            if (dataGridViewLogs.Columns.Count > 0)
            {
                dataGridViewLogs.Columns["LogID"].Width = 50;
                dataGridViewLogs.Columns["TripID"].Visible = false;
                dataGridViewLogs.Columns["TanggalLog"].Width = 150;
            }
        }

        private void ClearLogForm()
        {
            tbJenisLog.Text = "";
            tbIsiLog.Text = "";
            selectedLogId = -1;
            dataGridViewLogs.ClearSelection();
        }

        private void dataGridViewLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && selectedTrip != null)
            {
                DataGridViewRow row = dataGridViewLogs.Rows[e.RowIndex];
                selectedLogId = (int)row.Cells["LogID"].Value;

                Log? log = selectedTrip.Logs.Find(l => l.LogID == selectedLogId);
                if (log != null)
                {
                    tbJenisLog.Text = log.JenisLog;
                    tbIsiLog.Text = log.IsiLog;
                }
            }
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            if (selectedTrip == null) { MessageBox.Show("Pilih trip dulu"); return; }
            try
            {
                Log newLog = new Log
                {
                    LogID = selectedTrip.Logs.Count > 0 ? selectedTrip.Logs.Max(l => l.LogID) + 1 : 1,
                    JenisLog = tbJenisLog.Text,
                    IsiLog = tbIsiLog.Text,
                    TanggalLog = DateTime.Now
                };

                selectedTrip.AddLog(newLog); // Pake method dari Trip.cs
                LoadLogsToGrid();
                ClearLogForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUpdateLog_Click(object sender, EventArgs e)
        {
            if (selectedTrip == null || selectedLogId == -1) { MessageBox.Show("Pilih log dulu"); return; }
            try
            {
                Log? logToUpdate = selectedTrip.Logs.Find(l => l.LogID == selectedLogId);
                if (logToUpdate != null)
                {
                    logToUpdate.Update(tbJenisLog.Text, tbIsiLog.Text); // Pake method dari Log.cs
                }
                LoadLogsToGrid();
                ClearLogForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}