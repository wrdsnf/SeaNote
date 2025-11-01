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
            this.dataGridViewMaintHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaintHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaintHistory
            // 
            this.dataGridViewMaintHistory.AllowUserToAddRows = false;
            this.dataGridViewMaintHistory.AllowUserToDeleteRows = false;
            this.dataGridViewMaintHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaintHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaintHistory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaintHistory.Name = "dataGridViewMaintHistory";
            this.dataGridViewMaintHistory.ReadOnly = true;
            this.dataGridViewMaintHistory.RowTemplate.Height = 25;
            this.dataGridViewMaintHistory.Size = new System.Drawing.Size(784, 561);
            this.dataGridViewMaintHistory.TabIndex = 0;
            // 
            // MaintenanceHistoryEngineerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridViewMaintHistory);
            this.Name = "MaintenanceHistoryEngineerForm";
            this.Text = "Maintenance History (Engineer)";
            this.Load += new System.EventHandler(this.MaintenanceHistoryEngineerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaintHistory)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaintHistory;
    }
}