using System;

using Library;

namespace Presenter
{
    public class FileTransferPresenter
    {
        private IFIleTransferModel _model;
        private IFileTransferView _view;

        public FileTransferPresenter(IFIleTransferModel model, IFileTransferView view)
        {
            _model = model;
            _view = view;
            UpdateModelFromView();
            WireUpEvents();
        }

        private void UpdateModelFromView()
        {
            _model.Source = _view.Source;
            _model.Target = _view.Target;
        }

        private void WireUpEvents()
        {
            _view.SourceBrowserButtonClicked += _view_BrowserButtonClicked;
            _view.TargetBrowserButtonClicked += _view_BrowserButtonClicked;
            _view.TransferButtonClicked += _view_TransferButtonClicked;
            _view.SourceTextBoxChanged += _view_SourceTextBoxChanged;
            _view.TargetTextBoxChanged += _view_TargetTextBoxChanged;
        }

        private void _view_BrowserButtonClicked(object sender, BrowserLocationChangedEventArgs e)
        {
            string location = string.Empty;
            _model.OpenFileBrowser(out location);
            e.Location = location;
        }

        private void _view_TransferButtonClicked(object sender, TransferButtonClickedEventArgs e)
        {
            string message = string.Empty;
            _view.TransferSuccessful = _model.TransferFiles(out message);
            e.Message = message;
        }

        private void _view_SourceTextBoxChanged(object sender, EventArgs e)
        {
            _model.Source = _view.Source;
        }

        private void _view_TargetTextBoxChanged(object sender, EventArgs e)
        {
            _model.Target = _view.Target;
        }


    }
}
