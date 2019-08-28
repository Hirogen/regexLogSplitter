namespace Splitt.Forms
{
    partial class RegexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegexForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.tlpRegexEditor = new System.Windows.Forms.TableLayoutPanel();
            this.rtbRegexEditor = new System.Windows.Forms.RichTextBox();
            this.tlpRegexButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRegex = new System.Windows.Forms.Button();
            this.btnDeleteRegex = new System.Windows.Forms.Button();
            this.btnClearRegexEditor = new System.Windows.Forms.Button();
            this.btnValidateRegex = new System.Windows.Forms.Button();
            this.lbRegexes = new System.Windows.Forms.ListBox();
            this.panelMain.SuspendLayout();
            this.tlpRegexEditor.SuspendLayout();
            this.tlpRegexButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tlpRegexEditor);
            this.panelMain.Controls.Add(this.lbRegexes);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // tlpRegexEditor
            // 
            resources.ApplyResources(this.tlpRegexEditor, "tlpRegexEditor");
            this.tlpRegexEditor.Controls.Add(this.rtbRegexEditor, 0, 1);
            this.tlpRegexEditor.Controls.Add(this.tlpRegexButtons, 0, 0);
            this.tlpRegexEditor.Name = "tlpRegexEditor";
            // 
            // rtbRegexEditor
            // 
            resources.ApplyResources(this.rtbRegexEditor, "rtbRegexEditor");
            this.rtbRegexEditor.Name = "rtbRegexEditor";
            this.rtbRegexEditor.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // tlpRegexButtons
            // 
            resources.ApplyResources(this.tlpRegexButtons, "tlpRegexButtons");
            this.tlpRegexButtons.Controls.Add(this.btnAddRegex, 0, 0);
            this.tlpRegexButtons.Controls.Add(this.btnDeleteRegex, 1, 0);
            this.tlpRegexButtons.Controls.Add(this.btnClearRegexEditor, 2, 0);
            this.tlpRegexButtons.Controls.Add(this.btnValidateRegex, 3, 0);
            this.tlpRegexButtons.Name = "tlpRegexButtons";
            // 
            // btnAddRegex
            // 
            resources.ApplyResources(this.btnAddRegex, "btnAddRegex");
            this.btnAddRegex.Name = "btnAddRegex";
            this.btnAddRegex.UseVisualStyleBackColor = true;
            this.btnAddRegex.Click += new System.EventHandler(this.btnAddRegex_Click);
            // 
            // btnDeleteRegex
            // 
            resources.ApplyResources(this.btnDeleteRegex, "btnDeleteRegex");
            this.btnDeleteRegex.Name = "btnDeleteRegex";
            this.btnDeleteRegex.UseVisualStyleBackColor = true;
            this.btnDeleteRegex.Click += new System.EventHandler(this.btnDeleteRegex_Click);
            // 
            // btnClearRegexEditor
            // 
            resources.ApplyResources(this.btnClearRegexEditor, "btnClearRegexEditor");
            this.btnClearRegexEditor.Name = "btnClearRegexEditor";
            this.btnClearRegexEditor.UseVisualStyleBackColor = true;
            this.btnClearRegexEditor.Click += new System.EventHandler(this.btnClearRegexEditor_Click);
            // 
            // btnValidateRegex
            // 
            resources.ApplyResources(this.btnValidateRegex, "btnValidateRegex");
            this.btnValidateRegex.Name = "btnValidateRegex";
            this.btnValidateRegex.UseVisualStyleBackColor = true;
            this.btnValidateRegex.Click += new System.EventHandler(this.btnValidateRegex_Click);
            // 
            // lbRegexes
            // 
            resources.ApplyResources(this.lbRegexes, "lbRegexes");
            this.lbRegexes.FormattingEnabled = true;
            this.lbRegexes.Name = "lbRegexes";
            this.lbRegexes.SelectedIndexChanged += new System.EventHandler(this.lbRegexes_SelectedIndexChanged);
            // 
            // RegexForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "RegexForm";
            this.panelMain.ResumeLayout(false);
            this.tlpRegexEditor.ResumeLayout(false);
            this.tlpRegexButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListBox lbRegexes;
        private System.Windows.Forms.TableLayoutPanel tlpRegexEditor;
        private System.Windows.Forms.RichTextBox rtbRegexEditor;
        private System.Windows.Forms.TableLayoutPanel tlpRegexButtons;
        private System.Windows.Forms.Button btnAddRegex;
        private System.Windows.Forms.Button btnDeleteRegex;
        private System.Windows.Forms.Button btnClearRegexEditor;
        private System.Windows.Forms.Button btnValidateRegex;
    }
}