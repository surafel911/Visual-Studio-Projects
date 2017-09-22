using System;

namespace Library
{
    public class BrowserLocationChangedEventArgs : EventArgs
    {
        public string Location { get; set; }

        public BrowserLocationChangedEventArgs() : base()
        { }
        
        public BrowserLocationChangedEventArgs(string location) : base()
        {
            Location = location;
        }
    }

    public class TransferButtonClickedEventArgs : EventArgs
    {
        public string Message { get; set; }

        public TransferButtonClickedEventArgs() : base()
        { }

        public TransferButtonClickedEventArgs(string message) : base()
        {
            Message = message;
        }
    }

    public interface IFileTransferView
    {
        event EventHandler<BrowserLocationChangedEventArgs> SourceBrowserButtonClicked;
        event EventHandler<BrowserLocationChangedEventArgs> TargetBrowserButtonClicked;
        event EventHandler<TransferButtonClickedEventArgs> TransferButtonClicked;
        event EventHandler SourceTextBoxChanged;
        event EventHandler TargetTextBoxChanged;

        bool TransferSuccessful { set; }

        string Source { get; }
        string Target { get; }

        void Show();
        void Close();
    }
}
