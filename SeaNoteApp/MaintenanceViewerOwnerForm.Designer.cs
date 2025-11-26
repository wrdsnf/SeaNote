namespace SeaNoteApp
{
    partial class MaintenanceViewerOwnerForm
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
            dataGridViewMaint = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaint
            // 
            dataGridViewMaint.AllowUserToAddRows = false;
            dataGridViewMaint.AllowUserToDeleteRows = false;
            dataGridViewMaint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaint.Dock = DockStyle.Fill;
            dataGridViewMaint.Location = new Point(0, 0);
            dataGridViewMaint.Margin = new Padding(6, 6, 6, 6);
            dataGridViewMaint.Name = "dataGridViewMaint";
            dataGridViewMaint.ReadOnly = true;
            dataGridViewMaint.RowHeadersWidth = 82;
            dataGridViewMaint.RowTemplate.Height = 25;
            dataGridViewMaint.Size = new Size(1456, 1197);
            dataGridViewMaint.TabIndex = 0;
            // 
            // MaintenanceViewerOwnerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 1197);
            Controls.Add(dataGridViewMaint);
            Margin = new Padding(6, 6, 6, 6);
            Name = "MaintenanceViewerOwnerForm";
            Text = "Maintenance Viewer (Owner)";
            Load += MaintenanceViewerOwnerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaint;
    }
}