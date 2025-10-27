namespace SeaNoteApp
{
    partial class AddMaintenanceEngineerForm
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
            cbShips = new ComboBox();
            tbDescription = new TextBox();
            dtpDateScheduled = new DateTimePicker();
            cbStatus = new ComboBox();
            dataGridViewMaint = new DataGridView();
            btnAddMaint = new Button();
            btnUpdateMaint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Pilih Kapal :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Deskripsi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 145);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Tgl Dijadwalkan :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 181);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Status :";
            // 
            // cbShips
            // 
            cbShips.FormattingEnabled = true;
            cbShips.Location = new Point(187, 29);
            cbShips.Margin = new Padding(2, 1, 2, 1);
            cbShips.Name = "cbShips";
            cbShips.Size = new Size(276, 28);
            cbShips.TabIndex = 4;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(187, 65);
            tbDescription.Margin = new Padding(2, 1, 2, 1);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(276, 64);
            tbDescription.TabIndex = 5;
            // 
            // dtpDateScheduled
            // 
            dtpDateScheduled.Location = new Point(187, 141);
            dtpDateScheduled.Margin = new Padding(2, 1, 2, 1);
            dtpDateScheduled.Name = "dtpDateScheduled";
            dtpDateScheduled.Size = new Size(276, 27);
            dtpDateScheduled.TabIndex = 6;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Pending", "Selesai", "Gagal" });
            cbStatus.Location = new Point(187, 180);
            cbStatus.Margin = new Padding(2, 1, 2, 1);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(276, 28);
            cbStatus.TabIndex = 7;
            // 
            // dataGridViewMaint
            // 
            dataGridViewMaint.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMaint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaint.Dock = DockStyle.Bottom;
            dataGridViewMaint.Location = new Point(0, 310);
            dataGridViewMaint.Margin = new Padding(2, 1, 2, 1);
            dataGridViewMaint.Name = "dataGridViewMaint";
            dataGridViewMaint.RowHeadersWidth = 82;
            dataGridViewMaint.Size = new Size(538, 105);
            dataGridViewMaint.TabIndex = 19;
            // 
            // btnAddMaint
            // 
            btnAddMaint.BackColor = Color.DodgerBlue;
            btnAddMaint.FlatStyle = FlatStyle.Flat;
            btnAddMaint.ForeColor = Color.White;
            btnAddMaint.Location = new Point(55, 247);
            btnAddMaint.Margin = new Padding(2, 1, 2, 1);
            btnAddMaint.Name = "btnAddMaint";
            btnAddMaint.Size = new Size(154, 29);
            btnAddMaint.TabIndex = 17;
            btnAddMaint.Text = "Add Maintenance";
            btnAddMaint.UseVisualStyleBackColor = false;
            btnAddMaint.Click += btnAddMaint_Click;
            // 
            // btnUpdateMaint
            // 
            btnUpdateMaint.BackColor = Color.Gainsboro;
            btnUpdateMaint.FlatStyle = FlatStyle.Flat;
            btnUpdateMaint.ForeColor = Color.Black;
            btnUpdateMaint.Location = new Point(294, 247);
            btnUpdateMaint.Margin = new Padding(2, 1, 2, 1);
            btnUpdateMaint.Name = "btnUpdateMaint";
            btnUpdateMaint.Size = new Size(169, 29);
            btnUpdateMaint.TabIndex = 20;
            btnUpdateMaint.Text = "Update Maintenance";
            btnUpdateMaint.UseVisualStyleBackColor = false;
            btnUpdateMaint.Click += btnUpdateMaint_Click;
            // 
            // AddMaintenanceEngineerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 415);
            Controls.Add(btnUpdateMaint);
            Controls.Add(dataGridViewMaint);
            Controls.Add(btnAddMaint);
            Controls.Add(cbStatus);
            Controls.Add(dtpDateScheduled);
            Controls.Add(tbDescription);
            Controls.Add(cbShips);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddMaintenanceEngineerForm";
            Text = "Add/Edit Maintenance";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbShips;
        private TextBox tbDescription;
        private DateTimePicker dtpDateScheduled;
        private ComboBox cbStatus;
        private DataGridView dataGridViewMaint;
        private Button btnAddMaint;
        private Button btnUpdateMaint;
    }
}