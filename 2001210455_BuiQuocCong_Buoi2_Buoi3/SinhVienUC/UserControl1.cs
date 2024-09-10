using System;
using System.IO;
using System.Windows.Forms;

namespace SinhVienUC
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void LoadStudentInfo(string mssv)
        {
            try
            {
                string filePath = "F:\\_HUIT\\APP\\PTPM_AI\\2001210455_BuiQuocCong_Buoi2\\students.txt";

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("K thấy file.","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 6 && parts[0].Trim() == mssv)
                    {
                        lbMaSV.Text = "" + parts[0].Trim();
                        lbTenSV.Text = "" + parts[1].Trim();
                        lbGioiTinh.Text = "" + parts[2].Trim();
                        lbMaLop.Text = "" + parts[3].Trim();
                        lbCCCD.Text = "" + parts[4].Trim();
                        lbNgSinh.Text = "" + parts[5].Trim();
                        return;
                    }
                }

                MessageBox.Show("K thấy sinh viên.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
