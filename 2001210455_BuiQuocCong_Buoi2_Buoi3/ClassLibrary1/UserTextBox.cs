using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class UserTextBox: TextBox
    {
        private ErrorProvider err = new ErrorProvider();
        public UserTextBox()
        {
            this.TextChanged += UserTextBox_TextChanged;
        }

        void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.Text;
            if (ContainsSpecialCharacters(text))
            {
                err.SetError(this, "Vui lòng không sử dụng ký tự đặc biệt.");
            }
            else
            {
                err.Clear();
            }
        }
        private bool ContainsSpecialCharacters(string text)
        {
            // Biểu thức chính quy để kiểm tra ký tự đặc biệt
            string pattern = @"[^a-zA-Z0-9\s]";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(text);
        }
    }
}
