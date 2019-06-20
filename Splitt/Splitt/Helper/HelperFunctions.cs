using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splitt.Helper
{
    public static class HelperFunctions
    {

        public static bool ValidateRegex(string regex, out string errorMessage)
        {
            try
            {
                new Regex(regex);
                errorMessage = string.Empty;
                return true;

            }
            catch (Exception exception)
            {
                errorMessage = exception.Message;
                return false;
            }
        }

        public static void ShowMessageBox(string text, string caption, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            MessageBox.Show(text, caption, messageBoxButtons, messageBoxIcon);
        }
    }
}
