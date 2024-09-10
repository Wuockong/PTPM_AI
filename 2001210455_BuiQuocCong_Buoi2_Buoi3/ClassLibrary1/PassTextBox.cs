using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class PassTextBox: TextBox
    {
        private ErrorProvider err = new ErrorProvider();
        public PassTextBox()
        {
            this.TextChanged += PassTextBox_TextChanged;
        }

        void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.Text;
            if (!HasSpecialCharacter(text) || text.Length < 6)
            {
                err.SetError(this, "Mật khẩu phải chứa ít nhất 6 ký tự và ít nhất 1 ký tự đặc biệt.");
            }
            else
            {
                err.SetError(this, string.Empty);
            }
        }
        private bool HasSpecialCharacter(string text)
        {
            string pattern = @"[!@#$%^&*()_+{}\[\]:;,.<>?~\\|]";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(text);
        }
    }
}
