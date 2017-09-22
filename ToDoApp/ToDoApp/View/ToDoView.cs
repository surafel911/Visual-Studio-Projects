using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Library;

namespace View
{
    public partial class ToDoView : Form, IToDoView
    {
        private List<Task> _tasks;

        public event EventHandler<DeleteNodeButtonEventArgs> DeleteTaskButtonClicked;
        public event EventHandler CreateTaskButtonClicked;

        public List<Task> Tasks
        {
            set
            {
                _tasks = value;
                treeView.Nodes.Clear();

                foreach (Task task in _tasks)
                {
                    treeView.Nodes.Add(task.Title);

                    foreach (TreeNode node in treeView.Nodes)
                    {
                        if (node.Text == task.Title)
                        {
                            node.ToolTipText = task.Description;
                            node.Checked = task.Completed;

                            foreach (SubTask subTask in task.SubTasks)
                            {
                                node.Nodes.Add(subTask.Title);

                                foreach (TreeNode subNode in node.Nodes)
                                {
                                    if (subNode.Text == subTask.Title)
                                    {
                                        subNode.ToolTipText = subTask.Description;
                                        subNode.Checked = subTask.Completed;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public ToDoView()
        {
            InitializeComponent();
            treeView.CheckBoxes = true;
        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            Enabled = false;

            if (CreateTaskButtonClicked != null)
            {
                CreateTaskButtonClicked(sender, e);
            }

            Enabled = true;
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if (DeleteTaskButtonClicked != null)
            {
                DeleteNodeButtonEventArgs args = new DeleteNodeButtonEventArgs(treeView.SelectedNode);
                DeleteTaskButtonClicked(sender, args);
            }
        }
    }
}

