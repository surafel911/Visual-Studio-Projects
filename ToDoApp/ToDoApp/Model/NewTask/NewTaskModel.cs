using System;
using System.Collections.Generic;

using Library;

namespace Model
{
    public class NewTaskModel : INewTaskModel
    {
        private Task _newTask;

        public event EventHandler SubTaskListChanged;

        public Task NewTask { get { return _newTask; } }

        public List<SubTask> SubTasks { get { return _newTask.SubTasks; } }

        public string Title { set { _newTask.Title = value; } }

        public string Description { set { _newTask.Description = value; } }
        
        public NewTaskModel()
        {
            _newTask = new Task();
            _newTask.Completed = false;
            _newTask.SubTasks = new List<SubTask>();
        }

        public void AddSubTask(SubTask task)
        {
            _newTask.SubTasks.Add(task);

            if (SubTaskListChanged != null)
            {
                SubTaskListChanged(this, new EventArgs());
            }
        }
    }
}
