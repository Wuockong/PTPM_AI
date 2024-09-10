using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLibrary1
{
    internal class DataGridView_CustomColor : DataGridView
    {
        public Color EvenRowColor { get; set; } = Color.LightBlue;
        public Color OddRowColor { get; set; } = Color.LightGray;

        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        {
            base.OnRowPrePaint(e);

            // Kiểm tra nếu dòng hiện tại là chẵn hoặc lẻ
            if (e.RowIndex % 2 == 0)
            {
                // Dòng chẵn
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = EvenRowColor;
            }
            else
            {
                // Dòng lẻ
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = OddRowColor;
            }
        }
    }
}
