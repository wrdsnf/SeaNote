namespace SeaNoteApp
{
    partial class TripManagementForm
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
            tbNamaKapal = new TextBox();
            tbTitikBerangkat = new TextBox();
            tbNakhoda = new TextBox();
            dtpTglBerangkat = new DateTimePicker();
            dtpTglSampai = new DateTimePicker();
            btnUpdateTrip = new Button();
            btnAddTrip = new Button();
            dataGridViewTrips = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Kapal :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Tgl Berangkat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Tgl Sampai :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 112);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "Titik Berangkat :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 141);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Nakhoda :";
            // 
            // tbNamaKapal
            // 
            tbNamaKapal.Location = new Point(153, 18);
            tbNamaKapal.Margin = new Padding(2, 1, 2, 1);
            tbNamaKapal.Name = "tbNamaKapal";
            tbNamaKapal.Size = new Size(224, 23);
            tbNamaKapal.TabIndex = 5;
            // 
            // tbTitikBerangkat
            // 
            tbTitikBerangkat.Location = new Point(153, 111);
            tbTitikBerangkat.Margin = new Padding(2, 1, 2, 1);
            tbTitikBerangkat.Name = "tbTitikBerangkat";
            tbTitikBerangkat.Size = new Size(224, 23);
            tbTitikBerangkat.TabIndex = 6;
            // 
            // tbNakhoda
            // 
            tbNakhoda.Location = new Point(153, 140);
            tbNakhoda.Margin = new Padding(2, 1, 2, 1);
            tbNakhoda.Name = "tbNakhoda";
            tbNakhoda.Size = new Size(224, 23);
            tbNakhoda.TabIndex = 7;
            // 
            // dtpTglBerangkat
            // 
            dtpTglBerangkat.Location = new Point(153, 48);
            dtpTglBerangkat.Margin = new Padding(2, 1, 2, 1);
            dtpTglBerangkat.Name = "dtpTglBerangkat";
            dtpTglBerangkat.Size = new Size(224, 23);
            dtpTglBerangkat.TabIndex = 8;
            // 
            // dtpTglSampai
            // 
            dtpTglSampai.Location = new Point(153, 78);
            dtpTglSampai.Margin = new Padding(2, 1, 2, 1);
            dtpTglSampai.Name = "dtpTglSampai";
            dtpTglSampai.Size = new Size(224, 23);
            dtpTglSampai.TabIndex = 9;
            // 
            // btnUpdateTrip
            // 
            btnUpdateTrip.BackColor = Color.Gainsboro;
            btnUpdateTrip.FlatStyle = FlatStyle.Flat;
            btnUpdateTrip.ForeColor = Color.Black;
            btnUpdateTrip.Location = new Point(232, 184);
            btnUpdateTrip.Margin = new Padding(2, 1, 2, 1);
            btnUpdateTrip.Name = "btnUpdateTrip";
            btnUpdateTrip.Size = new Size(135, 22);
            btnUpdateTrip.TabIndex = 15;
            btnUpdateTrip.Text = "Update Trip";
            btnUpdateTrip.UseVisualStyleBackColor = false;
            btnUpdateTrip.Click += btnUpdateTrip_Click;
            // 
            // btnAddTrip
            // 
            btnAddTrip.BackColor = Color.DodgerBlue;
            btnAddTrip.FlatStyle = FlatStyle.Flat;
            btnAddTrip.ForeColor = Color.White;
            btnAddTrip.Location = new Point(50, 184);
            btnAddTrip.Margin = new Padding(2, 1, 2, 1);
            btnAddTrip.Name = "btnAddTrip";
            btnAddTrip.Size = new Size(135, 22);
            btnAddTrip.TabIndex = 14;
            btnAddTrip.Text = "Add Trip";
            btnAddTrip.UseVisualStyleBackColor = false;
            btnAddTrip.Click += btnAddTrip_Click;
            // 
            // dataGridViewTrips
            // 
            dataGridViewTrips.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrips.Dock = DockStyle.Bottom;
            dataGridViewTrips.Location = new Point(0, 218);
            dataGridViewTrips.Margin = new Padding(2, 1, 2, 1);
            dataGridViewTrips.Name = "dataGridViewTrips";
            dataGridViewTrips.RowHeadersWidth = 82;
            dataGridViewTrips.Size = new Size(431, 133);
            dataGridViewTrips.TabIndex = 16;
            // 
            // TripManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(431, 351);
            Controls.Add(dataGridViewTrips);
            Controls.Add(btnUpdateTrip);
            Controls.Add(btnAddTrip);
            Controls.Add(dtpTglSampai);
            Controls.Add(dtpTglBerangkat);
            Controls.Add(tbNakhoda);
            Controls.Add(tbTitikBerangkat);
            Controls.Add(tbNamaKapal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "TripManagementForm";
            Text = "Trip Management";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrips).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNamaKapal;
        private TextBox tbTitikBerangkat;
        private TextBox tbNakhoda;
        private DateTimePicker dtpTglBerangkat;
        private DateTimePicker dtpTglSampai;
        private Button btnUpdateTrip;
        private Button btnAddTrip;
        private DataGridView dataGridViewTrips;
    }
}