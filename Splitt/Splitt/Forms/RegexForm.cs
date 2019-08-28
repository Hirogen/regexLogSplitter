using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Splitt.Helper;

namespace Splitt.Forms
{
    public partial class RegexForm : Form
    {
        #region Private Fields

        private readonly ResourceManager _resources = new ResourceManager(typeof(RegexForm));
        private List<string> _regexes;

        #endregion

        #region Ctor

        public RegexForm()
        {
            InitializeComponent();
            if (_regexes == null)
            {
                _regexes = new List<string>(1);
            }

            btnAddRegex.Enabled = false;
            btnDeleteRegex.Enabled = false;
            btnClearRegexEditor.Enabled = false;
            btnValidateRegex.Enabled = false;
        }

        #endregion

        #region Properties / Indexers

        public bool Add { get; set; }

        public List<string> Regexes
        {
            get => _regexes;
            set
            {
                if (value.Any())
                {
                    _regexes = value;
                    btnDeleteRegex.Enabled = true;
                }
            }
        }

        #endregion

        #region Event handling Methods

        private void OnTextChanged(object sender, EventArgs e)
        {
            CheckButtonStates();
        }

        #endregion

        #region Private Methods

        private void btnAddRegex_Click(object sender, EventArgs e)
        {
            if (CheckEditorEmptyOrWhiteSpaces() || !ValidateRegex())
            {
                CheckButtonStates();
                return;
            }

            lbRegexes.Items.Add(rtbRegexEditor.Text);
            rtbRegexEditor.Clear();
            CheckButtonStates();
        }

        private void btnClearRegexEditor_Click(object sender, EventArgs e)
        {
            rtbRegexEditor.Clear();
            CheckButtonStates();
        }

        private void btnDeleteRegex_Click(object sender, EventArgs e)
        {
            lbRegexes.Items.Remove(lbRegexes.SelectedItem);
            rtbRegexEditor.Clear();
            CheckButtonStates();
        }

        private void btnValidateRegex_Click(object sender, EventArgs e)
        {
            if (CheckEditorEmptyOrWhiteSpaces())
            {
                HelperFunctions.ShowMessageBox(_resources.GetString("textboxEmptyErrorMessage"), _resources.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ValidateRegex();
            }

            CheckButtonStates();
        }

        private void CheckButtonStates()
        {
            if (CheckEditorEmptyOrWhiteSpaces())
            {
                btnAddRegex.Enabled = false;
                btnValidateRegex.Enabled = false;

                if (CheckEditorEmpty())
                {
                    btnClearRegexEditor.Enabled = false;
                }
            }
            else
            {
                btnAddRegex.Enabled = true;
                btnValidateRegex.Enabled = true;
                btnClearRegexEditor.Enabled = true;
            }

            btnDeleteRegex.Enabled = lbRegexes.Items.Count > 0 && lbRegexes.SelectedItem != null;
        }

        private bool CheckEditorEmpty()
        {
            return string.IsNullOrEmpty(rtbRegexEditor.Text);
        }

        private bool CheckEditorEmptyOrWhiteSpaces()
        {
            return string.IsNullOrWhiteSpace(rtbRegexEditor.Text);
        }

        private void lbRegexes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRegexes.SelectedItem != null)
            {
                rtbRegexEditor.Text = lbRegexes.SelectedItem.ToString();
            }

            CheckButtonStates();
        }

        /// <summary>
        /// Validates a given Regex
        /// </summary>
        /// <returns>true if validation successfull</returns>
        private bool ValidateRegex()
        {
            if (HelperFunctions.ValidateRegex(rtbRegexEditor.Text, out string errorMessage))
            {
                HelperFunctions.ShowMessageBox(rtbRegexEditor.Text, _resources.GetString("regexValid"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            HelperFunctions.ShowMessageBox(errorMessage, _resources.GetString("regexInvalid"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        #endregion
    }
}