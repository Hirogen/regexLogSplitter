namespace Splitt
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startProcess = new System.Windows.Forms.Button();
            this.loadFile = new System.Windows.Forms.Button();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cancel = new System.Windows.Forms.Button();
            this._startTime = new System.Windows.Forms.DateTimePicker();
            this._endTime = new System.Windows.Forms.DateTimePicker();
            this._txtBoxFilePath = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._txtBoxRemoveLineRegex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBoxRemoveLines = new System.Windows.Forms.CheckBox();
            this._btnLoadFolder = new System.Windows.Forms.Button();
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // startProcess
            // 
            this.startProcess.Location = new System.Drawing.Point(11, 251);
            this.startProcess.Name = "startProcess";
            this.startProcess.Size = new System.Drawing.Size(75, 23);
            this.startProcess.TabIndex = 0;
            this.startProcess.Text = "Start";
            this.startProcess.UseVisualStyleBackColor = true;
            this.startProcess.Click += new System.EventHandler(this.start_Click);
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(11, 170);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(206, 23);
            this.loadFile.TabIndex = 1;
            this.loadFile.Text = "Load File";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // _openFileDialog
            // 
            this._openFileDialog.FileName = "openFileDialog";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(142, 251);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // _startTime
            // 
            this._startTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this._startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._startTime.Location = new System.Drawing.Point(11, 199);
            this._startTime.Name = "_startTime";
            this._startTime.Size = new System.Drawing.Size(206, 20);
            this._startTime.TabIndex = 3;
            // 
            // _endTime
            // 
            this._endTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this._endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._endTime.Location = new System.Drawing.Point(11, 225);
            this._endTime.Name = "_endTime";
            this._endTime.Size = new System.Drawing.Size(206, 20);
            this._endTime.TabIndex = 4;
            // 
            // _txtBoxFilePath
            // 
            this._txtBoxFilePath.Location = new System.Drawing.Point(12, 58);
            this._txtBoxFilePath.Name = "_txtBoxFilePath";
            this._txtBoxFilePath.ReadOnly = true;
            this._txtBoxFilePath.Size = new System.Drawing.Size(205, 20);
            this._txtBoxFilePath.TabIndex = 5;
            // 
            // _txtBoxRemoveLineRegex
            // 
            this._txtBoxRemoveLineRegex.Location = new System.Drawing.Point(11, 32);
            this._txtBoxRemoveLineRegex.Name = "_txtBoxRemoveLineRegex";
            this._txtBoxRemoveLineRegex.Size = new System.Drawing.Size(206, 20);
            this._txtBoxRemoveLineRegex.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Remove all lines containing this Regex:";
            // 
            // chkBoxRemoveLines
            // 
            this.chkBoxRemoveLines.AutoSize = true;
            this.chkBoxRemoveLines.Location = new System.Drawing.Point(12, 84);
            this.chkBoxRemoveLines.Name = "chkBoxRemoveLines";
            this.chkBoxRemoveLines.Size = new System.Drawing.Size(100, 17);
            this.chkBoxRemoveLines.TabIndex = 8;
            this.chkBoxRemoveLines.Text = "Remove Lines?";
            this.chkBoxRemoveLines.UseVisualStyleBackColor = true;
            // 
            // _btnLoadFolder
            // 
            this._btnLoadFolder.Location = new System.Drawing.Point(12, 141);
            this._btnLoadFolder.Name = "_btnLoadFolder";
            this._btnLoadFolder.Size = new System.Drawing.Size(206, 23);
            this._btnLoadFolder.TabIndex = 9;
            this._btnLoadFolder.Text = "Load Folder";
            this._btnLoadFolder.UseVisualStyleBackColor = true;
            this._btnLoadFolder.Click += new System.EventHandler(this.loadFolder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 280);
            this.Controls.Add(this._btnLoadFolder);
            this.Controls.Add(this.chkBoxRemoveLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtBoxRemoveLineRegex);
            this.Controls.Add(this._txtBoxFilePath);
            this.Controls.Add(this._startTime);
            this.Controls.Add(this._endTime);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.startProcess);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startProcess;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DateTimePicker _startTime;
        private System.Windows.Forms.DateTimePicker _endTime;
        private System.Windows.Forms.TextBox _txtBoxFilePath;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox _txtBoxRemoveLineRegex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxRemoveLines;
        private System.Windows.Forms.Button _btnLoadFolder;
        private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
    }
}

