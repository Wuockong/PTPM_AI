namespace _2001210455_BuiQuocCong_Buoi2
{
    partial class frmDangNhap
    {
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
            this.login1 = new LoginGUI.Login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Cnn = null;
            this.login1.Location = new System.Drawing.Point(12, 12);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(274, 150);
            this.login1.TabIndex = 12;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 264);
            this.Controls.Add(this.login1);
            this.Name = "frmDangNhap";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginGUI.Login login1;

    }
}