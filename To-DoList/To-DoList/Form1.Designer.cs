namespace To_DoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupAddTask = new GroupBox();
            lblNoTitle = new Label();
            btnSubmit = new Button();
            txtDescriptionBox = new TextBox();
            lblDescription = new Label();
            txtTitleBox = new TextBox();
            lblText = new Label();
            groupTasks = new GroupBox();
            taskPanel = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            completedTaskPanel = new FlowLayoutPanel();
            groupAddTask.SuspendLayout();
            groupTasks.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupAddTask
            // 
            groupAddTask.Controls.Add(lblNoTitle);
            groupAddTask.Controls.Add(btnSubmit);
            groupAddTask.Controls.Add(txtDescriptionBox);
            groupAddTask.Controls.Add(lblDescription);
            groupAddTask.Controls.Add(txtTitleBox);
            groupAddTask.Controls.Add(lblText);
            groupAddTask.Location = new Point(0, 0);
            groupAddTask.Name = "groupAddTask";
            groupAddTask.Size = new Size(250, 246);
            groupAddTask.TabIndex = 0;
            groupAddTask.TabStop = false;
            groupAddTask.Text = "Add Task";
            // 
            // lblNoTitle
            // 
            lblNoTitle.AutoSize = true;
            lblNoTitle.ForeColor = Color.Red;
            lblNoTitle.Location = new Point(12, 193);
            lblNoTitle.Name = "lblNoTitle";
            lblNoTitle.Size = new Size(0, 20);
            lblNoTitle.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 161);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtDescriptionBox
            // 
            txtDescriptionBox.Location = new Point(12, 112);
            txtDescriptionBox.Name = "txtDescriptionBox";
            txtDescriptionBox.Size = new Size(125, 27);
            txtDescriptionBox.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 89);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // txtTitleBox
            // 
            txtTitleBox.Location = new Point(12, 58);
            txtTitleBox.Name = "txtTitleBox";
            txtTitleBox.Size = new Size(125, 27);
            txtTitleBox.TabIndex = 1;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(12, 35);
            lblText.Name = "lblText";
            lblText.Size = new Size(38, 20);
            lblText.TabIndex = 0;
            lblText.Text = "Title";
            // 
            // groupTasks
            // 
            groupTasks.Controls.Add(taskPanel);
            groupTasks.Location = new Point(256, 0);
            groupTasks.Name = "groupTasks";
            groupTasks.Size = new Size(532, 288);
            groupTasks.TabIndex = 1;
            groupTasks.TabStop = false;
            groupTasks.Text = "Tasks";
            // 
            // taskPanel
            // 
            taskPanel.AutoScroll = true;
            taskPanel.FlowDirection = FlowDirection.TopDown;
            taskPanel.Location = new Point(6, 26);
            taskPanel.Name = "taskPanel";
            taskPanel.Size = new Size(520, 256);
            taskPanel.TabIndex = 0;
            taskPanel.WrapContents = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(completedTaskPanel);
            groupBox1.Location = new Point(256, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 149);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Completed Tasks";
            // 
            // completedTaskPanel
            // 
            completedTaskPanel.AutoScroll = true;
            completedTaskPanel.FlowDirection = FlowDirection.TopDown;
            completedTaskPanel.Location = new Point(6, 18);
            completedTaskPanel.Name = "completedTaskPanel";
            completedTaskPanel.Size = new Size(520, 125);
            completedTaskPanel.TabIndex = 0;
            completedTaskPanel.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupTasks);
            Controls.Add(groupAddTask);
            Name = "Form1";
            Text = "Form1";
            groupAddTask.ResumeLayout(false);
            groupAddTask.PerformLayout();
            groupTasks.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupAddTask;
        private Label lblText;
        private GroupBox groupTasks;
        private Button btnSubmit;
        private TextBox txtDescriptionBox;
        private Label lblDescription;
        private TextBox txtTitleBox;
        private FlowLayoutPanel taskPanel;
        private Label lblNoTitle;
        private GroupBox groupBox1;
        private FlowLayoutPanel completedTaskPanel;
    }
}
