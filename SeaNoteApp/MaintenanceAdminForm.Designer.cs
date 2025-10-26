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
            dataGridViewMaint.Location = new Point(0, 425);
            dataGridViewMaint.Name = "dataGridViewMaint";
            dataGridViewMaint.RowHeadersWidth = 82;
            dataGridViewMaint.Size = new Size(1177, 300);
            dataGridViewMaint.TabIndex = 30;
            // 
            // btnUpdateMaint
            // 
            btnUpdateMaint.BackColor = Color.Gainsboro;
            btnUpdateMaint.FlatStyle = FlatStyle.Flat;
            btnUpdateMaint.ForeColor = Color.Black;
            btnUpdateMaint.Location = new Point(398, 358);
            btnUpdateMaint.Name = "btnUpdateMaint";
            btnUpdateMaint.Size = new Size(200, 45);
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
            btnAddMaint.Location = new Point(123, 358);
            btnAddMaint.Name = "btnAddMaint";
            btnAddMaint.Size = new Size(200, 45);
            btnAddMaint.TabIndex = 28;
            btnAddMaint.Text = "Add Record";
            btnAddMaint.UseVisualStyleBackColor = false;
            btnAddMaint.Click += btnAddMaint_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Pending", "Selesai", "Gagal" });
            cbStatus.Location = new Point(380, 268);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(446, 40);
            cbStatus.TabIndex = 27;
            // 
            // dtpDateScheduled
            // 
            dtpDateScheduled.Location = new Point(380, 207);
            dtpDateScheduled.Name = "dtpDateScheduled";
            dtpDateScheduled.Size = new Size(446, 39);
            dtpDateScheduled.TabIndex = 26;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(380, 85);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(446, 100);
            tbDescription.TabIndex = 25;
            // 
            // cbShips
            // 
            cbShips.FormattingEnabled = true;
            cbShips.Location = new Point(380, 26);
            cbShips.Name = "cbShips";
            cbShips.Size = new Size(446, 40);
            cbShips.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 271);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 23;
            label4.Text = "Status :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 212);
            label3.Name = "label3";
            label3.Size = new Size(192, 32);
            label3.TabIndex = 22;
            label3.Text = "Tgl Dijadwalkan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 88);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 21;
            label2.Text = "Deskripsi :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 29);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 20;
            label1.Text = "Pilih Kapal :";
            // 
            // btnDeleteMaint
            // 
            btnDeleteMaint.BackColor = Color.Tomato;
            btnDeleteMaint.FlatStyle = FlatStyle.Flat;
            btnDeleteMaint.ForeColor = Color.White;
            btnDeleteMaint.Location = new Point(668, 358);
            btnDeleteMaint.Name = "btnDeleteMaint";
            btnDeleteMaint.Size = new Size(200, 45);
            btnDeleteMaint.TabIndex = 31;
            btnDeleteMaint.Text = "Delete Record";
            btnDeleteMaint.UseVisualStyleBackColor = false;
            btnDeleteMaint.Click += btnDeleteMaint_Click;
            // 
            // MaintenanceAdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 725);
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