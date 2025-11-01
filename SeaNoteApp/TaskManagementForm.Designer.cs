namespace SeaNoteApp
{
    partial class TaskManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.TextBox tbTaskDescription;
        private System.Windows.Forms.CheckBox chkIsCompleted;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewTasks = new DataGridView();
            tbTaskName = new TextBox();
            tbTaskDescription = new TextBox();
            chkIsCompleted = new CheckBox();
            btnDeleteTask = new Button();
            btnUpdateTask = new Button();
            btnAddTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(12, 210);
            dataGridViewTasks.MultiSelect = false;
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowHeadersWidth = 82;
            dataGridViewTasks.RowTemplate.Height = 25;
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.Size = new Size(894, 348);
            dataGridViewTasks.TabIndex = 0;
            dataGridViewTasks.CellClick += DataGridViewTasks_CellClick;
            // 
            // tbTaskName
            // 
            tbTaskName.Location = new Point(12, 12);
            tbTaskName.Name = "tbTaskName";
            tbTaskName.Size = new Size(300, 39);
            tbTaskName.TabIndex = 1;
            // 
            // tbTaskDescription
            // 
            tbTaskDescription.Location = new Point(12, 70);
            tbTaskDescription.Name = "tbTaskDescription";
            tbTaskDescription.Size = new Size(560, 39);
            tbTaskDescription.TabIndex = 2;
            // 
            // chkIsCompleted
            // 
            chkIsCompleted.AutoSize = true;
            chkIsCompleted.Location = new Point(320, 14);
            chkIsCompleted.Name = "chkIsCompleted";
            chkIsCompleted.Size = new Size(183, 36);
            chkIsCompleted.TabIndex = 3;
            chkIsCompleted.Text = "is completed";
            chkIsCompleted.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.Tomato;
            btnDeleteTask.FlatStyle = FlatStyle.Flat;
            btnDeleteTask.ForeColor = Color.White;
            btnDeleteTask.Location = new Point(331, 135);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(137, 45);
            btnDeleteTask.TabIndex = 9;
            btnDeleteTask.Text = "Delete";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += BtnDeleteTask_Click;
            // 
            // btnUpdateTask
            // 
            btnUpdateTask.FlatStyle = FlatStyle.Flat;
            btnUpdateTask.Location = new Point(175, 135);
            btnUpdateTask.Name = "btnUpdateTask";
            btnUpdateTask.Size = new Size(137, 45);
            btnUpdateTask.TabIndex = 8;
            btnUpdateTask.Text = "Update";
            btnUpdateTask.UseVisualStyleBackColor = true;
            btnUpdateTask.Click += BtnUpdateTask_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.DodgerBlue;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(21, 135);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(137, 45);
            btnAddTask.TabIndex = 7;
            btnAddTask.Text = "Add";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += BtnAddTask_Click;
            // 
            // TaskManagementForm
            // 
            ClientSize = new Size(918, 579);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnUpdateTask);
            Controls.Add(btnAddTask);
            Controls.Add(chkIsCompleted);
            Controls.Add(tbTaskDescription);
            Controls.Add(tbTaskName);
            Controls.Add(dataGridViewTasks);
            Name = "TaskManagementForm";
            Text = "Task Management";
            Load += TaskManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnDeleteTask;
        private Button btnUpdateTask;
        private Button btnAddTask;
    }
}
