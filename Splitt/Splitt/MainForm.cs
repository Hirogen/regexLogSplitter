using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        private readonly List<FileData> _filesData = new List<FileData>();
        private List<Split> _splittingMultipleFiles = new List<Split>();
        private List<Thread> _splittingMultipleFilesThreads = new List<Thread>();

        #endregion

        #region Ctor

        public MainForm()
        {
            InitializeComponent();

            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;
            cbxExtractionType.DataSource =  Enum.GetValues(typeof(ExtractionType));
        }

        #endregion

        #region Private Methods

        private void Start_Click(object sender, EventArgs e)
        {

            if (_filesData.Capacity > 0)
            {
                FilesPreWork();
                CreateThreads();
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filesData.Add(new FileData(_openFileDialog.FileName));
                _txtBoxFilePath.Text = _filesData.First().FileName;
                toolTip.SetToolTip(_txtBoxFilePath, _txtBoxFilePath.Text);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        #endregion

        private void LoadFolder_Click(object sender, EventArgs e)
        {
            if (_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = _folderBrowserDialog.SelectedPath;
                List<string> files = Directory.GetFiles(folderPath).ToList();

                foreach (string file in files)
                {
                    _filesData.Add(new FileData(file));
                }

                _txtBoxFilePath.Text = folderPath;
                toolTip.SetToolTip(_txtBoxFilePath, _txtBoxFilePath.Text);
            }
        }

        private void FilesPreWork()
        {
            if (_splittingMultipleFiles.Count > 0)
            {
                _splittingMultipleFiles = new List<Split>();
            }

            foreach (FileData fileData in _filesData)
            {
                _splittingMultipleFiles.Add(new Split(fileData));
            }

            foreach (Split splittingMultipleFile in _splittingMultipleFiles)
            {
                splittingMultipleFile.StartTime = _startTime.Value;
                splittingMultipleFile.EndTime = _endTime.Value;
                splittingMultipleFile.LineRegex = _txtBoxRemoveLineRegex.Text;
                splittingMultipleFile.ExtractionType = (ExtractionType)cbxExtractionType.SelectedItem;
                splittingMultipleFile.Interval = _chkboxInterval.Checked;
            }
        }

        private void CreateThreads()
        {
            if (_splittingMultipleFilesThreads.Count > 0)
            {
                _splittingMultipleFilesThreads = new List<Thread>();
            }

            foreach (Split splittingMultipleFile in _splittingMultipleFiles)
            {
                _splittingMultipleFilesThreads.Add(new Thread(() => splittingMultipleFile.Start(_cancellationToken))
                {
                    Name = splittingMultipleFile.Filename.Name
                });
            }

            foreach (Thread t in _splittingMultipleFilesThreads)
            {
                t.Start();
            }
        }
    }
}
