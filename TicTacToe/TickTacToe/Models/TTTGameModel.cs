using Interfaces;

namespace Models
{
    public class TTTGameModel : ITTTGameModel
    {
        private bool _isXTurn;
        private bool _winner;
        private int[,] _tileValues;
        private TileLocation _tileLocation;
        private Player _playerOne;
        private Player _playerTwo;

        private const int PlayerOne = 1;
        private const int PlayerTwo = 2;

        public string PlayerOneName
        {
            get { return _playerOne.Name; }
        }

        public string PlayerTwoName
        {
            get { return _playerTwo.Name; }
        }

        public int PlayerOneScore
        {
            get { return _playerOne.Score; }
        }

        public int PlayerTwoScore
        {
            get { return _playerTwo.Score; }
        }

        public bool IsXTurn
        {
            get { return _isXTurn; }
        }

        public TileLocation TileLocation
        {
            set { _tileLocation = value; }
        }

        public string WinningPlayer
        {
            get
            {
                if (_playerOne.Won)
                {
                    return _playerOne.Name;
                }
                else
                {
                    return _playerTwo.Name;
                }
            }
        }

        public bool Winner
        {
            get { return _winner; }
        }

        public void ResetGame()
        {
            _tileValues = null;
            _tileValues = new int[3, 3];

            for (int row = 0; row < 3; row ++)
            {
                for (int col = 0; col < 3; col++)
                {
                    _tileValues[row, col] = 0;
                }
            }

            _playerOne.Won = false;
            _playerTwo.Won = false;
            _isXTurn = true;
            _winner = false;
        }
        
        public void SwitchTurns()
        {
            _isXTurn = !_isXTurn;
        }

        public string SetValue()
        {
            if (_isXTurn)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }

        public bool CheckWinner()
        {
            bool rval = false;

            if (_isXTurn)
            {
                _tileValues[_tileLocation.X, _tileLocation.Y] = PlayerOne;
            }
            else
            {
                _tileValues[_tileLocation.X, _tileLocation.Y] = PlayerTwo;
            }
            
            // Horizontal //
            for (int row = 0; row < 3; row++)
            {
                if (_tileValues[row, 0] == PlayerTwo && _tileValues[row, 1] == PlayerTwo && _tileValues[row, 2] == PlayerTwo)
                {
                    rval = true;
                    _playerTwo.Won = true;
                    _playerTwo.Score++;
                    _winner = true;
                }
                else if (_tileValues[row, 0] == PlayerOne && _tileValues[row, 1] == PlayerOne && _tileValues[row, 2] == PlayerOne)
                {
                    rval = true;
                    _playerOne.Won = true;
                    _playerOne.Score++;
                    _winner = true;
                }
            }

            // Verticle //
            for (int col = 0; col < 3; col++)
            {
                if (_tileValues[0, col] == PlayerTwo && _tileValues[1, col] == PlayerTwo && _tileValues[2, col] == PlayerTwo)
                {
                    rval = true;
                    _playerTwo.Won = true;
                    _playerTwo.Score++;
                    _winner = true;
                }
                else if (_tileValues[0, col] == PlayerOne && _tileValues[1, col] == PlayerOne && _tileValues[2, col] == PlayerOne)
                {
                    rval = true;
                    _playerOne.Won = true;
                    _playerOne.Score++;
                    _winner = true;
                }
            }

            // Diagonal - Left//
            if (_tileValues[0, 0] == PlayerTwo && _tileValues[1, 1] == PlayerTwo && _tileValues[2, 2] == PlayerTwo)
            {
                rval = true;
                _playerTwo.Won = true;
                _playerTwo.Score++;
                _winner = true;
            }
            else if (_tileValues[0, 0] == PlayerOne && _tileValues[1, 1] == PlayerOne && _tileValues[2, 2] == PlayerOne)
            {
                rval = true;
                _playerOne.Won = true;
                _playerOne.Score++;
                _winner = true;
            }

            // Diagonal - Right //
            if (_tileValues[0, 2] == PlayerTwo && _tileValues[1, 1] == PlayerTwo && _tileValues[2, 0] == PlayerTwo)
            {
                rval = true;
                _playerTwo.Won = true;
                _playerTwo.Score++;
                _winner = true;
            }
            else if (_tileValues[0, 2] == PlayerOne && _tileValues[1, 1] == PlayerOne && _tileValues[2, 0] == PlayerOne)
            {
                rval = true;
                _playerOne.Won = true;
                _playerOne.Score++;
                _winner = true;
            }

            return rval;
        }

        public TTTGameModel(IMainMenuModel model)
        {
            _playerOne = new Player(model.PlayerOneName);
            _playerTwo = new Player(model.PlayerTwoName);
            ResetGame();
        }
    }
}
