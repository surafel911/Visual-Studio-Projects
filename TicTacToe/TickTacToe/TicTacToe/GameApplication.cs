using System.Windows.Forms;

using Interfaces;
using Models;
using Presenters;
using Views;

namespace TickTacToe
{
    public class GameApplication
    {
        private IMainMenuModel mainMenuModel;
        private GMainMenu mainMenuView;
        private MainMenuPresenter mainMenuPresenter;

        private ITTTGameModel tttModel;
        private TTTGame tttView;
        private TTTGamePresenter tttPresenter;

        public void Run()
        {
            RunMainMenu();

            if (mainMenuModel.PlayClicked)
            {
                RunTTTGame();
            }

            Application.Exit();
        }

        private void RunMainMenu()
        {
            mainMenuModel = new MainMenuModel();
            mainMenuView = new GMainMenu();
            mainMenuPresenter = new MainMenuPresenter(mainMenuModel, mainMenuView);

            Application.Run(mainMenuView);
        }

        private void RunTTTGame()
        {
            tttModel = new TTTGameModel(mainMenuModel);
            tttView = new TTTGame();
            tttPresenter = new TTTGamePresenter(tttModel, tttView);

            Application.Run(tttView);
        }
    }
}
