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
            this.dataGridViewMaint = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaint)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMaint
            // 
            this.dataGridViewMaint.AllowUserToAddRows = false;
            this.dataGridViewMaint.AllowUserToDeleteRows = false;
            this.dataGridViewMaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaint.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaint.Name = "dataGridViewMaint";
            this.dataGridViewMaint.ReadOnly = true;
            this.dataGridViewMaint.RowTemplate.Height = 25;
            this.dataGridViewMaint.Size = new System.Drawing.Size(784, 561);
            this.dataGridViewMaint.TabIndex = 0;
            // 
            // MaintenanceViewerOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridViewMaint);
            this.Name = "MaintenanceViewerOwnerForm";
            this.Text = "Maintenance Viewer (Owner)";
            this.Load += new System.EventHandler(this.MaintenanceViewerOwnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaint)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaint;
    }
}