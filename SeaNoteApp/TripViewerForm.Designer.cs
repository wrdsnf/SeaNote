namespace SeaNoteApp
{
    partial class TripViewerForm
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
            dataGridViewTrips = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTrips
            // 
            dataGridViewTrips.AllowUserToAddRows = false;
            dataGridViewTrips.AllowUserToDeleteRows = false;
            dataGridViewTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrips.Dock = DockStyle.Fill;
            dataGridViewTrips.Location = new Point(0, 0);
            dataGridViewTrips.Margin = new Padding(6, 6, 6, 6);
            dataGridViewTrips.Name = "dataGridViewTrips";
            dataGridViewTrips.ReadOnly = true;
            dataGridViewTrips.RowHeadersWidth = 82;
            dataGridViewTrips.RowTemplate.Height = 25;
            dataGridViewTrips.Size = new Size(1456, 1197);
            dataGridViewTrips.TabIndex = 0;
            // 
            // TripViewerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 1197);
            Controls.Add(dataGridViewTrips);
            Margin = new Padding(6, 6, 6, 6);
            Name = "TripViewerForm";
            Text = "Trip Viewer (Owner)";
            Load += TripViewerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrips;
    }
}