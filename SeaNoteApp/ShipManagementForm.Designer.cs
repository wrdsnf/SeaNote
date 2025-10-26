namespace SeaNoteApp
{
    partial class ShipManagementForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbShipName = new TextBox();
            tbShipYear = new TextBox();
            tbShipCapacity = new TextBox();
            tbShipFuel = new TextBox();
            tbShipTotalTrip = new TextBox();
            dtpMaintenance = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dataGridViewShips = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShips).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 59);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "Ship Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 114);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 1;
            label2.Text = "Year :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 168);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(150, 32);
            label3.TabIndex = 2;
            label3.Text = "Capacity (T) :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 224);
            label4.Name = "label4";
            label4.Size = new Size(103, 32);
            label4.TabIndex = 3;
            label4.Text = "Fuel (L) :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 277);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 4;
            label5.Text = "Total Trip :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 331);
            label6.Name = "label6";
            label6.Size = new Size(213, 32);
            label6.TabIndex = 5;
            label6.Text = "Last Maintenance :";
            // 
            // tbShipName
            // 
            tbShipName.Location = new Point(305, 56);
            tbShipName.Name = "tbShipName";
            tbShipName.Size = new Size(481, 39);
            tbShipName.TabIndex = 6;
            // 
            // tbShipYear
            // 
            tbShipYear.Location = new Point(305, 111);
            tbShipYear.Name = "tbShipYear";
            tbShipYear.Size = new Size(481, 39);
            tbShipYear.TabIndex = 7;
            // 
            // tbShipCapacity
            // 
            tbShipCapacity.Location = new Point(305, 165);
            tbShipCapacity.Name = "tbShipCapacity";
            tbShipCapacity.Size = new Size(481, 39);
            tbShipCapacity.TabIndex = 8;
            // 
            // tbShipFuel
            // 
            tbShipFuel.Location = new Point(305, 221);
            tbShipFuel.Name = "tbShipFuel";
            tbShipFuel.Size = new Size(481, 39);
            tbShipFuel.TabIndex = 9;
            // 
            // tbShipTotalTrip
            // 
            tbShipTotalTrip.Location = new Point(305, 274);
            tbShipTotalTrip.Name = "tbShipTotalTrip";
            tbShipTotalTrip.Size = new Size(481, 39);
            tbShipTotalTrip.TabIndex = 10;
            // 
            // dtpMaintenance
            // 
            dtpMaintenance.Location = new Point(305, 331);
            dtpMaintenance.Name = "dtpMaintenance";
            dtpMaintenance.Size = new Size(481, 39);
            dtpMaintenance.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(70, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gainsboro;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(258, 413);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(452, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(636, 413);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridViewShips
            // 
            dataGridViewShips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewShips.Dock = DockStyle.Bottom;
            dataGridViewShips.Location = new Point(0, 488);
            dataGridViewShips.Name = "dataGridViewShips";
            dataGridViewShips.ReadOnly = true;
            dataGridViewShips.RowHeadersWidth = 82;
            dataGridViewShips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShips.Size = new Size(901, 350);
            dataGridViewShips.TabIndex = 16;
            // 
            // ShipManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 838);
            Controls.Add(dataGridViewShips);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpMaintenance);
            Controls.Add(tbShipTotalTrip);
            Controls.Add(tbShipFuel);
            Controls.Add(tbShipCapacity);
            Controls.Add(tbShipYear);
            Controls.Add(tbShipName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ShipManagementForm";
            Text = "Ship Management";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShips).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbShipName;
        private TextBox tbShipYear;
        private TextBox tbShipCapacity;
        private TextBox tbShipFuel;
        private TextBox tbShipTotalTrip;
        private DateTimePicker dtpMaintenance;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dataGridViewShips;
    }
}