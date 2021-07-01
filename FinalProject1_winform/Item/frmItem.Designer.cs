
namespace FinalProject1_winform
{
    partial class frmProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Item = new FinalProject1_winform.DGV_gudi();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_YN = new FinalProject1_winform.ComboBox_gudi();
            this.cbo_OutHouse = new FinalProject1_winform.ComboBox_gudi();
            this.cbo_InHouse = new FinalProject1_winform.ComboBox_gudi();
            this.btn_Search = new FinalProject1_winform.Button_gudi();
            this.cbo_ItemType = new FinalProject1_winform.ComboBox_gudi();
            this.txt_ItemName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi9 = new FinalProject1_winform.Label_gudi();
            this.btn_Excel = new FinalProject1_winform.Button_gudi();
            this.btn_Update = new FinalProject1_winform.Button_gudi();
            this.btn_Delete = new FinalProject1_winform.Button_gudi();
            this.button_gudi3 = new FinalProject1_winform.Button_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_Item);
            this.panel2.Location = new System.Drawing.Point(18, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 398);
            this.panel2.TabIndex = 8;
            // 
            // dgv_Item
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_Item.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Item.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Item.CheckBoxAll = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21});
            this.dgv_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Item.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_Item.HeaderCheckStatus = false;
            this.dgv_Item.Location = new System.Drawing.Point(0, 0);
            this.dgv_Item.Name = "dgv_Item";
            this.dgv_Item.RowHeadersVisible = false;
            this.dgv_Item.RowTemplate.Height = 23;
            this.dgv_Item.Size = new System.Drawing.Size(1057, 398);
            this.dgv_Item.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "품목번호";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "품목유형";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "품목코드";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "품목명";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "단위";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "단위수량";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "발주방식";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "최소발주량";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "안전재고량";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "사용여부";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "담당자";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "입고 창고";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "출고 창고";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "납품업체";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "발주업체";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "측정방식";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "LeadTime";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "품목 최솟값";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "품목 최댓값";
            this.Column19.Name = "Column19";
            // 
            // Column20
            // 
            this.Column20.HeaderText = "바코드";
            this.Column20.Name = "Column20";
            // 
            // Column21
            // 
            this.Column21.HeaderText = "비고";
            this.Column21.Name = "Column21";
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(19, 176);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 7;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.cbo_YN);
            this.panel1.Controls.Add(this.cbo_OutHouse);
            this.panel1.Controls.Add(this.cbo_InHouse);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.cbo_ItemType);
            this.panel1.Controls.Add(this.txt_ItemName);
            this.panel1.Controls.Add(this.label_gudi6);
            this.panel1.Controls.Add(this.label_gudi4);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.label_gudi2);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Location = new System.Drawing.Point(18, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 127);
            this.panel1.TabIndex = 6;
            // 
            // cbo_YN
            // 
            this.cbo_YN.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_YN.FormattingEnabled = true;
            this.cbo_YN.Location = new System.Drawing.Point(736, 29);
            this.cbo_YN.Name = "cbo_YN";
            this.cbo_YN.Size = new System.Drawing.Size(161, 24);
            this.cbo_YN.TabIndex = 19;
            // 
            // cbo_OutHouse
            // 
            this.cbo_OutHouse.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_OutHouse.FormattingEnabled = true;
            this.cbo_OutHouse.Location = new System.Drawing.Point(441, 70);
            this.cbo_OutHouse.Name = "cbo_OutHouse";
            this.cbo_OutHouse.Size = new System.Drawing.Size(161, 24);
            this.cbo_OutHouse.TabIndex = 18;
            // 
            // cbo_InHouse
            // 
            this.cbo_InHouse.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_InHouse.FormattingEnabled = true;
            this.cbo_InHouse.Location = new System.Drawing.Point(441, 29);
            this.cbo_InHouse.Name = "cbo_InHouse";
            this.cbo_InHouse.Size = new System.Drawing.Size(161, 24);
            this.cbo_InHouse.TabIndex = 17;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btn_Search.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(946, 90);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 25);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // cbo_ItemType
            // 
            this.cbo_ItemType.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_ItemType.FormattingEnabled = true;
            this.cbo_ItemType.Location = new System.Drawing.Point(125, 29);
            this.cbo_ItemType.Name = "cbo_ItemType";
            this.cbo_ItemType.Size = new System.Drawing.Size(158, 24);
            this.cbo_ItemType.TabIndex = 7;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_ItemName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_ItemName.Location = new System.Drawing.Point(125, 70);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(158, 25);
            this.txt_ItemName.TabIndex = 6;
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(643, 33);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(72, 17);
            this.label_gudi6.TabIndex = 5;
            this.label_gudi6.Text = "■ 사용여부";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(51, 33);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(72, 17);
            this.label_gudi4.TabIndex = 3;
            this.label_gudi4.Text = "■ 품목유형";
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(348, 74);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(72, 17);
            this.label_gudi3.TabIndex = 2;
            this.label_gudi3.Text = "■ 출고창고";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(348, 33);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(72, 17);
            this.label_gudi2.TabIndex = 1;
            this.label_gudi2.Text = "■ 입고창고";
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(51, 74);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(60, 17);
            this.label_gudi1.TabIndex = 0;
            this.label_gudi1.Text = "■ 품목명";
            // 
            // label_gudi9
            // 
            this.label_gudi9.AutoSize = true;
            this.label_gudi9.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi9.Location = new System.Drawing.Point(50, 176);
            this.label_gudi9.Name = "label_gudi9";
            this.label_gudi9.Size = new System.Drawing.Size(60, 17);
            this.label_gudi9.TabIndex = 9;
            this.label_gudi9.Text = "품목 관리";
            // 
            // btn_Excel
            // 
            this.btn_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_Excel.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_Excel.FlatAppearance.BorderSize = 0;
            this.btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Excel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Excel.ForeColor = System.Drawing.Color.Black;
            this.btn_Excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel.Image")));
            this.btn_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel.Location = new System.Drawing.Point(1015, 172);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(60, 25);
            this.btn_Excel.TabIndex = 10;
            this.btn_Excel.Text = "엑셀";
            this.btn_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_Update.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(883, 172);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(60, 25);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "수정";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_Delete.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(949, 172);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(60, 25);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // button_gudi3
            // 
            this.button_gudi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi3.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi3.FlatAppearance.BorderSize = 0;
            this.button_gudi3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi3.ForeColor = System.Drawing.Color.Black;
            this.button_gudi3.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi3.Image")));
            this.button_gudi3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi3.Location = new System.Drawing.Point(817, 172);
            this.button_gudi3.Name = "button_gudi3";
            this.button_gudi3.Size = new System.Drawing.Size(60, 25);
            this.button_gudi3.TabIndex = 13;
            this.button_gudi3.Text = "등록";
            this.button_gudi3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi3.UseVisualStyleBackColor = false;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.button_gudi3);
            this.Controls.Add(this.label_gudi9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private DGV_gudi dgv_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private Label_gudi label_gudi6;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi1;
        private Controls.TextBox_gudi txt_ItemName;
        private ComboBox_gudi cbo_ItemType;
        private Button_gudi btn_Search;
        private ComboBox_gudi cbo_YN;
        private ComboBox_gudi cbo_OutHouse;
        private ComboBox_gudi cbo_InHouse;
        private Label_gudi label_gudi9;
        private Button_gudi btn_Excel;
        private Button_gudi btn_Update;
        private Button_gudi btn_Delete;
        private Button_gudi button_gudi3;
    }
}
