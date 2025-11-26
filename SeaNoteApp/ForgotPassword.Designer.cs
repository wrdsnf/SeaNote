namespace SeaNoteApp
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            label1 = new Label();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            label2 = new Label();
            btnVerify = new Button();
            panelReset = new Panel();
            btnReset = new Button();
            tbConfirmPassword = new TextBox();
            label4 = new Label();
            tbNewPassword = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            panelReset.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(74, 220);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(223, 213);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(368, 39);
            tbUsername.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(223, 271);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(368, 39);
            tbEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(74, 274);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(399, 353);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(192, 60);
            btnVerify.TabIndex = 3;
            btnVerify.Text = "Verifikasi";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // panelReset
            // 
            panelReset.BackColor = Color.Transparent;
            panelReset.Controls.Add(btnReset);
            panelReset.Controls.Add(tbConfirmPassword);
            panelReset.Controls.Add(label4);
            panelReset.Controls.Add(tbNewPassword);
            panelReset.Controls.Add(label3);
            panelReset.Location = new Point(34, 467);
            panelReset.Name = "panelReset";
            panelReset.Size = new Size(599, 260);
            panelReset.TabIndex = 4;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.DodgerBlue;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(364, 167);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(192, 60);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(188, 87);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(368, 39);
            tbConfirmPassword.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 90);
            label4.Name = "label4";
            label4.Size = new Size(131, 32);
            label4.TabIndex = 6;
            label4.Text = "Konfirmasi:";
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(188, 27);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '*';
            tbNewPassword.Size = new Size(368, 39);
            tbNewPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 30);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 4;
            label3.Text = "Pass. Baru:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(95, 23);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(477, 78);
            label6.TabIndex = 15;
            label6.Text = "Verifikasi Akun";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(268, 119);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(124, 37);
            label7.TabIndex = 14;
            label7.Text = "SeaNote";
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(670, 826);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(panelReset);
            Controls.Add(btnVerify);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lupa Password";
            panelReset.ResumeLayout(false);
            panelReset.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUsername;
        private TextBox tbEmail;
        private Label label2;
        private Button btnVerify;
        private Panel panelReset;
        private Button btnReset;
        private TextBox tbConfirmPassword;
        private Label label4;
        private TextBox tbNewPassword;
        private Label label3;
        private Label label6;
        private Label label7;
    }
}