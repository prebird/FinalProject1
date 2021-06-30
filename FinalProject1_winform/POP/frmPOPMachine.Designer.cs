
namespace FinalProject1_winform.POP
{
    partial class frmPOPMachine
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메인화면ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설비관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공정관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucMachine1 = new FinalProject1_winform.Controls.UCMachine();
            this.ucMachine2 = new FinalProject1_winform.Controls.UCMachine();
            this.ucMachine3 = new FinalProject1_winform.Controls.UCMachine();
            this.ucMachine4 = new FinalProject1_winform.Controls.UCMachine();
            this.ucMachine5 = new FinalProject1_winform.Controls.UCMachine();
            this.ucMachine6 = new FinalProject1_winform.Controls.UCMachine();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인화면ToolStripMenuItem,
            this.설비관리ToolStripMenuItem,
            this.공정관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메인화면ToolStripMenuItem
            // 
            this.메인화면ToolStripMenuItem.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.메인화면ToolStripMenuItem.Name = "메인화면ToolStripMenuItem";
            this.메인화면ToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.메인화면ToolStripMenuItem.Text = "메인 화면";
            // 
            // 설비관리ToolStripMenuItem
            // 
            this.설비관리ToolStripMenuItem.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.설비관리ToolStripMenuItem.Name = "설비관리ToolStripMenuItem";
            this.설비관리ToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.설비관리ToolStripMenuItem.Text = "설비 관리";
            // 
            // 공정관리ToolStripMenuItem
            // 
            this.공정관리ToolStripMenuItem.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.공정관리ToolStripMenuItem.Name = "공정관리ToolStripMenuItem";
            this.공정관리ToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.공정관리ToolStripMenuItem.Text = "공정 관리";
            // 
            // ucMachine1
            // 
            this.ucMachine1.Location = new System.Drawing.Point(12, 42);
            this.ucMachine1.Name = "ucMachine1";
            this.ucMachine1.Size = new System.Drawing.Size(322, 434);
            this.ucMachine1.TabIndex = 6;
            // 
            // ucMachine2
            // 
            this.ucMachine2.Location = new System.Drawing.Point(422, 42);
            this.ucMachine2.Name = "ucMachine2";
            this.ucMachine2.Size = new System.Drawing.Size(322, 434);
            this.ucMachine2.TabIndex = 7;
            // 
            // ucMachine3
            // 
            this.ucMachine3.Location = new System.Drawing.Point(817, 42);
            this.ucMachine3.Name = "ucMachine3";
            this.ucMachine3.Size = new System.Drawing.Size(322, 434);
            this.ucMachine3.TabIndex = 8;
            // 
            // ucMachine4
            // 
            this.ucMachine4.Location = new System.Drawing.Point(12, 495);
            this.ucMachine4.Name = "ucMachine4";
            this.ucMachine4.Size = new System.Drawing.Size(322, 434);
            this.ucMachine4.TabIndex = 9;
            // 
            // ucMachine5
            // 
            this.ucMachine5.Location = new System.Drawing.Point(422, 495);
            this.ucMachine5.Name = "ucMachine5";
            this.ucMachine5.Size = new System.Drawing.Size(322, 434);
            this.ucMachine5.TabIndex = 10;
            // 
            // ucMachine6
            // 
            this.ucMachine6.Location = new System.Drawing.Point(817, 495);
            this.ucMachine6.Name = "ucMachine6";
            this.ucMachine6.Size = new System.Drawing.Size(322, 434);
            this.ucMachine6.TabIndex = 11;
            // 
            // frmPOPMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1176, 695);
            this.Controls.Add(this.ucMachine6);
            this.Controls.Add(this.ucMachine5);
            this.Controls.Add(this.ucMachine4);
            this.Controls.Add(this.ucMachine3);
            this.Controls.Add(this.ucMachine2);
            this.Controls.Add(this.ucMachine1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPOPMachine";
            this.Text = "frmPOPMachine";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메인화면ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설비관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공정관리ToolStripMenuItem;
        private Controls.UCMachine ucMachine1;
        private Controls.UCMachine ucMachine2;
        private Controls.UCMachine ucMachine3;
        private Controls.UCMachine ucMachine4;
        private Controls.UCMachine ucMachine5;
        private Controls.UCMachine ucMachine6;
    }
}