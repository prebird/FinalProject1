
namespace FinalProject1_winform
{
    partial class frmBOMList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBOMList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_YN = new FinalProject1_winform.ComboBox_gudi();
            this.cbo_ItemCategory = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.txt_ItemName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.btn_Search = new FinalProject1_winform.Button_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.btn_Insert = new FinalProject1_winform.Button_gudi();
            this.dgv_Forward = new FinalProject1_winform.DGV_gudi();
            this.dgv_Reverse = new FinalProject1_winform.DGV_gudi();
            this.dgv_Item = new FinalProject1_winform.DGV_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Forward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.cbo_YN);
            this.panel1.Controls.Add(this.cbo_ItemCategory);
            this.panel1.Controls.Add(this.label_gudi6);
            this.panel1.Controls.Add(this.label_gudi5);
            this.panel1.Controls.Add(this.txt_ItemName);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.label_gudi4);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 67);
            this.panel1.TabIndex = 24;
            // 
            // cbo_YN
            // 
            this.cbo_YN.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_YN.FormattingEnabled = true;
            this.cbo_YN.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbo_YN.Location = new System.Drawing.Point(571, 24);
            this.cbo_YN.Name = "cbo_YN";
            this.cbo_YN.Size = new System.Drawing.Size(134, 24);
            this.cbo_YN.TabIndex = 41;
            // 
            // cbo_ItemCategory
            // 
            this.cbo_ItemCategory.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_ItemCategory.FormattingEnabled = true;
            this.cbo_ItemCategory.Items.AddRange(new object[] {
            "완제품",
            "반제품",
            "원자재"});
            this.cbo_ItemCategory.Location = new System.Drawing.Point(104, 23);
            this.cbo_ItemCategory.Name = "cbo_ItemCategory";
            this.cbo_ItemCategory.Size = new System.Drawing.Size(134, 24);
            this.cbo_ItemCategory.TabIndex = 40;
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(22, 27);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(76, 17);
            this.label_gudi6.TabIndex = 39;
            this.label_gudi6.Text = "■ 품목 유형";
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(493, 28);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(72, 17);
            this.label_gudi5.TabIndex = 35;
            this.label_gudi5.Text = "■ 사용유무";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_ItemName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_ItemName.Location = new System.Drawing.Point(330, 23);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(135, 25);
            this.txt_ItemName.TabIndex = 33;
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
            this.btn_Search.Location = new System.Drawing.Point(943, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(78, 25);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(263, 27);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(60, 17);
            this.label_gudi4.TabIndex = 31;
            this.label_gudi4.Text = "■ 품목명";
            // 
            // label_gudi2
            // 
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi2.Location = new System.Drawing.Point(15, 299);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(71, 18);
            this.label_gudi2.TabIndex = 29;
            this.label_gudi2.Text = "정전개";
            // 
            // label_gudi1
            // 
            this.label_gudi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi1.Location = new System.Drawing.Point(558, 299);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(71, 18);
            this.label_gudi1.TabIndex = 30;
            this.label_gudi1.Text = "역전개";
            // 
            // label_gudi7
            // 
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi7.Location = new System.Drawing.Point(15, 101);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(71, 18);
            this.label_gudi7.TabIndex = 31;
            this.label_gudi7.Text = "품목 정보";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_Insert.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Insert.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Insert.ForeColor = System.Drawing.Color.Black;
            this.btn_Insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_Insert.Image")));
            this.btn_Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Insert.Location = new System.Drawing.Point(961, 94);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(114, 25);
            this.btn_Insert.TabIndex = 34;
            this.btn_Insert.Text = "BOM 신규등록";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // dgv_Forward
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_Forward.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Forward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Forward.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Forward.CheckBoxAll = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Forward.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Forward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Forward.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_Forward.HeaderCheckStatus = false;
            this.dgv_Forward.Location = new System.Drawing.Point(18, 320);
            this.dgv_Forward.Name = "dgv_Forward";
            this.dgv_Forward.RowHeadersVisible = false;
            this.dgv_Forward.RowTemplate.Height = 23;
            this.dgv_Forward.Size = new System.Drawing.Size(537, 288);
            this.dgv_Forward.TabIndex = 35;
            // 
            // dgv_Reverse
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_Reverse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Reverse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Reverse.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Reverse.CheckBoxAll = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reverse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Reverse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reverse.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_Reverse.HeaderCheckStatus = false;
            this.dgv_Reverse.Location = new System.Drawing.Point(561, 320);
            this.dgv_Reverse.Name = "dgv_Reverse";
            this.dgv_Reverse.RowHeadersVisible = false;
            this.dgv_Reverse.RowTemplate.Height = 23;
            this.dgv_Reverse.Size = new System.Drawing.Size(514, 288);
            this.dgv_Reverse.TabIndex = 36;
            // 
            // dgv_Item
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_Item.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Item.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Item.CheckBoxAll = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Item.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_Item.HeaderCheckStatus = false;
            this.dgv_Item.Location = new System.Drawing.Point(18, 125);
            this.dgv_Item.Name = "dgv_Item";
            this.dgv_Item.RowHeadersVisible = false;
            this.dgv_Item.RowTemplate.Height = 23;
            this.dgv_Item.Size = new System.Drawing.Size(1057, 163);
            this.dgv_Item.TabIndex = 37;
            this.dgv_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Item_CellClick);
            // 
            // frmBOMList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.dgv_Item);
            this.Controls.Add(this.dgv_Reverse);
            this.Controls.Add(this.dgv_Forward);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBOMList";
            this.Text = "BOM 관리";
            this.Load += new System.EventHandler(this.frmBOM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Forward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Button_gudi btn_Search;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi1;
        private Label_gudi label_gudi5;
        private Controls.TextBox_gudi txt_ItemName;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi6;
        private ComboBox_gudi cbo_ItemCategory;
        private Label_gudi label_gudi7;
        private Button_gudi btn_Insert;
        private ComboBox_gudi cbo_YN;
        private DGV_gudi dgv_Forward;
        private DGV_gudi dgv_Reverse;
        private DGV_gudi dgv_Item;
    }
}
