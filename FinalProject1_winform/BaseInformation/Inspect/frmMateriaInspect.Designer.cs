
namespace FinalProject1_winform
{
    partial class frmMateriaInspect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriaInspect));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpInspect = new FinalProject1_winform.UcDateTimePicker();
            this.cboCompany = new FinalProject1_winform.ComboBox_gudi();
            this.cboResult = new FinalProject1_winform.ComboBox_gudi();
            this.cboPOid = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.btnSearch = new FinalProject1_winform.Button_gudi();
            this.cboItem = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.btnCheck = new FinalProject1_winform.Button_gudi();
            this.dgvInspect = new FinalProject1_winform.DGV_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspect)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gudi5
            // 
            this.button_gudi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi5.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi5.FlatAppearance.BorderSize = 0;
            this.button_gudi5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi5.ForeColor = System.Drawing.Color.Black;
            this.button_gudi5.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi5.Image")));
            this.button_gudi5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi5.Location = new System.Drawing.Point(1014, 107);
            this.button_gudi5.Name = "button_gudi5";
            this.button_gudi5.Size = new System.Drawing.Size(60, 25);
            this.button_gudi5.TabIndex = 33;
            this.button_gudi5.Text = "엑셀";
            this.button_gudi5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi5.UseVisualStyleBackColor = false;
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(49, 111);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(80, 17);
            this.label_gudi4.TabIndex = 31;
            this.label_gudi4.Text = "수입검사현황";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvInspect);
            this.panel2.Location = new System.Drawing.Point(17, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 466);
            this.panel2.TabIndex = 30;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(18, 109);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 29;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.dtpInspect);
            this.panel1.Controls.Add(this.cboCompany);
            this.panel1.Controls.Add(this.cboResult);
            this.panel1.Controls.Add(this.cboPOid);
            this.panel1.Controls.Add(this.label_gudi6);
            this.panel1.Controls.Add(this.label_gudi5);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cboItem);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.label_gudi2);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Location = new System.Drawing.Point(17, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 87);
            this.panel1.TabIndex = 28;
            // 
            // dtpInspect
            // 
            this.dtpInspect.FromDate = new System.DateTime(2021, 6, 28, 15, 6, 18, 19);
            this.dtpInspect.Location = new System.Drawing.Point(413, 11);
            this.dtpInspect.Name = "dtpInspect";
            this.dtpInspect.Size = new System.Drawing.Size(257, 30);
            this.dtpInspect.TabIndex = 17;
            this.dtpInspect.ToDate = new System.DateTime(2021, 6, 28, 15, 6, 18, 8);
            // 
            // cboCompany
            // 
            this.cboCompany.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(413, 52);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(187, 24);
            this.cboCompany.TabIndex = 16;
            // 
            // cboResult
            // 
            this.cboResult.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboResult.FormattingEnabled = true;
            this.cboResult.Location = new System.Drawing.Point(126, 50);
            this.cboResult.Name = "cboResult";
            this.cboResult.Size = new System.Drawing.Size(187, 24);
            this.cboResult.TabIndex = 15;
            // 
            // cboPOid
            // 
            this.cboPOid.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboPOid.FormattingEnabled = true;
            this.cboPOid.Location = new System.Drawing.Point(126, 12);
            this.cboPOid.Name = "cboPOid";
            this.cboPOid.Size = new System.Drawing.Size(187, 24);
            this.cboPOid.TabIndex = 14;
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(335, 55);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(48, 17);
            this.label_gudi6.TabIndex = 13;
            this.label_gudi6.Text = "■ 업체";
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(12, 55);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(48, 17);
            this.label_gudi5.TabIndex = 10;
            this.label_gudi5.Text = "■ 판정";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSearch.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(959, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 25);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboItem
            // 
            this.cboItem.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(743, 12);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(181, 24);
            this.cboItem.TabIndex = 5;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(688, 15);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(48, 17);
            this.label_gudi3.TabIndex = 4;
            this.label_gudi3.Text = "■ 품목";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(335, 15);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(72, 17);
            this.label_gudi2.TabIndex = 2;
            this.label_gudi2.Text = "■ 검사일자";
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(12, 15);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(67, 17);
            this.label_gudi1.TabIndex = 0;
            this.label_gudi1.Text = "■ Plan_ID";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnCheck.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.Location = new System.Drawing.Point(923, 107);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(85, 25);
            this.btnCheck.TabIndex = 34;
            this.btnCheck.Text = "검사확인";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dgvInspect
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvInspect.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInspect.BackgroundColor = System.Drawing.Color.White;
            this.dgvInspect.CheckBoxAll = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInspect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInspect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInspect.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvInspect.HeaderCheckStatus = false;
            this.dgvInspect.Location = new System.Drawing.Point(0, 0);
            this.dgvInspect.Name = "dgvInspect";
            this.dgvInspect.RowHeadersVisible = false;
            this.dgvInspect.RowTemplate.Height = 23;
            this.dgvInspect.Size = new System.Drawing.Size(1057, 466);
            this.dgvInspect.TabIndex = 0;
            // 
            // frmMateriaInspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.button_gudi5);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMateriaInspect";
            this.Text = "frmMateriaInspect";
            this.Load += new System.EventHandler(this.frmMateriaInspect_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button_gudi button_gudi5;
        private Label_gudi label_gudi4;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private Label_gudi label_gudi5;
        private Button_gudi btnSearch;
        private ComboBox_gudi cboItem;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi1;
        private ComboBox_gudi cboResult;
        private ComboBox_gudi cboPOid;
        private Label_gudi label_gudi6;
        private UcDateTimePicker dtpInspect;
        private ComboBox_gudi cboCompany;
        private Button_gudi btnCheck;
        private DGV_gudi dgvInspect;
    }
}