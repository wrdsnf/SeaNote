namespace SeaNoteApp
{
    partial class MaintenanceHistoryEngineerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Dock = DockStyle.Fill;
            dataGridViewHistory.Location = new Point(0, 0);
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.ReadOnly = true;
            dataGridViewHistory.RowHeadersWidth = 82;
            dataGridViewHistory.Size = new Size(774, 529);
            dataGridViewHistory.TabIndex = 0;
            // 
            // MaintenanceHistoryEngineerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 529);
            Controls.Add(dataGridViewHistory);
            Name = "MaintenanceHistoryEngineerForm";
            Text = "Maintenance History (Engineer)";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewHistory;
    }
}