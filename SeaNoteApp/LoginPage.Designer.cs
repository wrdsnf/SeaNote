namespace SeaNoteApp
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lnkSignUp = new LinkLabel();
            lnkForgotPassword = new LinkLabel();
            label6 = new Label();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(223, 213);
            tbUsername.Margin = new Padding(6);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(368, 39);
            tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(223, 299);
            tbPassword.Margin = new Padding(6);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(368, 39);
            tbPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(127, 434);
            btnLogin.Margin = new Padding(6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(193, 61);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Tomato;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(352, 434);
            btnClose.Margin = new Padding(6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(193, 61);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(74, 220);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 5;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(74, 305);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(270, 119);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 7;
            label3.Text = "SeaNote";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(164, 698);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(225, 32);
            label4.TabIndex = 8;
            label4.Text = "Belum punya akun?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(238, 23);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(195, 78);
            label5.TabIndex = 9;
            label5.Text = "Login";
            // 
            // lnkSignUp
            // 
            lnkSignUp.AutoSize = true;
            lnkSignUp.BackColor = Color.Transparent;
            lnkSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkSignUp.LinkColor = Color.White;
            lnkSignUp.Location = new Point(389, 698);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(103, 32);
            lnkSignUp.TabIndex = 10;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Sign Up";
            lnkSignUp.Click += lnkSignUp_Click;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.BackColor = Color.Transparent;
            lnkForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkForgotPassword.LinkColor = Color.White;
            lnkForgotPassword.Location = new Point(358, 745);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(190, 32);
            lnkForgotPassword.TabIndex = 12;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Reset Password";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(125, 745);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(233, 32);
            label6.TabIndex = 11;
            label6.Text = "Atau lupa password?";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(670, 826);
            Controls.Add(lnkForgotPassword);
            Controls.Add(label6);
            Controls.Add(lnkSignUp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Margin = new Padding(6);
            Name = "LoginPage";
            Text = "SeaNote Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        // private System.Windows.Forms.Button lnkSignUp; // <-- INI YANG DIHAPUS
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Label label5;
        private LinkLabel lnkSignUp; // <-- INI YANG BENER
        private LinkLabel lnkForgotPassword;
        private Label label6;
    }
}