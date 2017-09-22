using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public interface INewTaskView
    {
        event EventHandler CreateTaskButtonClicked;
        event EventHandler CreateSubTaskClicked;
        event EventHandler CancelButtonClicked;
        event EventHandler DescriptionTextBoxChanged;
        event EventHandler TitleTextBoxChanged;

        DialogResult Result { set; }
        List<SubTask> SubTasks { set; }
        string Title { get; }
        string Description { get; }

        void Show();
        void Close();
    }
}
