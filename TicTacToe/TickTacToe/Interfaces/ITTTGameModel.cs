namespace Interfaces
{
    public class TileLocation
    {
        public int X { get; set; }
        public int Y { get; set; }

        public TileLocation(int x, int y)
        {
            SetValues(x, y);
        }

        public void SetValues(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public bool Won { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
            Won = false;
        }
    }

    public interface ITTTGameModel
    {
        bool IsXTurn { get; }
        bool Winner { get; }
        string WinningPlayer { get; }
        int PlayerOneScore { get; }
        int PlayerTwoScore { get; }
        string PlayerOneName { get; }
        string PlayerTwoName { get; }
        TileLocation TileLocation { set; }

        void ResetGame();
        bool CheckWinner();
        void SwitchTurns();
        string SetValue();
    }
}
