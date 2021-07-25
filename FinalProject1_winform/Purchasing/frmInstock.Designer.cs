
namespace FinalProject1_winform
{
    partial class frmInstock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new FinalProject1_winform.Button_gudi();
            this.btnAdd = new FinalProject1_winform.Button_gudi();
            this.btnExcel = new FinalProject1_winform.Button_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvIn = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvWait = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtROID = new FinalProject1_winform.Controls.TextBox_gudi();
            this.cboCompany = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.cboStatus = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.dtp1 = new FinalProject1_winform.UcDateTimePicker();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.button_gudi8 = new FinalProject1_winform.Button_gudi();
            this.btnEdit = new FinalProject1_winform.Button_gudi();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(1187, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 25);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnAdd.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1093, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 25);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "입고처리";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnExcel.Location = new System.Drawing.Point(1187, 109);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(60, 25);
            this.btnExcel.TabIndex = 39;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // label_gudi2
            // 
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi2.Location = new System.Drawing.Point(49, 353);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(107, 18);
            this.label_gudi2.TabIndex = 37;
            this.label_gudi2.Text = "자재 입고";
            // 
            // label_gudi5
            // 
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi5.Location = new System.Drawing.Point(49, 116);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(107, 18);
            this.label_gudi5.TabIndex = 38;
            this.label_gudi5.Text = "입고 대기 리스트";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvIn);
            this.panel3.Location = new System.Drawing.Point(18, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1229, 311);
            this.panel3.TabIndex = 36;
            // 
            // dgvIn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvIn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIn.BackgroundColor = System.Drawing.Color.White;
            this.dgvIn.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIn.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvIn.HeaderCheckStatus = false;
            this.dgvIn.Location = new System.Drawing.Point(0, 0);
            this.dgvIn.Name = "dgvIn";
            this.dgvIn.RowHeadersVisible = false;
            this.dgvIn.RowTemplate.Height = 23;
            this.dgvIn.Size = new System.Drawing.Size(1229, 311);
            this.dgvIn.TabIndex = 0;
            // 
            // pictureBox_gudi1
            // 
            this.pictureBox_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi1.Image")));
            this.pictureBox_gudi1.Location = new System.Drawing.Point(18, 351);
            this.pictureBox_gudi1.Name = "pictureBox_gudi1";
            this.pictureBox_gudi1.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi1.TabIndex = 35;
            this.pictureBox_gudi1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvWait);
            this.panel2.Location = new System.Drawing.Point(18, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1229, 196);
            this.panel2.TabIndex = 34;
            // 
            // dgvWait
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvWait.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWait.BackgroundColor = System.Drawing.Color.White;
            this.dgvWait.CheckBoxAll = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWait.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWait.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvWait.HeaderCheckStatus = false;
            this.dgvWait.Location = new System.Drawing.Point(0, 0);
            this.dgvWait.Name = "dgvWait";
            this.dgvWait.RowHeadersVisible = false;
            this.dgvWait.RowTemplate.Height = 23;
            this.dgvWait.Size = new System.Drawing.Size(1229, 196);
            this.dgvWait.TabIndex = 0;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(18, 115);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 33;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.txtROID);
            this.panel1.Controls.Add(this.cboCompany);
            this.panel1.Controls.Add(this.label_gudi4);
            this.panel1.Controls.Add(this.cboStatus);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Controls.Add(this.label_gudi6);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.button_gudi8);
            this.panel1.Location = new System.Drawing.Point(18, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 79);
            this.panel1.TabIndex = 32;
            // 
            // txtROID
            // 
            this.txtROID.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtROID.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtROID.Location = new System.Drawing.Point(89, 12);
            this.txtROID.Name = "txtROID";
            this.txtROID.Size = new System.Drawing.Size(257, 25);
            this.txtROID.TabIndex = 23;
            // 
            // cboCompany
            // 
            this.cboCompany.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(818, 12);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(193, 24);
            this.cboCompany.TabIndex = 20;
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(11, 16);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(72, 17);
            this.label_gudi4.TabIndex = 19;
            this.label_gudi4.Text = "■ 발주번호";
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(477, 15);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(163, 24);
            this.cboStatus.TabIndex = 20;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(399, 19);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(48, 17);
            this.label_gudi1.TabIndex = 19;
            this.label_gudi1.Text = "■ 상태";
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(718, 15);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(72, 17);
            this.label_gudi6.TabIndex = 22;
            this.label_gudi6.Text = "■ 납품업체";
            // 
            // dtp1
            // 
            this.dtp1.FromDate = new System.DateTime(2021, 6, 25, 14, 0, 31, 72);
            this.dtp1.Location = new System.Drawing.Point(89, 41);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(257, 30);
            this.dtp1.TabIndex = 21;
            this.dtp1.ToDate = new System.DateTime(2021, 6, 25, 14, 0, 31, 69);
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(12, 47);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(72, 17);
            this.label_gudi3.TabIndex = 18;
            this.label_gudi3.Text = "■ 납기일자";
            // 
            // button_gudi8
            // 
            this.button_gudi8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.button_gudi8.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.button_gudi8.FlatAppearance.BorderSize = 0;
            this.button_gudi8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi8.ForeColor = System.Drawing.Color.White;
            this.button_gudi8.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi8.Image")));
            this.button_gudi8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi8.Location = new System.Drawing.Point(1136, 46);
            this.button_gudi8.Name = "button_gudi8";
            this.button_gudi8.Size = new System.Drawing.Size(78, 25);
            this.button_gudi8.TabIndex = 17;
            this.button_gudi8.Text = "조회";
            this.button_gudi8.UseVisualStyleBackColor = false;
            this.button_gudi8.Click += new System.EventHandler(this.button_gudi8_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnEdit.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(1121, 342);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 25);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "수정";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // frmInstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1265, 708);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox_gudi1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmInstock";
            this.Text = "자재입고";
            this.Load += new System.EventHandler(this.frmInstock_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button_gudi btnCancel;
        private Button_gudi btnAdd;
        private Button_gudi btnExcel;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi5;
        private System.Windows.Forms.Panel panel3;
        private PictureBox_gudi pictureBox_gudi1;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private ComboBox_gudi cboStatus;
        private Label_gudi label_gudi1;
        private Label_gudi label_gudi6;
        private UcDateTimePicker dtp1;
        private Label_gudi label_gudi3;
        private Button_gudi button_gudi8;
        private ComboBox_gudi cboCompany;
        private DGV_gudi dgvIn;
        private DGV_gudi dgvWait;
        private Button_gudi btnEdit;
        private Label_gudi label_gudi4;
        private Controls.TextBox_gudi txtROID;
    }
}
