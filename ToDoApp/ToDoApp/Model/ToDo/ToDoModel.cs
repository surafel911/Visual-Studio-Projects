using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Library;

namespace Model
{
    public class ToDoModel : IToDoModel
    {
        private List<Task> _tasks;

        public event EventHandler TaskListChanged;

        public List<Task> Tasks
        {
            get { return _tasks; }
        }

        public ToDoModel()
        {
            _tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
            
            if (TaskListChanged != null)
            {
                TaskListChanged(this, new EventArgs());
            }
        }

        public void RemoveTask(TreeNode node)
        {
            foreach (Task task in _tasks)
            {
                if (string.Equals(task.Title, node.Text) && string.Equals(task.Description, node.ToolTipText))
                {
                    _tasks.Remove(task);
                    break;
                }

                foreach (SubTask subTask in task.SubTasks)
                {
                    if (string.Equals(subTask.Title, node.Text) && string.Equals(subTask.Description, node.ToolTipText))
                    {
                        task.SubTasks.Remove(subTask);
                        break;
                    }
                }
            }

            if (TaskListChanged != null)
            {
                TaskListChanged(this, new EventArgs());
            }
        }

        public void SaveTasks()
        {
            // File Stuff!
        }
    }
}
