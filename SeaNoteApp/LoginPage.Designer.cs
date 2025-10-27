namespace SeaNoteApp
{
    partial class LoginPage
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
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(68, 75);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 54);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(68, 106);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(134, 12);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 45);
            label4.TabIndex = 3;
            label4.Text = "SeaNote";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(153, 74);
            tbUsername.Margin = new Padding(2, 1, 2, 1);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(196, 23);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(153, 103);
            tbPassword.Margin = new Padding(2, 1, 2, 1);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(196, 23);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(83, 151);
            btnLogin.Margin = new Padding(2, 1, 2, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 27);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gainsboro;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(223, 151);
            btnClose.Margin = new Padding(2, 1, 2, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(104, 27);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(431, 211);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonShadow;
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoginPage";
            Text = "SeaNote Login";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnClose;
    }
}