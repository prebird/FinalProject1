
namespace FinalProject1_winform
{
    partial class frmBORInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBORInsert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new FinalProject1_winform.Button_gudi();
            this.btnCancel = new FinalProject1_winform.Button_gudi();
            this.txtPriority = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtTactTime = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtStatus = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.cboIsUse = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.cboEquipment = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.cboProcess = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.cboItem = new FinalProject1_winform.ComboBox_gudi();
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
            // label_gudi1
            // 
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_gudi1.Location = new System.Drawing.Point(48, 11);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(155, 23);
            this.label_gudi1.TabIndex = 2;
            this.label_gudi1.Text = "BOR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 65);
            this.panel2.TabIndex = 31;
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.btnCancel.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(242, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtPriority
            // 
            this.txtPriority.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtPriority.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtPriority.Location = new System.Drawing.Point(87, 164);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(125, 25);
            this.txtPriority.TabIndex = 33;
            this.txtPriority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTactTime_KeyPress);
            // 
            // txtTactTime
            // 
            this.txtTactTime.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtTactTime.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtTactTime.Location = new System.Drawing.Point(327, 113);
            this.txtTactTime.Name = "txtTactTime";
            this.txtTactTime.Size = new System.Drawing.Size(125, 25);
            this.txtTactTime.TabIndex = 32;
            this.txtTactTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTactTime_KeyPress);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtStatus.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtStatus.Location = new System.Drawing.Point(87, 218);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(365, 97);
            this.txtStatus.TabIndex = 30;
            // 
            // label_gudi8
            // 
            this.label_gudi8.AutoSize = true;
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_gudi8.Location = new System.Drawing.Point(12, 218);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(48, 17);
            this.label_gudi8.TabIndex = 29;
            this.label_gudi8.Text = "■ 비고";
            // 
            // cboIsUse
            // 
            this.cboIsUse.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboIsUse.FormattingEnabled = true;
            this.cboIsUse.Items.AddRange(new object[] {
            "선택",
            "사용",
            "사용 안함"});
            this.cboIsUse.Location = new System.Drawing.Point(327, 167);
            this.cboIsUse.Name = "cboIsUse";
            this.cboIsUse.Size = new System.Drawing.Size(125, 24);
            this.cboIsUse.TabIndex = 28;
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_gudi7.Location = new System.Drawing.Point(237, 170);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(72, 17);
            this.label_gudi7.TabIndex = 27;
            this.label_gudi7.Text = "■ 사용유무";
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_gudi6.Location = new System.Drawing.Point(12, 167);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(72, 17);
            this.label_gudi6.TabIndex = 25;
            this.label_gudi6.Text = "■ 우선순위";
            // 
            // cboEquipment
            // 
            this.cboEquipment.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboEquipment.FormattingEnabled = true;
            this.cboEquipment.Location = new System.Drawing.Point(87, 114);
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(125, 24);
            this.cboEquipment.TabIndex = 24;
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi5.Location = new System.Drawing.Point(12, 117);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(48, 17);
            this.label_gudi5.TabIndex = 23;
            this.label_gudi5.Text = "■ 설비";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi4.Location = new System.Drawing.Point(237, 117);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(81, 17);
            this.label_gudi4.TabIndex = 21;
            this.label_gudi4.Text = "■ Tact Time";
            // 
            // cboProcess
            // 
            this.cboProcess.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboProcess.FormattingEnabled = true;
            this.cboProcess.Location = new System.Drawing.Point(327, 61);
            this.cboProcess.Name = "cboProcess";
            this.cboProcess.Size = new System.Drawing.Size(125, 24);
            this.cboProcess.TabIndex = 20;
            this.cboProcess.SelectedIndexChanged += new System.EventHandler(this.cboProcess_SelectedIndexChanged);
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi3.Location = new System.Drawing.Point(237, 64);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(48, 17);
            this.label_gudi3.TabIndex = 19;
            this.label_gudi3.Text = "■ 공정";
            // 
            // cboItem
            // 
            this.cboItem.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(87, 61);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(125, 24);
            this.cboItem.TabIndex = 18;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi2.Location = new System.Drawing.Point(12, 64);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(60, 17);
            this.label_gudi2.TabIndex = 17;
            this.label_gudi2.Text = "■ 품목명";
            // 
            // frmBORInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(474, 386);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.txtTactTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label_gudi8);
            this.Controls.Add(this.cboIsUse);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.label_gudi6);
            this.Controls.Add(this.cboEquipment);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.cboProcess);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 425);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(490, 425);
            this.Name = "frmBORInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBORInsert";
            this.Load += new System.EventHandler(this.frmBORInsert_Load);
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
        private Label_gudi label_gudi2;
        private ComboBox_gudi cboItem;
        private ComboBox_gudi cboProcess;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi4;
        private ComboBox_gudi cboEquipment;
        private Label_gudi label_gudi5;
        private Label_gudi label_gudi6;
        private ComboBox_gudi cboIsUse;
        private Label_gudi label_gudi7;
        private Label_gudi label_gudi8;
        private Controls.TextBox_gudi txtStatus;
        private System.Windows.Forms.Panel panel2;
        private Button_gudi btnSave;
        private Button_gudi btnCancel;
        private Controls.TextBox_gudi txtTactTime;
        private Controls.TextBox_gudi txtPriority;
    }
}