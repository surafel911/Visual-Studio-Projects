using System;
using System.Windows.Forms;

using Interfaces;

namespace Views
{
    public partial class TTTGame : Form, ITTTGameView
    {
        private string _value;
        private bool _winner;
        private TileLocation _tileLocation;

        public event EventHandler ReplayButtonClicked;
        public event EventHandler QuitButtonClicked;
        public event EventHandler TileClicked;

        public string Value
        {
            set { _value = value; }
        }

        public TileLocation TileLocation
        {
            get { return _tileLocation; }
        }

        public bool Winner
        {
            set { _winner = value; }
        }

        public void PresentScore(string playerOneName, int playerOneScore, string playerTwoName, int playerTwoScore)
        {
            MessageBox.Show(playerOneName + "'s Score: " + playerOneScore.ToString() + Environment.NewLine +
                            playerTwoName + "'s Score: " + playerTwoScore.ToString());
        }

        public void ResetTiles()
        {
            tile1.Text = string.Empty;
            tile2.Text = string.Empty;
            tile3.Text = string.Empty;
            tile4.Text = string.Empty;
            tile5.Text = string.Empty;
            tile6.Text = string.Empty;
            tile7.Text = string.Empty;
            tile8.Text = string.Empty;
            tile9.Text = string.Empty;
        }

        public void PresentWinner(string winningPlayer)
        {
            MessageBox.Show(winningPlayer + " won!");
        }

        public TTTGame()
        {
            InitializeComponent();
            _tileLocation = new TileLocation(0, 0);
            _winner = false;
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            if (ReplayButtonClicked != null)
            {
                ReplayButtonClicked(this, e);
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            if (QuitButtonClicked != null)
            {
                QuitButtonClicked(this, e);
            }
        }

        private void tile1_Click(object sender, MouseEventArgs e)
        {
            if (TileClicked != null && string.IsNullOrEmpty(tile1.Text) && !_winner)
            {
                _tileLocation.SetValues(0, 0);
                TileClicked(this, e);
                tile1.Text = " " + _value;
            }
        }

        private void tile2_Click(object sender, MouseEventArgs e)
        {
            if (TileClicked != null && string.IsNullOrEmpty(tile2.Text) && !_winner)
            {
                _tileLocation.SetValues(0, 1);
                TileClicked(this, e);
                tile2.Text = " " + _value;
            }
        }

        private void tile3_Click(object sender, MouseEventArgs e)
        {
            if (TileClicked != null && string.IsNullOrEmpty(tile3.Text) && !_winner)
            {
                _tileLocation.SetValues(0, 2);
                TileClicked(this, e);
                tile3.Text = " " + _value;
            }
        }

        private void tile4_Click(object sender, MouseEventArgs e)
        {
            if (TileClicked != null && string.IsNullOrEmpty(tile4.Text) && !_winner)
            {
                _tileLocation.SetValues(1, 0);
                TileClicked(this, e);
                tile4.Text = " " + _value;
            }
        }

        private void tile5_Click(object sender, MouseEventArgs e)
        {
            if (TileClicked != null && string.IsNullOrEmpty(tile5.Text) && !_winner)
            {
                _tileLocation.SetValues(1, 1);
                TileClicked(this, e);
                tile5.Text = " " + _value;
            }
        }

        private void tile6_Click(object sender, MouseEventArgs e)
        {
            if (TileClicked != null && string.IsNullOrEmpty(tile6.Text) && !_winner)
            {
                _tileLocation.SetValues(1, 2);
                TileClicked(this, e);
                tile6.Text = " " + _value;
            }
        }

        private void tile7_Click(object sender, MouseEventArgs e)
        {
            if (TileClicked != null && string.IsNullOrEmpty(tile7.Text) && !_winner)
            {
                _tileLocation.SetValues(2, 0);
                TileClicked(this, e);
                tile7.Text = " " + _value;
            }
        }

        private void tile8_Click(object sender, MouseEventArgs e)
        {
            if (TileClicked != null && string.IsNullOrEmpty(tile8.Text) && !_winner)
            {
                _tileLocation.SetValues(2, 1);
                TileClicked(this, e);
                tile8.Text = " " + _value;
            }
        }

        private void tile9_Click(object sender, MouseEventArgs e)
        {
            if (TileClicked != null && string.IsNullOrEmpty(tile9.Text) && !_winner)
            {
                _tileLocation.SetValues(2, 2);
                TileClicked(this, e);
                tile9.Text = " " + _value;
            }
        }
    }
}
