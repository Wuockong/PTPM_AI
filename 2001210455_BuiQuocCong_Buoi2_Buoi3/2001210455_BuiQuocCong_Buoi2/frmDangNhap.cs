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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();

            login1.Cnn = "Data Source=A102PC08;Initial Catalog=LOGIN;Integrated Security=True";
        }
    }
}
