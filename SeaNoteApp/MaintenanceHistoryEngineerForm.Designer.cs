namespace SeaNoteApp
{
    partial class MaintenanceHistoryEngineerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewMaintHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaintHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaintHistory
            // 
            dataGridViewMaintHistory.AllowUserToAddRows = false;
            dataGridViewMaintHistory.AllowUserToDeleteRows = false;
            dataGridViewMaintHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaintHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaintHistory.Dock = DockStyle.Fill;
            dataGridViewMaintHistory.Location = new Point(0, 0);
            dataGridViewMaintHistory.Margin = new Padding(6, 6, 6, 6);
            dataGridViewMaintHistory.Name = "dataGridViewMaintHistory";
            dataGridViewMaintHistory.ReadOnly = true;
            dataGridViewMaintHistory.RowHeadersWidth = 82;
            dataGridViewMaintHistory.RowTemplate.Height = 25;
            dataGridViewMaintHistory.Size = new Size(1456, 1197);
            dataGridViewMaintHistory.TabIndex = 0;
            // 
            // MaintenanceHistoryEngineerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 1197);
            Controls.Add(dataGridViewMaintHistory);
            Margin = new Padding(6, 6, 6, 6);
            Name = "MaintenanceHistoryEngineerForm";
            Text = "Maintenance History (Engineer)";
            Load += MaintenanceHistoryEngineerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaintHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaintHistory;
    }
}