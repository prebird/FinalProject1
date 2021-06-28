
namespace FinalProject1_winform
{
    partial class frmSMInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSMInsert));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.button_gudi10 = new FinalProject1_winform.Button_gudi();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            this.button_gudi3 = new FinalProject1_winform.Button_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgV_gudi1 = new FinalProject1_winform.DGV_gudi();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_gudi1)).BeginInit();
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
            // button_gudi10
            // 
            this.button_gudi10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi10.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi10.FlatAppearance.BorderSize = 0;
            this.button_gudi10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi10.ForeColor = System.Drawing.Color.Black;
            this.button_gudi10.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi10.Image")));
            this.button_gudi10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi10.Location = new System.Drawing.Point(829, 21);
            this.button_gudi10.Name = "button_gudi10";
            this.button_gudi10.Size = new System.Drawing.Size(111, 25);
            this.button_gudi10.TabIndex = 79;
            this.button_gudi10.Text = "양식 다운로드";
            this.button_gudi10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi10.UseVisualStyleBackColor = false;
            // 
            // button_gudi5
            // 
            this.button_gudi5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi5.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi5.FlatAppearance.BorderSize = 0;
            this.button_gudi5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi5.ForeColor = System.Drawing.Color.Black;
            this.button_gudi5.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi5.Image")));
            this.button_gudi5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi5.Location = new System.Drawing.Point(946, 21);
            this.button_gudi5.Name = "button_gudi5";
            this.button_gudi5.Size = new System.Drawing.Size(129, 25);
            this.button_gudi5.TabIndex = 80;
            this.button_gudi5.Text = "발주서 엑셀등록";
            this.button_gudi5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi5.UseVisualStyleBackColor = false;
            // 
            // button_gudi3
            // 
            this.button_gudi3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi3.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi3.FlatAppearance.BorderSize = 0;
            this.button_gudi3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi3.ForeColor = System.Drawing.Color.Black;
            this.button_gudi3.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi3.Image")));
            this.button_gudi3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi3.Location = new System.Drawing.Point(698, 21);
            this.button_gudi3.Name = "button_gudi3";
            this.button_gudi3.Size = new System.Drawing.Size(125, 25);
            this.button_gudi3.TabIndex = 82;
            this.button_gudi3.Text = "영업마스터 생성";
            this.button_gudi3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgV_gudi1);
            this.panel2.Location = new System.Drawing.Point(18, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 539);
            this.panel2.TabIndex = 78;
            // 
            // dgV_gudi1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgV_gudi1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgV_gudi1.BackgroundColor = System.Drawing.Color.White;
            this.dgV_gudi1.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgV_gudi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgV_gudi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_gudi1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6});
            this.dgV_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgV_gudi1.HeaderCheckStatus = false;
            this.dgV_gudi1.Location = new System.Drawing.Point(3, 3);
            this.dgV_gudi1.Name = "dgV_gudi1";
            this.dgV_gudi1.RowHeadersVisible = false;
            this.dgV_gudi1.RowTemplate.Height = 23;
            this.dgV_gudi1.Size = new System.Drawing.Size(1049, 533);
            this.dgV_gudi1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PO번호";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "계획번호";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "업체코드";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "품목명";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "납품처";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "총계획수량";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "납기일";
            this.Column6.Name = "Column6";
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
            // frmSMInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.button_gudi10);
            this.Controls.Add(this.button_gudi5);
            this.Controls.Add(this.button_gudi3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Name = "frmSMInsert";
            this.Text = "frmSMInsert";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgV_gudi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label_gudi label_gudi1;
        private Button_gudi button_gudi10;
        private Button_gudi button_gudi5;
        private Button_gudi button_gudi3;
        private System.Windows.Forms.Panel panel2;
        private DGV_gudi dgV_gudi1;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
