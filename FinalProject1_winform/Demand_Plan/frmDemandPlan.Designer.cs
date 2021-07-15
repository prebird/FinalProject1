
namespace FinalProject1_winform
{
    partial class frmDemandPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemandPlan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Excel = new FinalProject1_winform.Button_gudi();
            this.btn_Delete = new FinalProject1_winform.Button_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_DemandPlan = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_CompanyName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.dtp_End = new FinalProject1_winform.DateTimePicker_gudi();
            this.dtp_Start = new FinalProject1_winform.DateTimePicker_gudi();
            this.label_gudi14 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.txt_ItemName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.txt_PlanID = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.btn_Search = new FinalProject1_winform.Button_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.btn_CreatePP = new FinalProject1_winform.Button_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DemandPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Excel
            // 
            this.btn_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_Excel.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_Excel.FlatAppearance.BorderSize = 0;
            this.btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Excel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Excel.ForeColor = System.Drawing.Color.Black;
            this.btn_Excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel.Image")));
            this.btn_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel.Location = new System.Drawing.Point(896, 112);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(60, 25);
            this.btn_Excel.TabIndex = 28;
            this.btn_Excel.Text = "엑셀";
            this.btn_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel.UseVisualStyleBackColor = false;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_Delete.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(830, 112);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(60, 25);
            this.btn_Delete.TabIndex = 29;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_DemandPlan);
            this.panel2.Location = new System.Drawing.Point(18, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 459);
            this.panel2.TabIndex = 26;
            // 
            // dgv_DemandPlan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_DemandPlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DemandPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DemandPlan.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DemandPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DemandPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DemandPlan.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_DemandPlan.HeaderCheckStatus = false;
            this.dgv_DemandPlan.Location = new System.Drawing.Point(3, 3);
            this.dgv_DemandPlan.Name = "dgv_DemandPlan";
            this.dgv_DemandPlan.RowHeadersVisible = false;
            this.dgv_DemandPlan.RowTemplate.Height = 23;
            this.dgv_DemandPlan.Size = new System.Drawing.Size(1051, 453);
            this.dgv_DemandPlan.TabIndex = 0;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(18, 115);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 25;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.txt_CompanyName);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Controls.Add(this.dtp_End);
            this.panel1.Controls.Add(this.dtp_Start);
            this.panel1.Controls.Add(this.label_gudi14);
            this.panel1.Controls.Add(this.label_gudi6);
            this.panel1.Controls.Add(this.txt_ItemName);
            this.panel1.Controls.Add(this.label_gudi4);
            this.panel1.Controls.Add(this.txt_PlanID);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Location = new System.Drawing.Point(18, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 79);
            this.panel1.TabIndex = 24;
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_CompanyName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_CompanyName.Location = new System.Drawing.Point(659, 32);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(91, 25);
            this.txt_CompanyName.TabIndex = 89;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(432, 36);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(16, 17);
            this.label_gudi1.TabIndex = 88;
            this.label_gudi1.Text = "~";
            // 
            // dtp_End
            // 
            this.dtp_End.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_End.Location = new System.Drawing.Point(454, 32);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(111, 25);
            this.dtp_End.TabIndex = 87;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Start.Location = new System.Drawing.Point(315, 32);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(111, 25);
            this.dtp_Start.TabIndex = 86;
            // 
            // label_gudi14
            // 
            this.label_gudi14.AutoSize = true;
            this.label_gudi14.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi14.Location = new System.Drawing.Point(220, 36);
            this.label_gudi14.Name = "label_gudi14";
            this.label_gudi14.Size = new System.Drawing.Size(88, 17);
            this.label_gudi14.TabIndex = 85;
            this.label_gudi14.Text = "■ 고객 납기일";
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(581, 36);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(72, 17);
            this.label_gudi6.TabIndex = 83;
            this.label_gudi6.Text = "■ 고객사명";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_ItemName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_ItemName.Location = new System.Drawing.Point(827, 32);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(91, 25);
            this.txt_ItemName.TabIndex = 82;
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(761, 36);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(60, 17);
            this.label_gudi4.TabIndex = 81;
            this.label_gudi4.Text = "■ 품목명";
            // 
            // txt_PlanID
            // 
            this.txt_PlanID.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_PlanID.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_PlanID.Location = new System.Drawing.Point(114, 32);
            this.txt_PlanID.Name = "txt_PlanID";
            this.txt_PlanID.Size = new System.Drawing.Size(92, 25);
            this.txt_PlanID.TabIndex = 80;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(13, 36);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(95, 17);
            this.label_gudi3.TabIndex = 79;
            this.label_gudi3.Text = "■ 계획 Version";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btn_Search.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(967, 45);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(78, 25);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label_gudi2
            // 
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi2.Location = new System.Drawing.Point(49, 116);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(81, 18);
            this.label_gudi2.TabIndex = 33;
            this.label_gudi2.Text = "수요 계획 목록";
            // 
            // btn_CreatePP
            // 
            this.btn_CreatePP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreatePP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_CreatePP.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_CreatePP.FlatAppearance.BorderSize = 0;
            this.btn_CreatePP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CreatePP.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_CreatePP.ForeColor = System.Drawing.Color.Black;
            this.btn_CreatePP.Image = ((System.Drawing.Image)(resources.GetObject("btn_CreatePP.Image")));
            this.btn_CreatePP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreatePP.Location = new System.Drawing.Point(962, 112);
            this.btn_CreatePP.Name = "btn_CreatePP";
            this.btn_CreatePP.Size = new System.Drawing.Size(113, 25);
            this.btn_CreatePP.TabIndex = 31;
            this.btn_CreatePP.Text = "생산 계획 생성";
            this.btn_CreatePP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CreatePP.UseVisualStyleBackColor = false;
            // 
            // frmDemandPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.btn_CreatePP);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDemandPlan";
            this.Text = "frmDemandPlan";
            this.Load += new System.EventHandler(this.frmDemandPlan_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DemandPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button_gudi btn_Excel;
        private Button_gudi btn_Delete;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi btn_Search;
        private Label_gudi label_gudi2;
        private Controls.TextBox_gudi txt_PlanID;
        private Label_gudi label_gudi3;
        private Controls.TextBox_gudi txt_CompanyName;
        private Label_gudi label_gudi1;
        private DateTimePicker_gudi dtp_End;
        private DateTimePicker_gudi dtp_Start;
        private Label_gudi label_gudi14;
        private Label_gudi label_gudi6;
        private Controls.TextBox_gudi txt_ItemName;
        private Label_gudi label_gudi4;
        private DGV_gudi dgv_DemandPlan;
        private Button_gudi btn_CreatePP;
    }
}
