namespace SeaNoteApp
{
    partial class UserManagementForm
    {
        /// <summary>
        /// required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// clean up any resources being used.
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

        #region windows form designer generated code

        /// <summary>
        /// required method for designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewUsers = new DataGridView();
            panelLeft = new Panel();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            btnAddUser = new Button();
            tbPhone = new TextBox();
            labelPhone = new Label();
            tbEmail = new TextBox();
            labelEmail = new Label();
            tbFullname = new TextBox();
            labelFullname = new Label();
            tbUsername = new TextBox();
            labelUsername = new Label();
            panelAssign = new Panel();
            btnAssignRole = new Button();
            cbRoles = new ComboBox();
            labelAssign = new Label();
            labelHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panelLeft.SuspendLayout();
            panelAssign.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(594, 85);
            dataGridViewUsers.Margin = new Padding(6);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidth = 82;
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(1233, 920);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(btnDeleteUser);
            panelLeft.Controls.Add(btnUpdateUser);
            panelLeft.Controls.Add(btnAddUser);
            panelLeft.Controls.Add(tbPhone);
            panelLeft.Controls.Add(labelPhone);
            panelLeft.Controls.Add(tbEmail);
            panelLeft.Controls.Add(labelEmail);
            panelLeft.Controls.Add(tbFullname);
            panelLeft.Controls.Add(labelFullname);
            panelLeft.Controls.Add(tbUsername);
            panelLeft.Controls.Add(labelUsername);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 85);
            panelLeft.Margin = new Padding(6);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(594, 920);
            panelLeft.TabIndex = 1;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Tomato;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(371, 640);
            btnDeleteUser.Margin = new Padding(6);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(167, 64);
            btnDeleteUser.TabIndex = 10;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Location = new Point(193, 640);
            btnUpdateUser.Margin = new Padding(6);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(167, 64);
            btnUpdateUser.TabIndex = 9;
            btnUpdateUser.Text = "Update";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.DodgerBlue;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(15, 640);
            btnAddUser.Margin = new Padding(6);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(167, 64);
            btnAddUser.TabIndex = 8;
            btnAddUser.Text = "Add new";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(15, 512);
            tbPhone.Margin = new Padding(6);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(520, 39);
            tbPhone.TabIndex = 7;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(15, 469);
            labelPhone.Margin = new Padding(6, 0, 6, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(184, 32);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "No. Handphone";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(15, 384);
            tbEmail.Margin = new Padding(6);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(520, 39);
            tbEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(15, 341);
            labelEmail.Margin = new Padding(6, 0, 6, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(71, 32);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // tbFullname
            // 
            tbFullname.Location = new Point(15, 256);
            tbFullname.Margin = new Padding(6);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new Size(520, 39);
            tbFullname.TabIndex = 3;
            // 
            // labelFullname
            // 
            labelFullname.AutoSize = true;
            labelFullname.Location = new Point(15, 213);
            labelFullname.Margin = new Padding(6, 0, 6, 0);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(174, 32);
            labelFullname.TabIndex = 2;
            labelFullname.Text = "Nama Lengkap";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(15, 128);
            tbUsername.Margin = new Padding(6);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(520, 39);
            tbUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(15, 85);
            labelUsername.Margin = new Padding(6, 0, 6, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(121, 32);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            // 
            // panelAssign
            // 
            panelAssign.Controls.Add(btnAssignRole);
            panelAssign.Controls.Add(cbRoles);
            panelAssign.Controls.Add(labelAssign);
            panelAssign.Dock = DockStyle.Bottom;
            panelAssign.Location = new Point(0, 1005);
            panelAssign.Margin = new Padding(6);
            panelAssign.Name = "panelAssign";
            panelAssign.Size = new Size(1827, 128);
            panelAssign.TabIndex = 2;
            // 
            // btnAssignRole
            // 
            btnAssignRole.Location = new Point(780, 32);
            btnAssignRole.Margin = new Padding(6);
            btnAssignRole.Name = "btnAssignRole";
            btnAssignRole.Size = new Size(223, 64);
            btnAssignRole.TabIndex = 2;
            btnAssignRole.Text = "Assign Role";
            btnAssignRole.UseVisualStyleBackColor = true;
            btnAssignRole.Click += btnAssignRole_Click;
            // 
            // cbRoles
            // 
            cbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(409, 43);
            cbRoles.Margin = new Padding(6);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(331, 40);
            cbRoles.TabIndex = 1;
            // 
            // labelAssign
            // 
            labelAssign.AutoSize = true;
            labelAssign.Location = new Point(260, 51);
            labelAssign.Margin = new Padding(6, 0, 6, 0);
            labelAssign.Name = "labelAssign";
            labelAssign.Size = new Size(148, 32);
            labelAssign.TabIndex = 0;
            labelAssign.Text = "Assign Role :";
            // 
            // labelHeader
            // 
            labelHeader.Dock = DockStyle.Top;
            labelHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelHeader.Location = new Point(0, 0);
            labelHeader.Margin = new Padding(6, 0, 6, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Padding = new Padding(11, 13, 11, 13);
            labelHeader.Size = new Size(1827, 85);
            labelHeader.TabIndex = 3;
            labelHeader.Text = "Daftar User";
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 1133);
            Controls.Add(dataGridViewUsers);
            Controls.Add(panelLeft);
            Controls.Add(labelHeader);
            Controls.Add(panelAssign);
            Margin = new Padding(6);
            Name = "UserManagementForm";
            Text = "User Management (Admin)";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelAssign.ResumeLayout(false);
            panelAssign.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Panel panelAssign;
        private System.Windows.Forms.Button btnAssignRole;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Label labelAssign;
        private System.Windows.Forms.Label labelHeader;
    }
}
