
namespace FinalProject1_winform
{
    partial class frmMasterInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterInsert));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Destination = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txt_CancelCnt = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txt_OutCnt = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txt_EditManger = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi17 = new FinalProject1_winform.Label_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.txt_Content = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.btn_Insert = new FinalProject1_winform.Button_gudi();
            this.btn_Cancel = new FinalProject1_winform.Button_gudi();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.lbl_Title = new FinalProject1_winform.Label_gudi();
            this.dtp_EditDate = new FinalProject1_winform.DateTimePicker_gudi();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_Insert);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 51);
            this.panel2.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox_gudi1);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 37);
            this.panel1.TabIndex = 47;
            // 
            // txt_Destination
            // 
            this.txt_Destination.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_Destination.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_Destination.Location = new System.Drawing.Point(129, 82);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(144, 25);
            this.txt_Destination.TabIndex = 68;
            // 
            // txt_CancelCnt
            // 
            this.txt_CancelCnt.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_CancelCnt.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_CancelCnt.Location = new System.Drawing.Point(129, 166);
            this.txt_CancelCnt.Name = "txt_CancelCnt";
            this.txt_CancelCnt.Size = new System.Drawing.Size(144, 25);
            this.txt_CancelCnt.TabIndex = 67;
            // 
            // txt_OutCnt
            // 
            this.txt_OutCnt.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_OutCnt.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_OutCnt.Location = new System.Drawing.Point(129, 124);
            this.txt_OutCnt.Name = "txt_OutCnt";
            this.txt_OutCnt.Size = new System.Drawing.Size(144, 25);
            this.txt_OutCnt.TabIndex = 66;
            // 
            // txt_EditManger
            // 
            this.txt_EditManger.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_EditManger.FormattingEnabled = true;
            this.txt_EditManger.Items.AddRange(new object[] {
            "박재성",
            "박기덕",
            "이용이",
            "정용규"});
            this.txt_EditManger.Location = new System.Drawing.Point(391, 82);
            this.txt_EditManger.Name = "txt_EditManger";
            this.txt_EditManger.Size = new System.Drawing.Size(144, 24);
            this.txt_EditManger.TabIndex = 65;
            // 
            // label_gudi17
            // 
            this.label_gudi17.AutoSize = true;
            this.label_gudi17.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi17.Location = new System.Drawing.Point(305, 127);
            this.label_gudi17.Name = "label_gudi17";
            this.label_gudi17.Size = new System.Drawing.Size(60, 17);
            this.label_gudi17.TabIndex = 60;
            this.label_gudi17.Text = "■ 수정일";
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi7.Location = new System.Drawing.Point(305, 86);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(60, 17);
            this.label_gudi7.TabIndex = 54;
            this.label_gudi7.Text = "■ 수정자";
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(43, 166);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(76, 17);
            this.label_gudi5.TabIndex = 53;
            this.label_gudi5.Text = "■ 취소 수량";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(43, 126);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(76, 17);
            this.label_gudi4.TabIndex = 52;
            this.label_gudi4.Text = "■ 출고 수량";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(43, 86);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(60, 17);
            this.label_gudi2.TabIndex = 51;
            this.label_gudi2.Text = "■ 도착지";
            // 
            // txt_Content
            // 
            this.txt_Content.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_Content.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_Content.Location = new System.Drawing.Point(129, 208);
            this.txt_Content.Multiline = true;
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(406, 68);
            this.txt_Content.TabIndex = 50;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(43, 206);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(48, 17);
            this.label_gudi3.TabIndex = 49;
            this.label_gudi3.Text = "■ 비고";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btn_Insert.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Insert.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.Location = new System.Drawing.Point(229, 6);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 33);
            this.btn_Insert.TabIndex = 69;
            this.btn_Insert.Text = "저장";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
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
            this.btn_Cancel.Location = new System.Drawing.Point(315, 6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 33);
            this.btn_Cancel.TabIndex = 70;
            this.btn_Cancel.Text = "닫기";
            this.btn_Cancel.UseVisualStyleBackColor = false;
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
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Title.Location = new System.Drawing.Point(48, 11);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(155, 23);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "확정 Order 입력";
            // 
            // dtp_EditDate
            // 
            this.dtp_EditDate.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtp_EditDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EditDate.Location = new System.Drawing.Point(391, 124);
            this.dtp_EditDate.Name = "dtp_EditDate";
            this.dtp_EditDate.Size = new System.Drawing.Size(144, 25);
            this.dtp_EditDate.TabIndex = 69;
            // 
            // frmMasterInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 372);
            this.Controls.Add(this.dtp_EditDate);
            this.Controls.Add(this.txt_Destination);
            this.Controls.Add(this.txt_CancelCnt);
            this.Controls.Add(this.txt_OutCnt);
            this.Controls.Add(this.txt_EditManger);
            this.Controls.Add(this.label_gudi17);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMasterInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMasterInsert";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.TextBox_gudi txt_Destination;
        private Controls.TextBox_gudi txt_CancelCnt;
        private Controls.TextBox_gudi txt_OutCnt;
        private ComboBox_gudi txt_EditManger;
        private Label_gudi label_gudi17;
        private Label_gudi label_gudi7;
        private Label_gudi label_gudi5;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi2;
        private Controls.TextBox_gudi txt_Content;
        private Label_gudi label_gudi3;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi lbl_Title;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi btn_Insert;
        private Button_gudi btn_Cancel;
        private DateTimePicker_gudi dtp_EditDate;
    }
}