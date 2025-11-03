namespace SeaNoteApp
{
    partial class ShipViewerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewShips = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShips).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewShips
            // 
            dataGridViewShips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewShips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShips.Dock = DockStyle.Fill;
            dataGridViewShips.Location = new Point(0, 0);
            dataGridViewShips.MultiSelect = false;
            dataGridViewShips.Name = "dataGridViewShips";
            dataGridViewShips.ReadOnly = true;
            dataGridViewShips.RowHeadersWidth = 82;
            dataGridViewShips.RowTemplate.Height = 25;
            dataGridViewShips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShips.Size = new Size(1152, 651);
            dataGridViewShips.TabIndex = 1;
            // 
            // ShipViewerForm
            // 
            ClientSize = new Size(1152, 651);
            Controls.Add(dataGridViewShips);
            Name = "ShipViewerForm";
            Text = "Ship Viewer";
            Load += ShipViewerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShips).EndInit();
            ResumeLayout(false);
        }
        private DataGridView dataGridViewShips;
    }
}
