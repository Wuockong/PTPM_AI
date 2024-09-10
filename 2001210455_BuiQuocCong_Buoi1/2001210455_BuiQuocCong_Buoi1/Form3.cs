using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaroGame
{
    public partial class Form3 : Form
    {
        private TextBox txtSize;
        private Button btnGenerate;
        private Panel pnlBoard;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Clear previous board
            pnlBoard.Controls.Clear();

            // Get board size
            int size;
            if (int.TryParse(txtSize.Text, out size))
            {
                if (size < 1 || size > 50)
                {
                    MessageBox.Show("Board size must be between 1 and 50.", "Invalid Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Set panel size
                pnlBoard.Width = size * 30;
                pnlBoard.Height = size * 30;

                // Create board buttons
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Button btn = new Button
                        {
                            Width = 30,
                            Height = 30,
                            Location = new Point(j * 30, i * 30),
                            Text = "",
                            Tag = new Point(i, j) // Store the position in Tag
                        };
                        btn.Click += Btn_Click;
                        pnlBoard.Controls.Add(btn);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Point pos = (Point)clickedButton.Tag;

            if (clickedButton.Text == "")
            {
                clickedButton.Text = "X";
            }
            else if (clickedButton.Text == "X")
            {
                clickedButton.Text = "O";
            }
            else
            {
                clickedButton.Text = "";
            }
        }
    }
}
