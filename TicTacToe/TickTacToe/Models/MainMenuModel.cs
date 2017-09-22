using Interfaces;

namespace Models
{
    public class MainMenuModel : IMainMenuModel
    {
        private string _playerOneName;
        private string _playerTwoName;
        private bool _playClicked;

        public string PlayerOneName
        {
            get { return _playerOneName; }

            set { _playerOneName = value; }
        }

        public string PlayerTwoName
        {
            get { return _playerTwoName; }

            set { _playerTwoName = value; }
        }

        public bool PlayClicked
        {
            get { return _playClicked; }

            set { _playClicked = value; }
        }
    }
}
