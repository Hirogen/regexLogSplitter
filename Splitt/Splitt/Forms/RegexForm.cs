using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Splitt.Helper;
using Splitt.Properties;

namespace Splitt.Forms
{
    public partial class RegexForm : Form
    {
        private List<string> _regexes;
        private readonly ResourceManager _resources = new ResourceManager(typeof(RegexForm));

        public bool Add { get; set; }

        public List<string> Regexes
        {
            get => _regexes;
            set => _regexes = value;
        }

        public RegexForm()
        {
            InitializeComponent();
            if (_regexes == null)
            {
                _regexes = new List<string>(1);
            }
        }

        private void lbRegexes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRegexes.SelectedItem != null)
            {
                rtbRegexEditor.Text = lbRegexes.SelectedItem.ToString();
            }
        }

        private void btnAddRegex_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbRegexEditor.Text) || !ValidateRegex()) return;

            lbRegexes.Items.Add(rtbRegexEditor.Text);
            rtbRegexEditor.Clear();
        }

        private void btnDeleteRegex_Click(object sender, EventArgs e)
        {
            lbRegexes.Items.Remove(lbRegexes.SelectedItem);
            rtbRegexEditor.Clear();
        }

        private void btnClearRegexEditor_Click(object sender, EventArgs e)
        {
            rtbRegexEditor.Clear();
        }

        private void btnValidateRegex_Click(object sender, EventArgs e)
        {
            ValidateRegex();
        }

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

    }
}
