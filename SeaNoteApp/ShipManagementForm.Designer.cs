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
            label4 = new Label();
            tbFuel = new TextBox();
            label5 = new Label();
            numTotalTrip = new NumericUpDown();
            btnAddShip = new Button();
            btnUpdateShip = new Button();
            btnDeleteShip = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShips).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalTrip).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewShips
            // 
            dataGridViewShips.AllowUserToAddRows = false;
            dataGridViewShips.AllowUserToDeleteRows = false;
            dataGridViewShips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShips.Location = new Point(22, 26);
            dataGridViewShips.Margin = new Padding(6, 6, 6, 6);
            dataGridViewShips.Name = "dataGridViewShips";
            dataGridViewShips.ReadOnly = true;
            dataGridViewShips.RowHeadersWidth = 82;
            dataGridViewShips.RowTemplate.Height = 25;
            dataGridViewShips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShips.Size = new Size(1411, 533);
            dataGridViewShips.TabIndex = 0;
            dataGridViewShips.CellClick += dataGridViewShips_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 597);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 1;
            label1.Text = "Nama Kapal:";
            // 
            // tbShipName
            // 
            tbShipName.Location = new Point(186, 591);
            tbShipName.Margin = new Padding(6, 6, 6, 6);
            tbShipName.Name = "tbShipName";
            tbShipName.Size = new Size(331, 39);
            tbShipName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 661);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 3;
            label2.Text = "Tahun:";
            // 
            // numYear
            // 
            numYear.Location = new Point(186, 657);
            numYear.Margin = new Padding(6, 6, 6, 6);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(334, 39);
            numYear.TabIndex = 4;
            numYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 725);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 5;
            label3.Text = "Kapasitas:";
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(186, 721);
            numCapacity.Margin = new Padding(6, 6, 6, 6);
            numCapacity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(334, 39);
            numCapacity.TabIndex = 6;
            numCapacity.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(557, 597);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 32);
            label4.TabIndex = 7;
            label4.Text = "Fuel:";
            // 
            // tbFuel
            // 
            tbFuel.Location = new Point(687, 591);
            tbFuel.Margin = new Padding(6, 6, 6, 6);
            tbFuel.Name = "tbFuel";
            tbFuel.Size = new Size(331, 39);
            tbFuel.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(557, 661);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 9;
            label5.Text = "Total Trip:";
            // 
            // numTotalTrip
            // 
            numTotalTrip.Location = new Point(687, 657);
            numTotalTrip.Margin = new Padding(6, 6, 6, 6);
            numTotalTrip.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numTotalTrip.Name = "numTotalTrip";
            numTotalTrip.Size = new Size(334, 39);
            numTotalTrip.TabIndex = 10;
            // 
            // btnAddShip
            // 
            btnAddShip.BackColor = Color.DodgerBlue;
            btnAddShip.FlatStyle = FlatStyle.Flat;
            btnAddShip.ForeColor = Color.White;
            btnAddShip.Location = new Point(22, 811);
            btnAddShip.Margin = new Padding(6, 6, 6, 6);
            btnAddShip.Name = "btnAddShip";
            btnAddShip.Size = new Size(223, 85);
            btnAddShip.TabIndex = 11;
            btnAddShip.Text = "Add New";
            btnAddShip.UseVisualStyleBackColor = false;
            btnAddShip.Click += btnAddShip_Click;
            // 
            // btnUpdateShip
            // 
            btnUpdateShip.FlatStyle = FlatStyle.Flat;
            btnUpdateShip.Location = new Point(260, 811);
            btnUpdateShip.Margin = new Padding(6, 6, 6, 6);
            btnUpdateShip.Name = "btnUpdateShip";
            btnUpdateShip.Size = new Size(223, 85);
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
            btnDeleteShip.Location = new Point(501, 811);
            btnDeleteShip.Margin = new Padding(6, 6, 6, 6);
            btnDeleteShip.Name = "btnDeleteShip";
            btnDeleteShip.Size = new Size(223, 85);
            btnDeleteShip.TabIndex = 13;
            btnDeleteShip.Text = "Delete Selected";
            btnDeleteShip.UseVisualStyleBackColor = false;
            btnDeleteShip.Click += btnDeleteShip_Click;
            // 
            // ShipManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 919);
            Controls.Add(btnDeleteShip);
            Controls.Add(btnUpdateShip);
            Controls.Add(btnAddShip);
            Controls.Add(numTotalTrip);
            Controls.Add(label5);
            Controls.Add(tbFuel);
            Controls.Add(label4);
            Controls.Add(numCapacity);
            Controls.Add(label3);
            Controls.Add(numYear);
            Controls.Add(label2);
            Controls.Add(tbShipName);
            Controls.Add(label1);
            Controls.Add(dataGridViewShips);
            Margin = new Padding(6, 6, 6, 6);
            Name = "ShipManagementForm";
            Text = "Ship Management (Admin)";
            Load += ShipManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShips).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalTrip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbShipName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFuel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTotalTrip;
        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.Button btnUpdateShip;
        private System.Windows.Forms.Button btnDeleteShip;
    }
}