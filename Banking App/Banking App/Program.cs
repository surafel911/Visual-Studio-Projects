using System;
using System.Windows.Forms;

using Library;
using Model;
using Presenter;
using View;

namespace Banking_App
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

            IBankModel model = new BankModel();
            BankView view = new BankView();
            BankPresenter presenter = new BankPresenter(model, view);

            Application.Run(view);
        }
    }
}
