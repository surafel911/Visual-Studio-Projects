using System;
using System.Windows.Forms;

using Library;
using Model;
using View;

namespace Presenter
{
    public class NewTaskPresenter
    {
        private INewTaskModel _model;
        private INewTaskView _view;

        public NewTaskPresenter(INewTaskModel model, INewTaskView view)
        {
            _model = model;
            _view = view;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            _view.TitleTextBoxChanged += _view_TitleTextBoxChanged;
            _view.DescriptionTextBoxChanged += _view_DescriptionTextBoxChanged;
            _view.CreateTaskButtonClicked += _view_CreateTaskButtonClicked;
            _view.CreateSubTaskClicked += _view_CreateSubTaskClicked;
            _view.CancelButtonClicked += _view_CancelButtonClicked;
            _model.SubTaskListChanged += _model_SubTaskListChanged;
        }

        private void UpdateModelFromView()
        {
            _model.Title = _view.Title;
            _model.Description = _view.Description;
            _view.SubTasks = _model.SubTasks;
        }

        private void _view_CreateTaskButtonClicked(object sender, EventArgs e)
        {
            _view.Result = DialogResult.OK;
        }

        private void _view_CreateSubTaskClicked(object sender, EventArgs e)
        {
            INewSubTaskModel model = new NewSubTaskModel();
            NewSubTaskView view = new NewSubTaskView();
            NewSubTaskPresenter presenter = new NewSubTaskPresenter(model, view);

            DialogResult result = view.ShowDialog();

            if (result != DialogResult.None)
            {
                if (result == DialogResult.OK)
                {
                    _model.AddSubTask(model.NewSubTask);
                }

                view.Close();
            }
        }

        private void _view_CancelButtonClicked(object sender, EventArgs e)
        {
            _view.Result = DialogResult.Cancel;
        }

        private void _view_TitleTextBoxChanged(object sender, EventArgs e)
        {
            _model.Title = _view.Title;
        }

        private void _view_DescriptionTextBoxChanged(object sender, EventArgs e)
        {
            _model.Title = _view.Title;
        }

        private void _model_SubTaskListChanged(object sender, EventArgs e)
        {
            _view.SubTasks = _model.SubTasks;
        }
    }
}
