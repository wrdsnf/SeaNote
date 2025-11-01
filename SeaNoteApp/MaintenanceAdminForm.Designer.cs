namespace SeaNoteApp
{
    partial class MaintenanceAdminForm
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
            dataGridViewMaint = new DataGridView();
            btnUpdateMaint = new Button();
            btnAddMaint = new Button();
            cbStatus = new ComboBox();
            dtpDateScheduled = new DateTimePicker();
            tbDescription = new TextBox();
            cbShips = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDeleteMaint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaint
            // 
            dataGridViewMaint.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMaint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaint.Dock = DockStyle.Bottom;
            dataGridViewMaint.Location = new Point(0, 215);
            dataGridViewMaint.Margin = new Padding(2, 1, 2, 1);
            dataGridViewMaint.Name = "dataGridViewMaint";
            dataGridViewMaint.RowHeadersWidth = 82;
            dataGridViewMaint.Size = new Size(634, 125);
            dataGridViewMaint.TabIndex = 30;
            // 
            // btnUpdateMaint
            // 
            btnUpdateMaint.BackColor = Color.Gainsboro;
            btnUpdateMaint.FlatStyle = FlatStyle.Flat;
            btnUpdateMaint.ForeColor = Color.Black;
            btnUpdateMaint.Location = new Point(214, 168);
            btnUpdateMaint.Margin = new Padding(2, 1, 2, 1);
            btnUpdateMaint.Name = "btnUpdateMaint";
            btnUpdateMaint.Size = new Size(108, 32);
            btnUpdateMaint.TabIndex = 29;
            btnUpdateMaint.Text = "Update Record";
            btnUpdateMaint.UseVisualStyleBackColor = false;
            btnUpdateMaint.Click += btnUpdateMaint_Click;
            // 
            // btnAddMaint
            // 
            btnAddMaint.BackColor = Color.DodgerBlue;
            btnAddMaint.FlatStyle = FlatStyle.Flat;
            btnAddMaint.ForeColor = Color.White;
            btnAddMaint.Location = new Point(66, 168);
            btnAddMaint.Margin = new Padding(2, 1, 2, 1);
            btnAddMaint.Name = "btnAddMaint";
            btnAddMaint.Size = new Size(108, 32);
            btnAddMaint.TabIndex = 28;
            btnAddMaint.Text = "Add Record";
            btnAddMaint.UseVisualStyleBackColor = false;
            btnAddMaint.Click += btnAddMaint_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Pending", "Selesai", "Gagal" });
            cbStatus.Location = new Point(205, 126);
            cbStatus.Margin = new Padding(2, 1, 2, 1);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(242, 23);
            cbStatus.TabIndex = 27;
            // 
            // dtpDateScheduled
            // 
            dtpDateScheduled.Location = new Point(205, 97);
            dtpDateScheduled.Margin = new Padding(2, 1, 2, 1);
            dtpDateScheduled.Name = "dtpDateScheduled";
            dtpDateScheduled.Size = new Size(242, 23);
            dtpDateScheduled.TabIndex = 26;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(205, 40);
            tbDescription.Margin = new Padding(2, 1, 2, 1);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(242, 49);
            tbDescription.TabIndex = 25;
            // 
            // cbShips
            // 
            cbShips.FormattingEnabled = true;
            cbShips.Location = new Point(205, 12);
            cbShips.Margin = new Padding(2, 1, 2, 1);
            cbShips.Name = "cbShips";
            cbShips.Size = new Size(242, 23);
            cbShips.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 127);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 23;
            label4.Text = "Status :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 99);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 22;
            label3.Text = "Tgl Dijadwalkan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 21;
            label2.Text = "Deskripsi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 20;
            label1.Text = "Pilih Kapal :";
            // 
            // btnDeleteMaint
            // 
            btnDeleteMaint.BackColor = Color.Tomato;
            btnDeleteMaint.FlatStyle = FlatStyle.Flat;
            btnDeleteMaint.ForeColor = Color.White;
            btnDeleteMaint.Location = new Point(360, 168);
            btnDeleteMaint.Margin = new Padding(2, 1, 2, 1);
            btnDeleteMaint.Name = "btnDeleteMaint";
            btnDeleteMaint.Size = new Size(108, 32);
            btnDeleteMaint.TabIndex = 31;
            btnDeleteMaint.Text = "Delete Record";
            btnDeleteMaint.UseVisualStyleBackColor = false;
            btnDeleteMaint.Click += btnDeleteMaint_Click;
            // 
            // MaintenanceAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 340);
            Controls.Add(btnDeleteMaint);
            Controls.Add(dataGridViewMaint);
            Controls.Add(btnUpdateMaint);
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
            Name = "MaintenanceAdminForm";
            Text = "Maintenance (Admin)";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMaint;
        private Button btnUpdateMaint;
        private Button btnAddMaint;
        private ComboBox cbStatus;
        private DateTimePicker dtpDateScheduled;
        private TextBox tbDescription;
        private ComboBox cbShips;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDeleteMaint;
    }
}