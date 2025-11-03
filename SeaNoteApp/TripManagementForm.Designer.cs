namespace SeaNoteApp
{
    partial class TripManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            btnManageTasks = new Button();
            btnManageLogs = new Button();
            btnUpdateTrip = new Button();
            btnAddTrip = new Button();
            btnDeleteTrip = new Button();
            panelControls = new Panel();
            label6 = new Label();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbTitikBerangkat = new TextBox();
            dtpTanggalSampai = new DateTimePicker();
            tbNakhoda = new TextBox();
            label10 = new Label();
            cbKapal = new ComboBox();
            dtpTanggalBerangkat = new DateTimePicker();
            tbNotes = new RichTextBox();
            dataGridViewTrips = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.9397926F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.06021F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panelControls, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewTrips, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 798F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            // KODE YANG ERROR UDAH DIHAPUS DARI SINI
            tableLayoutPanel1.Size = new Size(1874, 1197);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnManageTasks);
            panel1.Controls.Add(btnManageLogs);
            panel1.Controls.Add(btnUpdateTrip);
            panel1.Controls.Add(btnAddTrip);
            panel1.Controls.Add(btnDeleteTrip);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(6, 804);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 387);
            panel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 250);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 18;
            label1.Text = "Related Actions:";
            // 
            // btnManageTasks
            // 
            btnManageTasks.Location = new Point(14, 300);
            btnManageTasks.Name = "btnManageTasks";
            btnManageTasks.Size = new Size(228, 46);
            btnManageTasks.TabIndex = 17;
            btnManageTasks.Text = "Manage Tasks";
            btnManageTasks.UseVisualStyleBackColor = true;
            btnManageTasks.Click += BtnManageTasks_Click;
            // 
            // btnManageLogs
            // 
            btnManageLogs.Location = new Point(261, 300);
            btnManageLogs.Name = "btnManageLogs";
            btnManageLogs.Size = new Size(232, 46);
            btnManageLogs.TabIndex = 16;
            btnManageLogs.Text = "Manage Logs";
            btnManageLogs.UseVisualStyleBackColor = true;
            btnManageLogs.Click += BtnManageLogs_Click;
            // 
            // btnUpdateTrip
            // 
            btnUpdateTrip.FlatStyle = FlatStyle.Flat;
            btnUpdateTrip.Location = new Point(261, 21);
            btnUpdateTrip.Margin = new Padding(0);
            btnUpdateTrip.Name = "btnUpdateTrip";
            btnUpdateTrip.Size = new Size(232, 64);
            btnUpdateTrip.TabIndex = 14;
            btnUpdateTrip.Text = "Update";
            btnUpdateTrip.UseVisualStyleBackColor = true;
            btnUpdateTrip.Click += BtnUpdateTrip_Click;
            // 
            // btnAddTrip
            // 
            btnAddTrip.BackColor = Color.DodgerBlue;
            btnAddTrip.FlatStyle = FlatStyle.Flat;
            btnAddTrip.ForeColor = Color.White;
            btnAddTrip.Location = new Point(10, 21);
            btnAddTrip.Margin = new Padding(0);
            btnAddTrip.Name = "btnAddTrip";
            btnAddTrip.Size = new Size(232, 64);
            btnAddTrip.TabIndex = 13;
            btnAddTrip.Text = "Add";
            btnAddTrip.UseVisualStyleBackColor = false;
            btnAddTrip.Click += BtnAddTrip_Click;
            // 
            // btnDeleteTrip
            // 
            btnDeleteTrip.BackColor = Color.Tomato;
            btnDeleteTrip.FlatStyle = FlatStyle.Flat;
            btnDeleteTrip.ForeColor = Color.White;
            btnDeleteTrip.Location = new Point(14, 106);
            btnDeleteTrip.Margin = new Padding(0);
            btnDeleteTrip.Name = "btnDeleteTrip";
            btnDeleteTrip.Size = new Size(479, 64);
            btnDeleteTrip.TabIndex = 15;
            btnDeleteTrip.Text = "Delete";
            btnDeleteTrip.UseVisualStyleBackColor = false;
            btnDeleteTrip.Click += BtnDeleteTrip_Click;
            // 
            // panelControls
            // 
            panelControls.AutoScroll = true;
            panelControls.Controls.Add(label6);
            panelControls.Controls.Add(label12);
            panelControls.Controls.Add(label11);
            panelControls.Controls.Add(label8);
            panelControls.Controls.Add(label9);
            panelControls.Controls.Add(tbTitikBerangkat);
            panelControls.Controls.Add(dtpTanggalSampai);
            panelControls.Controls.Add(tbNakhoda);
            panelControls.Controls.Add(label10);
            panelControls.Controls.Add(cbKapal);
            panelControls.Controls.Add(dtpTanggalBerangkat);
            panelControls.Controls.Add(tbNotes);
            panelControls.Dock = DockStyle.Fill;
            panelControls.Location = new Point(6, 6);
            panelControls.Margin = new Padding(6);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(549, 786);
            panelControls.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 467);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 20;
            label6.Text = "Nakhoda:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 361);
            label12.Margin = new Padding(0);
            label12.Name = "label12";
            label12.Size = new Size(178, 32);
            label12.TabIndex = 17;
            label12.Text = "Titik Berangkat:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 255);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(186, 32);
            label11.TabIndex = 14;
            label11.Text = "Tanggal Sampai:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 574);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(82, 32);
            label8.TabIndex = 4;
            label8.Text = "Notes:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 149);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(215, 32);
            label9.TabIndex = 2;
            label9.Text = "Tanggal Berangkat:";
            // 
            // tbTitikBerangkat
            // 
            tbTitikBerangkat.Location = new Point(37, 404);
            tbTitikBerangkat.Margin = new Padding(0);
            tbTitikBerangkat.Name = "tbTitikBerangkat";
            tbTitikBerangkat.Size = new Size(428, 39);
            tbTitikBerangkat.TabIndex = 4;
            // 
            // dtpTanggalSampai
            // 
            dtpTanggalSampai.Location = new Point(37, 298);
            dtpTanggalSampai.Margin = new Padding(0);
            dtpTanggalSampai.Name = "dtpTanggalSampai";
            dtpTanggalSampai.Size = new Size(428, 39);
            dtpTanggalSampai.TabIndex = 3;
            // 
            // tbNakhoda
            // 
            tbNakhoda.Location = new Point(37, 510);
            tbNakhoda.Margin = new Padding(0);
            tbNakhoda.Name = "tbNakhoda";
            tbNakhoda.Size = new Size(428, 39);
            tbNakhoda.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 43);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(129, 32);
            label10.TabIndex = 0;
            label10.Text = "Pilih Kapal:";
            // 
            // cbKapal
            // 
            cbKapal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKapal.Location = new Point(37, 85);
            cbKapal.Margin = new Padding(0);
            cbKapal.Name = "cbKapal";
            cbKapal.Size = new Size(428, 40);
            cbKapal.TabIndex = 0;
            // 
            // dtpTanggalBerangkat
            // 
            dtpTanggalBerangkat.Location = new Point(37, 192);
            dtpTanggalBerangkat.Margin = new Padding(0);
            dtpTanggalBerangkat.Name = "dtpTanggalBerangkat";
            dtpTanggalBerangkat.Size = new Size(428, 39);
            dtpTanggalBerangkat.TabIndex = 2;
            // 
            // tbNotes
            // 
            tbNotes.Location = new Point(37, 617);
            tbNotes.Margin = new Padding(0);
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(428, 123);
            tbNotes.TabIndex = 23;
            tbNotes.Text = "";
            // 
            // dataGridViewTrips
            // 
            dataGridViewTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrips.Dock = DockStyle.Fill;
            dataGridViewTrips.Location = new Point(564, 3);
            dataGridViewTrips.Name = "dataGridViewTrips";
            dataGridViewTrips.RowHeadersWidth = 82;
            dataGridViewTrips.Size = new Size(1307, 792);
            dataGridViewTrips.TabIndex = 0;
            dataGridViewTrips.CellClick += DataGridViewTrips_CellClick;
            // 
            // TripManagementForm
            // 
            ClientSize = new Size(1874, 1197);
            Controls.Add(tableLayoutPanel1);
            Name = "TripManagementForm";
            Text = "Trip Management";
            Load += TripManagementForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).EndInit();
            ResumeLayout(false);
        }
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewTrips;
        private Panel panelControls;
        private Label label6;
        private Label label12;
        private Label label11;
        private Label label8;
        private Button btnDeleteTrip;
        private Button btnUpdateTrip;
        private Button btnAddTrip;
        private Label label9;
        private TextBox tbTitikBerangkat;
        private DateTimePicker dtpTanggalSampai;
        private TextBox tbNakhoda;
        private Label label10;
        private ComboBox cbKapal;
        private DateTimePicker dtpTanggalBerangkat;
        private RichTextBox tbNotes;
        private Panel panel1;
        private Label label1;
        private Button btnManageTasks;
        private Button btnManageLogs;
    }
}