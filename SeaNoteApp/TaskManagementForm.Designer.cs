namespace SeaNoteApp
{
    partial class TaskManagementForm
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
            cbTrips = new ComboBox();
            dataGridViewTasks = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            tbTaskName = new TextBox();
            label3 = new Label();
            tbTaskDesc = new TextBox();
            checkCompleted = new CheckBox();
            btnAddTask = new Button();
            btnUpdateTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 0;
            label1.Text = "Select Trip :";
            // 
            // cbTrips
            // 
            cbTrips.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrips.FormattingEnabled = true;
            cbTrips.Location = new Point(220, 30);
            cbTrips.Name = "cbTrips";
            cbTrips.Size = new Size(242, 40);
            cbTrips.TabIndex = 1;
            cbTrips.SelectedIndexChanged += cbTrips_SelectedIndexChanged;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(46, 114);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 82;
            dataGridViewTasks.Size = new Size(416, 300);
            dataGridViewTasks.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(tbTaskName);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(tbTaskDesc);
            flowLayoutPanel1.Controls.Add(checkCompleted);
            flowLayoutPanel1.Controls.Add(btnAddTask);
            flowLayoutPanel1.Controls.Add(btnUpdateTask);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(674, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(300, 533);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 4;
            label2.Text = "Task Name :";
            // 
            // tbTaskName
            // 
            tbTaskName.Location = new Point(3, 35);
            tbTaskName.Name = "tbTaskName";
            tbTaskName.Size = new Size(200, 39);
            tbTaskName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 77);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 5;
            label3.Text = "Description :";
            // 
            // tbTaskDesc
            // 
            tbTaskDesc.Location = new Point(3, 112);
            tbTaskDesc.Multiline = true;
            tbTaskDesc.Name = "tbTaskDesc";
            tbTaskDesc.Size = new Size(200, 39);
            tbTaskDesc.TabIndex = 7;
            // 
            // checkCompleted
            // 
            checkCompleted.AutoSize = true;
            checkCompleted.Location = new Point(3, 157);
            checkCompleted.Name = "checkCompleted";
            checkCompleted.Size = new Size(187, 36);
            checkCompleted.TabIndex = 8;
            checkCompleted.Text = "is Completed";
            checkCompleted.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(3, 199);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(150, 46);
            btnAddTask.TabIndex = 9;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnUpdateTask
            // 
            btnUpdateTask.Location = new Point(3, 251);
            btnUpdateTask.Name = "btnUpdateTask";
            btnUpdateTask.Size = new Size(150, 46);
            btnUpdateTask.TabIndex = 10;
            btnUpdateTask.Text = "Update Task";
            btnUpdateTask.UseVisualStyleBackColor = true;
            btnUpdateTask.Click += btnUpdateTask_Click;
            // 
            // TaskManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(974, 533);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridViewTasks);
            Controls.Add(cbTrips);
            Controls.Add(label1);
            Name = "TaskManagementForm";
            Text = "Task Management";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbTrips;
        private DataGridView dataGridViewTasks;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox tbTaskName;
        private Label label3;
        private TextBox tbTaskDesc;
        private CheckBox checkCompleted;
        private Button btnAddTask;
        private Button btnUpdateTask;
    }
}