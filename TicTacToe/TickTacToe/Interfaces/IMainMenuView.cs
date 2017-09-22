using System;

namespace Interfaces
{
    public interface IMainMenuView
    {
        event EventHandler PlayerOneNameChanged;
        event EventHandler PlayerTwoNameChanged;
        event EventHandler PlayButtonClicked;
        event EventHandler QuitButtonClicked;

        string PlayerOneName { get; set; }
        string PlayerTwoName { get; set; }

        void Show();
        void Close();
    }
}
