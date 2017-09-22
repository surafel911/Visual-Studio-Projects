using System;
using System.Collections.Generic;

namespace Library
{
    public interface INewTaskModel
    {
        event EventHandler SubTaskListChanged;

        Task NewTask { get; }
        List<SubTask> SubTasks { get; }
        string Title { set; }
        string Description { set; }

        void AddSubTask(SubTask task);
    }
}
