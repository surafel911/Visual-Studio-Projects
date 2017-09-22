using System;
using System.Windows.Forms;

namespace TickTacToe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GameApplication app = new GameApplication();

            app.Run();
        }
    }
}
