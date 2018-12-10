using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Splitt
{
    public partial class MainForm : Form
    {
        // TODO Add progressbar

        #region Private Fields

        private readonly CancellationToken _cancellationToken;
        private readonly CancellationTokenSource _cancellationTokenSource;
        private FileData[] _filesData;
        private Split[] _splittingMultipleFiles;
        private Thread[] _splittingMultipleFilesThreads;

        #endregion

        #region Ctor

        public MainForm()
        {
            InitializeComponent();

            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;
        }

        #endregion

        #region Private Methods

        private void start_Click(object sender, EventArgs e)
        {

            if (_filesData.Length > 0)
            {
                FilesPreWork();
                CreateThreads();
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filesData = new[] { new FileData(_openFileDialog.FileName) };
                _txtBoxFilePath.Text = _filesData[0].FileName; // Possible Bug
                toolTip.SetToolTip(_txtBoxFilePath, _txtBoxFilePath.Text);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        #endregion

        private void loadFolder_Click(object sender, EventArgs e)
        {
            if (_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = _folderBrowserDialog.SelectedPath;
                string[] files = Directory.GetFiles(folderPath);

                _filesData = new FileData[files.Length];
                for (int i = 0; i < files.Length; i++)
                {
                    _filesData[i] = new FileData(files[i]);
                }

                _txtBoxFilePath.Text = folderPath;
                toolTip.SetToolTip(_txtBoxFilePath, _txtBoxFilePath.Text);
            }
        }

        private void FilesPreWork()
        {
            _splittingMultipleFiles = new Split[_filesData.Length];

            for (int i = 0; i < _splittingMultipleFiles.Length; i++)
            {
                _splittingMultipleFiles[i] = new Split(_filesData[i]);
                _splittingMultipleFiles[i].StartTime = _startTime.Value;
                _splittingMultipleFiles[i].EndTime = _endTime.Value;
                _splittingMultipleFiles[i].RemoveLineRegex = _txtBoxRemoveLineRegex.Text;
                _splittingMultipleFiles[i].RemoveLines = chkBoxRemoveLines.Checked;
            }
        }

        private void CreateThreads()
        {
            _splittingMultipleFilesThreads = new Thread[_filesData.Length];

            for (int i = 0; i < _splittingMultipleFilesThreads.Length; i++)
            {
                //Index Out of Bounds Exception without threadCopy!
                int threadCopy = i;
                _splittingMultipleFilesThreads[i] = new Thread(() => _splittingMultipleFiles[threadCopy].Start(_cancellationToken))
                {
                    Name = _filesData[i].Name
                };
            }

            foreach (Thread t in _splittingMultipleFilesThreads)
            {
                t.Start();
            }
        }
    }
}
