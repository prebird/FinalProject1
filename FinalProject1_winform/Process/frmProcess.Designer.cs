
namespace FinalProject1_winform.Process
{
    partial class frmProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcess));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new FinalProject1_winform.Button_gudi();
            this.btnClose = new FinalProject1_winform.Button_gudi();
            this.txtIns_Date = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtIns_Emp = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.cboIsUse = new FinalProject1_winform.ComboBox_gudi();
            this.txtName = new FinalProject1_winform.PlaceholderNew();
            this.txtCode = new FinalProject1_winform.PlaceholderNew();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
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
            this.panel1.Size = new System.Drawing.Size(474, 37);
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
            this.label_gudi1.Text = "공정";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 65);
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
            this.btnClose.Location = new System.Drawing.Point(242, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 33);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // txtIns_Date
            // 
            this.txtIns_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIns_Date.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtIns_Date.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtIns_Date.Location = new System.Drawing.Point(238, 252);
            this.txtIns_Date.Name = "txtIns_Date";
            this.txtIns_Date.ReadOnly = true;
            this.txtIns_Date.Size = new System.Drawing.Size(149, 25);
            this.txtIns_Date.TabIndex = 23;
            // 
            // txtIns_Emp
            // 
            this.txtIns_Emp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIns_Emp.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtIns_Emp.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtIns_Emp.Location = new System.Drawing.Point(238, 210);
            this.txtIns_Emp.Name = "txtIns_Emp";
            this.txtIns_Emp.ReadOnly = true;
            this.txtIns_Emp.Size = new System.Drawing.Size(149, 25);
            this.txtIns_Emp.TabIndex = 22;
            // 
            // label_gudi6
            // 
            this.label_gudi6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(101, 255);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(56, 17);
            this.label_gudi6.TabIndex = 21;
            this.label_gudi6.Text = "수정시간";
            // 
            // label_gudi5
            // 
            this.label_gudi5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(113, 213);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(44, 17);
            this.label_gudi5.TabIndex = 20;
            this.label_gudi5.Text = "수정자";
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
            this.cboIsUse.Location = new System.Drawing.Point(238, 168);
            this.cboIsUse.Name = "cboIsUse";
            this.cboIsUse.Size = new System.Drawing.Size(149, 24);
            this.cboIsUse.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtName.InputType = FinalProject1_winform.validType.Common;
            this.txtName.Location = new System.Drawing.Point(238, 126);
            this.txtName.Name = "txtName";
            this.txtName.PlaceHolderActiveForeColor = System.Drawing.Color.Gray;
            this.txtName.PlaceHolderFont = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtName.PlaceHolderForeColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceHolderText = "필수 입력 사항입니다.";
            this.txtName.Size = new System.Drawing.Size(149, 25);
            this.txtName.TabIndex = 18;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCode.InputType = FinalProject1_winform.validType.Common;
            this.txtCode.Location = new System.Drawing.Point(238, 84);
            this.txtCode.Name = "txtCode";
            this.txtCode.PlaceHolderActiveForeColor = System.Drawing.Color.Gray;
            this.txtCode.PlaceHolderFont = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCode.PlaceHolderForeColor = System.Drawing.Color.DarkGray;
            this.txtCode.PlaceHolderText = "필수 입력 사항입니다.";
            this.txtCode.Size = new System.Drawing.Size(149, 25);
            this.txtCode.TabIndex = 17;
            // 
            // label_gudi4
            // 
            this.label_gudi4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(97, 171);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(60, 17);
            this.label_gudi4.TabIndex = 16;
            this.label_gudi4.Text = "사용 유무";
            // 
            // label_gudi3
            // 
            this.label_gudi3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi3.Location = new System.Drawing.Point(113, 129);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(44, 17);
            this.label_gudi3.TabIndex = 15;
            this.label_gudi3.Text = "공정명";
            // 
            // label_gudi2
            // 
            this.label_gudi2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi2.Location = new System.Drawing.Point(97, 87);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(60, 17);
            this.label_gudi2.TabIndex = 14;
            this.label_gudi2.Text = "공정 코드";
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(474, 386);
            this.Controls.Add(this.txtIns_Date);
            this.Controls.Add(this.txtIns_Emp);
            this.Controls.Add(this.label_gudi6);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.cboIsUse);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 425);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(490, 425);
            this.Name = "frmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProcess";
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
        private FinalProject1_winform.Controls.TextBox_gudi txtIns_Date;
        private FinalProject1_winform.Controls.TextBox_gudi txtIns_Emp;
        private Label_gudi label_gudi6;
        private Label_gudi label_gudi5;
        private ComboBox_gudi cboIsUse;
        private PlaceholderNew txtName;
        private PlaceholderNew txtCode;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi2;
    }
}