
namespace FinalProject1_winform
{
    partial class frmItem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItem));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Item = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.입력초기화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbo_YN = new FinalProject1_winform.ComboBox_gudi();
            this.btn_Search = new FinalProject1_winform.Button_gudi();
            this.cbo_ItemCategory = new FinalProject1_winform.ComboBox_gudi();
            this.txt_ItemName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi9 = new FinalProject1_winform.Label_gudi();
            this.btn_Excel = new FinalProject1_winform.Button_gudi();
            this.btn_Update = new FinalProject1_winform.Button_gudi();
            this.btn_Delete = new FinalProject1_winform.Button_gudi();
            this.btn_Insert = new FinalProject1_winform.Button_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_Item);
            this.panel2.Location = new System.Drawing.Point(18, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 433);
            this.panel2.TabIndex = 8;
            // 
            // dgv_Item
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_Item.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Item.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Item.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Item.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_Item.HeaderCheckStatus = false;
            this.dgv_Item.Location = new System.Drawing.Point(0, 0);
            this.dgv_Item.Name = "dgv_Item";
            this.dgv_Item.RowHeadersVisible = false;
            this.dgv_Item.RowTemplate.Height = 23;
            this.dgv_Item.Size = new System.Drawing.Size(1057, 433);
            this.dgv_Item.TabIndex = 0;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(19, 139);
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
            this.panel1.ContextMenuStrip = this.contextMenuStrip2;
            this.panel1.Controls.Add(this.cbo_YN);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.cbo_ItemCategory);
            this.panel1.Controls.Add(this.txt_ItemName);
            this.panel1.Controls.Add(this.label_gudi6);
            this.panel1.Controls.Add(this.label_gudi4);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Location = new System.Drawing.Point(18, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 96);
            this.panel1.TabIndex = 6;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.입력초기화ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(139, 26);
            // 
            // 입력초기화ToolStripMenuItem
            // 
            this.입력초기화ToolStripMenuItem.Name = "입력초기화ToolStripMenuItem";
            this.입력초기화ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.입력초기화ToolStripMenuItem.Text = "입력 초기화";
            this.입력초기화ToolStripMenuItem.Click += new System.EventHandler(this.입력초기화ToolStripMenuItem_Click);
            // 
            // cbo_YN
            // 
            this.cbo_YN.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_YN.FormattingEnabled = true;
            this.cbo_YN.Location = new System.Drawing.Point(662, 32);
            this.cbo_YN.Name = "cbo_YN";
            this.cbo_YN.Size = new System.Drawing.Size(161, 24);
            this.cbo_YN.TabIndex = 19;
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
            this.btn_Search.Location = new System.Drawing.Point(946, 54);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 25);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbo_ItemCategory
            // 
            this.cbo_ItemCategory.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_ItemCategory.FormattingEnabled = true;
            this.cbo_ItemCategory.Location = new System.Drawing.Point(124, 32);
            this.cbo_ItemCategory.Name = "cbo_ItemCategory";
            this.cbo_ItemCategory.Size = new System.Drawing.Size(158, 24);
            this.cbo_ItemCategory.TabIndex = 7;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_ItemName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_ItemName.Location = new System.Drawing.Point(384, 32);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(158, 25);
            this.txt_ItemName.TabIndex = 6;
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(569, 36);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(72, 17);
            this.label_gudi6.TabIndex = 5;
            this.label_gudi6.Text = "■ 사용여부";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(50, 36);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(72, 17);
            this.label_gudi4.TabIndex = 3;
            this.label_gudi4.Text = "■ 품목유형";
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(310, 36);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(60, 17);
            this.label_gudi1.TabIndex = 0;
            this.label_gudi1.Text = "■ 품목명";
            // 
            // label_gudi9
            // 
            this.label_gudi9.AutoSize = true;
            this.label_gudi9.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi9.Location = new System.Drawing.Point(50, 139);
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
            this.btn_Excel.Location = new System.Drawing.Point(1015, 135);
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
            this.btn_Update.Location = new System.Drawing.Point(883, 135);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(60, 25);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "수정";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
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
            this.btn_Delete.Location = new System.Drawing.Point(949, 135);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(60, 25);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Insert.Location = new System.Drawing.Point(817, 135);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(60, 25);
            this.btn_Insert.TabIndex = 13;
            this.btn_Insert.Text = "등록";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label_gudi9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmItem";
            this.Text = "frmItem";
            this.Load += new System.EventHandler(this.frmItem_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private DGV_gudi dgv_Item;
        private Label_gudi label_gudi6;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi1;
        private Controls.TextBox_gudi txt_ItemName;
        private ComboBox_gudi cbo_ItemCategory;
        private Button_gudi btn_Search;
        private ComboBox_gudi cbo_YN;
        private Label_gudi label_gudi9;
        private Button_gudi btn_Excel;
        private Button_gudi btn_Update;
        private Button_gudi btn_Delete;
        private Button_gudi btn_Insert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 입력초기화ToolStripMenuItem;
    }
}
