using System;

namespace Interfaces
{
    public interface ITTTGameView
    {
        event EventHandler ReplayButtonClicked;
        event EventHandler QuitButtonClicked;
        event EventHandler TileClicked;

        string Value { set; }
        bool Winner { set; }
        TileLocation TileLocation { get; }

        void Show();
        void Close();
        void PresentWinner(string winningPlayer);
        void PresentScore(string playerOneName, int playerOneScore, string playerTwoName, int playerTwoScore);
        void ResetTiles();
    }
}
