
namespace FinalProject1_winform
{
    partial class frmPOUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOUpload));
            this.txt_FileName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.btn_Insert = new FinalProject1_winform.Button_gudi();
            this.btn_Cancel = new FinalProject1_winform.Button_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SearchFile = new FinalProject1_winform.Button_gudi();
            this.dtp_Date = new FinalProject1_winform.DateTimePicker_gudi();
            this.label_gudi14 = new FinalProject1_winform.Label_gudi();
            this.txt_Version = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_FileName
            // 
            this.txt_FileName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_FileName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_FileName.Location = new System.Drawing.Point(156, 133);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(134, 25);
            this.txt_FileName.TabIndex = 77;
            // 
            // pictureBox_gudi1
            // 
            this.pictureBox_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi1.Image")));
            this.pictureBox_gudi1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_gudi1.Name = "pictureBox_gudi1";
            this.pictureBox_gudi1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox_gudi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi1.TabIndex = 3;
            this.pictureBox_gudi1.TabStop = false;
            // 
            // label_gudi1
            // 
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_gudi1.Location = new System.Drawing.Point(48, 11);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(155, 23);
            this.label_gudi1.TabIndex = 2;
            this.label_gudi1.Text = "고객 발주서 업로드";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btn_Insert.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btn_Insert.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Insert.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.Location = new System.Drawing.Point(123, 17);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 33);
            this.btn_Insert.TabIndex = 5;
            this.btn_Insert.Text = "업로드";
            this.btn_Insert.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.btn_Cancel.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(210, 17);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 33);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "닫기";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(55, 135);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(76, 17);
            this.label_gudi4.TabIndex = 52;
            this.label_gudi4.Text = "■ 파일 경로";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(55, 92);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(76, 17);
            this.label_gudi2.TabIndex = 51;
            this.label_gudi2.Text = "■ 파일 탐색";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_Insert);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 53);
            this.panel2.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 37);
            this.panel1.TabIndex = 47;
            // 
            // btn_SearchFile
            // 
            this.btn_SearchFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btn_SearchFile.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btn_SearchFile.FlatAppearance.BorderSize = 0;
            this.btn_SearchFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchFile.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_SearchFile.ForeColor = System.Drawing.Color.White;
            this.btn_SearchFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchFile.Image")));
            this.btn_SearchFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchFile.Location = new System.Drawing.Point(156, 84);
            this.btn_SearchFile.Name = "btn_SearchFile";
            this.btn_SearchFile.Size = new System.Drawing.Size(108, 32);
            this.btn_SearchFile.TabIndex = 78;
            this.btn_SearchFile.Text = "   파일선택";
            this.btn_SearchFile.UseVisualStyleBackColor = false;
            this.btn_SearchFile.Click += new System.EventHandler(this.btn_SearchFile_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(156, 175);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(134, 25);
            this.dtp_Date.TabIndex = 80;
            // 
            // label_gudi14
            // 
            this.label_gudi14.AutoSize = true;
            this.label_gudi14.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi14.Location = new System.Drawing.Point(55, 178);
            this.label_gudi14.Name = "label_gudi14";
            this.label_gudi14.Size = new System.Drawing.Size(76, 17);
            this.label_gudi14.TabIndex = 79;
            this.label_gudi14.Text = "■ 계획 일자";
            // 
            // txt_Version
            // 
            this.txt_Version.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_Version.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_Version.Location = new System.Drawing.Point(156, 217);
            this.txt_Version.Name = "txt_Version";
            this.txt_Version.Size = new System.Drawing.Size(134, 25);
            this.txt_Version.TabIndex = 82;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(55, 221);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(67, 17);
            this.label_gudi3.TabIndex = 81;
            this.label_gudi3.Text = "■ Version";
            // 
            // frmPOUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 367);
            this.Controls.Add(this.txt_Version);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.label_gudi14);
            this.Controls.Add(this.btn_SearchFile);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPOUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSMUpload";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.TextBox_gudi txt_FileName;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private Button_gudi btn_Insert;
        private Button_gudi btn_Cancel;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi btn_SearchFile;
        private DateTimePicker_gudi dtp_Date;
        private Label_gudi label_gudi14;
        private Controls.TextBox_gudi txt_Version;
        private Label_gudi label_gudi3;
    }
}