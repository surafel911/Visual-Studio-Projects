using System;
using System.Windows.Forms;

namespace Start
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

            DTApp app = new DTApp();
            app.Run();
        }
    }
}
