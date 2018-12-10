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
        private FileData _file;
        private FileData[] _filesData;
        private Split _splitter;
        private Thread _splitterThread;

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
            _splitter = new Split(_file);

            _splitter.StartTime = _startTime.Value;
            _splitter.EndTime = _endTime.Value;
            _splitter.RemoveLineRegex = _txtBoxRemoveLineRegex.Text;
            _splitter.FilesToWorkWith = _filesData;
            _splitter.RemoveLines = chkBoxRemoveLines.Checked;

            // start in new thread, so GUI is not blocked
            _splitterThread = new Thread(() => _splitter.Start(_cancellationToken))
            {
                Name = nameof(Split)
            };

            _splitterThread.Start();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _file = new FileData(_openFileDialog.FileName);
                _txtBoxFilePath.Text = _file.FileName;
                toolTip.SetToolTip(_txtBoxFilePath, _txtBoxFilePath.Text);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
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
    }
}
