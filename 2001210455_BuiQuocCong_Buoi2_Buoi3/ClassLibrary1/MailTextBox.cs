using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class MailTextBox: TextBox
    {
        private ErrorProvider err = new ErrorProvider();

        public MailTextBox()
        {
            this.TextChanged += MailTextBox_TextChanged;
        }

        void MailTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.Text;
            if (!text.Contains("@") || !text.EndsWith(".com"))
            {
                err.SetError(this, "Địa chỉ email phải chứa ký tự '@' và kết thúc bằng '.com'.");
            }
            else
            {
                err.Clear();
            }
        }
    }
}
