
namespace FinalProject1_winform
{
    partial class frmCompanyInfoIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyInfoIns));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.cboCompanyYN = new FinalProject1_winform.ComboBox_gudi();
            this.txtCompanyName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.dtpDateTime = new FinalProject1_winform.DateTimePick_Format_Time();
            this.txtCompanyCode = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtCompanyUadmin = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi21 = new FinalProject1_winform.Label_gudi();
            this.label_gudi19 = new FinalProject1_winform.Label_gudi();
            this.label_gudi17 = new FinalProject1_winform.Label_gudi();
            this.txtCompanyEmail = new FinalProject1_winform.Controls.TextBox_gudi();
            this.cboCompanyType = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi13 = new FinalProject1_winform.Label_gudi();
            this.label_gudi15 = new FinalProject1_winform.Label_gudi();
            this.btnSave = new FinalProject1_winform.Button_gudi();
            this.btnClose = new FinalProject1_winform.Button_gudi();
            this.txtCompanyCrum = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtCompanyComment = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtCompanyPhone = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtCompanyCeo = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi10 = new FinalProject1_winform.Label_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 37);
            this.panel1.TabIndex = 49;
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
            this.label_gudi1.Text = "업체정보";
            // 
            // cboCompanyYN
            // 
            this.cboCompanyYN.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompanyYN.FormattingEnabled = true;
            this.cboCompanyYN.Items.AddRange(new object[] {
            "사용",
            "미사용"});
            this.cboCompanyYN.Location = new System.Drawing.Point(421, 152);
            this.cboCompanyYN.Name = "cboCompanyYN";
            this.cboCompanyYN.Size = new System.Drawing.Size(162, 24);
            this.cboCompanyYN.TabIndex = 76;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyName.Location = new System.Drawing.Point(421, 54);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(162, 25);
            this.txtCompanyName.TabIndex = 74;
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpDateTime.Enabled = false;
            this.dtpDateTime.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTime.Location = new System.Drawing.Point(115, 202);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(162, 25);
            this.dtpDateTime.TabIndex = 73;
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyCode.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyCode.Location = new System.Drawing.Point(115, 54);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(162, 25);
            this.txtCompanyCode.TabIndex = 70;
            // 
            // txtCompanyUadmin
            // 
            this.txtCompanyUadmin.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyUadmin.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyUadmin.Location = new System.Drawing.Point(693, 155);
            this.txtCompanyUadmin.Name = "txtCompanyUadmin";
            this.txtCompanyUadmin.ReadOnly = true;
            this.txtCompanyUadmin.Size = new System.Drawing.Size(162, 25);
            this.txtCompanyUadmin.TabIndex = 69;
            // 
            // label_gudi21
            // 
            this.label_gudi21.AutoSize = true;
            this.label_gudi21.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi21.Location = new System.Drawing.Point(595, 155);
            this.label_gudi21.Name = "label_gudi21";
            this.label_gudi21.Size = new System.Drawing.Size(60, 17);
            this.label_gudi21.TabIndex = 68;
            this.label_gudi21.Text = "■ 수정자";
            // 
            // label_gudi19
            // 
            this.label_gudi19.AutoSize = true;
            this.label_gudi19.BackColor = System.Drawing.Color.White;
            this.label_gudi19.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi19.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi19.Location = new System.Drawing.Point(306, 155);
            this.label_gudi19.Name = "label_gudi19";
            this.label_gudi19.Size = new System.Drawing.Size(72, 17);
            this.label_gudi19.TabIndex = 64;
            this.label_gudi19.Text = "■ 사용유무";
            // 
            // label_gudi17
            // 
            this.label_gudi17.AutoSize = true;
            this.label_gudi17.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi17.Location = new System.Drawing.Point(18, 208);
            this.label_gudi17.Name = "label_gudi17";
            this.label_gudi17.Size = new System.Drawing.Size(72, 17);
            this.label_gudi17.TabIndex = 60;
            this.label_gudi17.Text = "■ 수정시간";
            // 
            // txtCompanyEmail
            // 
            this.txtCompanyEmail.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyEmail.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyEmail.Location = new System.Drawing.Point(693, 107);
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.txtCompanyEmail.Size = new System.Drawing.Size(162, 25);
            this.txtCompanyEmail.TabIndex = 56;
            // 
            // cboCompanyType
            // 
            this.cboCompanyType.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompanyType.FormattingEnabled = true;
            this.cboCompanyType.Items.AddRange(new object[] {
            "고객사",
            "협력사"});
            this.cboCompanyType.Location = new System.Drawing.Point(693, 54);
            this.cboCompanyType.Name = "cboCompanyType";
            this.cboCompanyType.Size = new System.Drawing.Size(162, 24);
            this.cboCompanyType.TabIndex = 54;
            // 
            // label_gudi13
            // 
            this.label_gudi13.AutoSize = true;
            this.label_gudi13.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi13.Location = new System.Drawing.Point(595, 107);
            this.label_gudi13.Name = "label_gudi13";
            this.label_gudi13.Size = new System.Drawing.Size(60, 17);
            this.label_gudi13.TabIndex = 52;
            this.label_gudi13.Text = "■ 이메일";
            // 
            // label_gudi15
            // 
            this.label_gudi15.AutoSize = true;
            this.label_gudi15.BackColor = System.Drawing.Color.White;
            this.label_gudi15.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi15.Location = new System.Drawing.Point(595, 58);
            this.label_gudi15.Name = "label_gudi15";
            this.label_gudi15.Size = new System.Drawing.Size(72, 17);
            this.label_gudi15.TabIndex = 50;
            this.label_gudi15.Text = "■ 업체타입";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSave.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(344, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 33);
            this.btnSave.TabIndex = 48;
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
            this.btnClose.Location = new System.Drawing.Point(483, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 33);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCompanyCrum
            // 
            this.txtCompanyCrum.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyCrum.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyCrum.Location = new System.Drawing.Point(421, 104);
            this.txtCompanyCrum.Name = "txtCompanyCrum";
            this.txtCompanyCrum.Size = new System.Drawing.Size(162, 25);
            this.txtCompanyCrum.TabIndex = 44;
            // 
            // txtCompanyComment
            // 
            this.txtCompanyComment.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyComment.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyComment.Location = new System.Drawing.Point(115, 265);
            this.txtCompanyComment.Multiline = true;
            this.txtCompanyComment.Name = "txtCompanyComment";
            this.txtCompanyComment.Size = new System.Drawing.Size(729, 98);
            this.txtCompanyComment.TabIndex = 42;
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyPhone.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyPhone.Location = new System.Drawing.Point(115, 153);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(162, 25);
            this.txtCompanyPhone.TabIndex = 41;
            // 
            // txtCompanyCeo
            // 
            this.txtCompanyCeo.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyCeo.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyCeo.Location = new System.Drawing.Point(115, 103);
            this.txtCompanyCeo.Name = "txtCompanyCeo";
            this.txtCompanyCeo.Size = new System.Drawing.Size(162, 25);
            this.txtCompanyCeo.TabIndex = 38;
            // 
            // label_gudi10
            // 
            this.label_gudi10.AutoSize = true;
            this.label_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi10.Location = new System.Drawing.Point(306, 107);
            this.label_gudi10.Name = "label_gudi10";
            this.label_gudi10.Size = new System.Drawing.Size(108, 17);
            this.label_gudi10.TabIndex = 34;
            this.label_gudi10.Text = "■ 사업자등록번호";
            // 
            // label_gudi8
            // 
            this.label_gudi8.AutoSize = true;
            this.label_gudi8.BackColor = System.Drawing.Color.White;
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi8.Location = new System.Drawing.Point(306, 58);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(60, 17);
            this.label_gudi8.TabIndex = 33;
            this.label_gudi8.Text = "■ 업체명";
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi7.Location = new System.Drawing.Point(18, 265);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(72, 17);
            this.label_gudi7.TabIndex = 32;
            this.label_gudi7.Text = "■ 업체정보";
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(18, 155);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(72, 17);
            this.label_gudi6.TabIndex = 31;
            this.label_gudi6.Text = "■ 전화번호";
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi3.Location = new System.Drawing.Point(18, 107);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(72, 17);
            this.label_gudi3.TabIndex = 28;
            this.label_gudi3.Text = "■ 대표자명";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.BackColor = System.Drawing.Color.White;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi2.Location = new System.Drawing.Point(18, 58);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(72, 17);
            this.label_gudi2.TabIndex = 27;
            this.label_gudi2.Text = "■ 업체코드";
            // 
            // frmCompanyInfoIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 444);
            this.Controls.Add(this.cboCompanyYN);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.txtCompanyCode);
            this.Controls.Add(this.txtCompanyUadmin);
            this.Controls.Add(this.label_gudi21);
            this.Controls.Add(this.label_gudi19);
            this.Controls.Add(this.label_gudi17);
            this.Controls.Add(this.txtCompanyEmail);
            this.Controls.Add(this.cboCompanyType);
            this.Controls.Add(this.label_gudi13);
            this.Controls.Add(this.label_gudi15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCompanyCrum);
            this.Controls.Add(this.txtCompanyComment);
            this.Controls.Add(this.txtCompanyPhone);
            this.Controls.Add(this.txtCompanyCeo);
            this.Controls.Add(this.label_gudi10);
            this.Controls.Add(this.label_gudi8);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.label_gudi6);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.label_gudi2);
            this.Name = "frmCompanyInfoIns";
            this.Load += new System.EventHandler(this.frmCompanyInfoIns_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button_gudi btnSave;
        private Button_gudi btnClose;
        private Controls.TextBox_gudi txtCompanyCrum;
        private Controls.TextBox_gudi txtCompanyComment;
        private Controls.TextBox_gudi txtCompanyPhone;
        private Controls.TextBox_gudi txtCompanyCeo;
        private Label_gudi label_gudi10;
        private Label_gudi label_gudi8;
        private Label_gudi label_gudi7;
        private Label_gudi label_gudi6;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi2;
        private System.Windows.Forms.Panel panel1;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private Controls.TextBox_gudi txtCompanyEmail;
        private ComboBox_gudi cboCompanyType;
        private Label_gudi label_gudi13;
        private Label_gudi label_gudi15;
        private Label_gudi label_gudi17;
        private Label_gudi label_gudi19;
        private Controls.TextBox_gudi txtCompanyUadmin;
        private Label_gudi label_gudi21;
        private Controls.TextBox_gudi txtCompanyCode;
        private DateTimePick_Format_Time dtpDateTime;
        private Controls.TextBox_gudi txtCompanyName;
        private ComboBox_gudi cboCompanyYN;
    }
}