namespace Library
{
    public interface IFIleTransferModel
    {
        string Source { set; }
        string Target { set; }

        bool TransferFiles(out string message);
        void OpenFileBrowser(out string location);
    }
}
