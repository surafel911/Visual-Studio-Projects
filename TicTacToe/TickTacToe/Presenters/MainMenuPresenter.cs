using System;

using Interfaces;

namespace Presenters
{
    public class MainMenuPresenter
    {
        private IMainMenuModel _model;
        private IMainMenuView _view;

        public MainMenuPresenter(IMainMenuModel model, IMainMenuView view)
        {
            _model = model;
            _view = view;
            UpdateModelInfo();
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            _view.PlayerOneNameChanged += _view_PlayerOneNameChanged;
            _view.PlayerTwoNameChanged += _view_PlayerTwoNameChanged;
            _view.PlayButtonClicked += _view_PlayButtonClicked;
            _view.QuitButtonClicked += _view_QuitButtonClicked;
        }

        private void _view_PlayerOneNameChanged(object sender, EventArgs e)
        {
            _model.PlayerOneName = _view.PlayerOneName;
        }

        private void _view_PlayerTwoNameChanged(object sender, EventArgs e)
        {
            _model.PlayerTwoName = _view.PlayerTwoName;
        }

        private void _view_PlayButtonClicked(object sender, EventArgs e)
        {
            _model.PlayClicked = true;
            _view.Close();
        }

        private void _view_QuitButtonClicked(object sender, EventArgs e)
        {
            _view.Close();
        }

        private void UpdateModelInfo()
        {
            _model.PlayerOneName = _view.PlayerOneName;
            _model.PlayerTwoName = _view.PlayerTwoName;
            _model.PlayClicked = false;
        }
    }
}
