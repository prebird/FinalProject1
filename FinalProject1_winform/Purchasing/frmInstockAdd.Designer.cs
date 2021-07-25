
namespace FinalProject1_winform
{
    partial class frmInstockAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstockAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.cboType = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.txtUser = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.txtCnt = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.label_gudi9 = new FinalProject1_winform.Label_gudi();
            this.txtTime = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi10 = new FinalProject1_winform.Label_gudi();
            this.txtNote = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi11 = new FinalProject1_winform.Label_gudi();
            this.btnSave = new FinalProject1_winform.Button_gudi();
            this.btnClose = new FinalProject1_winform.Button_gudi();
            this.cbofactory = new FinalProject1_winform.ComboBox_gudi();
            this.cboItem = new FinalProject1_winform.ComboBox_gudi();
            this.txtPOID = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtROID = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 37);
            this.panel1.TabIndex = 2;
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
            this.label_gudi1.Text = "입출고등록";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(32, 117);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(84, 17);
            this.label_gudi2.TabIndex = 3;
            this.label_gudi2.Text = "■ 입출고창고";
            // 
            // cboType
            // 
            this.cboType.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "선택",
            "입고",
            "출고"});
            this.cboType.Location = new System.Drawing.Point(127, 70);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(159, 24);
            this.cboType.TabIndex = 4;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(32, 161);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(48, 17);
            this.label_gudi3.TabIndex = 3;
            this.label_gudi3.Text = "■ 품목";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(32, 205);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(72, 17);
            this.label_gudi4.TabIndex = 3;
            this.label_gudi4.Text = "■ 구매번호";
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(337, 72);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(60, 17);
            this.label_gudi5.TabIndex = 3;
            this.label_gudi5.Text = "■ 담당자";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtUser.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtUser.Location = new System.Drawing.Point(428, 69);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(159, 25);
            this.txtUser.TabIndex = 5;
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(32, 295);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(84, 17);
            this.label_gudi6.TabIndex = 3;
            this.label_gudi6.Text = "■ 입출고갯수";
            // 
            // txtCnt
            // 
            this.txtCnt.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCnt.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCnt.Location = new System.Drawing.Point(127, 291);
            this.txtCnt.Name = "txtCnt";
            this.txtCnt.Size = new System.Drawing.Size(159, 25);
            this.txtCnt.TabIndex = 5;
            // 
            // label_gudi8
            // 
            this.label_gudi8.AutoSize = true;
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi8.Location = new System.Drawing.Point(32, 73);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(84, 17);
            this.label_gudi8.TabIndex = 3;
            this.label_gudi8.Text = "■ 입출고타입";
            this.label_gudi8.Click += new System.EventHandler(this.label_gudi8_Click);
            // 
            // label_gudi9
            // 
            this.label_gudi9.AutoSize = true;
            this.label_gudi9.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi9.Location = new System.Drawing.Point(337, 112);
            this.label_gudi9.Name = "label_gudi9";
            this.label_gudi9.Size = new System.Drawing.Size(84, 17);
            this.label_gudi9.TabIndex = 3;
            this.label_gudi9.Text = "■ 입출고시간";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtTime.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtTime.Location = new System.Drawing.Point(428, 109);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(159, 25);
            this.txtTime.TabIndex = 5;
            // 
            // label_gudi10
            // 
            this.label_gudi10.AutoSize = true;
            this.label_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi10.Location = new System.Drawing.Point(337, 152);
            this.label_gudi10.Name = "label_gudi10";
            this.label_gudi10.Size = new System.Drawing.Size(72, 17);
            this.label_gudi10.TabIndex = 3;
            this.label_gudi10.Text = "■ 특이사항";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtNote.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtNote.Location = new System.Drawing.Point(427, 149);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(346, 167);
            this.txtNote.TabIndex = 5;
            // 
            // label_gudi11
            // 
            this.label_gudi11.AutoSize = true;
            this.label_gudi11.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi11.Location = new System.Drawing.Point(32, 249);
            this.label_gudi11.Name = "label_gudi11";
            this.label_gudi11.Size = new System.Drawing.Size(72, 17);
            this.label_gudi11.TabIndex = 3;
            this.label_gudi11.Text = "■ 발주번호";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSave.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(288, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 33);
            this.btnSave.TabIndex = 6;
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
            this.btnClose.Location = new System.Drawing.Point(396, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 33);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbofactory
            // 
            this.cbofactory.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbofactory.FormattingEnabled = true;
            this.cbofactory.Items.AddRange(new object[] {
            "선택",
            "입고",
            "출고"});
            this.cbofactory.Location = new System.Drawing.Point(127, 114);
            this.cbofactory.Name = "cbofactory";
            this.cbofactory.Size = new System.Drawing.Size(159, 24);
            this.cbofactory.TabIndex = 4;
            // 
            // cboItem
            // 
            this.cboItem.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Items.AddRange(new object[] {
            "선택",
            "입고",
            "출고"});
            this.cboItem.Location = new System.Drawing.Point(127, 158);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(159, 24);
            this.cboItem.TabIndex = 4;
            // 
            // txtPOID
            // 
            this.txtPOID.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtPOID.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtPOID.Location = new System.Drawing.Point(127, 202);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Size = new System.Drawing.Size(159, 25);
            this.txtPOID.TabIndex = 5;
            // 
            // txtROID
            // 
            this.txtROID.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtROID.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtROID.Location = new System.Drawing.Point(127, 246);
            this.txtROID.Name = "txtROID";
            this.txtROID.Size = new System.Drawing.Size(159, 25);
            this.txtROID.TabIndex = 5;
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi7.ForeColor = System.Drawing.Color.Red;
            this.label_gudi7.Location = new System.Drawing.Point(47, 332);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(239, 15);
            this.label_gudi7.TabIndex = 3;
            this.label_gudi7.Text = "* 구매번호와 발주번호중 하나만 입력하시면 됩니다.";
            // 
            // frmInstockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(794, 434);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label_gudi11);
            this.Controls.Add(this.txtCnt);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtROID);
            this.Controls.Add(this.txtPOID);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.label_gudi6);
            this.Controls.Add(this.label_gudi10);
            this.Controls.Add(this.label_gudi9);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.cbofactory);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label_gudi8);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmInstockAdd";
            this.Text = "frmInstockAdd";
            this.Load += new System.EventHandler(this.frmInstockAdd_Load);
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
        private ComboBox_gudi cboType;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi5;
        private Controls.TextBox_gudi txtUser;
        private Label_gudi label_gudi6;
        private Controls.TextBox_gudi txtCnt;
        private Label_gudi label_gudi8;
        private Label_gudi label_gudi9;
        private Controls.TextBox_gudi txtTime;
        private Label_gudi label_gudi10;
        private Controls.TextBox_gudi txtNote;
        private Label_gudi label_gudi11;
        private Button_gudi btnSave;
        private Button_gudi btnClose;
        private ComboBox_gudi cbofactory;
        private ComboBox_gudi cboItem;
        private Controls.TextBox_gudi txtPOID;
        private Controls.TextBox_gudi txtROID;
        private Label_gudi label_gudi7;
    }
}