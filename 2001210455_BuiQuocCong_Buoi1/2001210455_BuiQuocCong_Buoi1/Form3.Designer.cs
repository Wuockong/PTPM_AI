namespace CaroGame
{
    partial class Form3
    {
        private void InitializeComponent()
        {
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(12, 12);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 0;
            this.txtSize.Text = "10";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(118, 10);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.AutoScroll = true;
            this.pnlBoard.Location = new System.Drawing.Point(12, 39);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(776, 399);
            this.pnlBoard.TabIndex = 2;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtSize);
            this.Name = "Form3";
            this.Text = "Caro Game";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form3";
        }

        #endregion
    }
}