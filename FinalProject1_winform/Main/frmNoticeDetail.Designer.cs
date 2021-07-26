
namespace FinalProject1_winform
{
    partial class frmNoticeDetail
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
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.txtContent = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtTitle = new FinalProject1_winform.Controls.TextBox_gudi();
            this.SuspendLayout();
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(8, 72);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(32, 17);
            this.label_gudi3.TabIndex = 1;
            this.label_gudi3.Text = "내용";
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(8, 17);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(32, 17);
            this.label_gudi1.TabIndex = 1;
            this.label_gudi1.Text = "제목";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtContent.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtContent.Location = new System.Drawing.Point(8, 92);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(472, 228);
            this.txtContent.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtTitle.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtTitle.Location = new System.Drawing.Point(8, 37);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(466, 25);
            this.txtTitle.TabIndex = 0;
            // 
            // frmNoticeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(488, 337);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmNoticeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "공지사항 세부";
            this.Load += new System.EventHandler(this.frmNoticeDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TextBox_gudi txtTitle;
        private Controls.TextBox_gudi txtContent;
        private Label_gudi label_gudi1;
        private Label_gudi label_gudi3;
    }
}