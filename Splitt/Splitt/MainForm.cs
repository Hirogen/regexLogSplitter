using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Threading;
using System.Windows.Forms;
using Splitt.Properties;

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
            FixTableSizes();
            btnCancel.Enabled = false;
            btnStartProcess.Enabled = false;
            btnEditRegex.Enabled = false;
            btnDeleteRegex.Enabled = false;

            dtpStartTime.Enabled = chkboxInterval.Checked;
            dtpEndTime.Enabled = chkboxInterval.Checked;
        }

        private void FixTableSizes()
        {
            int row = tlpMain.GetRow(lblChooseFolderOrFile);
            tlpMain.RowStyles[row].Height = lblChooseFolderOrFile.Height;

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
                txtBoxFilePath.Text = _filesData.First().FileName;
                toolTip.SetToolTip(txtBoxFilePath, txtBoxFilePath.Text);
                SetPanelImages();
            }
        }

        private void SetPanelImages()
        {
            panelFileOrFolderImages.BackgroundImage = Resources.ok;
            toolTip.SetToolTip(panelFileOrFolderImages, "File or Folder chosen!");
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

                txtBoxFilePath.Text = folderPath;
                toolTip.SetToolTip(txtBoxFilePath, txtBoxFilePath.Text);
                SetPanelImages();
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
                if (chkboxInterval.Checked)
                {
                    splittingMultipleFile.StartTime = dtpStartTime.Value;
                    splittingMultipleFile.EndTime = dtpEndTime.Value;
                }

                splittingMultipleFile.Interval = chkboxInterval.Checked;

                //splittingMultipleFile.LineRegex = _txtBoxRemoveLineRegex.Text;

                if ((ExtractionType) cbxExtractionType.SelectedItem != ExtractionType.ChooseType)
                {
                    splittingMultipleFile.ExtractionType = (ExtractionType)cbxExtractionType.SelectedItem;
                }

                
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
            // TODO Add functionality to wait for task to finish
            Application.Exit();
            
        }

        private void btnAddRegex_Click(object sender, EventArgs e)
        {
            // TODO Add Regex Dialog here
        }

        private void btnDeleteRegex_Click(object sender, EventArgs e)
        {
            // TODO ADD "Remove" selected Regex here
        }

        private void btnEditRegex_Click(object sender, EventArgs e)
        {
            // TODO Add "Edit" selected Regex here
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            dtpStartTime.Enabled = chkboxInterval.Checked;
            dtpEndTime.Enabled = chkboxInterval.Checked;
            panelIntervalImage.BackgroundImage = chkboxInterval.Checked ? Resources.ok : Resources.nok;
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            panelTypeImage.BackgroundImage = (ExtractionType) cbxExtractionType.SelectedItem != ExtractionType.ChooseType ? Resources.ok : Resources.nok;
        }
    }
}
