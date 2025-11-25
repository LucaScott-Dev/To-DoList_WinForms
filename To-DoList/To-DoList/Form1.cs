using System.Linq;

namespace To_DoList
{
    public partial class Form1 : Form
    {
        private TaskManager taskManager = new TaskManager();

        public Form1()
        {
            InitializeComponent();
            taskManager.LoadFromFile();
            RefreshTaskUI();
        }

        private void RefreshTaskUI()
        {
            taskPanel.Controls.Clear();
            completedTaskPanel.Controls.Clear();

            // ========================
            // ACTIVE TASKS
            // ========================

            var active = taskManager.ActiveTasks;

            for (int i = 0; i < active.Count; i++)
            {
                int index = taskManager.Tasks.ToList().IndexOf(active[i]);   // FIXED

                Panel p = new Panel();
                p.Width = taskPanel.Width - 25;
                p.Height = 50;
                p.Margin = new Padding(5);

                //Complete button
                Button btnComplete = new Button();
                btnComplete.Text = "✓";
                btnComplete.Width = 30;
                btnComplete.Height = 30;
                btnComplete.Left = 0;
                btnComplete.Tag = index;
                btnComplete.Click += (s, e) =>
                {
                    taskManager.CompleteTask(index);
                    RefreshTaskUI();
                };

                //Delete button
                Button btnDelete = new Button();
                btnDelete.Text = "X";
                btnDelete.Width = 30;
                btnDelete.Height = 30;
                btnDelete.Left = 35;
                btnDelete.Tag = index;
                btnDelete.Click += (s, e) =>
                {
                    taskManager.DeleteTask(index);
                    RefreshTaskUI();
                };

                //Label
                Label lbl = new Label();
                lbl.Text = $"{active[i].Title} - {active[i].Description}";
                lbl.Left = 70;
                lbl.Width = p.Width - 80;
                lbl.Top = 15;

                p.Controls.Add(btnComplete);
                p.Controls.Add(btnDelete);
                p.Controls.Add(lbl);

                taskPanel.Controls.Add(p);
            }

            // ========================
            // COMPLETED TASKS
            // ========================

            var completed = taskManager.CompletedTasks;

            for (int i = 0; i < completed.Count; i++)
            {
                int index = taskManager.Tasks.ToList().IndexOf(completed[i]);   // FIXED

                Panel p = new Panel();
                p.Width = completedTaskPanel.Width - 25;
                p.Height = 50;
                p.Margin = new Padding(5);

                //Undo button
                Button btnUndo = new Button();
                btnUndo.Text = "↩";
                btnUndo.Width = 30;
                btnUndo.Height = 30;
                btnUndo.Left = 0;
                btnUndo.Tag = index;
                btnUndo.Click += (s, e) =>
                {
                    taskManager.UncompleteTask(index);
                    RefreshTaskUI();
                };

                //Delete button
                Button btnDeleteDone = new Button();
                btnDeleteDone.Text = "X";
                btnDeleteDone.Width = 30;
                btnDeleteDone.Height = 30;
                btnDeleteDone.Left = 35;
                btnDeleteDone.Tag = index;
                btnDeleteDone.Click += (s, e) =>
                {
                    taskManager.DeleteTask(index);
                    RefreshTaskUI();
                };

                //Label
                Label lbl = new Label();
                lbl.Text = $"{completed[i].Title} - {completed[i].Description}";
                lbl.Left = 70;
                lbl.Width = p.Width - 80;
                lbl.Top = 15;
                lbl.ForeColor = Color.Green;

                p.Controls.Add(btnUndo);
                p.Controls.Add(btnDeleteDone);
                p.Controls.Add(lbl);

                completedTaskPanel.Controls.Add(p);
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string title = txtTitleBox.Text.Trim();
            string desc = txtDescriptionBox.Text.Trim();

            if (title.Length == 0)
            {
                lblNoTitle.Text = "PLEASE ADD A TITLE";
                return;
            }

            taskManager.AddTasks(title, desc);

            txtTitleBox.Clear();
            txtDescriptionBox.Clear();
            lblNoTitle.Text = "";

            RefreshTaskUI();
        }
    }
}
