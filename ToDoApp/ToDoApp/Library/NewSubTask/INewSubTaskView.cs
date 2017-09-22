using System;
using System.Windows.Forms;

namespace Library
{
    public interface INewSubTaskView
    {
        event EventHandler CreateSubTaskButtonClicked;
        event EventHandler CancelButtonClicked;
        event EventHandler TitleTextBoxChanged;
        event EventHandler DescriptionTextBoxChanged;

        DialogResult Result { set; }
        string Title { get; }
        string Description { get; }
    }
}
