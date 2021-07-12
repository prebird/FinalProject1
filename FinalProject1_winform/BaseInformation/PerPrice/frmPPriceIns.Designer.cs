
namespace FinalProject1_winform
{
    partial class frmPPriceIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPPriceIns));
            this.btnSave = new FinalProject1_winform.Button_gudi();
            this.btnClose = new FinalProject1_winform.Button_gudi();
            this.txtUadmin = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtedate = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtPrice_past = new FinalProject1_winform.Controls.TextBox_gudi();
            this.cboItemCode = new FinalProject1_winform.ComboBox_gudi();
            this.txtComment = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtUdate = new FinalProject1_winform.Controls.TextBox_gudi();
            this.cboyn = new FinalProject1_winform.ComboBox_gudi();
            this.dtpsdate = new FinalProject1_winform.DateTimePicker_gudi();
            this.txtPrice_present = new FinalProject1_winform.Controls.TextBox_gudi();
            this.cboCompanyCode = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi12 = new FinalProject1_winform.Label_gudi();
            this.label_gudi11 = new FinalProject1_winform.Label_gudi();
            this.label_gudi10 = new FinalProject1_winform.Label_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.cboItemCategory = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi9 = new FinalProject1_winform.Label_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSave.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(250, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 33);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.btnClose.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(372, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 33);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUadmin
            // 
            this.txtUadmin.Enabled = false;
            this.txtUadmin.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtUadmin.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtUadmin.Location = new System.Drawing.Point(439, 259);
            this.txtUadmin.Name = "txtUadmin";
            this.txtUadmin.Size = new System.Drawing.Size(162, 25);
            this.txtUadmin.TabIndex = 47;
            // 
            // txtedate
            // 
            this.txtedate.Enabled = false;
            this.txtedate.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtedate.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtedate.Location = new System.Drawing.Point(439, 208);
            this.txtedate.Name = "txtedate";
            this.txtedate.Size = new System.Drawing.Size(162, 25);
            this.txtedate.TabIndex = 46;
            // 
            // txtPrice_past
            // 
            this.txtPrice_past.Enabled = false;
            this.txtPrice_past.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtPrice_past.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtPrice_past.Location = new System.Drawing.Point(439, 157);
            this.txtPrice_past.Name = "txtPrice_past";
            this.txtPrice_past.Size = new System.Drawing.Size(162, 25);
            this.txtPrice_past.TabIndex = 45;
            // 
            // cboItemCode
            // 
            this.cboItemCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboItemCode.FormattingEnabled = true;
            this.cboItemCode.Location = new System.Drawing.Point(439, 55);
            this.cboItemCode.Name = "cboItemCode";
            this.cboItemCode.Size = new System.Drawing.Size(162, 24);
            this.cboItemCode.TabIndex = 44;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtComment.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtComment.Location = new System.Drawing.Point(133, 313);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(468, 98);
            this.txtComment.TabIndex = 43;
            // 
            // txtUdate
            // 
            this.txtUdate.Enabled = false;
            this.txtUdate.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtUdate.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtUdate.Location = new System.Drawing.Point(133, 260);
            this.txtUdate.Name = "txtUdate";
            this.txtUdate.Size = new System.Drawing.Size(162, 25);
            this.txtUdate.TabIndex = 42;
            // 
            // cboyn
            // 
            this.cboyn.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboyn.FormattingEnabled = true;
            this.cboyn.Items.AddRange(new object[] {
            "사용",
            "미사용"});
            this.cboyn.Location = new System.Drawing.Point(133, 208);
            this.cboyn.Name = "cboyn";
            this.cboyn.Size = new System.Drawing.Size(162, 24);
            this.cboyn.TabIndex = 41;
            // 
            // dtpsdate
            // 
            this.dtpsdate.Enabled = false;
            this.dtpsdate.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtpsdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpsdate.Location = new System.Drawing.Point(133, 158);
            this.dtpsdate.Name = "dtpsdate";
            this.dtpsdate.Size = new System.Drawing.Size(162, 25);
            this.dtpsdate.TabIndex = 40;
            // 
            // txtPrice_present
            // 
            this.txtPrice_present.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtPrice_present.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtPrice_present.Location = new System.Drawing.Point(133, 106);
            this.txtPrice_present.Name = "txtPrice_present";
            this.txtPrice_present.Size = new System.Drawing.Size(162, 25);
            this.txtPrice_present.TabIndex = 39;
            // 
            // cboCompanyCode
            // 
            this.cboCompanyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompanyCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompanyCode.FormattingEnabled = true;
            this.cboCompanyCode.Location = new System.Drawing.Point(133, 55);
            this.cboCompanyCode.Name = "cboCompanyCode";
            this.cboCompanyCode.Size = new System.Drawing.Size(162, 24);
            this.cboCompanyCode.TabIndex = 38;
            this.cboCompanyCode.SelectedIndexChanged += new System.EventHandler(this.cboCompanyCode_SelectedIndexChanged);
            // 
            // label_gudi12
            // 
            this.label_gudi12.AutoSize = true;
            this.label_gudi12.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi12.Location = new System.Drawing.Point(352, 263);
            this.label_gudi12.Name = "label_gudi12";
            this.label_gudi12.Size = new System.Drawing.Size(60, 17);
            this.label_gudi12.TabIndex = 37;
            this.label_gudi12.Text = "■ 수정자";
            // 
            // label_gudi11
            // 
            this.label_gudi11.AutoSize = true;
            this.label_gudi11.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi11.Location = new System.Drawing.Point(352, 212);
            this.label_gudi11.Name = "label_gudi11";
            this.label_gudi11.Size = new System.Drawing.Size(60, 17);
            this.label_gudi11.TabIndex = 36;
            this.label_gudi11.Text = "■ 종료일";
            // 
            // label_gudi10
            // 
            this.label_gudi10.AutoSize = true;
            this.label_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi10.Location = new System.Drawing.Point(352, 161);
            this.label_gudi10.Name = "label_gudi10";
            this.label_gudi10.Size = new System.Drawing.Size(72, 17);
            this.label_gudi10.TabIndex = 35;
            this.label_gudi10.Text = "■ 이전단가";
            // 
            // label_gudi8
            // 
            this.label_gudi8.AutoSize = true;
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi8.Location = new System.Drawing.Point(352, 58);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(48, 17);
            this.label_gudi8.TabIndex = 34;
            this.label_gudi8.Text = "■ 품목";
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi7.Location = new System.Drawing.Point(36, 313);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(48, 17);
            this.label_gudi7.TabIndex = 33;
            this.label_gudi7.Text = "■ 비고";
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(36, 262);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(60, 17);
            this.label_gudi6.TabIndex = 32;
            this.label_gudi6.Text = "■ 수정일";
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(36, 211);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(72, 17);
            this.label_gudi5.TabIndex = 31;
            this.label_gudi5.Text = "■ 사용유무";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi4.Location = new System.Drawing.Point(36, 160);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(60, 17);
            this.label_gudi4.TabIndex = 30;
            this.label_gudi4.Text = "■ 시작일";
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi3.Location = new System.Drawing.Point(36, 109);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(72, 17);
            this.label_gudi3.TabIndex = 29;
            this.label_gudi3.Text = "■ 현재단가";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi2.Location = new System.Drawing.Point(36, 58);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(48, 17);
            this.label_gudi2.TabIndex = 28;
            this.label_gudi2.Text = "■ 업체";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 37);
            this.panel1.TabIndex = 27;
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
            this.label_gudi1.Text = "단가관리";
            // 
            // cboItemCategory
            // 
            this.cboItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemCategory.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboItemCategory.FormattingEnabled = true;
            this.cboItemCategory.Items.AddRange(new object[] {
            "원자재",
            "반제품",
            "완제품"});
            this.cboItemCategory.Location = new System.Drawing.Point(439, 106);
            this.cboItemCategory.Name = "cboItemCategory";
            this.cboItemCategory.Size = new System.Drawing.Size(162, 24);
            this.cboItemCategory.TabIndex = 51;
            // 
            // label_gudi9
            // 
            this.label_gudi9.AutoSize = true;
            this.label_gudi9.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi9.Location = new System.Drawing.Point(352, 109);
            this.label_gudi9.Name = "label_gudi9";
            this.label_gudi9.Size = new System.Drawing.Size(72, 17);
            this.label_gudi9.TabIndex = 50;
            this.label_gudi9.Text = "■ 품목유형";
            // 
            // frmPPriceIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 470);
            this.Controls.Add(this.cboItemCategory);
            this.Controls.Add(this.label_gudi9);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtUadmin);
            this.Controls.Add(this.txtedate);
            this.Controls.Add(this.txtPrice_past);
            this.Controls.Add(this.cboItemCode);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtUdate);
            this.Controls.Add(this.cboyn);
            this.Controls.Add(this.dtpsdate);
            this.Controls.Add(this.txtPrice_present);
            this.Controls.Add(this.cboCompanyCode);
            this.Controls.Add(this.label_gudi12);
            this.Controls.Add(this.label_gudi11);
            this.Controls.Add(this.label_gudi10);
            this.Controls.Add(this.label_gudi8);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.label_gudi6);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPPriceIns";
            this.Text = "frmPPriceIns";
            this.Load += new System.EventHandler(this.frmPPriceIns_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button_gudi btnSave;
        private Button_gudi btnClose;
        private Controls.TextBox_gudi txtUadmin;
        private Controls.TextBox_gudi txtedate;
        private Controls.TextBox_gudi txtPrice_past;
        private ComboBox_gudi cboItemCode;
        private Controls.TextBox_gudi txtComment;
        private Controls.TextBox_gudi txtUdate;
        private ComboBox_gudi cboyn;
        private DateTimePicker_gudi dtpsdate;
        private Controls.TextBox_gudi txtPrice_present;
        private ComboBox_gudi cboCompanyCode;
        private Label_gudi label_gudi12;
        private Label_gudi label_gudi11;
        private Label_gudi label_gudi10;
        private Label_gudi label_gudi8;
        private Label_gudi label_gudi7;
        private Label_gudi label_gudi6;
        private Label_gudi label_gudi5;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi2;
        private System.Windows.Forms.Panel panel1;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private ComboBox_gudi cboItemCategory;
        private Label_gudi label_gudi9;
    }
}