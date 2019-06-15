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
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.panelIntervalImage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTypeImage = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpFileOrFolder.SuspendLayout();
            this.tlpRegex.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartProcess.Location = new System.Drawing.Point(1, 1);
            this.btnStartProcess.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(193, 38);
            this.btnStartProcess.TabIndex = 0;
            this.btnStartProcess.Text = "Start";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            this.btnStartProcess.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadFile.Location = new System.Drawing.Point(264, 0);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(265, 61);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // _openFileDialog
            // 
            this._openFileDialog.FileName = "openFileDialog";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(194, 1);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(3, 45);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(258, 20);
            this.dtpStartTime.TabIndex = 3;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(267, 45);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(259, 20);
            this.dtpEndTime.TabIndex = 4;
            // 
            // txtBoxFilePath
            // 
            this.tlpMain.SetColumnSpan(this.txtBoxFilePath, 2);
            this.txtBoxFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxFilePath.Location = new System.Drawing.Point(3, 80);
            this.txtBoxFilePath.Name = "txtBoxFilePath";
            this.txtBoxFilePath.ReadOnly = true;
            this.txtBoxFilePath.Size = new System.Drawing.Size(578, 20);
            this.txtBoxFilePath.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtBoxFilePath, "Chosen folder / file");
            // 
            // panelFileOrFolderImages
            // 
            this.panelFileOrFolderImages.BackgroundImage = global::Splitt.Properties.Resources.nok;
            this.panelFileOrFolderImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFileOrFolderImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFileOrFolderImages.Location = new System.Drawing.Point(0, 16);
            this.panelFileOrFolderImages.Margin = new System.Windows.Forms.Padding(0);
            this.panelFileOrFolderImages.Name = "panelFileOrFolderImages";
            this.panelFileOrFolderImages.Size = new System.Drawing.Size(55, 61);
            this.panelFileOrFolderImages.TabIndex = 11;
            this.toolTip.SetToolTip(this.panelFileOrFolderImages, "No file or folder has been chosen");
            // 
            // lblRegex
            // 
            this.lblRegex.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lblRegex, 2);
            this.lblRegex.Location = new System.Drawing.Point(3, 106);
            this.lblRegex.Margin = new System.Windows.Forms.Padding(3);
            this.lblRegex.Name = "lblRegex";
            this.lblRegex.Size = new System.Drawing.Size(41, 13);
            this.lblRegex.TabIndex = 7;
            this.lblRegex.Text = "Regex:";
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadFolder.Location = new System.Drawing.Point(0, 0);
            this.btnLoadFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(264, 61);
            this.btnLoadFolder.TabIndex = 9;
            this.btnLoadFolder.Text = "Load Folder";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            this.btnLoadFolder.Click += new System.EventHandler(this.LoadFolder_Click);
            // 
            // chkboxInterval
            // 
            this.chkboxInterval.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkboxInterval, 2);
            this.chkboxInterval.Location = new System.Drawing.Point(3, 3);
            this.chkboxInterval.Name = "chkboxInterval";
            this.chkboxInterval.Size = new System.Drawing.Size(103, 17);
            this.chkboxInterval.TabIndex = 10;
            this.chkboxInterval.Text = "Activate Interval";
            this.chkboxInterval.UseVisualStyleBackColor = true;
            this.chkboxInterval.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbxExtractionType
            // 
            this.cbxExtractionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxExtractionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExtractionType.FormattingEnabled = true;
            this.cbxExtractionType.Items.AddRange(new object[] {
            "Choose Type",
            "Extract Lines",
            "Obfusicate Lines",
            "Remove Lines"});
            this.cbxExtractionType.Location = new System.Drawing.Point(58, 294);
            this.cbxExtractionType.Name = "cbxExtractionType";
            this.cbxExtractionType.Size = new System.Drawing.Size(523, 21);
            this.cbxExtractionType.TabIndex = 11;
            this.cbxExtractionType.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tlpMain);
            this.panelMain.Controls.Add(this.panelButtons);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(584, 394);
            this.panelMain.TabIndex = 16;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.548611F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.45139F));
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
            this.tlpMain.Controls.Add(this.label1, 1, 10);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 12;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(584, 354);
            this.tlpMain.TabIndex = 17;
            // 
            // lblChooseFolderOrFile
            // 
            this.lblChooseFolderOrFile.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lblChooseFolderOrFile, 2);
            this.lblChooseFolderOrFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChooseFolderOrFile.Location = new System.Drawing.Point(3, 3);
            this.lblChooseFolderOrFile.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblChooseFolderOrFile.Name = "lblChooseFolderOrFile";
            this.lblChooseFolderOrFile.Size = new System.Drawing.Size(578, 13);
            this.lblChooseFolderOrFile.TabIndex = 0;
            this.lblChooseFolderOrFile.Text = "Choose File or Folder with Files to edit";
            // 
            // tlpFileOrFolder
            // 
            this.tlpFileOrFolder.ColumnCount = 2;
            this.tlpFileOrFolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFileOrFolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFileOrFolder.Controls.Add(this.btnLoadFolder, 0, 0);
            this.tlpFileOrFolder.Controls.Add(this.btnLoadFile, 1, 0);
            this.tlpFileOrFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFileOrFolder.Location = new System.Drawing.Point(55, 16);
            this.tlpFileOrFolder.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFileOrFolder.Name = "tlpFileOrFolder";
            this.tlpFileOrFolder.RowCount = 1;
            this.tlpFileOrFolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpFileOrFolder.Size = new System.Drawing.Size(529, 61);
            this.tlpFileOrFolder.TabIndex = 10;
            // 
            // tlpRegex
            // 
            this.tlpRegex.ColumnCount = 4;
            this.tlpRegex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 409F));
            this.tlpRegex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpRegex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpRegex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpRegex.Controls.Add(this.cbxRegex, 0, 0);
            this.tlpRegex.Controls.Add(this.btnAddRegex, 1, 0);
            this.tlpRegex.Controls.Add(this.btnEditRegex, 2, 0);
            this.tlpRegex.Controls.Add(this.btnDeleteRegex, 3, 0);
            this.tlpRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegex.Location = new System.Drawing.Point(58, 125);
            this.tlpRegex.Name = "tlpRegex";
            this.tlpRegex.RowCount = 1;
            this.tlpRegex.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRegex.Size = new System.Drawing.Size(523, 55);
            this.tlpRegex.TabIndex = 16;
            // 
            // cbxRegex
            // 
            this.cbxRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRegex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegex.FormattingEnabled = true;
            this.cbxRegex.Location = new System.Drawing.Point(3, 3);
            this.cbxRegex.Name = "cbxRegex";
            this.cbxRegex.Size = new System.Drawing.Size(403, 21);
            this.cbxRegex.TabIndex = 15;
            // 
            // btnAddRegex
            // 
            this.btnAddRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRegex.Location = new System.Drawing.Point(410, 0);
            this.btnAddRegex.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnAddRegex.Name = "btnAddRegex";
            this.btnAddRegex.Size = new System.Drawing.Size(30, 55);
            this.btnAddRegex.TabIndex = 12;
            this.btnAddRegex.Text = "+";
            this.btnAddRegex.UseVisualStyleBackColor = true;
            this.btnAddRegex.Click += new System.EventHandler(this.btnAddRegex_Click);
            // 
            // btnEditRegex
            // 
            this.btnEditRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRegex.Location = new System.Drawing.Point(442, 0);
            this.btnEditRegex.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnEditRegex.Name = "btnEditRegex";
            this.btnEditRegex.Size = new System.Drawing.Size(51, 55);
            this.btnEditRegex.TabIndex = 14;
            this.btnEditRegex.Text = "Edit";
            this.btnEditRegex.UseVisualStyleBackColor = true;
            this.btnEditRegex.Click += new System.EventHandler(this.btnEditRegex_Click);
            // 
            // btnDeleteRegex
            // 
            this.btnDeleteRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRegex.Location = new System.Drawing.Point(495, 0);
            this.btnDeleteRegex.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnDeleteRegex.Name = "btnDeleteRegex";
            this.btnDeleteRegex.Size = new System.Drawing.Size(28, 55);
            this.btnDeleteRegex.TabIndex = 13;
            this.btnDeleteRegex.Text = "-";
            this.btnDeleteRegex.UseVisualStyleBackColor = true;
            this.btnDeleteRegex.Click += new System.EventHandler(this.btnDeleteRegex_Click);
            // 
            // panelRegexImage
            // 
            this.panelRegexImage.BackgroundImage = global::Splitt.Properties.Resources.nok;
            this.panelRegexImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelRegexImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegexImage.Location = new System.Drawing.Point(0, 122);
            this.panelRegexImage.Margin = new System.Windows.Forms.Padding(0);
            this.panelRegexImage.Name = "panelRegexImage";
            this.panelRegexImage.Size = new System.Drawing.Size(55, 61);
            this.panelRegexImage.TabIndex = 17;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lblInterval, 2);
            this.lblInterval.Location = new System.Drawing.Point(3, 186);
            this.lblInterval.Margin = new System.Windows.Forms.Padding(3);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(45, 13);
            this.lblInterval.TabIndex = 18;
            this.lblInterval.Text = "Interval:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.tlpButtons);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 354);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(584, 40);
            this.panelButtons.TabIndex = 16;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 3;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.Controls.Add(this.btnStartProcess, 0, 0);
            this.tlpButtons.Controls.Add(this.btnExit, 2, 0);
            this.tlpButtons.Controls.Add(this.btnCancel, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(584, 40);
            this.tlpButtons.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(388, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dtpStartTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpEndTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStartTime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEndTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkboxInterval, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 202);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 70);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(3, 26);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(54, 13);
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "Start time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(267, 26);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(3);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(51, 13);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "End time:";
            // 
            // panelIntervalImage
            // 
            this.panelIntervalImage.BackgroundImage = global::Splitt.Properties.Resources.nok;
            this.panelIntervalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelIntervalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIntervalImage.Location = new System.Drawing.Point(0, 202);
            this.panelIntervalImage.Margin = new System.Windows.Forms.Padding(0);
            this.panelIntervalImage.Name = "panelIntervalImage";
            this.panelIntervalImage.Size = new System.Drawing.Size(55, 70);
            this.panelIntervalImage.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Extraction Type:";
            // 
            // panelTypeImage
            // 
            this.panelTypeImage.BackgroundImage = global::Splitt.Properties.Resources.nok;
            this.panelTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTypeImage.Location = new System.Drawing.Point(0, 291);
            this.panelTypeImage.Margin = new System.Windows.Forms.Padding(0);
            this.panelTypeImage.Name = "panelTypeImage";
            this.panelTypeImage.Size = new System.Drawing.Size(55, 61);
            this.panelTypeImage.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 394);
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpFileOrFolder.ResumeLayout(false);
            this.tlpRegex.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTypeImage;
    }
}

