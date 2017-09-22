using System;

using Library;

namespace Presenter
{
    public class BankPresenter
    {
        private IBankModel _model;
        private IBankView _view;

        public BankPresenter(IBankModel model, IBankView view)
        {
            _model = model;
            _view = view;
            UpdateModelFromView();
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            _view.ButtonClicked += _view_ButtonClicked;
            _view.FirstNameChanged += _view_FirstNameChanged;
            _view.LastNameChanged += _view_LastNameChanged;
            _view.SocialSecurityChanged += _view_SocialSecurityChanged;
        }

        private void _view_ButtonClicked(object sender, ButtonClickedEventArgs e)
        {
            _view.PresentName(_model.GetFirstName());

            _view.PresentName(e.LastName);
        }
        
        private void _view_FirstNameChanged(object sender, EventArgs e)
        {
            _model.FirstName = _view.FirstName;
        }

        private void _view_LastNameChanged(object sender, EventArgs e)
        {
            _model.LastName = _view.LastName;
        }

        private void _view_SocialSecurityChanged(object sender, EventArgs e)
        {
            _model.SocialSecurity = _view.SocialSecurity;
        }

        private void UpdateModelFromView()
        {
            _model.FirstName = _view.FirstName;
            _model.LastName = _view.LastName;
            _model.SocialSecurity = _view.SocialSecurity;
            _model.PhoneNumber = _view.PhoneNumber;
        }
    }
}
