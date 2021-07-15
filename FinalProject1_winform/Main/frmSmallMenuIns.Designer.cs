
namespace FinalProject1_winform
{
    partial class frmSmallMenuIns
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSmallMenuIns));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboForm = new FinalProject1_winform.ComboBox_gudi();
            this.dgvBig = new FinalProject1_winform.DGV_gudi();
            this.dtpDate = new FinalProject1_winform.DateTimePicker_gudi();
            this.btnSave = new FinalProject1_winform.Button_gudi();
            this.btnClose = new FinalProject1_winform.Button_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.txtUserName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtMenuName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBig)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(33, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 56);
            this.panel1.TabIndex = 53;
            // 
            // cboForm
            // 
            this.cboForm.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboForm.FormattingEnabled = true;
            this.cboForm.Location = new System.Drawing.Point(219, 531);
            this.cboForm.Margin = new System.Windows.Forms.Padding(4);
            this.cboForm.Name = "cboForm";
            this.cboForm.Size = new System.Drawing.Size(494, 24);
            this.cboForm.TabIndex = 66;
            // 
            // dgvBig
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvBig.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBig.BackgroundColor = System.Drawing.Color.White;
            this.dgvBig.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBig.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvBig.HeaderCheckStatus = false;
            this.dgvBig.Location = new System.Drawing.Point(220, 184);
            this.dgvBig.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBig.Name = "dgvBig";
            this.dgvBig.RowHeadersVisible = false;
            this.dgvBig.RowTemplate.Height = 23;
            this.dgvBig.Size = new System.Drawing.Size(494, 302);
            this.dgvBig.TabIndex = 65;
            this.dgvBig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBig_CellClick);
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(217, 678);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(490, 25);
            this.dtpDate.TabIndex = 64;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSave.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(227, 782);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 50);
            this.btnSave.TabIndex = 62;
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
            this.btnClose.Location = new System.Drawing.Point(367, 782);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 50);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi5.Location = new System.Drawing.Point(41, 687);
            this.label_gudi5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(72, 17);
            this.label_gudi5.TabIndex = 54;
            this.label_gudi5.Text = "■ 수정일자";
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi6.Location = new System.Drawing.Point(41, 609);
            this.label_gudi6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(60, 17);
            this.label_gudi6.TabIndex = 55;
            this.label_gudi6.Text = "■ 수정자";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi4.Location = new System.Drawing.Point(41, 536);
            this.label_gudi4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(64, 17);
            this.label_gudi4.TabIndex = 55;
            this.label_gudi4.Text = "■ 폼 선택";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi2.Location = new System.Drawing.Point(41, 184);
            this.label_gudi2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(72, 17);
            this.label_gudi2.TabIndex = 56;
            this.label_gudi2.Text = "■ 상위메뉴";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtUserName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtUserName.Location = new System.Drawing.Point(219, 609);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(488, 25);
            this.txtUserName.TabIndex = 58;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtMenuName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtMenuName.Location = new System.Drawing.Point(224, 111);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(488, 25);
            this.txtMenuName.TabIndex = 59;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi3.Location = new System.Drawing.Point(41, 116);
            this.label_gudi3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(72, 17);
            this.label_gudi3.TabIndex = 57;
            this.label_gudi3.Text = "■ 메뉴이름";
            // 
            // pictureBox_gudi1
            // 
            this.pictureBox_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi1.Image")));
            this.pictureBox_gudi1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox_gudi1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_gudi1.Name = "pictureBox_gudi1";
            this.pictureBox_gudi1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox_gudi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi1.TabIndex = 3;
            this.pictureBox_gudi1.TabStop = false;
            // 
            // label_gudi1
            // 
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_gudi1.Location = new System.Drawing.Point(69, 16);
            this.label_gudi1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(221, 34);
            this.label_gudi1.TabIndex = 2;
            this.label_gudi1.Text = "하위메뉴등록";
            // 
            // frmSmallMenuIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(747, 856);
            this.Controls.Add(this.cboForm);
            this.Controls.Add(this.dgvBig);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.label_gudi6);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSmallMenuIns";
            this.Text = "frmSmallMenuIns";
            this.Load += new System.EventHandler(this.frmSmallMenuIns_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker_gudi dtpDate;
        private Button_gudi btnSave;
        private Button_gudi btnClose;
        private Label_gudi label_gudi5;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi2;
        private Controls.TextBox_gudi txtUserName;
        private Controls.TextBox_gudi txtMenuName;
        private Label_gudi label_gudi3;
        private System.Windows.Forms.Panel panel1;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private DGV_gudi dgvBig;
        private ComboBox_gudi cboForm;
        private Label_gudi label_gudi6;
    }
}