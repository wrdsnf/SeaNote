namespace SeaNoteApp
{
    partial class ShipViewerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewShips;
        private System.Windows.Forms.TextBox tbShipName;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.TextBox tbFuel;
        private System.Windows.Forms.NumericUpDown numTotalTrip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewShips = new System.Windows.Forms.DataGridView();
            this.tbShipName = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.tbFuel = new System.Windows.Forms.TextBox();
            this.numTotalTrip = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTrip)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShips
            // 
            this.dataGridViewShips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom) |
                System.Windows.Forms.AnchorStyles.Left) |
                System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShips.Location = new System.Drawing.Point(12, 90);
            this.dataGridViewShips.MultiSelect = false;
            this.dataGridViewShips.Name = "dataGridViewShips";
            this.dataGridViewShips.ReadOnly = true;
            this.dataGridViewShips.RowTemplate.Height = 25;
            this.dataGridViewShips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShips.Size = new System.Drawing.Size(760, 260);
            this.dataGridViewShips.TabIndex = 0;
            this.dataGridViewShips.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShips_CellClick);
            // 
            // tbShipName
            // 
            this.tbShipName.Location = new System.Drawing.Point(12, 12);
            this.tbShipName.Name = "tbShipName";
            this.tbShipName.Size = new System.Drawing.Size(200, 23);
            this.tbShipName.TabIndex = 1;
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(230, 12);
            this.numYear.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            this.numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(100, 23);
            this.numYear.TabIndex = 2;
            this.numYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(340, 12);
            this.numCapacity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(100, 23);
            this.numCapacity.TabIndex = 3;
            // 
            // tbFuel
            // 
            this.tbFuel.Location = new System.Drawing.Point(460, 12);
            this.tbFuel.Name = "tbFuel";
            this.tbFuel.Size = new System.Drawing.Size(150, 23);
            this.tbFuel.TabIndex = 4;
            // 
            // numTotalTrip
            // 
            this.numTotalTrip.Location = new System.Drawing.Point(620, 12);
            this.numTotalTrip.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numTotalTrip.Name = "numTotalTrip";
            this.numTotalTrip.Size = new System.Drawing.Size(100, 23);
            this.numTotalTrip.TabIndex = 5;
            // 
            // ShipViewerForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.numTotalTrip);
            this.Controls.Add(this.tbFuel);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.tbShipName);
            this.Controls.Add(this.dataGridViewShips);
            this.Name = "ShipViewerForm";
            this.Text = "Ship Viewer";
            this.Load += new System.EventHandler(this.ShipViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
