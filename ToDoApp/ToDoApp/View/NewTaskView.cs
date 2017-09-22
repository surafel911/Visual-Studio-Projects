using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Library;

namespace View
{
    public partial class NewTaskView : Form, INewTaskView
    {
        private List<SubTask> _subTask;

        public event EventHandler CreateTaskButtonClicked;
        public event EventHandler CreateSubTaskClicked;
        public event EventHandler CancelButtonClicked;
        public event EventHandler DescriptionTextBoxChanged;
        public event EventHandler TitleTextBoxChanged;

        public DialogResult Result { set { DialogResult = value; } }

        public List<SubTask> SubTasks
        {
            set
            {
                _subTask = value;
                treeView.Nodes.Clear();

                foreach (SubTask task in _subTask)
                {
                    treeView.Nodes.Add(task.Title);

                    foreach (TreeNode node in treeView.Nodes)
                    {
                        if (node.Text == task.Title)
                        {
                            node.ToolTipText = task.Description;
                            node.Checked = task.Completed;
                        }
                    }
                }
            }
        }

        public string Title { get { return titleTextBox.Text; } }

        public string Description { get { return descriptionTextBox.Text; } }

        public NewTaskView()
        {
            InitializeComponent();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TitleTextBoxChanged != null)
            {
                TitleTextBoxChanged(sender, e);
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionTextBoxChanged != null)
            {
                DescriptionTextBoxChanged(sender, e);
            }
        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            if (CreateTaskButtonClicked != null)
            {
                CreateTaskButtonClicked(sender, e);
            }
        }

        private void createSubTaskButton_Click(object sender, EventArgs e)
        {
            Enabled = false;

            if (CreateSubTaskClicked != null)
            {
                CreateSubTaskClicked(sender, e);
            }

            Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (CancelButtonClicked != null)
            {
                CancelButtonClicked(sender, e);
            }
        }
    }
}
