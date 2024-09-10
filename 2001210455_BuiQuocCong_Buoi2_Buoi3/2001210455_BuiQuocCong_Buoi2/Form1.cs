using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001210455_BuiQuocCong_Buoi2
{
    public partial class Form1 : Form
    {
        private XuLy xuLy;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();

            if (!string.IsNullOrEmpty(mssv))
            {
                ucSV.LoadStudentInfo(mssv);
            }
            else
            {
                MessageBox.Show("Please enter a valid MSSV.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
