using System;
using System.Windows.Forms;

using Library;
using Model;
using Presenter;
using View;

namespace ToDoApp
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

            IToDoModel model = new ToDoModel();
            ToDoView view = new ToDoView();
            ToDoPresenter presenter = new ToDoPresenter(model, view);

            Application.Run(view);
        }
    }
}
