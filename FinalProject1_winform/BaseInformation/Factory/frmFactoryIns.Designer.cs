
namespace FinalProject1_winform
{
    partial class frmFactoryIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactoryIns));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.label_gudi9 = new FinalProject1_winform.Label_gudi();
            this.label_gudi10 = new FinalProject1_winform.Label_gudi();
            this.cboFactoryGrade = new FinalProject1_winform.ComboBox_gudi();
            this.cboCompanyCode = new FinalProject1_winform.ComboBox_gudi();
            this.cboFactoryYN = new FinalProject1_winform.ComboBox_gudi();
            this.cboFactoryParent = new FinalProject1_winform.ComboBox_gudi();
            this.cboCompanyType = new FinalProject1_winform.ComboBox_gudi();
            this.txtFactoryName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtFactoryCode = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtFactoryUdate = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtFactoryComment = new FinalProject1_winform.Controls.TextBox_gudi();
            this.btnSave = new FinalProject1_winform.Button_gudi();
            this.btnClose = new FinalProject1_winform.Button_gudi();
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
            this.panel1.Size = new System.Drawing.Size(601, 37);
            this.panel1.TabIndex = 5;
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
            this.label_gudi1.Text = "공장정보";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi2.Location = new System.Drawing.Point(23, 75);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(52, 16);
            this.label_gudi2.TabIndex = 6;
            this.label_gudi2.Text = "■시설군";
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi3.Location = new System.Drawing.Point(23, 138);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(52, 16);
            this.label_gudi3.TabIndex = 7;
            this.label_gudi3.Text = "■시설명";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi4.Location = new System.Drawing.Point(23, 201);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(41, 16);
            this.label_gudi4.TabIndex = 8;
            this.label_gudi4.Text = "■업체";
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi5.Location = new System.Drawing.Point(23, 264);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(63, 16);
            this.label_gudi5.TabIndex = 9;
            this.label_gudi5.Text = "■사용유무";
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi6.Location = new System.Drawing.Point(23, 327);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(63, 16);
            this.label_gudi6.TabIndex = 10;
            this.label_gudi6.Text = "■시설설명";
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi7.Location = new System.Drawing.Point(322, 75);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(63, 16);
            this.label_gudi7.TabIndex = 11;
            this.label_gudi7.Text = "■상위시설";
            // 
            // label_gudi8
            // 
            this.label_gudi8.AutoSize = true;
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi8.Location = new System.Drawing.Point(322, 138);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(63, 16);
            this.label_gudi8.TabIndex = 12;
            this.label_gudi8.Text = "■시설코드";
            // 
            // label_gudi9
            // 
            this.label_gudi9.AutoSize = true;
            this.label_gudi9.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_gudi9.Location = new System.Drawing.Point(322, 201);
            this.label_gudi9.Name = "label_gudi9";
            this.label_gudi9.Size = new System.Drawing.Size(63, 16);
            this.label_gudi9.TabIndex = 13;
            this.label_gudi9.Text = "■시설구분";
            // 
            // label_gudi10
            // 
            this.label_gudi10.AutoSize = true;
            this.label_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi10.Location = new System.Drawing.Point(322, 264);
            this.label_gudi10.Name = "label_gudi10";
            this.label_gudi10.Size = new System.Drawing.Size(63, 16);
            this.label_gudi10.TabIndex = 14;
            this.label_gudi10.Text = "■수정시간";
            // 
            // cboFactoryGrade
            // 
            this.cboFactoryGrade.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboFactoryGrade.FormattingEnabled = true;
            this.cboFactoryGrade.Items.AddRange(new object[] {
            "회사",
            "공장",
            "창고"});
            this.cboFactoryGrade.Location = new System.Drawing.Point(97, 72);
            this.cboFactoryGrade.Name = "cboFactoryGrade";
            this.cboFactoryGrade.Size = new System.Drawing.Size(145, 24);
            this.cboFactoryGrade.TabIndex = 15;
            // 
            // cboCompanyCode
            // 
            this.cboCompanyCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompanyCode.FormattingEnabled = true;
            this.cboCompanyCode.Location = new System.Drawing.Point(97, 194);
            this.cboCompanyCode.Name = "cboCompanyCode";
            this.cboCompanyCode.Size = new System.Drawing.Size(145, 24);
            this.cboCompanyCode.TabIndex = 16;
            // 
            // cboFactoryYN
            // 
            this.cboFactoryYN.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboFactoryYN.FormattingEnabled = true;
            this.cboFactoryYN.Location = new System.Drawing.Point(97, 261);
            this.cboFactoryYN.Name = "cboFactoryYN";
            this.cboFactoryYN.Size = new System.Drawing.Size(145, 24);
            this.cboFactoryYN.TabIndex = 17;
            // 
            // cboFactoryParent
            // 
            this.cboFactoryParent.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboFactoryParent.FormattingEnabled = true;
            this.cboFactoryParent.Items.AddRange(new object[] {
            "(주)구디"});
            this.cboFactoryParent.Location = new System.Drawing.Point(405, 72);
            this.cboFactoryParent.Name = "cboFactoryParent";
            this.cboFactoryParent.Size = new System.Drawing.Size(145, 24);
            this.cboFactoryParent.TabIndex = 18;
            // 
            // cboCompanyType
            // 
            this.cboCompanyType.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompanyType.FormattingEnabled = true;
            this.cboCompanyType.Location = new System.Drawing.Point(405, 198);
            this.cboCompanyType.Name = "cboCompanyType";
            this.cboCompanyType.Size = new System.Drawing.Size(145, 24);
            this.cboCompanyType.TabIndex = 19;
            // 
            // txtFactoryName
            // 
            this.txtFactoryName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtFactoryName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtFactoryName.Location = new System.Drawing.Point(97, 135);
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.Size = new System.Drawing.Size(145, 25);
            this.txtFactoryName.TabIndex = 20;
            // 
            // txtFactoryCode
            // 
            this.txtFactoryCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtFactoryCode.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtFactoryCode.Location = new System.Drawing.Point(405, 135);
            this.txtFactoryCode.Name = "txtFactoryCode";
            this.txtFactoryCode.Size = new System.Drawing.Size(145, 25);
            this.txtFactoryCode.TabIndex = 21;
            // 
            // txtFactoryUdate
            // 
            this.txtFactoryUdate.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtFactoryUdate.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtFactoryUdate.Location = new System.Drawing.Point(405, 261);
            this.txtFactoryUdate.Name = "txtFactoryUdate";
            this.txtFactoryUdate.Size = new System.Drawing.Size(145, 25);
            this.txtFactoryUdate.TabIndex = 22;
            // 
            // txtFactoryComment
            // 
            this.txtFactoryComment.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtFactoryComment.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtFactoryComment.Location = new System.Drawing.Point(97, 327);
            this.txtFactoryComment.Multiline = true;
            this.txtFactoryComment.Name = "txtFactoryComment";
            this.txtFactoryComment.Size = new System.Drawing.Size(453, 116);
            this.txtFactoryComment.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSave.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(203, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 33);
            this.btnSave.TabIndex = 28;
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
            this.btnClose.Location = new System.Drawing.Point(325, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 33);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmFactoryIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 501);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFactoryComment);
            this.Controls.Add(this.txtFactoryUdate);
            this.Controls.Add(this.txtFactoryCode);
            this.Controls.Add(this.txtFactoryName);
            this.Controls.Add(this.cboCompanyType);
            this.Controls.Add(this.cboFactoryParent);
            this.Controls.Add(this.cboFactoryYN);
            this.Controls.Add(this.cboCompanyCode);
            this.Controls.Add(this.cboFactoryGrade);
            this.Controls.Add(this.label_gudi10);
            this.Controls.Add(this.label_gudi9);
            this.Controls.Add(this.label_gudi8);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.label_gudi6);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmFactoryIns";
            this.Text = "frmFactoryIns";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi5;
        private Label_gudi label_gudi6;
        private Label_gudi label_gudi7;
        private Label_gudi label_gudi8;
        private Label_gudi label_gudi9;
        private Label_gudi label_gudi10;
        private ComboBox_gudi cboFactoryGrade;
        private ComboBox_gudi cboCompanyCode;
        private ComboBox_gudi cboFactoryYN;
        private ComboBox_gudi cboFactoryParent;
        private ComboBox_gudi cboCompanyType;
        private Controls.TextBox_gudi txtFactoryName;
        private Controls.TextBox_gudi txtFactoryCode;
        private Controls.TextBox_gudi txtFactoryUdate;
        private Controls.TextBox_gudi txtFactoryComment;
        private Button_gudi btnSave;
        private Button_gudi btnClose;
    }
}