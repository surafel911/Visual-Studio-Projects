using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{

    public interface IToDoModel
    {
        event EventHandler TaskListChanged;

        List<Task> Tasks { get; }

        void AddTask(Task task);
        void RemoveTask(TreeNode node);
        void SaveTasks();
    }
}
