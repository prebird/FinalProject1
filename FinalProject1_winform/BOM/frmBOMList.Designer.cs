
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBOMList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Forward = new FinalProject1_winform.DGV_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_YN = new FinalProject1_winform.ComboBox_gudi();
            this.cbo_ItemCategory = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.txt_ItemName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.btn_Search = new FinalProject1_winform.Button_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_Item = new FinalProject1_winform.DGV_gudi();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Reverse = new FinalProject1_winform.DGV_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.btn_Insert = new FinalProject1_winform.Button_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Forward)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reverse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_Forward);
            this.panel2.Location = new System.Drawing.Point(18, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 288);
            this.panel2.TabIndex = 26;
            // 
            // dgv_Forward
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_Forward.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Forward.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Forward.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Forward.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Forward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Forward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Forward.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_Forward.HeaderCheckStatus = false;
            this.dgv_Forward.Location = new System.Drawing.Point(0, 0);
            this.dgv_Forward.Name = "dgv_Forward";
            this.dgv_Forward.RowHeadersVisible = false;
            this.dgv_Forward.RowTemplate.Height = 23;
            this.dgv_Forward.Size = new System.Drawing.Size(521, 288);
            this.dgv_Forward.TabIndex = 0;
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
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.dgv_Item);
            this.panel4.Location = new System.Drawing.Point(18, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1057, 163);
            this.panel4.TabIndex = 28;
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
            this.dgv_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Item.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_Item.HeaderCheckStatus = false;
            this.dgv_Item.Location = new System.Drawing.Point(0, 0);
            this.dgv_Item.Name = "dgv_Item";
            this.dgv_Item.RowHeadersVisible = false;
            this.dgv_Item.RowTemplate.Height = 23;
            this.dgv_Item.Size = new System.Drawing.Size(1057, 163);
            this.dgv_Item.TabIndex = 0;
            this.dgv_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Item_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgv_Reverse);
            this.panel3.Location = new System.Drawing.Point(561, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 288);
            this.panel3.TabIndex = 27;
            // 
            // dgv_Reverse
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_Reverse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Reverse.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Reverse.CheckBoxAll = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reverse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Reverse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Reverse.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_Reverse.HeaderCheckStatus = false;
            this.dgv_Reverse.Location = new System.Drawing.Point(0, 0);
            this.dgv_Reverse.Name = "dgv_Reverse";
            this.dgv_Reverse.RowHeadersVisible = false;
            this.dgv_Reverse.RowTemplate.Height = 23;
            this.dgv_Reverse.Size = new System.Drawing.Size(514, 288);
            this.dgv_Reverse.TabIndex = 1;
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
            // frmBOMList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBOMList";
            this.Text = "frmBOMList";
            this.Load += new System.EventHandler(this.frmBOM_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Forward)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reverse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi btn_Search;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi1;
        private DGV_gudi dgv_Forward;
        private DGV_gudi dgv_Reverse;
        private Label_gudi label_gudi5;
        private Controls.TextBox_gudi txt_ItemName;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi6;
        private ComboBox_gudi cbo_ItemCategory;
        private DGV_gudi dgv_Item;
        private Label_gudi label_gudi7;
        private Button_gudi btn_Insert;
        private ComboBox_gudi cbo_YN;
    }
}
