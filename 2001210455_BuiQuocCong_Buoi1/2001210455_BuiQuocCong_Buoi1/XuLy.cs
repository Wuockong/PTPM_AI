using System;
using System.Linq;
using System.Windows.Forms;

namespace _2001210455_BuiQuocCong_Buoi1
{
    public class XuLy
    {
        public void lstCheckbox(Form f)
        {
            string[] foods = { "Grain", "Bread", "Beans", "Eggs", "Chicken",
                               "Milk", "Fruit", "Vegetables", "Pasta", "Rice", "Fish", "Beef" };
            int topPosition = 100;
            foreach (string food in foods)
            {
                CheckBox cb = new CheckBox();
                cb.Left = 10;
                cb.Top = topPosition;
                topPosition += 30;
                cb.Text = food;
                f.Controls.Add(cb);
            }
        }

        public string showChecked(Form f)
        {
            var checkedBoxes = f.Controls.OfType<CheckBox>().Where(cb => cb.Checked).Select(cb => cb.Text);
            return string.Join(", ", checkedBoxes);
        }

        public void ClearTextBoxes(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }
        }
    }
}
