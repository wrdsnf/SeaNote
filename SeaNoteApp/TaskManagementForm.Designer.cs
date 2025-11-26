namespace SeaNoteApp
{
    partial class TaskManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.TextBox tbTaskName;
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
            chkIsCompleted = new CheckBox();
            btnDeleteTask = new Button();
            btnUpdateTask = new Button();
            btnAddTask = new Button();
            label1 = new Label();
            label2 = new Label();
            tbTaskDescription = new RichTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(12, 357);
            dataGridViewTasks.MultiSelect = false;
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowHeadersWidth = 82;
            dataGridViewTasks.RowTemplate.Height = 25;
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.Size = new Size(894, 342);
            dataGridViewTasks.TabIndex = 0;
            dataGridViewTasks.CellClick += DataGridViewTasks_CellClick;
            // 
            // tbTaskName
            // 
            tbTaskName.Location = new Point(48, 127);
            tbTaskName.Name = "tbTaskName";
            tbTaskName.Size = new Size(300, 39);
            tbTaskName.TabIndex = 1;
            // 
            // chkIsCompleted
            // 
            chkIsCompleted.AutoSize = true;
            chkIsCompleted.Location = new Point(356, 129);
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
            btnDeleteTask.Location = new Point(610, 255);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(253, 67);
            btnDeleteTask.TabIndex = 9;
            btnDeleteTask.Text = "Delete";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += BtnDeleteTask_Click;
            // 
            // btnUpdateTask
            // 
            btnUpdateTask.FlatStyle = FlatStyle.Flat;
            btnUpdateTask.Location = new Point(610, 174);
            btnUpdateTask.Name = "btnUpdateTask";
            btnUpdateTask.Size = new Size(253, 67);
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
            btnAddTask.Location = new Point(610, 92);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(253, 67);
            btnAddTask.TabIndex = 7;
            btnAddTask.Text = "Add";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += BtnAddTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 92);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 10;
            label1.Text = "Nama Task:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 189);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 11;
            label2.Text = "Deskripsi:";
            // 
            // tbTaskDescription
            // 
            tbTaskDescription.Location = new Point(48, 224);
            tbTaskDescription.Name = "tbTaskDescription";
            tbTaskDescription.Size = new Size(447, 97);
            tbTaskDescription.TabIndex = 12;
            tbTaskDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 27);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 13;
            // 
            // TaskManagementForm
            // 
            ClientSize = new Size(918, 720);
            Controls.Add(label3);
            Controls.Add(tbTaskDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnUpdateTask);
            Controls.Add(btnAddTask);
            Controls.Add(chkIsCompleted);
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
        private Label label1;
        private Label label2;
        private RichTextBox tbTaskDescription;
        private Label label3;
    }
}
