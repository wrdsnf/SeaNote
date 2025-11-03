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
            panelControls = new Panel();
            label6 = new Label();
            label12 = new Label();
            label11 = new Label();
            tbMaintDescription = new TextBox();
            label8 = new Label();
            btnDeleteTrip = new Button();
            btnManageLogs = new Button();
            btnManageTasks = new Button();
            btnUpdateTrip = new Button();
            btnAddTrip = new Button();
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
            panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.3081551F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.69184F));
            tableLayoutPanel1.Controls.Add(panelControls, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewTrips, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1827, 1197);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(label6);
            panelControls.Controls.Add(label12);
            panelControls.Controls.Add(label11);
            panelControls.Controls.Add(tbMaintDescription);
            panelControls.Controls.Add(label8);
            panelControls.Controls.Add(btnDeleteTrip);
            panelControls.Controls.Add(btnManageLogs);
            panelControls.Controls.Add(btnManageTasks);
            panelControls.Controls.Add(btnUpdateTrip);
            panelControls.Controls.Add(btnAddTrip);
            panelControls.Controls.Add(label9);
            panelControls.Controls.Add(tbTitikBerangkat);
            panelControls.Controls.Add(dtpTanggalSampai);
            panelControls.Controls.Add(tbNakhoda);
            panelControls.Controls.Add(label10);
            panelControls.Controls.Add(cbKapal);
            panelControls.Controls.Add(dtpTanggalBerangkat);
            panelControls.Controls.Add(tbNotes);
            panelControls.Location = new Point(6, 6);
            panelControls.Margin = new Padding(6);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(556, 1185);
            panelControls.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 467);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 32);
            label6.TabIndex = 20;
            label6.Text = "Nakhoda:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 361);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(178, 32);
            label12.TabIndex = 17;
            label12.Text = "Titik Berangkat:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 255);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(186, 32);
            label11.TabIndex = 14;
            label11.Text = "Tanggal Sampai:";
            // 
            // tbMaintDescription
            // 
            tbMaintDescription.Location = new Point(37, 617);
            tbMaintDescription.Margin = new Padding(6);
            tbMaintDescription.Multiline = true;
            tbMaintDescription.Name = "tbMaintDescription";
            tbMaintDescription.Size = new Size(0, 0);
            tbMaintDescription.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 574);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(82, 32);
            label8.TabIndex = 4;
            label8.Text = "Notes:";
            // 
            // btnDeleteTrip
            // 
            btnDeleteTrip.BackColor = Color.Tomato;
            btnDeleteTrip.FlatStyle = FlatStyle.Flat;
            btnDeleteTrip.ForeColor = Color.White;
            btnDeleteTrip.Location = new Point(37, 1000);
            btnDeleteTrip.Name = "btnDeleteTrip";
            btnDeleteTrip.Size = new Size(479, 64);
            btnDeleteTrip.TabIndex = 15;
            btnDeleteTrip.Text = "Delete";
            btnDeleteTrip.UseVisualStyleBackColor = false;
            // 
            // btnManageLogs
            // 
            btnManageLogs.Location = new Point(284, 806);
            btnManageLogs.Name = "btnManageLogs";
            btnManageLogs.Size = new Size(145, 42);
            btnManageLogs.TabIndex = 11;
            btnManageLogs.Text = "Logs";
            btnManageLogs.UseVisualStyleBackColor = true;
            // 
            // btnManageTasks
            // 
            btnManageTasks.Location = new Point(117, 806);
            btnManageTasks.Name = "btnManageTasks";
            btnManageTasks.Size = new Size(145, 42);
            btnManageTasks.TabIndex = 10;
            btnManageTasks.Text = "Tasks";
            btnManageTasks.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTrip
            // 
            btnUpdateTrip.FlatStyle = FlatStyle.Flat;
            btnUpdateTrip.Location = new Point(284, 915);
            btnUpdateTrip.Name = "btnUpdateTrip";
            btnUpdateTrip.Size = new Size(232, 64);
            btnUpdateTrip.TabIndex = 14;
            btnUpdateTrip.Text = "Update";
            btnUpdateTrip.UseVisualStyleBackColor = true;
            // 
            // btnAddTrip
            // 
            btnAddTrip.BackColor = Color.DodgerBlue;
            btnAddTrip.FlatStyle = FlatStyle.Flat;
            btnAddTrip.ForeColor = Color.White;
            btnAddTrip.Location = new Point(33, 915);
            btnAddTrip.Name = "btnAddTrip";
            btnAddTrip.Size = new Size(232, 64);
            btnAddTrip.TabIndex = 13;
            btnAddTrip.Text = "Add";
            btnAddTrip.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 149);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(215, 32);
            label9.TabIndex = 2;
            label9.Text = "Tanggal Berangkat:";
            // 
            // tbTitikBerangkat
            // 
            tbTitikBerangkat.Location = new Point(37, 404);
            tbTitikBerangkat.Name = "tbTitikBerangkat";
            tbTitikBerangkat.Size = new Size(479, 39);
            tbTitikBerangkat.TabIndex = 4;
            // 
            // dtpTanggalSampai
            // 
            dtpTanggalSampai.Location = new Point(37, 298);
            dtpTanggalSampai.Name = "dtpTanggalSampai";
            dtpTanggalSampai.Size = new Size(479, 39);
            dtpTanggalSampai.TabIndex = 3;
            // 
            // tbNakhoda
            // 
            tbNakhoda.Location = new Point(37, 510);
            tbNakhoda.Name = "tbNakhoda";
            tbNakhoda.Size = new Size(479, 39);
            tbNakhoda.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 43);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(129, 32);
            label10.TabIndex = 0;
            label10.Text = "Pilih Kapal:";
            // 
            // cbKapal
            // 
            cbKapal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKapal.Location = new Point(37, 85);
            cbKapal.Name = "cbKapal";
            cbKapal.Size = new Size(479, 40);
            cbKapal.TabIndex = 0;
            // 
            // dtpTanggalBerangkat
            // 
            dtpTanggalBerangkat.Location = new Point(37, 192);
            dtpTanggalBerangkat.Name = "dtpTanggalBerangkat";
            dtpTanggalBerangkat.Size = new Size(479, 39);
            dtpTanggalBerangkat.TabIndex = 2;
            // 
            // tbNotes
            // 
            tbNotes.Location = new Point(37, 617);
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(479, 123);
            tbNotes.TabIndex = 23;
            tbNotes.Text = "";
            // 
            // dataGridViewTrips
            // 
            dataGridViewTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrips.Dock = DockStyle.Fill;
            dataGridViewTrips.Location = new Point(575, 3);
            dataGridViewTrips.Name = "dataGridViewTrips";
            dataGridViewTrips.RowHeadersWidth = 82;
            dataGridViewTrips.Size = new Size(1249, 1191);
            dataGridViewTrips.TabIndex = 0;
            // 
            // TripManagementForm
            // 
            ClientSize = new Size(1827, 1197);
            Controls.Add(tableLayoutPanel1);
            Name = "TripManagementForm";
            Text = "Trip Management";
            WindowState = FormWindowState.Minimized;
            Load += TripManagementForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
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
        private TextBox tbMaintDescription;
        private Label label8;
        private Button btnDeleteTrip;
        private Button btnManageLogs;
        private Button btnManageTasks;
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
    }
}
