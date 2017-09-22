using System;
using System.Windows.Forms;

using Library;

namespace View
{
    public partial class FileTransferView : Form, IFileTransferView
    {
        private bool _transferSuccessful;

        public event EventHandler<BrowserLocationChangedEventArgs> SourceBrowserButtonClicked;
        public event EventHandler<BrowserLocationChangedEventArgs> TargetBrowserButtonClicked;
        public event EventHandler<TransferButtonClickedEventArgs> TransferButtonClicked;
        public event EventHandler SourceTextBoxChanged;
        public event EventHandler TargetTextBoxChanged;

        public string Source { get { return sourceTextBox.Text; } }

        public string Target { get { return targetTextBox.Text; } }

        public bool TransferSuccessful { set { _transferSuccessful = value; } }

        public FileTransferView()
        {
            InitializeComponent();
            _transferSuccessful = false;
        }

        private void sourceBrowseButton_Click(object sender, EventArgs e)
        {
            if (SourceBrowserButtonClicked != null)
            {
                BrowserLocationChangedEventArgs args = new BrowserLocationChangedEventArgs();

                SourceBrowserButtonClicked(sender, args);
                sourceTextBox.Text = args.Location;
            }
        }

        private void targetBrowseButton_Click(object sender, EventArgs e)
        {
            if (TargetBrowserButtonClicked != null)
            {
                BrowserLocationChangedEventArgs args = new BrowserLocationChangedEventArgs();

                TargetBrowserButtonClicked(sender, args);
                targetTextBox.Text = args.Location;
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            TransferButtonClickedEventArgs args = new TransferButtonClickedEventArgs();

            if (TransferButtonClicked != null)
            {
                TransferButtonClicked(sender, args);
            }

            Cursor.Current = Cursors.Default;

            if (_transferSuccessful)
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show(args.Message);
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show(args.Message);
            }
        }

        private void sourceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SourceTextBoxChanged != null)
            {
                SourceTextBoxChanged(sender, e);
            }
        }

        private void targetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TargetTextBoxChanged != null)
            {
                TargetTextBoxChanged(sender, e);
            }
        }
    }
}
