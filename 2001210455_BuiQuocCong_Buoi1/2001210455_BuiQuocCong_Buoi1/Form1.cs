using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001210455_BuiQuocCong_Buoi1
{
    public partial class Form1 : Form
    {
        XuLy xl;

        public void bUtton()
        {
            Button b = new Button();
            b.Name = "b1";
            b.Size = new Size(30, 30);
            b.Left = 30;
            b.Top = 20;
            this.Controls.Add(b);
            b.Click += new System.EventHandler(bt_click);
        }

        public Form1()
        {
            InitializeComponent();
            xl = new XuLy();
            bUtton();
            xl.lstCheckbox(this);
        }

        private void bt_click(object sender, EventArgs e) {
            string checkedItems = xl.showChecked(this);
            MessageBox.Show("Checked items: " + checkedItems, "Checked Items");
        }
    }
}
