namespace SeaNoteApp
{
    partial class TripManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbKapal;
        private System.Windows.Forms.DataGridView dataGridViewTrips;
        private System.Windows.Forms.DateTimePicker dtpTanggalBerangkat;
        private System.Windows.Forms.DateTimePicker dtpTanggalSampai;
        private System.Windows.Forms.TextBox tbTitikBerangkat;
        private System.Windows.Forms.TextBox tbNakhoda;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btnManageTasks;
        private System.Windows.Forms.Button btnManageLogs;
        private System.Windows.Forms.Label labelKapal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cbKapal = new ComboBox();
            dataGridViewTrips = new DataGridView();
            dtpTanggalBerangkat = new DateTimePicker();
            dtpTanggalSampai = new DateTimePicker();
            tbTitikBerangkat = new TextBox();
            tbNakhoda = new TextBox();
            tbNotes = new TextBox();
            btnManageTasks = new Button();
            btnManageLogs = new Button();
            labelKapal = new Label();
            btnDeleteTrip = new Button();
            btnUpdateTrip = new Button();
            btnAddTrip = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).BeginInit();
            SuspendLayout();
            // 
            // cbKapal
            // 
            cbKapal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKapal.Location = new Point(12, 41);
            cbKapal.Name = "cbKapal";
            cbKapal.Size = new Size(200, 40);
            cbKapal.TabIndex = 0;
            // 
            // dataGridViewTrips
            // 
            dataGridViewTrips.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrips.Location = new Point(12, 296);
            dataGridViewTrips.MultiSelect = false;
            dataGridViewTrips.Name = "dataGridViewTrips";
            dataGridViewTrips.ReadOnly = true;
            dataGridViewTrips.RowHeadersWidth = 82;
            dataGridViewTrips.RowTemplate.Height = 25;
            dataGridViewTrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTrips.Size = new Size(951, 346);
            dataGridViewTrips.TabIndex = 1;
            dataGridViewTrips.CellClick += DataGridViewTrips_CellClick;
            // 
            // dtpTanggalBerangkat
            // 
            dtpTanggalBerangkat.Location = new Point(230, 41);
            dtpTanggalBerangkat.Name = "dtpTanggalBerangkat";
            dtpTanggalBerangkat.Size = new Size(210, 39);
            dtpTanggalBerangkat.TabIndex = 2;
            // 
            // dtpTanggalSampai
            // 
            dtpTanggalSampai.Location = new Point(460, 41);
            dtpTanggalSampai.Name = "dtpTanggalSampai";
            dtpTanggalSampai.Size = new Size(210, 39);
            dtpTanggalSampai.TabIndex = 3;
            // 
            // tbTitikBerangkat
            // 
            tbTitikBerangkat.Location = new Point(12, 98);
            tbTitikBerangkat.Name = "tbTitikBerangkat";
            tbTitikBerangkat.Size = new Size(200, 39);
            tbTitikBerangkat.TabIndex = 4;
            // 
            // tbNakhoda
            // 
            tbNakhoda.Location = new Point(230, 98);
            tbNakhoda.Name = "tbNakhoda";
            tbNakhoda.Size = new Size(200, 39);
            tbNakhoda.TabIndex = 5;
            // 
            // tbNotes
            // 
            tbNotes.Location = new Point(460, 98);
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(312, 39);
            tbNotes.TabIndex = 6;
            // 
            // btnManageTasks
            // 
            btnManageTasks.Location = new Point(460, 151);
            btnManageTasks.Name = "btnManageTasks";
            btnManageTasks.Size = new Size(145, 42);
            btnManageTasks.TabIndex = 10;
            btnManageTasks.Text = "Tasks";
            btnManageTasks.UseVisualStyleBackColor = true;
            btnManageTasks.Click += BtnManageTasks_Click;
            // 
            // btnManageLogs
            // 
            btnManageLogs.Location = new Point(627, 151);
            btnManageLogs.Name = "btnManageLogs";
            btnManageLogs.Size = new Size(145, 42);
            btnManageLogs.TabIndex = 11;
            btnManageLogs.Text = "Logs";
            btnManageLogs.UseVisualStyleBackColor = true;
            btnManageLogs.Click += BtnManageLogs_Click;
            // 
            // labelKapal
            // 
            labelKapal.AutoSize = true;
            labelKapal.Location = new Point(12, -2);
            labelKapal.Name = "labelKapal";
            labelKapal.Size = new Size(72, 32);
            labelKapal.TabIndex = 12;
            labelKapal.Text = "Kapal";
            // 
            // btnDeleteTrip
            // 
            btnDeleteTrip.BackColor = Color.Tomato;
            btnDeleteTrip.FlatStyle = FlatStyle.Flat;
            btnDeleteTrip.ForeColor = Color.White;
            btnDeleteTrip.Location = new Point(324, 213);
            btnDeleteTrip.Name = "btnDeleteTrip";
            btnDeleteTrip.Size = new Size(137, 45);
            btnDeleteTrip.TabIndex = 15;
            btnDeleteTrip.Text = "Delete";
            btnDeleteTrip.UseVisualStyleBackColor = false;
            btnDeleteTrip.Click += BtnDeleteTrip_Click;
            // 
            // btnUpdateTrip
            // 
            btnUpdateTrip.FlatStyle = FlatStyle.Flat;
            btnUpdateTrip.Location = new Point(168, 213);
            btnUpdateTrip.Name = "btnUpdateTrip";
            btnUpdateTrip.Size = new Size(137, 45);
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
            btnAddTrip.Location = new Point(14, 213);
            btnAddTrip.Name = "btnAddTrip";
            btnAddTrip.Size = new Size(137, 45);
            btnAddTrip.TabIndex = 13;
            btnAddTrip.Text = "Add";
            btnAddTrip.UseVisualStyleBackColor = false;
            btnAddTrip.Click += BtnAddTrip_Click;
            // 
            // TripManagementForm
            // 
            ClientSize = new Size(975, 663);
            Controls.Add(btnDeleteTrip);
            Controls.Add(btnUpdateTrip);
            Controls.Add(btnAddTrip);
            Controls.Add(btnManageLogs);
            Controls.Add(btnManageTasks);
            Controls.Add(tbNotes);
            Controls.Add(tbNakhoda);
            Controls.Add(tbTitikBerangkat);
            Controls.Add(dtpTanggalSampai);
            Controls.Add(dtpTanggalBerangkat);
            Controls.Add(dataGridViewTrips);
            Controls.Add(cbKapal);
            Controls.Add(labelKapal);
            Name = "TripManagementForm";
            Text = "Trip Management";
            Load += TripManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnDeleteTrip;
        private Button btnUpdateTrip;
        private Button btnAddTrip;
    }
}
