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
            this.dataGridViewTrips = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrips
            // 
            this.dataGridViewTrips.AllowUserToAddRows = false;
            this.dataGridViewTrips.AllowUserToDeleteRows = false;
            this.dataGridViewTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrips.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTrips.Name = "dataGridViewTrips";
            this.dataGridViewTrips.ReadOnly = true;
            this.dataGridViewTrips.RowTemplate.Height = 25;
            this.dataGridViewTrips.Size = new System.Drawing.Size(784, 561);
            this.dataGridViewTrips.TabIndex = 0;
            // 
            // TripViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridViewTrips);
            this.Name = "TripViewerForm";
            this.Text = "Trip Viewer (Owner)";
            this.Load += new System.EventHandler(this.TripViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrips;
    }
}