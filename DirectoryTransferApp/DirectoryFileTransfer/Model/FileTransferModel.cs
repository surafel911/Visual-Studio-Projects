using System.IO;
using System.Windows.Forms;

using Library;

namespace Model
{
    public class FileTransferModel : IFIleTransferModel
    {
        private string _sourcePath;
        private string _targetPath;

        public string Source { set { _sourcePath = value; } }

        public string Target { set { _targetPath = value; } }

        public bool TransferFiles(out string message)
        {
            bool rval = false;
            message = string.Empty;

            if (string.IsNullOrEmpty(_sourcePath) || string.IsNullOrEmpty(_targetPath))
            {
                message = "Missing a folder path";
            }
            else if (!Directory.Exists(_sourcePath))
            {
                message = "Source folder path does not exist.";
            }
            else
            {
                if (!Directory.Exists(_targetPath))
                {
                    Directory.CreateDirectory(_targetPath);
                }

                string[] files = Directory.GetFiles(_sourcePath);

                foreach (string file in files)
                { string fileName = Path.GetFileName(file);
                    string targetFilePath = Path.Combine(_targetPath, fileName);
                    File.Copy(file, targetFilePath, true);
                }

                string[] directories = Directory.GetDirectories(_sourcePath);

                foreach (string directory in directories)
                {
                    DirectoryInfo dir = new DirectoryInfo(directory);
                    string directoryName = dir.Name;
                    string targetDirectoryPath = Path.Combine(_targetPath, directoryName);
                    Directory.CreateDirectory(targetDirectoryPath);

                    string[] directoryFiles = Directory.GetFiles(directory);

                    foreach (string file in directoryFiles)
                    {
                        string fileName = Path.GetFileName(file);
                        string targetFilePath = Path.Combine(targetDirectoryPath, fileName);
                        File.Copy(file, targetFilePath, true);
                    }
                }

                rval = true;
                message = "File transfer complete";
            }

            return rval;
        }

        public void OpenFileBrowser(out string location)
        {
            location = string.Empty;

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    location = dialog.SelectedPath;
                }
            }

        }
    }
}
