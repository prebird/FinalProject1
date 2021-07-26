
namespace FinalProject1_winform.Demand_Plan
{
    partial class frmProductionPlanMake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionPlanMake));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new FinalProject1_winform.Button_gudi();
            this.btnClose = new FinalProject1_winform.Button_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.dtpMakeDate = new FinalProject1_winform.DateTimePicker_gudi();
            this.label_gudi10 = new FinalProject1_winform.Label_gudi();
            this.txtINS_EMP = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi9 = new FinalProject1_winform.Label_gudi();
            this.txtQuantity = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.cboProcess = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.txtIns_Date = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtPriorDate = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.cboEquipment = new FinalProject1_winform.ComboBox_gudi();
            this.txtItemName = new FinalProject1_winform.PlaceholderNew();
            this.txtPlanID = new FinalProject1_winform.PlaceholderNew();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 37);
            this.panel1.TabIndex = 6;
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
            this.label_gudi1.Text = "생산 계획 생성";
            // 
            // dtpMakeDate
            // 
            this.dtpMakeDate.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtpMakeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMakeDate.Location = new System.Drawing.Point(304, 197);
            this.dtpMakeDate.Name = "dtpMakeDate";
            this.dtpMakeDate.Size = new System.Drawing.Size(149, 25);
            this.dtpMakeDate.TabIndex = 41;
            // 
            // label_gudi10
            // 
            this.label_gudi10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi10.AutoSize = true;
            this.label_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi10.Location = new System.Drawing.Point(228, 200);
            this.label_gudi10.Name = "label_gudi10";
            this.label_gudi10.Size = new System.Drawing.Size(68, 17);
            this.label_gudi10.TabIndex = 40;
            this.label_gudi10.Text = "생산계획일";
            // 
            // txtINS_EMP
            // 
            this.txtINS_EMP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtINS_EMP.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtINS_EMP.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtINS_EMP.Location = new System.Drawing.Point(304, 228);
            this.txtINS_EMP.Name = "txtINS_EMP";
            this.txtINS_EMP.Size = new System.Drawing.Size(149, 25);
            this.txtINS_EMP.TabIndex = 39;
            this.txtINS_EMP.Text = "박기덕";
            // 
            // label_gudi9
            // 
            this.label_gudi9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi9.AutoSize = true;
            this.label_gudi9.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi9.Location = new System.Drawing.Point(252, 231);
            this.label_gudi9.Name = "label_gudi9";
            this.label_gudi9.Size = new System.Drawing.Size(44, 17);
            this.label_gudi9.TabIndex = 38;
            this.label_gudi9.Text = "수정자";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtQuantity.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtQuantity.Location = new System.Drawing.Point(72, 138);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(149, 25);
            this.txtQuantity.TabIndex = 37;
            // 
            // label_gudi8
            // 
            this.label_gudi8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi8.AutoSize = true;
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi8.Location = new System.Drawing.Point(6, 141);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(60, 17);
            this.label_gudi8.TabIndex = 36;
            this.label_gudi8.Text = "생산 수량";
            // 
            // cboProcess
            // 
            this.cboProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProcess.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboProcess.FormattingEnabled = true;
            this.cboProcess.Items.AddRange(new object[] {
            "선택",
            "사용",
            "사용 안함"});
            this.cboProcess.Location = new System.Drawing.Point(304, 72);
            this.cboProcess.Name = "cboProcess";
            this.cboProcess.Size = new System.Drawing.Size(149, 24);
            this.cboProcess.TabIndex = 35;
            // 
            // label_gudi7
            // 
            this.label_gudi7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi7.Location = new System.Drawing.Point(252, 75);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(44, 17);
            this.label_gudi7.TabIndex = 34;
            this.label_gudi7.Text = "공정명";
            // 
            // txtIns_Date
            // 
            this.txtIns_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIns_Date.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtIns_Date.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtIns_Date.Location = new System.Drawing.Point(304, 259);
            this.txtIns_Date.Name = "txtIns_Date";
            this.txtIns_Date.ReadOnly = true;
            this.txtIns_Date.Size = new System.Drawing.Size(149, 25);
            this.txtIns_Date.TabIndex = 33;
            // 
            // txtPriorDate
            // 
            this.txtPriorDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriorDate.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtPriorDate.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtPriorDate.Location = new System.Drawing.Point(304, 141);
            this.txtPriorDate.Name = "txtPriorDate";
            this.txtPriorDate.ReadOnly = true;
            this.txtPriorDate.Size = new System.Drawing.Size(149, 25);
            this.txtPriorDate.TabIndex = 32;
            // 
            // label_gudi6
            // 
            this.label_gudi6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(240, 262);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(56, 17);
            this.label_gudi6.TabIndex = 31;
            this.label_gudi6.Text = "수정시간";
            // 
            // label_gudi5
            // 
            this.label_gudi5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(228, 144);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(68, 17);
            this.label_gudi5.TabIndex = 30;
            this.label_gudi5.Text = "공정선행일";
            // 
            // cboEquipment
            // 
            this.cboEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEquipment.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboEquipment.FormattingEnabled = true;
            this.cboEquipment.Items.AddRange(new object[] {
            "선택",
            "사용",
            "사용 안함"});
            this.cboEquipment.Location = new System.Drawing.Point(304, 108);
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(149, 24);
            this.cboEquipment.TabIndex = 29;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtItemName.InputType = FinalProject1_winform.validType.Common;
            this.txtItemName.Location = new System.Drawing.Point(72, 107);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PlaceHolderActiveForeColor = System.Drawing.Color.Gray;
            this.txtItemName.PlaceHolderFont = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtItemName.PlaceHolderForeColor = System.Drawing.Color.DarkGray;
            this.txtItemName.PlaceHolderText = "필수 입력 사항입니다.";
            this.txtItemName.Size = new System.Drawing.Size(149, 25);
            this.txtItemName.TabIndex = 28;
            // 
            // txtPlanID
            // 
            this.txtPlanID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlanID.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtPlanID.InputType = FinalProject1_winform.validType.Common;
            this.txtPlanID.Location = new System.Drawing.Point(72, 71);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.PlaceHolderActiveForeColor = System.Drawing.Color.Gray;
            this.txtPlanID.PlaceHolderFont = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtPlanID.PlaceHolderForeColor = System.Drawing.Color.DarkGray;
            this.txtPlanID.PlaceHolderText = "필수 입력 사항입니다.";
            this.txtPlanID.Size = new System.Drawing.Size(149, 25);
            this.txtPlanID.TabIndex = 27;
            // 
            // label_gudi4
            // 
            this.label_gudi4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(252, 111);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(44, 17);
            this.label_gudi4.TabIndex = 26;
            this.label_gudi4.Text = "설비명";
            // 
            // label_gudi3
            // 
            this.label_gudi3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi3.Location = new System.Drawing.Point(22, 108);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(44, 17);
            this.label_gudi3.TabIndex = 25;
            this.label_gudi3.Text = "물품명";
            // 
            // label_gudi2
            // 
            this.label_gudi2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi2.Location = new System.Drawing.Point(20, 74);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(46, 17);
            this.label_gudi2.TabIndex = 24;
            this.label_gudi2.Text = "PlanID";
            // 
            // frmProductionPlanMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 386);
            this.Controls.Add(this.dtpMakeDate);
            this.Controls.Add(this.label_gudi10);
            this.Controls.Add(this.txtINS_EMP);
            this.Controls.Add(this.label_gudi9);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label_gudi8);
            this.Controls.Add(this.cboProcess);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.txtIns_Date);
            this.Controls.Add(this.txtPriorDate);
            this.Controls.Add(this.label_gudi6);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.cboEquipment);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtPlanID);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmProductionPlanMake";
            this.Text = "생산 계획 생성";
            this.Load += new System.EventHandler(this.frmProductionPlanMake_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Button_gudi btnSave;
        private Button_gudi btnClose;
        private System.Windows.Forms.Panel panel1;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private Controls.TextBox_gudi txtIns_Date;
        private Controls.TextBox_gudi txtPriorDate;
        private Label_gudi label_gudi6;
        private Label_gudi label_gudi5;
        private ComboBox_gudi cboEquipment;
        private PlaceholderNew txtItemName;
        private PlaceholderNew txtPlanID;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi2;
        private ComboBox_gudi cboProcess;
        private Label_gudi label_gudi7;
        private Controls.TextBox_gudi txtQuantity;
        private Label_gudi label_gudi8;
        private Controls.TextBox_gudi txtINS_EMP;
        private Label_gudi label_gudi9;
        private Label_gudi label_gudi10;
        private DateTimePicker_gudi dtpMakeDate;
    }
}