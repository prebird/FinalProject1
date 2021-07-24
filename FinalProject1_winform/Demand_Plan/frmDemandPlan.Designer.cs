
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_DemandPlan = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_PlanID = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.dtp_End = new FinalProject1_winform.DateTimePicker_gudi();
            this.dtp_Start = new FinalProject1_winform.DateTimePicker_gudi();
            this.label_gudi14 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.btn_Search = new FinalProject1_winform.Button_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.btn_ProductionPlan = new FinalProject1_winform.Button_gudi();
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
            this.panel1.Controls.Add(this.cbo_PlanID);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Controls.Add(this.dtp_End);
            this.panel1.Controls.Add(this.dtp_Start);
            this.panel1.Controls.Add(this.label_gudi14);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Location = new System.Drawing.Point(18, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 79);
            this.panel1.TabIndex = 24;
            // 
            // cbo_PlanID
            // 
            this.cbo_PlanID.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_PlanID.FormattingEnabled = true;
            this.cbo_PlanID.Location = new System.Drawing.Point(171, 28);
            this.cbo_PlanID.Name = "cbo_PlanID";
            this.cbo_PlanID.Size = new System.Drawing.Size(111, 24);
            this.cbo_PlanID.TabIndex = 90;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(557, 32);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(16, 17);
            this.label_gudi1.TabIndex = 88;
            this.label_gudi1.Text = "~";
            // 
            // dtp_End
            // 
            this.dtp_End.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_End.Location = new System.Drawing.Point(585, 28);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(111, 25);
            this.dtp_End.TabIndex = 87;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Start.Location = new System.Drawing.Point(433, 28);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(111, 25);
            this.dtp_Start.TabIndex = 86;
            // 
            // label_gudi14
            // 
            this.label_gudi14.AutoSize = true;
            this.label_gudi14.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi14.Location = new System.Drawing.Point(325, 32);
            this.label_gudi14.Name = "label_gudi14";
            this.label_gudi14.Size = new System.Drawing.Size(88, 17);
            this.label_gudi14.TabIndex = 85;
            this.label_gudi14.Text = "■ 고객 납기일";
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(65, 32);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(90, 17);
            this.label_gudi3.TabIndex = 79;
            this.label_gudi3.Text = "■ 계획 PlanID";
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
            // btn_ProductionPlan
            // 
            this.btn_ProductionPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ProductionPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_ProductionPlan.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_ProductionPlan.FlatAppearance.BorderSize = 0;
            this.btn_ProductionPlan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ProductionPlan.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_ProductionPlan.ForeColor = System.Drawing.Color.Black;
            this.btn_ProductionPlan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ProductionPlan.Image")));
            this.btn_ProductionPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ProductionPlan.Location = new System.Drawing.Point(962, 112);
            this.btn_ProductionPlan.Name = "btn_ProductionPlan";
            this.btn_ProductionPlan.Size = new System.Drawing.Size(113, 25);
            this.btn_ProductionPlan.TabIndex = 31;
            this.btn_ProductionPlan.Text = "생산 계획 생성";
            this.btn_ProductionPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ProductionPlan.UseVisualStyleBackColor = false;
            this.btn_ProductionPlan.Click += new System.EventHandler(this.btn_ProductionPlan_Click);
            // 
            // frmDemandPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.btn_ProductionPlan);
            this.Controls.Add(this.btn_Excel);
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
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi btn_Search;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi1;
        private DateTimePicker_gudi dtp_End;
        private DateTimePicker_gudi dtp_Start;
        private Label_gudi label_gudi14;
        private DGV_gudi dgv_DemandPlan;
        private Button_gudi btn_ProductionPlan;
        private ComboBox_gudi cbo_PlanID;
    }
}
