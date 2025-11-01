namespace SeaNoteApp
{
    partial class ShipViewerForm
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
            dataGridViewShips = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShips).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewShips
            // 
            dataGridViewShips.AllowUserToAddRows = false;
            dataGridViewShips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShips.Dock = DockStyle.Fill;
            dataGridViewShips.Location = new Point(0, 0);
            dataGridViewShips.Name = "dataGridViewShips";
            dataGridViewShips.ReadOnly = true;
            dataGridViewShips.RowHeadersWidth = 82;
            dataGridViewShips.Size = new Size(874, 529);
            dataGridViewShips.TabIndex = 0;
            // 
            // ShipViewerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 529);
            Controls.Add(dataGridViewShips);
            Name = "ShipViewerForm";
            Text = "View All Ships";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShips).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewShips;
    }
}