
namespace FinalProject1_winform
{
    partial class frmInstockWait
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstockWait));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCompany = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.txtRO = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.dtp1 = new FinalProject1_winform.UcDateTimePicker();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.btnSearch = new FinalProject1_winform.Button_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.btnExcel = new FinalProject1_winform.Button_gudi();
            this.btnSelect = new FinalProject1_winform.Button_gudi();
            this.btnCancel = new FinalProject1_winform.Button_gudi();
            this.btnGO = new FinalProject1_winform.Button_gudi();
            this.dgv1 = new FinalProject1_winform.DGV_gudi();
            this.dgv2 = new FinalProject1_winform.DGV_gudi();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgv2);
            this.panel3.Location = new System.Drawing.Point(18, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 223);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox_gudi1
            // 
            this.pictureBox_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi1.Image")));
            this.pictureBox_gudi1.Location = new System.Drawing.Point(18, 351);
            this.pictureBox_gudi1.Name = "pictureBox_gudi1";
            this.pictureBox_gudi1.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi1.TabIndex = 12;
            this.pictureBox_gudi1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv1);
            this.panel2.Location = new System.Drawing.Point(18, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 196);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(18, 115);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 10;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.cboCompany);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Controls.Add(this.txtRO);
            this.panel1.Controls.Add(this.label_gudi6);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(18, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 79);
            this.panel1.TabIndex = 9;
            // 
            // cboCompany
            // 
            this.cboCompany.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(477, 12);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(163, 24);
            this.cboCompany.TabIndex = 20;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(398, 15);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(72, 17);
            this.label_gudi1.TabIndex = 19;
            this.label_gudi1.Text = "■ 납품업체";
            // 
            // txtRO
            // 
            this.txtRO.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtRO.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtRO.Location = new System.Drawing.Point(796, 11);
            this.txtRO.Name = "txtRO";
            this.txtRO.Size = new System.Drawing.Size(205, 25);
            this.txtRO.TabIndex = 23;
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(715, 15);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(72, 17);
            this.label_gudi6.TabIndex = 22;
            this.label_gudi6.Text = "■ 발주번호";
            // 
            // dtp1
            // 
            this.dtp1.FromDate = new System.DateTime(2021, 6, 25, 14, 0, 31, 72);
            this.dtp1.Location = new System.Drawing.Point(89, 9);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(257, 30);
            this.dtp1.TabIndex = 21;
            this.dtp1.ToDate = new System.DateTime(2021, 6, 25, 14, 0, 31, 69);
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(12, 17);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(72, 17);
            this.label_gudi3.TabIndex = 18;
            this.label_gudi3.Text = "■ 납기일자";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSearch.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(964, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 25);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label_gudi5
            // 
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi5.Location = new System.Drawing.Point(49, 116);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(107, 18);
            this.label_gudi5.TabIndex = 27;
            this.label_gudi5.Text = "입고 대기 리스트";
            // 
            // label_gudi2
            // 
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi2.Location = new System.Drawing.Point(49, 353);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(107, 18);
            this.label_gudi2.TabIndex = 27;
            this.label_gudi2.Text = "자재 입고 대기";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnExcel.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1015, 107);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(60, 25);
            this.btnExcel.TabIndex = 28;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnSelect.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(949, 107);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(60, 25);
            this.btnSelect.TabIndex = 29;
            this.btnSelect.Text = "선택";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnCancel.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1015, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 25);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGO
            // 
            this.btnGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnGO.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnGO.FlatAppearance.BorderSize = 0;
            this.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGO.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnGO.ForeColor = System.Drawing.Color.Black;
            this.btnGO.Image = ((System.Drawing.Image)(resources.GetObject("btnGO.Image")));
            this.btnGO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGO.Location = new System.Drawing.Point(900, 346);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(109, 25);
            this.btnGO.TabIndex = 31;
            this.btnGO.Text = "입고대기처리";
            this.btnGO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // dgv1
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.CheckBoxAll = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv1.HeaderCheckStatus = false;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(1057, 196);
            this.dgv1.TabIndex = 0;
            // 
            // dgv2
            // 
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv2.BackgroundColor = System.Drawing.Color.White;
            this.dgv2.CheckBoxAll = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv2.HeaderCheckStatus = false;
            this.dgv2.Location = new System.Drawing.Point(0, 0);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowTemplate.Height = 23;
            this.dgv2.Size = new System.Drawing.Size(1057, 223);
            this.dgv2.TabIndex = 0;
            // 
            // frmInstockWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox_gudi1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmInstockWait";
            this.Text = "입고대기";
            this.Load += new System.EventHandler(this.frmInstockWait_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private PictureBox_gudi pictureBox_gudi1;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private Controls.TextBox_gudi txtRO;
        private Label_gudi label_gudi6;
        private UcDateTimePicker dtp1;
        private ComboBox_gudi cboCompany;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi1;
        private Button_gudi btnSearch;
        private Label_gudi label_gudi5;
        private Label_gudi label_gudi2;
        private Button_gudi btnExcel;
        private Button_gudi btnSelect;
        private Button_gudi btnCancel;
        private Button_gudi btnGO;
        private DGV_gudi dgv2;
        private DGV_gudi dgv1;
    }
}
