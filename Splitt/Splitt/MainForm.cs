﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace Splitt
{
    public partial class MainForm : Form
    {
        #region Private Fields

        private readonly CancellationToken _cancellationToken;
        private readonly CancellationTokenSource _cancellationTokenSource;
        private FileData _file;
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

            _splitterThread = new Thread(() => _splitter.Start(_cancellationToken))
            {
                Name = nameof(Split)
            };

            _splitterThread.Start();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _file = new FileData(openFileDialog.FileName);
                _txtBoxFilePath.Text = _file.FileName;
                toolTip.SetToolTip(_txtBoxFilePath, _txtBoxFilePath.Text);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        #endregion
    }
}