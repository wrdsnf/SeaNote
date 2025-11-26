namespace SeaNoteApp
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            label1 = new Label();
            tbNamaLengkap = new TextBox();
            label2 = new Label();
            tbUsernameSignUp = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            tbPasswordSignUp = new TextBox();
            label5 = new Label();
            tbNomorTelepon = new TextBox();
            btnDoSignUp = new Button();
            btnCancelSignUp = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(64, 220);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 0;
            label1.Text = "Nama Lengkap:";
            // 
            // tbNamaLengkap
            // 
            tbNamaLengkap.Location = new Point(268, 214);
            tbNamaLengkap.Margin = new Padding(6);
            tbNamaLengkap.Name = "tbNamaLengkap";
            tbNamaLengkap.Size = new Size(368, 39);
            tbNamaLengkap.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(64, 284);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // tbUsernameSignUp
            // 
            tbUsernameSignUp.Location = new Point(268, 278);
            tbUsernameSignUp.Margin = new Padding(6);
            tbUsernameSignUp.Name = "tbUsernameSignUp";
            tbUsernameSignUp.Size = new Size(368, 39);
            tbUsernameSignUp.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(64, 348);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(268, 342);
            tbEmail.Margin = new Padding(6);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(368, 39);
            tbEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(64, 412);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // tbPasswordSignUp
            // 
            tbPasswordSignUp.Location = new Point(268, 406);
            tbPasswordSignUp.Margin = new Padding(6);
            tbPasswordSignUp.Name = "tbPasswordSignUp";
            tbPasswordSignUp.PasswordChar = '*';
            tbPasswordSignUp.Size = new Size(368, 39);
            tbPasswordSignUp.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(64, 476);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 32);
            label5.TabIndex = 8;
            label5.Text = "Nomor Telepon:";
            // 
            // tbNomorTelepon
            // 
            tbNomorTelepon.Location = new Point(268, 470);
            tbNomorTelepon.Margin = new Padding(6);
            tbNomorTelepon.Name = "tbNomorTelepon";
            tbNomorTelepon.Size = new Size(368, 39);
            tbNomorTelepon.TabIndex = 9;
            // 
            // btnDoSignUp
            // 
            btnDoSignUp.BackColor = Color.DodgerBlue;
            btnDoSignUp.FlatStyle = FlatStyle.Flat;
            btnDoSignUp.ForeColor = Color.White;
            btnDoSignUp.Location = new Point(127, 604);
            btnDoSignUp.Margin = new Padding(6);
            btnDoSignUp.Name = "btnDoSignUp";
            btnDoSignUp.Size = new Size(193, 61);
            btnDoSignUp.TabIndex = 10;
            btnDoSignUp.Text = "Sign Up";
            btnDoSignUp.UseVisualStyleBackColor = false;
            btnDoSignUp.Click += btnDoSignUp_Click;
            // 
            // btnCancelSignUp
            // 
            btnCancelSignUp.BackColor = Color.Tomato;
            btnCancelSignUp.FlatStyle = FlatStyle.Flat;
            btnCancelSignUp.ForeColor = Color.White;
            btnCancelSignUp.Location = new Point(352, 604);
            btnCancelSignUp.Margin = new Padding(6);
            btnCancelSignUp.Name = "btnCancelSignUp";
            btnCancelSignUp.Size = new Size(193, 61);
            btnCancelSignUp.TabIndex = 11;
            btnCancelSignUp.Text = "Cancel";
            btnCancelSignUp.UseVisualStyleBackColor = false;
            btnCancelSignUp.Click += btnCancelSignUp_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(206, 23);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(258, 78);
            label6.TabIndex = 13;
            label6.Text = "Sign Up";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(270, 119);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(124, 37);
            label7.TabIndex = 12;
            label7.Text = "SeaNote";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(670, 826);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btnCancelSignUp);
            Controls.Add(btnDoSignUp);
            Controls.Add(tbNomorTelepon);
            Controls.Add(label5);
            Controls.Add(tbPasswordSignUp);
            Controls.Add(label4);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(tbUsernameSignUp);
            Controls.Add(label2);
            Controls.Add(tbNamaLengkap);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "SignUpForm";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaLengkap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsernameSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPasswordSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNomorTelepon;
        private System.Windows.Forms.Button btnDoSignUp;
        private System.Windows.Forms.Button btnCancelSignUp;
        private Label label6;
        private Label label7;
    }
}