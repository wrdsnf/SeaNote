namespace SeaNoteApp
{
    partial class MaintenanceEngineerForm
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
            dataGridViewMaint = new DataGridView();
            panelControls = new Panel();
            btnUpdateMaint = new Button();
            btnAddMaint = new Button();
            cbStatus = new ComboBox();
            label4 = new Label();
            dtpMaintenanceDate = new DateTimePicker();
            label3 = new Label();
            tbMaintDescription = new TextBox();
            label2 = new Label();
            tbMaintTitle = new TextBox();
            label1 = new Label();
            cbKapal = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).BeginInit();
            panelControls.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMaint
            // 
            dataGridViewMaint.AllowUserToAddRows = false;
            dataGridViewMaint.AllowUserToDeleteRows = false;
            dataGridViewMaint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaint.Dock = DockStyle.Right;
            dataGridViewMaint.Location = new Point(557, 0);
            dataGridViewMaint.Margin = new Padding(6);
            dataGridViewMaint.Name = "dataGridViewMaint";
            dataGridViewMaint.ReadOnly = true;
            dataGridViewMaint.RowHeadersWidth = 82;
            dataGridViewMaint.RowTemplate.Height = 25;
            dataGridViewMaint.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaint.Size = new Size(1270, 1197);
            dataGridViewMaint.TabIndex = 0;
            dataGridViewMaint.CellClick += DataGridViewMaint_CellClick;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(btnUpdateMaint);
            panelControls.Controls.Add(btnAddMaint);
            panelControls.Controls.Add(cbStatus);
            panelControls.Controls.Add(label4);
            panelControls.Controls.Add(dtpMaintenanceDate);
            panelControls.Controls.Add(label3);
            panelControls.Controls.Add(tbMaintDescription);
            panelControls.Controls.Add(label2);
            panelControls.Controls.Add(tbMaintTitle);
            panelControls.Controls.Add(label1);
            panelControls.Controls.Add(cbKapal);
            panelControls.Controls.Add(label6);
            panelControls.Dock = DockStyle.Left;
            panelControls.Location = new Point(0, 0);
            panelControls.Margin = new Padding(6);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(557, 1197);
            panelControls.TabIndex = 2;
            // 
            // btnUpdateMaint
            // 
            btnUpdateMaint.FlatStyle = FlatStyle.Flat;
            btnUpdateMaint.Location = new Point(288, 683);
            btnUpdateMaint.Margin = new Padding(6);
            btnUpdateMaint.Name = "btnUpdateMaint";
            btnUpdateMaint.Size = new Size(232, 64);
            btnUpdateMaint.TabIndex = 11;
            btnUpdateMaint.Text = "Update Status";
            btnUpdateMaint.UseVisualStyleBackColor = true;
            btnUpdateMaint.Click += BtnUpdateMaint_Click;
            // 
            // btnAddMaint
            // 
            btnAddMaint.BackColor = Color.DodgerBlue;
            btnAddMaint.FlatStyle = FlatStyle.Flat;
            btnAddMaint.ForeColor = Color.White;
            btnAddMaint.Location = new Point(37, 683);
            btnAddMaint.Margin = new Padding(6);
            btnAddMaint.Name = "btnAddMaint";
            btnAddMaint.Size = new Size(232, 64);
            btnAddMaint.TabIndex = 10;
            btnAddMaint.Text = "Add Record";
            btnAddMaint.UseVisualStyleBackColor = false;
            btnAddMaint.Click += BtnAddMaint_Click;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(37, 597);
            cbStatus.Margin = new Padding(6);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(479, 40);
            cbStatus.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 555);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 8;
            label4.Text = "Status:";
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Location = new Point(37, 491);
            dtpMaintenanceDate.Margin = new Padding(6);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(479, 39);
            dtpMaintenanceDate.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 448);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(215, 32);
            label3.TabIndex = 6;
            label3.Text = "Maintenance Date:";
            // 
            // tbMaintDescription
            // 
            tbMaintDescription.Location = new Point(37, 299);
            tbMaintDescription.Margin = new Padding(6);
            tbMaintDescription.Multiline = true;
            tbMaintDescription.Name = "tbMaintDescription";
            tbMaintDescription.Size = new Size(479, 123);
            tbMaintDescription.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 256);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 4;
            label2.Text = "Description:";
            // 
            // tbMaintTitle
            // 
            tbMaintTitle.Location = new Point(37, 192);
            tbMaintTitle.Margin = new Padding(6);
            tbMaintTitle.Name = "tbMaintTitle";
            tbMaintTitle.Size = new Size(479, 39);
            tbMaintTitle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 149);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 2;
            label1.Text = "Maintenance Title:";
            // 
            // cbKapal
            // 
            cbKapal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKapal.FormattingEnabled = true;
            cbKapal.Location = new Point(37, 85);
            cbKapal.Margin = new Padding(6);
            cbKapal.Name = "cbKapal";
            cbKapal.Size = new Size(479, 40);
            cbKapal.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 43);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 32);
            label6.TabIndex = 0;
            label6.Text = "Pilih Kapal:";
            // 
            // MaintenanceEngineerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 1197);
            Controls.Add(panelControls);
            Controls.Add(dataGridViewMaint);
            Margin = new Padding(6);
            Name = "MaintenanceEngineerForm";
            Text = "Maintenance (Engineer)";
            Load += MaintenanceEngineerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaint).EndInit();
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMaint;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.ComboBox cbKapal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaintTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaintDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpMaintenanceDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateMaint;
        private System.Windows.Forms.Button btnAddMaint;
    }
}