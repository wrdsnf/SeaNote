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
            label1.Location = new Point(71, 42);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 0;
            label1.Text = "Nama Kapal :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 107);
            label2.Name = "label2";
            label2.Size = new Size(171, 32);
            label2.TabIndex = 1;
            label2.Text = "Tgl Berangkat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 171);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 2;
            label3.Text = "Tgl Sampai :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 239);
            label4.Name = "label4";
            label4.Size = new Size(185, 32);
            label4.TabIndex = 3;
            label4.Text = "Titik Berangkat :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 301);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 4;
            label5.Text = "Nakhoda :";
            // 
            // tbNamaKapal
            // 
            tbNamaKapal.Location = new Point(285, 39);
            tbNamaKapal.Name = "tbNamaKapal";
            tbNamaKapal.Size = new Size(412, 39);
            tbNamaKapal.TabIndex = 5;
            // 
            // tbTitikBerangkat
            // 
            tbTitikBerangkat.Location = new Point(285, 236);
            tbTitikBerangkat.Name = "tbTitikBerangkat";
            tbTitikBerangkat.Size = new Size(412, 39);
            tbTitikBerangkat.TabIndex = 6;
            // 
            // tbNakhoda
            // 
            tbNakhoda.Location = new Point(285, 298);
            tbNakhoda.Name = "tbNakhoda";
            tbNakhoda.Size = new Size(412, 39);
            tbNakhoda.TabIndex = 7;
            // 
            // dtpTglBerangkat
            // 
            dtpTglBerangkat.Location = new Point(285, 102);
            dtpTglBerangkat.Name = "dtpTglBerangkat";
            dtpTglBerangkat.Size = new Size(412, 39);
            dtpTglBerangkat.TabIndex = 8;
            // 
            // dtpTglSampai
            // 
            dtpTglSampai.Location = new Point(285, 166);
            dtpTglSampai.Name = "dtpTglSampai";
            dtpTglSampai.Size = new Size(412, 39);
            dtpTglSampai.TabIndex = 9;
            // 
            // btnUpdateTrip
            // 
            btnUpdateTrip.BackColor = Color.Gainsboro;
            btnUpdateTrip.FlatStyle = FlatStyle.Flat;
            btnUpdateTrip.ForeColor = Color.Black;
            btnUpdateTrip.Location = new Point(431, 392);
            btnUpdateTrip.Name = "btnUpdateTrip";
            btnUpdateTrip.Size = new Size(250, 46);
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
            btnAddTrip.Location = new Point(92, 392);
            btnAddTrip.Name = "btnAddTrip";
            btnAddTrip.Size = new Size(250, 46);
            btnAddTrip.TabIndex = 14;
            btnAddTrip.Text = "Add Trip";
            btnAddTrip.UseVisualStyleBackColor = false;
            btnAddTrip.Click += btnAddTrip_Click;
            // 
            // dataGridViewTrips
            // 
            dataGridViewTrips.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrips.Location = new Point(12, 468);
            dataGridViewTrips.Name = "dataGridViewTrips";
            dataGridViewTrips.RowHeadersWidth = 82;
            dataGridViewTrips.Size = new Size(820, 350);
            dataGridViewTrips.TabIndex = 16;
            // 
            // TripManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 853);
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