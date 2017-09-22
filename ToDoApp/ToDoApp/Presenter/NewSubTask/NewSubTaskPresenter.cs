using System;
using System.Windows.Forms;

using Library;

namespace Presenter
{
    public class NewSubTaskPresenter
    {
        private INewSubTaskModel _model;
        private INewSubTaskView _view;

        public NewSubTaskPresenter(INewSubTaskModel model, INewSubTaskView view)
        {
            _model = model;
            _view = view;
            WireUpEvents();
            UpdateModelFromView();
        }

        private void WireUpEvents()
        {
            _view.CreateSubTaskButtonClicked += _view_CreateSubTaskButtonClicked;
            _view.CancelButtonClicked += _view_CancelButtonClicked;
            _view.TitleTextBoxChanged += _view_TitleTextBoxChanged;
            _view.DescriptionTextBoxChanged += _view_DescriptionTextBoxChanged;
        }

        private void UpdateModelFromView()
        {
            _model.Title = _view.Title;
            _model.Description = _view.Description;
        }

        private void _view_CreateSubTaskButtonClicked(object sender, EventArgs e)
        {
            _view.Result = DialogResult.OK;
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
            _model.Description = _view.Description;
        }
    }
}
