using System;
using System.Windows.Forms;

using Library;
using Model;
using View;

namespace Presenter
{
    public class ToDoPresenter
    {
        private IToDoModel _model;
        private IToDoView _view;

        public ToDoPresenter(IToDoModel model, IToDoView view)
        {
            _model = model;
            _view = view;
            WireUpEvents();
            UpdateViewFromModel();
        }

        private void WireUpEvents()
        {
            _view.CreateTaskButtonClicked += _view_CreateTaskButtonClicked;
            _view.DeleteTaskButtonClicked += _view_DeleteTaskButtonClicked;
            _model.TaskListChanged += _model_TaskListChanged;
        }

        private void UpdateViewFromModel()
        {
            _view.Tasks = _model.Tasks;
        }

        private void _view_CreateTaskButtonClicked(object sender, EventArgs e)
        {
            INewTaskModel model = new NewTaskModel();
            NewTaskView view = new NewTaskView();
            NewTaskPresenter presenter = new NewTaskPresenter(model, view);

            DialogResult result = view.ShowDialog();

            if (result != DialogResult.None)
            {
                if (result == DialogResult.OK)
                {
                    _model.AddTask(model.NewTask);
                }

                view.Close();
            }
        }

        private void _view_DeleteTaskButtonClicked(object sender, DeleteNodeButtonEventArgs e)
        {
            _model.RemoveTask(e.SelectedNode);
        }

        private void _model_TaskListChanged(object sender, EventArgs e)
        {
            _view.Tasks = _model.Tasks;
            _model.SaveTasks();
        }
    }
}
