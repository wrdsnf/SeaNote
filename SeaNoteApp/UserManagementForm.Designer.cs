namespace SeaNoteApp
{
    partial class UserManagementForm
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
            dataGridViewUsers = new DataGridView();
            panelAssign = new Panel();
            btnAssignRole = new Button();
            cbRoles = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panelAssign.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(332, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 31);
            label2.TabIndex = 1;
            label2.Text = "Daftar User";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(0, 56);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(800, 400);
            dataGridViewUsers.TabIndex = 2;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // panelAssign
            // 
            panelAssign.Controls.Add(btnAssignRole);
            panelAssign.Controls.Add(cbRoles);
            panelAssign.Controls.Add(label3);
            panelAssign.Dock = DockStyle.Bottom;
            panelAssign.Location = new Point(0, 321);
            panelAssign.Name = "panelAssign";
            panelAssign.Size = new Size(800, 130);
            panelAssign.TabIndex = 3;
            // 
            // btnAssignRole
            // 
            btnAssignRole.BackColor = Color.DodgerBlue;
            btnAssignRole.BackgroundImageLayout = ImageLayout.None;
            btnAssignRole.FlatStyle = FlatStyle.Flat;
            btnAssignRole.ForeColor = Color.White;
            btnAssignRole.Location = new Point(332, 83);
            btnAssignRole.Margin = new Padding(2);
            btnAssignRole.Name = "btnAssignRole";
            btnAssignRole.Size = new Size(119, 36);
            btnAssignRole.TabIndex = 17;
            btnAssignRole.Text = "Assign Role";
            btnAssignRole.UseVisualStyleBackColor = false;
            btnAssignRole.Click += btnAssignRole_Click;
            // 
            // cbRoles
            // 
            cbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoles.FormattingEnabled = true;
            cbRoles.Items.AddRange(new object[] { "Admin", "Owner", "Engineer" });
            cbRoles.Location = new Point(0, 41);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(800, 28);
            cbRoles.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 18);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 0;
            label3.Text = "Assign Role :";
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(panelAssign);
            Controls.Add(dataGridViewUsers);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panelAssign.ResumeLayout(false);
            panelAssign.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridViewUsers;
        private Panel panelAssign;
        private ComboBox cbRoles;
        private Label label3;
        private Button btnAssignRole;
    }
}