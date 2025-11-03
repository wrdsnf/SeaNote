namespace SeaNoteApp
{
    partial class ShipManagementForm
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
            dataGridViewShips = new DataGridView();
            label1 = new Label();
            tbShipName = new TextBox();
            label2 = new Label();
            numYear = new NumericUpDown();
            label3 = new Label();
            numCapacity = new NumericUpDown();
            tbFuel = new TextBox();
            numTotalTrip = new NumericUpDown();
            btnAddShip = new Button();
            btnUpdateShip = new Button();
            btnDeleteShip = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShips).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalTrip).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewShips
            // 
            dataGridViewShips.AllowUserToAddRows = false;
            dataGridViewShips.AllowUserToDeleteRows = false;
            dataGridViewShips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewShips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShips.Dock = DockStyle.Fill;
            dataGridViewShips.Location = new Point(615, 6);
            dataGridViewShips.Margin = new Padding(6);
            dataGridViewShips.Name = "dataGridViewShips";
            dataGridViewShips.ReadOnly = true;
            dataGridViewShips.RowHeadersWidth = 82;
            dataGridViewShips.RowTemplate.Height = 25;
            dataGridViewShips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShips.Size = new Size(1253, 907);
            dataGridViewShips.TabIndex = 0;
            dataGridViewShips.CellClick += dataGridViewShips_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 43);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 1;
            label1.Text = "Nama Kapal:";
            // 
            // tbShipName
            // 
            tbShipName.Location = new Point(57, 81);
            tbShipName.Margin = new Padding(6);
            tbShipName.Name = "tbShipName";
            tbShipName.Size = new Size(428, 39);
            tbShipName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 138);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 3;
            label2.Text = "Tahun:";
            // 
            // numYear
            // 
            numYear.Location = new Point(57, 176);
            numYear.Margin = new Padding(6);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(428, 39);
            numYear.TabIndex = 4;
            numYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 236);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 5;
            label3.Text = "Kapasitas:";
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(57, 274);
            numCapacity.Margin = new Padding(6);
            numCapacity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(428, 39);
            numCapacity.TabIndex = 6;
            numCapacity.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // tbFuel
            // 
            tbFuel.Location = new Point(57, 372);
            tbFuel.Margin = new Padding(6);
            tbFuel.Name = "tbFuel";
            tbFuel.Size = new Size(428, 39);
            tbFuel.TabIndex = 8;
            // 
            // numTotalTrip
            // 
            numTotalTrip.Location = new Point(57, 471);
            numTotalTrip.Margin = new Padding(6);
            numTotalTrip.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numTotalTrip.Name = "numTotalTrip";
            numTotalTrip.Size = new Size(428, 39);
            numTotalTrip.TabIndex = 10;
            // 
            // btnAddShip
            // 
            btnAddShip.BackColor = Color.DodgerBlue;
            btnAddShip.FlatStyle = FlatStyle.Flat;
            btnAddShip.ForeColor = Color.White;
            btnAddShip.Location = new Point(57, 594);
            btnAddShip.Margin = new Padding(6);
            btnAddShip.Name = "btnAddShip";
            btnAddShip.Size = new Size(232, 64);
            btnAddShip.TabIndex = 11;
            btnAddShip.Text = "Add New";
            btnAddShip.UseVisualStyleBackColor = false;
            btnAddShip.Click += btnAddShip_Click;
            // 
            // btnUpdateShip
            // 
            btnUpdateShip.FlatStyle = FlatStyle.Flat;
            btnUpdateShip.Location = new Point(304, 594);
            btnUpdateShip.Margin = new Padding(6);
            btnUpdateShip.Name = "btnUpdateShip";
            btnUpdateShip.Size = new Size(232, 64);
            btnUpdateShip.TabIndex = 12;
            btnUpdateShip.Text = "Update Selected";
            btnUpdateShip.UseVisualStyleBackColor = true;
            btnUpdateShip.Click += btnUpdateShip_Click;
            // 
            // btnDeleteShip
            // 
            btnDeleteShip.BackColor = Color.Tomato;
            btnDeleteShip.FlatStyle = FlatStyle.Flat;
            btnDeleteShip.ForeColor = Color.White;
            btnDeleteShip.Location = new Point(57, 689);
            btnDeleteShip.Margin = new Padding(6);
            btnDeleteShip.Name = "btnDeleteShip";
            btnDeleteShip.Size = new Size(479, 64);
            btnDeleteShip.TabIndex = 13;
            btnDeleteShip.Text = "Delete Selected";
            btnDeleteShip.UseVisualStyleBackColor = false;
            btnDeleteShip.Click += btnDeleteShip_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.54438F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.45562F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewShips, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1874, 919);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnDeleteShip);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnUpdateShip);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddShip);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numTotalTrip);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbShipName);
            panel1.Controls.Add(numYear);
            panel1.Controls.Add(tbFuel);
            panel1.Controls.Add(numCapacity);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 913);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 334);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 32);
            label6.TabIndex = 8;
            label6.Text = "Fuel Type:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 433);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 10;
            label7.Text = "Total Trip:";
            // 
            // ShipManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1874, 919);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(6);
            Name = "ShipManagementForm";
            Text = "Ship Management (Admin)";
            Load += ShipManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShips).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalTrip).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbShipName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.TextBox tbFuel;
        private System.Windows.Forms.NumericUpDown numTotalTrip;
        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.Button btnUpdateShip;
        private System.Windows.Forms.Button btnDeleteShip;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label7;
        private Label label6;
    }
}