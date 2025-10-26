namespace SeaNoteApp
{
    partial class TripViewerForm
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
            dataGridViewTrips = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTrips
            // 
            dataGridViewTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrips.Dock = DockStyle.Fill;
            dataGridViewTrips.Location = new Point(0, 0);
            dataGridViewTrips.Name = "dataGridViewTrips";
            dataGridViewTrips.ReadOnly = true;
            dataGridViewTrips.RowHeadersWidth = 82;
            dataGridViewTrips.Size = new Size(774, 529);
            dataGridViewTrips.TabIndex = 0;
            // 
            // TripViewerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 529);
            Controls.Add(dataGridViewTrips);
            Name = "TripViewerForm";
            Text = "Trip Viewer (Read-Only)";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTrips;
    }
}