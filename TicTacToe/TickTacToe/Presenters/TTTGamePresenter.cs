using System;

using Interfaces;

namespace Presenters
{
    public class TTTGamePresenter
    {
        private ITTTGameModel _model;
        private ITTTGameView _view;

        public TTTGamePresenter(ITTTGameModel model, ITTTGameView view)
        {
            _model = model;
            _view = view;
            UpdateModelInfo();
            WireUpEvents();
        }

        private void UpdateModelInfo()
        {
            _model.TileLocation = _view.TileLocation;
        }

        private void WireUpEvents()
        {
            _view.ReplayButtonClicked += _view_ReplayButtonClicked;
            _view.QuitButtonClicked += _view_QuitButtonClicked;
            _view.TileClicked += _view_TileClicked;
        }
        
        private void _view_ReplayButtonClicked(object sender, EventArgs e)
        {
            _model.ResetGame();
            _view.ResetTiles();
            _view.Winner = _model.Winner;
        }

        private void _view_QuitButtonClicked(object sender, EventArgs e)
        {
            _view.PresentScore(_model.PlayerOneName, _model.PlayerOneScore, _model.PlayerTwoName, _model.PlayerTwoScore);
            _view.Close();
        }

        private void _view_TileClicked(object sender, EventArgs e)
        {
            UpdateModelInfo();
            _view.Value = _model.SetValue();

            if (_model.CheckWinner())
            {
                _view.Winner = _model.Winner;
                _view.PresentWinner(_model.WinningPlayer);
            }

            _model.SwitchTurns();
        }
    }
}
