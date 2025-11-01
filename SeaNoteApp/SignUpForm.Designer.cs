namespace SeaNoteApp
{
    partial class SignUpForm
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
            label4 = new Label();
            tbPasswordSignUp = new TextBox();
            tbNamaLengkap = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tbEmail = new TextBox();
            tbUsernameSignUp = new TextBox();
            label2 = new Label();
            label5 = new Label();
            tbNomorTelepon = new TextBox();
            label6 = new Label();
            btnCancelSignUp = new Button();
            btnDoSignUp = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(94, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(183, 54);
            label4.TabIndex = 4;
            label4.Text = "SeaNote";
            // 
            // tbPasswordSignUp
            // 
            tbPasswordSignUp.Location = new Point(148, 194);
            tbPasswordSignUp.Margin = new Padding(2);
            tbPasswordSignUp.Name = "tbPasswordSignUp";
            tbPasswordSignUp.Size = new Size(201, 27);
            tbPasswordSignUp.TabIndex = 9;
            tbPasswordSignUp.UseSystemPasswordChar = true;
            // 
            // tbNamaLengkap
            // 
            tbNamaLengkap.Location = new Point(148, 76);
            tbNamaLengkap.Margin = new Padding(2);
            tbNamaLengkap.Name = "tbNamaLengkap";
            tbNamaLengkap.Size = new Size(201, 27);
            tbNamaLengkap.TabIndex = 8;
            tbNamaLengkap.TextChanged += tbNamaLengkap_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(28, 198);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 7;
            label3.Text = "Password          :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 6;
            label1.Text = "Nama Lengkap :";
            label1.Click += label1_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(148, 153);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(201, 27);
            tbEmail.TabIndex = 13;
            // 
            // tbUsernameSignUp
            // 
            tbUsernameSignUp.Location = new Point(148, 114);
            tbUsernameSignUp.Margin = new Padding(2);
            tbUsernameSignUp.Name = "tbUsernameSignUp";
            tbUsernameSignUp.Size = new Size(201, 27);
            tbUsernameSignUp.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(28, 157);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 11;
            label2.Text = "Email                :";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 116);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 10;
            label5.Text = "Username         :";
            // 
            // tbNomorTelepon
            // 
            tbNomorTelepon.Location = new Point(151, 238);
            tbNomorTelepon.Margin = new Padding(2);
            tbNomorTelepon.Name = "tbNomorTelepon";
            tbNomorTelepon.Size = new Size(201, 27);
            tbNomorTelepon.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(31, 242);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 14;
            label6.Text = "Nomor Telp     :";
            // 
            // btnCancelSignUp
            // 
            btnCancelSignUp.BackColor = Color.Gainsboro;
            btnCancelSignUp.BackgroundImageLayout = ImageLayout.None;
            btnCancelSignUp.FlatStyle = FlatStyle.Flat;
            btnCancelSignUp.ForeColor = Color.Black;
            btnCancelSignUp.Location = new Point(206, 294);
            btnCancelSignUp.Margin = new Padding(2);
            btnCancelSignUp.Name = "btnCancelSignUp";
            btnCancelSignUp.Size = new Size(119, 36);
            btnCancelSignUp.TabIndex = 17;
            btnCancelSignUp.Text = "Cancel";
            btnCancelSignUp.UseVisualStyleBackColor = false;
            btnCancelSignUp.Click += btnCancelSignUp_Click;
            // 
            // btnDoSignUp
            // 
            btnDoSignUp.BackColor = Color.DodgerBlue;
            btnDoSignUp.BackgroundImageLayout = ImageLayout.None;
            btnDoSignUp.FlatStyle = FlatStyle.Flat;
            btnDoSignUp.ForeColor = Color.White;
            btnDoSignUp.Location = new Point(46, 294);
            btnDoSignUp.Margin = new Padding(2);
            btnDoSignUp.Name = "btnDoSignUp";
            btnDoSignUp.Size = new Size(119, 36);
            btnDoSignUp.TabIndex = 16;
            btnDoSignUp.Text = "Sign Up";
            btnDoSignUp.UseVisualStyleBackColor = false;
            btnDoSignUp.Click += btnDoSignUp_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 503);
            Controls.Add(btnCancelSignUp);
            Controls.Add(btnDoSignUp);
            Controls.Add(tbNomorTelepon);
            Controls.Add(label6);
            Controls.Add(tbEmail);
            Controls.Add(tbUsernameSignUp);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(tbPasswordSignUp);
            Controls.Add(tbNamaLengkap);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox tbPasswordSignUp;
        private TextBox tbNamaLengkap;
        private Label label3;
        private Label label1;
        private TextBox tbEmail;
        private TextBox tbUsernameSignUp;
        private Label label2;
        private Label label5;
        private TextBox tbNomorTelepon;
        private Label label6;
        private Button btnCancelSignUp;
        private Button btnDoSignUp;
    }
}