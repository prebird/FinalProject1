
namespace FinalProject1_winform
{
    partial class frmEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new FinalProject1_winform.Button_gudi();
            this.btnClose = new FinalProject1_winform.Button_gudi();
            this.cboProcessCode = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.cboEquipmentGroupCode = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.txtCode = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.txtINS_EMP = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtINS_DATE = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.txtSpecific = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.cboOutputLocation = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi9 = new FinalProject1_winform.Label_gudi();
            this.label_gudi10 = new FinalProject1_winform.Label_gudi();
            this.cboInputLocation = new FinalProject1_winform.ComboBox_gudi();
            this.cboIsUse = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi11 = new FinalProject1_winform.Label_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(611, 37);
            this.panel1.TabIndex = 3;
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
            this.label_gudi1.Text = "설비";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 65);
            this.panel2.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSave.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(150, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.btnClose.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(379, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 33);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // cboProcessCode
            // 
            this.cboProcessCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboProcessCode.FormattingEnabled = true;
            this.cboProcessCode.Location = new System.Drawing.Point(167, 73);
            this.cboProcessCode.Name = "cboProcessCode";
            this.cboProcessCode.Size = new System.Drawing.Size(121, 24);
            this.cboProcessCode.TabIndex = 5;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi2.Location = new System.Drawing.Point(52, 76);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(60, 17);
            this.label_gudi2.TabIndex = 6;
            this.label_gudi2.Text = "공정 코드";
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi3.Location = new System.Drawing.Point(40, 117);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(72, 17);
            this.label_gudi3.TabIndex = 7;
            this.label_gudi3.Text = "설비군 코드";
            // 
            // cboEquipmentGroupCode
            // 
            this.cboEquipmentGroupCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboEquipmentGroupCode.FormattingEnabled = true;
            this.cboEquipmentGroupCode.Location = new System.Drawing.Point(167, 114);
            this.cboEquipmentGroupCode.Name = "cboEquipmentGroupCode";
            this.cboEquipmentGroupCode.Size = new System.Drawing.Size(121, 24);
            this.cboEquipmentGroupCode.TabIndex = 8;
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi4.Location = new System.Drawing.Point(52, 159);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(60, 17);
            this.label_gudi4.TabIndex = 9;
            this.label_gudi4.Text = "설비 코드";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCode.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCode.Location = new System.Drawing.Point(167, 156);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(121, 25);
            this.txtCode.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtName.Location = new System.Drawing.Point(167, 198);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 25);
            this.txtName.TabIndex = 12;
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi5.Location = new System.Drawing.Point(68, 202);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(44, 17);
            this.label_gudi5.TabIndex = 11;
            this.label_gudi5.Text = "설비명";
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(370, 77);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(44, 17);
            this.label_gudi6.TabIndex = 13;
            this.label_gudi6.Text = "수정자";
            // 
            // txtINS_EMP
            // 
            this.txtINS_EMP.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtINS_EMP.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtINS_EMP.Location = new System.Drawing.Point(453, 73);
            this.txtINS_EMP.Name = "txtINS_EMP";
            this.txtINS_EMP.ReadOnly = true;
            this.txtINS_EMP.Size = new System.Drawing.Size(121, 25);
            this.txtINS_EMP.TabIndex = 14;
            // 
            // txtINS_DATE
            // 
            this.txtINS_DATE.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtINS_DATE.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtINS_DATE.Location = new System.Drawing.Point(453, 119);
            this.txtINS_DATE.Name = "txtINS_DATE";
            this.txtINS_DATE.ReadOnly = true;
            this.txtINS_DATE.Size = new System.Drawing.Size(121, 25);
            this.txtINS_DATE.TabIndex = 16;
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi7.Location = new System.Drawing.Point(354, 123);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(60, 17);
            this.label_gudi7.TabIndex = 15;
            this.label_gudi7.Text = "수정 일자";
            // 
            // txtSpecific
            // 
            this.txtSpecific.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecific.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtSpecific.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtSpecific.Location = new System.Drawing.Point(55, 293);
            this.txtSpecific.Multiline = true;
            this.txtSpecific.Name = "txtSpecific";
            this.txtSpecific.Size = new System.Drawing.Size(519, 86);
            this.txtSpecific.TabIndex = 18;
            // 
            // label_gudi8
            // 
            this.label_gudi8.AutoSize = true;
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi8.Location = new System.Drawing.Point(52, 273);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(60, 17);
            this.label_gudi8.TabIndex = 17;
            this.label_gudi8.Text = "특이 사항";
            // 
            // cboOutputLocation
            // 
            this.cboOutputLocation.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboOutputLocation.FormattingEnabled = true;
            this.cboOutputLocation.Location = new System.Drawing.Point(453, 202);
            this.cboOutputLocation.Name = "cboOutputLocation";
            this.cboOutputLocation.Size = new System.Drawing.Size(121, 24);
            this.cboOutputLocation.TabIndex = 22;
            // 
            // label_gudi9
            // 
            this.label_gudi9.AutoSize = true;
            this.label_gudi9.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi9.Location = new System.Drawing.Point(354, 205);
            this.label_gudi9.Name = "label_gudi9";
            this.label_gudi9.Size = new System.Drawing.Size(60, 17);
            this.label_gudi9.TabIndex = 21;
            this.label_gudi9.Text = "양품 창고";
            // 
            // label_gudi10
            // 
            this.label_gudi10.AutoSize = true;
            this.label_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi10.Location = new System.Drawing.Point(354, 164);
            this.label_gudi10.Name = "label_gudi10";
            this.label_gudi10.Size = new System.Drawing.Size(60, 17);
            this.label_gudi10.TabIndex = 20;
            this.label_gudi10.Text = "소진 창고";
            // 
            // cboInputLocation
            // 
            this.cboInputLocation.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboInputLocation.FormattingEnabled = true;
            this.cboInputLocation.Location = new System.Drawing.Point(453, 161);
            this.cboInputLocation.Name = "cboInputLocation";
            this.cboInputLocation.Size = new System.Drawing.Size(121, 24);
            this.cboInputLocation.TabIndex = 19;
            // 
            // cboIsUse
            // 
            this.cboIsUse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIsUse.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboIsUse.FormattingEnabled = true;
            this.cboIsUse.Items.AddRange(new object[] {
            "선택",
            "사용",
            "사용 안함"});
            this.cboIsUse.Location = new System.Drawing.Point(167, 239);
            this.cboIsUse.Name = "cboIsUse";
            this.cboIsUse.Size = new System.Drawing.Size(121, 24);
            this.cboIsUse.TabIndex = 24;
            // 
            // label_gudi11
            // 
            this.label_gudi11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi11.AutoSize = true;
            this.label_gudi11.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi11.Location = new System.Drawing.Point(52, 242);
            this.label_gudi11.Name = "label_gudi11";
            this.label_gudi11.Size = new System.Drawing.Size(60, 17);
            this.label_gudi11.TabIndex = 23;
            this.label_gudi11.Text = "사용 유무";
            // 
            // frmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(611, 475);
            this.Controls.Add(this.cboIsUse);
            this.Controls.Add(this.label_gudi11);
            this.Controls.Add(this.cboOutputLocation);
            this.Controls.Add(this.label_gudi9);
            this.Controls.Add(this.label_gudi10);
            this.Controls.Add(this.cboInputLocation);
            this.Controls.Add(this.txtSpecific);
            this.Controls.Add(this.label_gudi8);
            this.Controls.Add(this.txtINS_DATE);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.txtINS_EMP);
            this.Controls.Add(this.label_gudi6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.cboEquipmentGroupCode);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.cboProcessCode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEquipment";
            this.Load += new System.EventHandler(this.frmEquipment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private System.Windows.Forms.Panel panel2;
        private Button_gudi btnSave;
        private Button_gudi btnClose;
        private ComboBox_gudi cboProcessCode;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi3;
        private ComboBox_gudi cboEquipmentGroupCode;
        private Label_gudi label_gudi4;
        private Controls.TextBox_gudi txtCode;
        private Controls.TextBox_gudi txtName;
        private Label_gudi label_gudi5;
        private Label_gudi label_gudi6;
        private Controls.TextBox_gudi txtINS_EMP;
        private Controls.TextBox_gudi txtINS_DATE;
        private Label_gudi label_gudi7;
        private Controls.TextBox_gudi txtSpecific;
        private Label_gudi label_gudi8;
        private ComboBox_gudi cboOutputLocation;
        private Label_gudi label_gudi9;
        private Label_gudi label_gudi10;
        private ComboBox_gudi cboInputLocation;
        private ComboBox_gudi cboIsUse;
        private Label_gudi label_gudi11;
    }
}