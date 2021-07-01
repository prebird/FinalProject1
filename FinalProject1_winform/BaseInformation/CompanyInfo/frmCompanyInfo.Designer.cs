
namespace FinalProject1_winform
{
    partial class frmCompanyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompanyInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btmUpdate = new FinalProject1_winform.Button_gudi();
            this.button_gudi10 = new FinalProject1_winform.Button_gudi();
            this.btnExportExcel = new FinalProject1_winform.Button_gudi();
            this.btnDelete = new FinalProject1_winform.Button_gudi();
            this.btnInsert = new FinalProject1_winform.Button_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgV_Company = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCompanyCrum = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtCompanyCode = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.btmSearch = new FinalProject1_winform.Button_gudi();
            this.cboCompanyType = new FinalProject1_winform.ComboBox_gudi();
            this.lblCompanyType = new FinalProject1_winform.Label_gudi();
            this.txtCompanyName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.lblCompanyName = new FinalProject1_winform.Label_gudi();
            this.lblCompanyCode = new FinalProject1_winform.Label_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_Company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmUpdate
            // 
            this.btmUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btmUpdate.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btmUpdate.FlatAppearance.BorderSize = 0;
            this.btmUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmUpdate.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btmUpdate.ForeColor = System.Drawing.Color.Black;
            this.btmUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btmUpdate.Image")));
            this.btmUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmUpdate.Location = new System.Drawing.Point(730, 109);
            this.btmUpdate.Name = "btmUpdate";
            this.btmUpdate.Size = new System.Drawing.Size(60, 25);
            this.btmUpdate.TabIndex = 27;
            this.btmUpdate.Text = "수정";
            this.btmUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmUpdate.UseVisualStyleBackColor = false;
            // 
            // button_gudi10
            // 
            this.button_gudi10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi10.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi10.FlatAppearance.BorderSize = 0;
            this.button_gudi10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi10.ForeColor = System.Drawing.Color.Black;
            this.button_gudi10.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi10.Image")));
            this.button_gudi10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi10.Location = new System.Drawing.Point(926, 109);
            this.button_gudi10.Name = "button_gudi10";
            this.button_gudi10.Size = new System.Drawing.Size(149, 25);
            this.button_gudi10.TabIndex = 22;
            this.button_gudi10.Text = "양식(양식이름) 다운";
            this.button_gudi10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi10.UseVisualStyleBackColor = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnExportExcel.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportExcel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(861, 109);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(60, 25);
            this.btnExportExcel.TabIndex = 23;
            this.btnExportExcel.Text = "엑셀";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnDelete.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(795, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 25);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnInsert.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(665, 109);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(60, 25);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "등록";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi4.Location = new System.Drawing.Point(49, 113);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(74, 16);
            this.label_gudi4.TabIndex = 21;
            this.label_gudi4.Text = "업체코드정의";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgV_Company);
            this.panel2.Location = new System.Drawing.Point(17, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 466);
            this.panel2.TabIndex = 20;
            // 
            // dgV_Company
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgV_Company.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgV_Company.BackgroundColor = System.Drawing.Color.White;
            this.dgV_Company.CheckBoxAll = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgV_Company.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgV_Company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_Company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgV_Company.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgV_Company.HeaderCheckStatus = false;
            this.dgV_Company.Location = new System.Drawing.Point(0, 0);
            this.dgV_Company.Name = "dgV_Company";
            this.dgV_Company.RowHeadersVisible = false;
            this.dgV_Company.RowTemplate.Height = 23;
            this.dgV_Company.Size = new System.Drawing.Size(1057, 466);
            this.dgV_Company.TabIndex = 0;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(18, 111);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 19;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.txtCompanyCrum);
            this.panel1.Controls.Add(this.txtCompanyCode);
            this.panel1.Controls.Add(this.label_gudi5);
            this.panel1.Controls.Add(this.btmSearch);
            this.panel1.Controls.Add(this.cboCompanyType);
            this.panel1.Controls.Add(this.lblCompanyType);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.lblCompanyName);
            this.panel1.Controls.Add(this.lblCompanyCode);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 87);
            this.panel1.TabIndex = 18;
            // 
            // txtCompanyCrum
            // 
            this.txtCompanyCrum.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyCrum.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyCrum.Location = new System.Drawing.Point(126, 54);
            this.txtCompanyCrum.Name = "txtCompanyCrum";
            this.txtCompanyCrum.Size = new System.Drawing.Size(187, 25);
            this.txtCompanyCrum.TabIndex = 12;
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyCode.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyCode.Location = new System.Drawing.Point(126, 11);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(187, 25);
            this.txtCompanyCode.TabIndex = 11;
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi5.Location = new System.Drawing.Point(12, 57);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(99, 16);
            this.label_gudi5.TabIndex = 10;
            this.label_gudi5.Text = "■ 사업자등록번호";
            // 
            // btmSearch
            // 
            this.btmSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btmSearch.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btmSearch.FlatAppearance.BorderSize = 0;
            this.btmSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSearch.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btmSearch.ForeColor = System.Drawing.Color.White;
            this.btmSearch.Image = ((System.Drawing.Image)(resources.GetObject("btmSearch.Image")));
            this.btmSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmSearch.Location = new System.Drawing.Point(959, 11);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(78, 25);
            this.btmSearch.TabIndex = 9;
            this.btmSearch.Text = "조회";
            this.btmSearch.UseVisualStyleBackColor = false;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // cboCompanyType
            // 
            this.cboCompanyType.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompanyType.FormattingEnabled = true;
            this.cboCompanyType.Items.AddRange(new object[] {
            "고객사",
            "협력사"});
            this.cboCompanyType.Location = new System.Drawing.Point(747, 11);
            this.cboCompanyType.Name = "cboCompanyType";
            this.cboCompanyType.Size = new System.Drawing.Size(139, 24);
            this.cboCompanyType.TabIndex = 5;
            // 
            // lblCompanyType
            // 
            this.lblCompanyType.AutoSize = true;
            this.lblCompanyType.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCompanyType.Location = new System.Drawing.Point(669, 15);
            this.lblCompanyType.Name = "lblCompanyType";
            this.lblCompanyType.Size = new System.Drawing.Size(66, 16);
            this.lblCompanyType.TabIndex = 4;
            this.lblCompanyType.Text = "■ 업체타입";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompanyName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompanyName.Location = new System.Drawing.Point(426, 11);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(187, 25);
            this.txtCompanyName.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCompanyName.Location = new System.Drawing.Point(360, 15);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(55, 16);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "■ 업체명";
            // 
            // lblCompanyCode
            // 
            this.lblCompanyCode.AutoSize = true;
            this.lblCompanyCode.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCompanyCode.Location = new System.Drawing.Point(12, 15);
            this.lblCompanyCode.Name = "lblCompanyCode";
            this.lblCompanyCode.Size = new System.Drawing.Size(66, 16);
            this.lblCompanyCode.TabIndex = 0;
            this.lblCompanyCode.Text = "■ 업체코드";
            // 
            // frmCompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.btmUpdate);
            this.Controls.Add(this.button_gudi10);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCompanyInfo";
            this.Text = "frmCompanyInfo";
            this.Load += new System.EventHandler(this.frmCompanyInfo_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgV_Company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button_gudi btmUpdate;
        private Button_gudi button_gudi10;
        private Button_gudi btnExportExcel;
        private Button_gudi btnDelete;
        private Button_gudi btnInsert;
        private Label_gudi label_gudi4;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi btmSearch;
        private ComboBox_gudi cboCompanyType;
        private Label_gudi lblCompanyType;
        private Controls.TextBox_gudi txtCompanyName;
        private Label_gudi lblCompanyName;
        private Label_gudi lblCompanyCode;
        private Controls.TextBox_gudi txtCompanyCrum;
        private Controls.TextBox_gudi txtCompanyCode;
        private Label_gudi label_gudi5;
        private DGV_gudi dgV_Company;
    }
}