namespace Splitt.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtBoxFilePath = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelFileOrFolderImages = new System.Windows.Forms.Panel();
            this.lblRegex = new System.Windows.Forms.Label();
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.chkboxInterval = new System.Windows.Forms.CheckBox();
            this.cbxExtractionType = new System.Windows.Forms.ComboBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblChooseFolderOrFile = new System.Windows.Forms.Label();
            this.tlpFileOrFolder = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRegex = new System.Windows.Forms.TableLayoutPanel();
            this.cbxRegex = new System.Windows.Forms.ComboBox();
            this.btnAddRegex = new System.Windows.Forms.Button();
            this.btnEditRegex = new System.Windows.Forms.Button();
            this.btnDeleteRegex = new System.Windows.Forms.Button();
            this.panelRegexImage = new System.Windows.Forms.Panel();
            this.lblInterval = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.panelIntervalImage = new System.Windows.Forms.Panel();
            this.panelTypeImage = new System.Windows.Forms.Panel();
            this.lblExtractionType = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpFileOrFolder.SuspendLayout();
            this.tlpRegex.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartProcess
            // 
            resources.ApplyResources(this.btnStartProcess, "btnStartProcess");
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            this.btnStartProcess.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnLoadFile
            // 
            resources.ApplyResources(this.btnLoadFile, "btnLoadFile");
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // _openFileDialog
            // 
            this._openFileDialog.FileName = "openFileDialog";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dtpStartTime
            // 
            resources.ApplyResources(this.dtpStartTime, "dtpStartTime");
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Name = "dtpStartTime";
            // 
            // dtpEndTime
            // 
            resources.ApplyResources(this.dtpEndTime, "dtpEndTime");
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Name = "dtpEndTime";
            // 
            // txtBoxFilePath
            // 
            this.tlpMain.SetColumnSpan(this.txtBoxFilePath, 2);
            resources.ApplyResources(this.txtBoxFilePath, "txtBoxFilePath");
            this.txtBoxFilePath.Name = "txtBoxFilePath";
            this.txtBoxFilePath.ReadOnly = true;
            this.toolTip.SetToolTip(this.txtBoxFilePath, resources.GetString("txtBoxFilePath.ToolTip"));
            // 
            // panelFileOrFolderImages
            // 
            this.panelFileOrFolderImages.BackgroundImage = global::Splitt.Properties.Resources.nok;
            resources.ApplyResources(this.panelFileOrFolderImages, "panelFileOrFolderImages");
            this.panelFileOrFolderImages.Name = "panelFileOrFolderImages";
            this.toolTip.SetToolTip(this.panelFileOrFolderImages, resources.GetString("panelFileOrFolderImages.ToolTip"));
            // 
            // lblRegex
            // 
            resources.ApplyResources(this.lblRegex, "lblRegex");
            this.tlpMain.SetColumnSpan(this.lblRegex, 2);
            this.lblRegex.Name = "lblRegex";
            // 
            // btnLoadFolder
            // 
            resources.ApplyResources(this.btnLoadFolder, "btnLoadFolder");
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            this.btnLoadFolder.Click += new System.EventHandler(this.LoadFolder_Click);
            // 
            // chkboxInterval
            // 
            resources.ApplyResources(this.chkboxInterval, "chkboxInterval");
            this.tableLayoutPanel1.SetColumnSpan(this.chkboxInterval, 2);
            this.chkboxInterval.Name = "chkboxInterval";
            this.chkboxInterval.UseVisualStyleBackColor = true;
            this.chkboxInterval.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbxExtractionType
            // 
            resources.ApplyResources(this.cbxExtractionType, "cbxExtractionType");
            this.cbxExtractionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExtractionType.FormattingEnabled = true;
            this.cbxExtractionType.Items.AddRange(new object[] {
            resources.GetString("cbxExtractionType.Items"),
            resources.GetString("cbxExtractionType.Items1"),
            resources.GetString("cbxExtractionType.Items2"),
            resources.GetString("cbxExtractionType.Items3")});
            this.cbxExtractionType.Name = "cbxExtractionType";
            this.cbxExtractionType.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tlpMain);
            this.panelMain.Controls.Add(this.panelButtons);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // tlpMain
            // 
            resources.ApplyResources(this.tlpMain, "tlpMain");
            this.tlpMain.Controls.Add(this.lblChooseFolderOrFile, 1, 1);
            this.tlpMain.Controls.Add(this.tlpFileOrFolder, 1, 2);
            this.tlpMain.Controls.Add(this.panelFileOrFolderImages, 0, 2);
            this.tlpMain.Controls.Add(this.txtBoxFilePath, 1, 3);
            this.tlpMain.Controls.Add(this.lblRegex, 1, 5);
            this.tlpMain.Controls.Add(this.tlpRegex, 1, 6);
            this.tlpMain.Controls.Add(this.panelRegexImage, 0, 6);
            this.tlpMain.Controls.Add(this.lblInterval, 1, 7);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 1, 9);
            this.tlpMain.Controls.Add(this.panelIntervalImage, 0, 9);
            this.tlpMain.Controls.Add(this.cbxExtractionType, 1, 11);
            this.tlpMain.Controls.Add(this.panelTypeImage, 0, 11);
            this.tlpMain.Controls.Add(this.lblExtractionType, 1, 10);
            this.tlpMain.Name = "tlpMain";
            // 
            // lblChooseFolderOrFile
            // 
            resources.ApplyResources(this.lblChooseFolderOrFile, "lblChooseFolderOrFile");
            this.tlpMain.SetColumnSpan(this.lblChooseFolderOrFile, 2);
            this.lblChooseFolderOrFile.Name = "lblChooseFolderOrFile";
            // 
            // tlpFileOrFolder
            // 
            resources.ApplyResources(this.tlpFileOrFolder, "tlpFileOrFolder");
            this.tlpFileOrFolder.Controls.Add(this.btnLoadFolder, 0, 0);
            this.tlpFileOrFolder.Controls.Add(this.btnLoadFile, 1, 0);
            this.tlpFileOrFolder.Name = "tlpFileOrFolder";
            // 
            // tlpRegex
            // 
            resources.ApplyResources(this.tlpRegex, "tlpRegex");
            this.tlpRegex.Controls.Add(this.cbxRegex, 0, 0);
            this.tlpRegex.Controls.Add(this.btnAddRegex, 1, 0);
            this.tlpRegex.Controls.Add(this.btnEditRegex, 2, 0);
            this.tlpRegex.Controls.Add(this.btnDeleteRegex, 3, 0);
            this.tlpRegex.Name = "tlpRegex";
            // 
            // cbxRegex
            // 
            resources.ApplyResources(this.cbxRegex, "cbxRegex");
            this.cbxRegex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegex.FormattingEnabled = true;
            this.cbxRegex.Name = "cbxRegex";
            // 
            // btnAddRegex
            // 
            resources.ApplyResources(this.btnAddRegex, "btnAddRegex");
            this.btnAddRegex.Name = "btnAddRegex";
            this.btnAddRegex.UseVisualStyleBackColor = true;
            this.btnAddRegex.Click += new System.EventHandler(this.btnAddRegex_Click);
            // 
            // btnEditRegex
            // 
            resources.ApplyResources(this.btnEditRegex, "btnEditRegex");
            this.btnEditRegex.Name = "btnEditRegex";
            this.btnEditRegex.UseVisualStyleBackColor = true;
            this.btnEditRegex.Click += new System.EventHandler(this.btnEditRegex_Click);
            // 
            // btnDeleteRegex
            // 
            resources.ApplyResources(this.btnDeleteRegex, "btnDeleteRegex");
            this.btnDeleteRegex.Name = "btnDeleteRegex";
            this.btnDeleteRegex.UseVisualStyleBackColor = true;
            this.btnDeleteRegex.Click += new System.EventHandler(this.btnDeleteRegex_Click);
            // 
            // panelRegexImage
            // 
            this.panelRegexImage.BackgroundImage = global::Splitt.Properties.Resources.nok;
            resources.ApplyResources(this.panelRegexImage, "panelRegexImage");
            this.panelRegexImage.Name = "panelRegexImage";
            // 
            // lblInterval
            // 
            resources.ApplyResources(this.lblInterval, "lblInterval");
            this.tlpMain.SetColumnSpan(this.lblInterval, 2);
            this.lblInterval.Name = "lblInterval";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.dtpStartTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpEndTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStartTime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEndTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkboxInterval, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblStartTime
            // 
            resources.ApplyResources(this.lblStartTime, "lblStartTime");
            this.lblStartTime.Name = "lblStartTime";
            // 
            // lblEndTime
            // 
            resources.ApplyResources(this.lblEndTime, "lblEndTime");
            this.lblEndTime.Name = "lblEndTime";
            // 
            // panelIntervalImage
            // 
            this.panelIntervalImage.BackgroundImage = global::Splitt.Properties.Resources.nok;
            resources.ApplyResources(this.panelIntervalImage, "panelIntervalImage");
            this.panelIntervalImage.Name = "panelIntervalImage";
            // 
            // panelTypeImage
            // 
            this.panelTypeImage.BackgroundImage = global::Splitt.Properties.Resources.nok;
            resources.ApplyResources(this.panelTypeImage, "panelTypeImage");
            this.panelTypeImage.Name = "panelTypeImage";
            // 
            // lblExtractionType
            // 
            resources.ApplyResources(this.lblExtractionType, "lblExtractionType");
            this.tlpMain.SetColumnSpan(this.lblExtractionType, 2);
            this.lblExtractionType.Name = "lblExtractionType";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.tlpButtons);
            resources.ApplyResources(this.panelButtons, "panelButtons");
            this.panelButtons.Name = "panelButtons";
            // 
            // tlpButtons
            // 
            resources.ApplyResources(this.tlpButtons, "tlpButtons");
            this.tlpButtons.Controls.Add(this.btnStartProcess, 0, 0);
            this.tlpButtons.Controls.Add(this.btnExit, 2, 0);
            this.tlpButtons.Controls.Add(this.btnCancel, 1, 0);
            this.tlpButtons.Name = "tlpButtons";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.panelMain.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpFileOrFolder.ResumeLayout(false);
            this.tlpRegex.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartProcess;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.TextBox txtBoxFilePath;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblRegex;
        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
        private System.Windows.Forms.CheckBox chkboxInterval;
        private System.Windows.Forms.ComboBox cbxExtractionType;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpFileOrFolder;
        private System.Windows.Forms.Label lblChooseFolderOrFile;
        private System.Windows.Forms.Panel panelFileOrFolderImages;
        private System.Windows.Forms.Panel panelRegexImage;
        private System.Windows.Forms.TableLayoutPanel tlpRegex;
        private System.Windows.Forms.ComboBox cbxRegex;
        private System.Windows.Forms.Button btnAddRegex;
        private System.Windows.Forms.Button btnEditRegex;
        private System.Windows.Forms.Button btnDeleteRegex;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Panel panelIntervalImage;
        private System.Windows.Forms.Label lblExtractionType;
        private System.Windows.Forms.Panel panelTypeImage;
    }
}

