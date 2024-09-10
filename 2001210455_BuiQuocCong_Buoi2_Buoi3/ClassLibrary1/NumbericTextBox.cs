using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class NumericTextBox : TextBox
    {
        private ErrorProvider err = new ErrorProvider();
        public NumericTextBox()
        {
            this.KeyPress += NumericTextBox_KeyPress;
        }
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                err.SetError(this, "Vui lòng chỉ nhập số");
            }
            else
            {
                err.Clear();
            }
        }
    }
}
