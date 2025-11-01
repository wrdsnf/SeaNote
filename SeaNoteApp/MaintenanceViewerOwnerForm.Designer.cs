namespace SeaNoteApp
{
    partial class MaintenanceViewerOwnerForm
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
            dataGridViewMaint = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaint
            // 
            dataGridViewMaint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaint.Dock = DockStyle.Fill;
            dataGridViewMaint.Location = new Point(0, 0);
            dataGridViewMaint.Name = "dataGridViewMaint";
            dataGridViewMaint.ReadOnly = true;
            dataGridViewMaint.RowHeadersWidth = 82;
            dataGridViewMaint.Size = new Size(800, 450);
            dataGridViewMaint.TabIndex = 0;
            // 
            // MaintenanceViewerOwnerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewMaint);
            Name = "MaintenanceViewerOwnerForm";
            Text = "Maintenance Viewer (Owner)";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMaint;
    }
}