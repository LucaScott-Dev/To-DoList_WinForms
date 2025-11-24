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
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtTitleBox = new TextBox();
            label2 = new Label();
            txtDescriptionBox = new TextBox();
            btnSubmit = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(txtDescriptionBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTitleBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 215);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Task";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(256, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(532, 450);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tasks";
            // 
            // txtTitleBox
            // 
            txtTitleBox.Location = new Point(12, 58);
            txtTitleBox.Name = "txtTitleBox";
            txtTitleBox.Size = new Size(125, 27);
            txtTitleBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // txtDescriptionBox
            // 
            txtDescriptionBox.Location = new Point(12, 112);
            txtDescriptionBox.Name = "txtDescriptionBox";
            txtDescriptionBox.Size = new Size(125, 27);
            txtDescriptionBox.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 161);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(0, 221);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 229);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Properties";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnSubmit;
        private TextBox txtDescriptionBox;
        private Label label2;
        private TextBox txtTitleBox;
        private GroupBox groupBox3;
    }
}
