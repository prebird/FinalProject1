
namespace FinalProject1_winform
{
    partial class frmItemInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemInsert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.lbl_Title = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_InsUp = new FinalProject1_winform.Button_gudi();
            this.btn_Cancel = new FinalProject1_winform.Button_gudi();
            this.cbo_OrderType = new FinalProject1_winform.ComboBox_gudi();
            this.cbo_YN = new FinalProject1_winform.ComboBox_gudi();
            this.txt_SafetyQTY = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txt_UnitQTY = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txt_Name = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txt_Code = new FinalProject1_winform.Controls.TextBox_gudi();
            this.cbo_Category = new FinalProject1_winform.ComboBox_gudi();
            this.cbo_CheckType = new FinalProject1_winform.ComboBox_gudi();
            this.cbo_OutHouse = new FinalProject1_winform.ComboBox_gudi();
            this.cbo_InHouse = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi17 = new FinalProject1_winform.Label_gudi();
            this.label_gudi14 = new FinalProject1_winform.Label_gudi();
            this.label_gudi13 = new FinalProject1_winform.Label_gudi();
            this.label_gudi11 = new FinalProject1_winform.Label_gudi();
            this.label_gudi10 = new FinalProject1_winform.Label_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.txt_Content = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.pictureBox1 = new FinalProject1_winform.PictureBox_gudi();
            this.btnSearchPic = new FinalProject1_winform.Button_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox_gudi1);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 37);
            this.panel1.TabIndex = 4;
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
            this.lbl_Title.Text = "품목 정보 등록";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_InsUp);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 558);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 51);
            this.panel2.TabIndex = 5;
            // 
            // btn_InsUp
            // 
            this.btn_InsUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_InsUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btn_InsUp.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btn_InsUp.FlatAppearance.BorderSize = 0;
            this.btn_InsUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsUp.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_InsUp.ForeColor = System.Drawing.Color.White;
            this.btn_InsUp.Location = new System.Drawing.Point(278, 6);
            this.btn_InsUp.Name = "btn_InsUp";
            this.btn_InsUp.Size = new System.Drawing.Size(80, 33);
            this.btn_InsUp.TabIndex = 5;
            this.btn_InsUp.Text = "저장";
            this.btn_InsUp.UseVisualStyleBackColor = false;
            this.btn_InsUp.Click += new System.EventHandler(this.btn_InsUp_Click);
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
            this.btn_Cancel.Location = new System.Drawing.Point(370, 6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 33);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "닫기";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // cbo_OrderType
            // 
            this.cbo_OrderType.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_OrderType.FormattingEnabled = true;
            this.cbo_OrderType.Items.AddRange(new object[] {
            "정량",
            "부분"});
            this.cbo_OrderType.Location = new System.Drawing.Point(132, 255);
            this.cbo_OrderType.Name = "cbo_OrderType";
            this.cbo_OrderType.Size = new System.Drawing.Size(198, 24);
            this.cbo_OrderType.TabIndex = 42;
            // 
            // cbo_YN
            // 
            this.cbo_YN.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_YN.FormattingEnabled = true;
            this.cbo_YN.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbo_YN.Location = new System.Drawing.Point(478, 105);
            this.cbo_YN.Name = "cbo_YN";
            this.cbo_YN.Size = new System.Drawing.Size(222, 24);
            this.cbo_YN.TabIndex = 40;
            // 
            // txt_SafetyQTY
            // 
            this.txt_SafetyQTY.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_SafetyQTY.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_SafetyQTY.Location = new System.Drawing.Point(132, 292);
            this.txt_SafetyQTY.Name = "txt_SafetyQTY";
            this.txt_SafetyQTY.Size = new System.Drawing.Size(198, 25);
            this.txt_SafetyQTY.TabIndex = 39;
            // 
            // txt_UnitQTY
            // 
            this.txt_UnitQTY.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_UnitQTY.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_UnitQTY.Location = new System.Drawing.Point(132, 180);
            this.txt_UnitQTY.Name = "txt_UnitQTY";
            this.txt_UnitQTY.Size = new System.Drawing.Size(198, 25);
            this.txt_UnitQTY.TabIndex = 37;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_Name.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_Name.Location = new System.Drawing.Point(132, 143);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(198, 25);
            this.txt_Name.TabIndex = 36;
            // 
            // txt_Code
            // 
            this.txt_Code.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_Code.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_Code.Location = new System.Drawing.Point(132, 105);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(198, 25);
            this.txt_Code.TabIndex = 35;
            // 
            // cbo_Category
            // 
            this.cbo_Category.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_Category.FormattingEnabled = true;
            this.cbo_Category.Items.AddRange(new object[] {
            "원자재",
            "반제품",
            "완제품"});
            this.cbo_Category.Location = new System.Drawing.Point(132, 67);
            this.cbo_Category.Name = "cbo_Category";
            this.cbo_Category.Size = new System.Drawing.Size(198, 24);
            this.cbo_Category.TabIndex = 33;
            // 
            // cbo_CheckType
            // 
            this.cbo_CheckType.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_CheckType.FormattingEnabled = true;
            this.cbo_CheckType.Items.AddRange(new object[] {
            "입고검사",
            "출고검사"});
            this.cbo_CheckType.Location = new System.Drawing.Point(132, 218);
            this.cbo_CheckType.Name = "cbo_CheckType";
            this.cbo_CheckType.Size = new System.Drawing.Size(198, 24);
            this.cbo_CheckType.TabIndex = 32;
            // 
            // cbo_OutHouse
            // 
            this.cbo_OutHouse.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_OutHouse.FormattingEnabled = true;
            this.cbo_OutHouse.Location = new System.Drawing.Point(478, 67);
            this.cbo_OutHouse.Name = "cbo_OutHouse";
            this.cbo_OutHouse.Size = new System.Drawing.Size(221, 24);
            this.cbo_OutHouse.TabIndex = 29;
            // 
            // cbo_InHouse
            // 
            this.cbo_InHouse.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_InHouse.FormattingEnabled = true;
            this.cbo_InHouse.Location = new System.Drawing.Point(133, 330);
            this.cbo_InHouse.Name = "cbo_InHouse";
            this.cbo_InHouse.Size = new System.Drawing.Size(197, 24);
            this.cbo_InHouse.TabIndex = 28;
            // 
            // label_gudi17
            // 
            this.label_gudi17.AutoSize = true;
            this.label_gudi17.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi17.Location = new System.Drawing.Point(33, 223);
            this.label_gudi17.Name = "label_gudi17";
            this.label_gudi17.Size = new System.Drawing.Size(72, 17);
            this.label_gudi17.TabIndex = 23;
            this.label_gudi17.Text = "■ 측정방식";
            // 
            // label_gudi14
            // 
            this.label_gudi14.AutoSize = true;
            this.label_gudi14.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi14.Location = new System.Drawing.Point(389, 71);
            this.label_gudi14.Name = "label_gudi14";
            this.label_gudi14.Size = new System.Drawing.Size(72, 17);
            this.label_gudi14.TabIndex = 20;
            this.label_gudi14.Text = "■ 출고창고";
            // 
            // label_gudi13
            // 
            this.label_gudi13.AutoSize = true;
            this.label_gudi13.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi13.Location = new System.Drawing.Point(33, 337);
            this.label_gudi13.Name = "label_gudi13";
            this.label_gudi13.Size = new System.Drawing.Size(72, 17);
            this.label_gudi13.TabIndex = 19;
            this.label_gudi13.Text = "■ 입고창고";
            // 
            // label_gudi11
            // 
            this.label_gudi11.AutoSize = true;
            this.label_gudi11.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi11.Location = new System.Drawing.Point(389, 109);
            this.label_gudi11.Name = "label_gudi11";
            this.label_gudi11.Size = new System.Drawing.Size(72, 17);
            this.label_gudi11.TabIndex = 17;
            this.label_gudi11.Text = "■ 사용여부";
            // 
            // label_gudi10
            // 
            this.label_gudi10.AutoSize = true;
            this.label_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi10.Location = new System.Drawing.Point(33, 299);
            this.label_gudi10.Name = "label_gudi10";
            this.label_gudi10.Size = new System.Drawing.Size(84, 17);
            this.label_gudi10.TabIndex = 16;
            this.label_gudi10.Text = "■ 안전재고량";
            // 
            // label_gudi8
            // 
            this.label_gudi8.AutoSize = true;
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi8.Location = new System.Drawing.Point(33, 261);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(72, 17);
            this.label_gudi8.TabIndex = 14;
            this.label_gudi8.Text = "■ 발주방식";
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi7.Location = new System.Drawing.Point(33, 185);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(72, 17);
            this.label_gudi7.TabIndex = 13;
            this.label_gudi7.Text = "■ 단위수량";
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(33, 147);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(60, 17);
            this.label_gudi5.TabIndex = 11;
            this.label_gudi5.Text = "■ 품목명";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(33, 109);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(72, 17);
            this.label_gudi4.TabIndex = 10;
            this.label_gudi4.Text = "■ 품목코드";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(33, 71);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(72, 17);
            this.label_gudi2.TabIndex = 9;
            this.label_gudi2.Text = "■ 품목유형";
            // 
            // txt_Content
            // 
            this.txt_Content.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_Content.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_Content.Location = new System.Drawing.Point(132, 375);
            this.txt_Content.Multiline = true;
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(567, 115);
            this.txt_Content.TabIndex = 8;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(33, 375);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(48, 17);
            this.label_gudi3.TabIndex = 7;
            this.label_gudi3.Text = "■ 비고";
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(390, 147);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(60, 17);
            this.label_gudi1.TabIndex = 17;
            this.label_gudi1.Text = "■ 이미지";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(478, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearchPic
            // 
            this.btnSearchPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSearchPic.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSearchPic.FlatAppearance.BorderSize = 0;
            this.btnSearchPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPic.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSearchPic.ForeColor = System.Drawing.Color.White;
            this.btnSearchPic.Location = new System.Drawing.Point(478, 303);
            this.btnSearchPic.Name = "btnSearchPic";
            this.btnSearchPic.Size = new System.Drawing.Size(221, 27);
            this.btnSearchPic.TabIndex = 52;
            this.btnSearchPic.Text = "이미지검색";
            this.btnSearchPic.UseVisualStyleBackColor = false;
            this.btnSearchPic.Click += new System.EventHandler(this.btnSearchPic_Click);
            // 
            // frmItemInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(729, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearchPic);
            this.Controls.Add(this.cbo_OrderType);
            this.Controls.Add(this.cbo_YN);
            this.Controls.Add(this.txt_SafetyQTY);
            this.Controls.Add(this.txt_UnitQTY);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.cbo_Category);
            this.Controls.Add(this.cbo_CheckType);
            this.Controls.Add(this.cbo_OutHouse);
            this.Controls.Add(this.cbo_InHouse);
            this.Controls.Add(this.label_gudi17);
            this.Controls.Add(this.label_gudi14);
            this.Controls.Add(this.label_gudi13);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.label_gudi11);
            this.Controls.Add(this.label_gudi10);
            this.Controls.Add(this.label_gudi8);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmItemInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmItemInsert";
            this.Load += new System.EventHandler(this.frmItemInsert_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi lbl_Title;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi btn_InsUp;
        private Button_gudi btn_Cancel;
        private System.Windows.Forms.Panel panel2;
        private Label_gudi label_gudi3;
        private Controls.TextBox_gudi txt_Content;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi5;
        private Label_gudi label_gudi7;
        private Label_gudi label_gudi8;
        private Label_gudi label_gudi10;
        private Label_gudi label_gudi11;
        private Label_gudi label_gudi13;
        private Label_gudi label_gudi14;
        private ComboBox_gudi cbo_InHouse;
        private ComboBox_gudi cbo_OutHouse;
        private ComboBox_gudi cbo_Category;
        private Controls.TextBox_gudi txt_Code;
        private Controls.TextBox_gudi txt_Name;
        private Controls.TextBox_gudi txt_UnitQTY;
        private Controls.TextBox_gudi txt_SafetyQTY;
        private ComboBox_gudi cbo_YN;
        private ComboBox_gudi cbo_OrderType;
        private Label_gudi label_gudi17;
        private ComboBox_gudi cbo_CheckType;
        private Label_gudi label_gudi1;
        private PictureBox_gudi pictureBox1;
        private Button_gudi btnSearchPic;
    }
}