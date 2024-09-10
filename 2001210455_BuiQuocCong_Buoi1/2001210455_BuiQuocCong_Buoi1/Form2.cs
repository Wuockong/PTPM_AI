using System;
using System.Windows.Forms;

namespace _2001210455_BuiQuocCong_Buoi1
{
    public partial class Form2 : Form
    {
        private XuLy xl;

        public Form2()
        {
            InitializeComponent();
            xl = new XuLy();
            button1.Click += new EventHandler(Button1_Click);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            xl.ClearTextBoxes(this);
        }
    }
}
