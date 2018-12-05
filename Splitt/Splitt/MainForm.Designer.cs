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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cancel = new System.Windows.Forms.Button();
            this._startTime = new System.Windows.Forms.DateTimePicker();
            this._endTime = new System.Windows.Forms.DateTimePicker();
            this._txtBoxFilePath = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // startProcess
            // 
            this.startProcess.Location = new System.Drawing.Point(12, 113);
            this.startProcess.Name = "startProcess";
            this.startProcess.Size = new System.Drawing.Size(75, 23);
            this.startProcess.TabIndex = 0;
            this.startProcess.Text = "Start";
            this.startProcess.UseVisualStyleBackColor = true;
            this.startProcess.Click += new System.EventHandler(this.start_Click);
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(12, 32);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(156, 23);
            this.loadFile.TabIndex = 1;
            this.loadFile.Text = "Load File";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(93, 113);
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
            this._startTime.Location = new System.Drawing.Point(12, 61);
            this._startTime.Name = "_startTime";
            this._startTime.Size = new System.Drawing.Size(156, 20);
            this._startTime.TabIndex = 3;
            // 
            // _endTime
            // 
            this._endTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this._endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._endTime.Location = new System.Drawing.Point(12, 87);
            this._endTime.Name = "_endTime";
            this._endTime.Size = new System.Drawing.Size(156, 20);
            this._endTime.TabIndex = 4;
            // 
            // _txtBoxFilePath
            // 
            this._txtBoxFilePath.Location = new System.Drawing.Point(13, 6);
            this._txtBoxFilePath.Name = "_txtBoxFilePath";
            this._txtBoxFilePath.ReadOnly = true;
            this._txtBoxFilePath.Size = new System.Drawing.Size(155, 20);
            this._txtBoxFilePath.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 143);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DateTimePicker _startTime;
        private System.Windows.Forms.DateTimePicker _endTime;
        private System.Windows.Forms.TextBox _txtBoxFilePath;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

