namespace SeaNoteApp
{
    partial class MaintenanceEngineerForm
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
            btnUpdateMaint = new Button();
            btnAddMaint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 49);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 0;
            label1.Text = "Pilih Kapal :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 108);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 1;
            label2.Text = "Deskripsi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 232);
            label3.Name = "label3";
            label3.Size = new Size(192, 32);
            label3.TabIndex = 2;
            label3.Text = "Tgl Dijadwalkan :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 291);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 3;
            label4.Text = "Status :";
            // 
            // cbShips
            // 
            cbShips.FormattingEnabled = true;
            cbShips.Location = new Point(305, 46);
            cbShips.Name = "cbShips";
            cbShips.Size = new Size(446, 40);
            cbShips.TabIndex = 4;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(305, 105);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(446, 100);
            tbDescription.TabIndex = 5;
            // 
            // dtpDateScheduled
            // 
            dtpDateScheduled.Location = new Point(305, 227);
            dtpDateScheduled.Name = "dtpDateScheduled";
            dtpDateScheduled.Size = new Size(446, 39);
            dtpDateScheduled.TabIndex = 6;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Pending", "Selesai", "Gagal" });
            cbStatus.Location = new Point(305, 288);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(446, 40);
            cbStatus.TabIndex = 7;
            // 
            // dataGridViewMaint
            // 
            dataGridViewMaint.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMaint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaint.Location = new Point(28, 455);
            dataGridViewMaint.Name = "dataGridViewMaint";
            dataGridViewMaint.RowHeadersWidth = 82;
            dataGridViewMaint.Size = new Size(820, 300);
            dataGridViewMaint.TabIndex = 19;
            // 
            // btnUpdateMaint
            // 
            btnUpdateMaint.BackColor = Color.Gainsboro;
            btnUpdateMaint.FlatStyle = FlatStyle.Flat;
            btnUpdateMaint.ForeColor = Color.Black;
            btnUpdateMaint.Location = new Point(447, 379);
            btnUpdateMaint.Name = "btnUpdateMaint";
            btnUpdateMaint.Size = new Size(250, 46);
            btnUpdateMaint.TabIndex = 18;
            btnUpdateMaint.Text = "Update Maintenance";
            btnUpdateMaint.UseVisualStyleBackColor = false;
            btnUpdateMaint.Click += btnUpdateMaint_Click;
            // 
            // btnAddMaint
            // 
            btnAddMaint.BackColor = Color.DodgerBlue;
            btnAddMaint.FlatStyle = FlatStyle.Flat;
            btnAddMaint.ForeColor = Color.White;
            btnAddMaint.Location = new Point(108, 379);
            btnAddMaint.Name = "btnAddMaint";
            btnAddMaint.Size = new Size(250, 46);
            btnAddMaint.TabIndex = 17;
            btnAddMaint.Text = "Add Maintenance";
            btnAddMaint.UseVisualStyleBackColor = false;
            btnAddMaint.Click += btnAddMaint_Click;
            // 
            // MaintenanceEngineerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 945);
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
            Name = "MaintenanceEngineerForm";
            Text = "Add/Edit Maintenance";
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
        private Button btnUpdateMaint;
        private Button btnAddMaint;
    }
}