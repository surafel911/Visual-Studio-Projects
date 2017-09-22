using System;
using System.Windows.Forms;

using Library;

namespace View
{
    public partial class NewSubTaskView : Form, INewSubTaskView
    {
        public event EventHandler CreateSubTaskButtonClicked;
        public event EventHandler CancelButtonClicked;
        public event EventHandler TitleTextBoxChanged;
        public event EventHandler DescriptionTextBoxChanged;

        public DialogResult Result { set { DialogResult = value; } }

        public string Title { get { return titleTextBox.Text; } }

        public string Description { get { return descriptionTextBox.Text; } }

        public NewSubTaskView()
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

        private void createSubTaskButton_Click(object sender, EventArgs e)
        {
            if (CreateSubTaskButtonClicked != null)
            {
                CreateSubTaskButtonClicked(sender, e);
            }
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
