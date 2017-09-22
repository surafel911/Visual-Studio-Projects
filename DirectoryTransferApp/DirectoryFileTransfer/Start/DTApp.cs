using System.Windows.Forms;

using Library;
using Model;
using Presenter;
using View;

namespace Start
{
    public class DTApp
    {
        private IFIleTransferModel model;
        private FileTransferView view;
        private FileTransferPresenter presenter;


        public void Run()
        {
            model = new FileTransferModel();
            view = new FileTransferView();
            presenter = new FileTransferPresenter(model, view);

            DialogResult result = view.ShowDialog(); 

            if (result == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
    }
}
