
namespace FinalProject1_winform
{
    partial class frmMasterCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterCreate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.btn_Template = new FinalProject1_winform.Button_gudi();
            this.btn_POExcel = new FinalProject1_winform.Button_gudi();
            this.btn_Create = new FinalProject1_winform.Button_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_PO = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(49, 25);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(72, 17);
            this.label_gudi1.TabIndex = 83;
            this.label_gudi1.Text = "영업 마스터";
            // 
            // btn_Template
            // 
            this.btn_Template.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Template.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_Template.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_Template.FlatAppearance.BorderSize = 0;
            this.btn_Template.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Template.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Template.ForeColor = System.Drawing.Color.Black;
            this.btn_Template.Image = ((System.Drawing.Image)(resources.GetObject("btn_Template.Image")));
            this.btn_Template.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Template.Location = new System.Drawing.Point(829, 21);
            this.btn_Template.Name = "btn_Template";
            this.btn_Template.Size = new System.Drawing.Size(111, 25);
            this.btn_Template.TabIndex = 79;
            this.btn_Template.Text = "양식 다운로드";
            this.btn_Template.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Template.UseVisualStyleBackColor = false;
            // 
            // btn_POExcel
            // 
            this.btn_POExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_POExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_POExcel.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_POExcel.FlatAppearance.BorderSize = 0;
            this.btn_POExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_POExcel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_POExcel.ForeColor = System.Drawing.Color.Black;
            this.btn_POExcel.Image = ((System.Drawing.Image)(resources.GetObject("btn_POExcel.Image")));
            this.btn_POExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_POExcel.Location = new System.Drawing.Point(946, 21);
            this.btn_POExcel.Name = "btn_POExcel";
            this.btn_POExcel.Size = new System.Drawing.Size(129, 25);
            this.btn_POExcel.TabIndex = 80;
            this.btn_POExcel.Text = "발주서 엑셀등록";
            this.btn_POExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_POExcel.UseVisualStyleBackColor = false;
            this.btn_POExcel.Click += new System.EventHandler(this.btn_POExcel_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_Create.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_Create.FlatAppearance.BorderSize = 0;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Create.ForeColor = System.Drawing.Color.Black;
            this.btn_Create.Image = ((System.Drawing.Image)(resources.GetObject("btn_Create.Image")));
            this.btn_Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Create.Location = new System.Drawing.Point(698, 21);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(125, 25);
            this.btn_Create.TabIndex = 82;
            this.btn_Create.Text = "영업마스터 생성";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_PO);
            this.panel2.Location = new System.Drawing.Point(18, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 551);
            this.panel2.TabIndex = 78;
            // 
            // dgv_PO
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_PO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PO.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PO.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PO.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_PO.HeaderCheckStatus = false;
            this.dgv_PO.Location = new System.Drawing.Point(3, 3);
            this.dgv_PO.Name = "dgv_PO";
            this.dgv_PO.RowHeadersVisible = false;
            this.dgv_PO.RowTemplate.Height = 23;
            this.dgv_PO.Size = new System.Drawing.Size(1049, 533);
            this.dgv_PO.TabIndex = 0;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(19, 24);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 77;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // frmMasterCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 632);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.btn_Template);
            this.Controls.Add(this.btn_POExcel);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Name = "frmMasterCreate";
            this.Text = "frmSMInsert";
            this.Load += new System.EventHandler(this.frmMasterCreate_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label_gudi label_gudi1;
        private Button_gudi btn_Template;
        private Button_gudi btn_POExcel;
        private Button_gudi btn_Create;
        private System.Windows.Forms.Panel panel2;
        private DGV_gudi dgv_PO;
        private PictureBox_gudi pictureBox_gudi2;
    }
}
