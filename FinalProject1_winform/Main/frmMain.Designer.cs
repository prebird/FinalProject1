
namespace FinalProject1_winform
{
    partial class frmMain
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
            this.pnlUpSide = new System.Windows.Forms.Panel();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlUpSide
            // 
            this.pnlUpSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpSide.Location = new System.Drawing.Point(0, 0);
            this.pnlUpSide.Name = "pnlUpSide";
            this.pnlUpSide.Size = new System.Drawing.Size(1329, 99);
            this.pnlUpSide.TabIndex = 0;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 99);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(200, 554);
            this.pnlSideBar.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 653);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlUpSide);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpSide;
        private System.Windows.Forms.Panel pnlSideBar;
    }
}