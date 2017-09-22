using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public class CreateTaskButtonEventArgs : EventArgs
    {
        public Task SelectedTask { get; set; }

        public CreateTaskButtonEventArgs() : base()
        { }

        public CreateTaskButtonEventArgs(Task task) : base()
        {
            SelectedTask = task;
        }
    }

    public class DeleteNodeButtonEventArgs : EventArgs
    {
        public  TreeNode SelectedNode { get; set; }

        public DeleteNodeButtonEventArgs() : base()
        { }

        public DeleteNodeButtonEventArgs(TreeNode node) : base()
        {
            SelectedNode = node;
        }
    }

    public interface IToDoView
    {
        event EventHandler<DeleteNodeButtonEventArgs> DeleteTaskButtonClicked;
        event EventHandler CreateTaskButtonClicked;

        void Show();
        void Close();

        List<Task> Tasks { set; }
    }
}
