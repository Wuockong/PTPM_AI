using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlClass;

namespace LoginGUI
{
    public partial class Login: UserControl
    {
        string _cnn;
        SqlDatabase sqldt = new SqlDatabase();
        public string Cnn
        {
            get
            {
                return _cnn;
            }
            set
            {
                _cnn = value;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqldt.CreateConnection(_cnn);

            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Nhập User.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Nhập Pass.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ten = txtUser.Text;
            string mk = txtPass.Text;

            string checK = "select COUNT(*) from Account where Ures = '"+ten+"' and Pass = '"+mk+"'";

            int i = (int)sqldt.ExecuteScalar(checK);

            if (i == 1)
            {
                MessageBox.Show("OK");
                Form1 f1 = new Form1();
                f1.UpdateStatusBar("Xin chào người dùng: " + txtTenDangNhap.Text);
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("No OK");
            }


        }
    }
}
