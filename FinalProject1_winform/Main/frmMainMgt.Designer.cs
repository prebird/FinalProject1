
namespace FinalProject1_winform
{
    partial class frmMainMgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMgt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.dgvUpMenu = new FinalProject1_winform.DGV_gudi();
            this.dgvDownMenu = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi3 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnBigDelete = new FinalProject1_winform.Button_gudi();
            this.btnBigInsert = new FinalProject1_winform.Button_gudi();
            this.btnSmallDelete = new FinalProject1_winform.Button_gudi();
            this.btnBigUps = new FinalProject1_winform.Button_gudi();
            this.btnSmallInsert = new FinalProject1_winform.Button_gudi();
            this.btnSmallUps = new FinalProject1_winform.Button_gudi();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi4.Location = new System.Drawing.Point(51, 18);
            this.label_gudi4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(77, 16);
            this.label_gudi4.TabIndex = 23;
            this.label_gudi4.Text = "메뉴 상위목록";
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(7, 11);
            this.pictureBox_gudi2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(36, 28);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 22;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // pictureBox_gudi1
            // 
            this.pictureBox_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi1.Image")));
            this.pictureBox_gudi1.Location = new System.Drawing.Point(7, 419);
            this.pictureBox_gudi1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_gudi1.Name = "pictureBox_gudi1";
            this.pictureBox_gudi1.Size = new System.Drawing.Size(36, 28);
            this.pictureBox_gudi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi1.TabIndex = 22;
            this.pictureBox_gudi1.TabStop = false;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.Location = new System.Drawing.Point(51, 426);
            this.label_gudi1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(77, 16);
            this.label_gudi1.TabIndex = 23;
            this.label_gudi1.Text = "메뉴 하위목록";
            // 
            // dgvUpMenu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvUpMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUpMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpMenu.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUpMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpMenu.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvUpMenu.HeaderCheckStatus = false;
            this.dgvUpMenu.Location = new System.Drawing.Point(7, 47);
            this.dgvUpMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUpMenu.Name = "dgvUpMenu";
            this.dgvUpMenu.RowHeadersVisible = false;
            this.dgvUpMenu.RowTemplate.Height = 23;
            this.dgvUpMenu.Size = new System.Drawing.Size(963, 357);
            this.dgvUpMenu.TabIndex = 24;
            this.dgvUpMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpMenu_CellClick);
            // 
            // dgvDownMenu
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvDownMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDownMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDownMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDownMenu.CheckBoxAll = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDownMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDownMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDownMenu.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvDownMenu.HeaderCheckStatus = false;
            this.dgvDownMenu.Location = new System.Drawing.Point(7, 458);
            this.dgvDownMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDownMenu.Name = "dgvDownMenu";
            this.dgvDownMenu.RowHeadersVisible = false;
            this.dgvDownMenu.RowTemplate.Height = 23;
            this.dgvDownMenu.Size = new System.Drawing.Size(963, 394);
            this.dgvDownMenu.TabIndex = 24;
            // 
            // pictureBox_gudi3
            // 
            this.pictureBox_gudi3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi3.Image")));
            this.pictureBox_gudi3.Location = new System.Drawing.Point(989, 12);
            this.pictureBox_gudi3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_gudi3.Name = "pictureBox_gudi3";
            this.pictureBox_gudi3.Size = new System.Drawing.Size(36, 28);
            this.pictureBox_gudi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi3.TabIndex = 22;
            this.pictureBox_gudi3.TabStop = false;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi2.Location = new System.Drawing.Point(1033, 17);
            this.label_gudi2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(66, 16);
            this.label_gudi2.TabIndex = 23;
            this.label_gudi2.Text = "메뉴 트리뷰";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView1.Location = new System.Drawing.Point(990, 48);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(481, 800);
            this.treeView1.TabIndex = 25;
            // 
            // btnBigDelete
            // 
            this.btnBigDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnBigDelete.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnBigDelete.FlatAppearance.BorderSize = 0;
            this.btnBigDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBigDelete.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnBigDelete.ForeColor = System.Drawing.Color.Black;
            this.btnBigDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnBigDelete.Image")));
            this.btnBigDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBigDelete.Location = new System.Drawing.Point(898, 11);
            this.btnBigDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnBigDelete.Name = "btnBigDelete";
            this.btnBigDelete.Size = new System.Drawing.Size(72, 31);
            this.btnBigDelete.TabIndex = 26;
            this.btnBigDelete.Text = "삭제";
            this.btnBigDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBigDelete.UseVisualStyleBackColor = false;
            this.btnBigDelete.Click += new System.EventHandler(this.btnBigDelete_Click);
            // 
            // btnBigInsert
            // 
            this.btnBigInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnBigInsert.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnBigInsert.FlatAppearance.BorderSize = 0;
            this.btnBigInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBigInsert.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnBigInsert.ForeColor = System.Drawing.Color.Black;
            this.btnBigInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnBigInsert.Image")));
            this.btnBigInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBigInsert.Location = new System.Drawing.Point(737, 10);
            this.btnBigInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnBigInsert.Name = "btnBigInsert";
            this.btnBigInsert.Size = new System.Drawing.Size(71, 31);
            this.btnBigInsert.TabIndex = 27;
            this.btnBigInsert.Text = "등록";
            this.btnBigInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBigInsert.UseVisualStyleBackColor = false;
            this.btnBigInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSmallDelete
            // 
            this.btnSmallDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnSmallDelete.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnSmallDelete.FlatAppearance.BorderSize = 0;
            this.btnSmallDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSmallDelete.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSmallDelete.ForeColor = System.Drawing.Color.Black;
            this.btnSmallDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnSmallDelete.Image")));
            this.btnSmallDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmallDelete.Location = new System.Drawing.Point(898, 418);
            this.btnSmallDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnSmallDelete.Name = "btnSmallDelete";
            this.btnSmallDelete.Size = new System.Drawing.Size(72, 32);
            this.btnSmallDelete.TabIndex = 26;
            this.btnSmallDelete.Text = "삭제";
            this.btnSmallDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSmallDelete.UseVisualStyleBackColor = false;
            this.btnSmallDelete.Click += new System.EventHandler(this.btnSmallDelete_Click);
            // 
            // btnBigUps
            // 
            this.btnBigUps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnBigUps.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnBigUps.FlatAppearance.BorderSize = 0;
            this.btnBigUps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBigUps.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnBigUps.ForeColor = System.Drawing.Color.Black;
            this.btnBigUps.Image = ((System.Drawing.Image)(resources.GetObject("btnBigUps.Image")));
            this.btnBigUps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBigUps.Location = new System.Drawing.Point(816, 11);
            this.btnBigUps.Margin = new System.Windows.Forms.Padding(4);
            this.btnBigUps.Name = "btnBigUps";
            this.btnBigUps.Size = new System.Drawing.Size(74, 31);
            this.btnBigUps.TabIndex = 28;
            this.btnBigUps.Text = "수정";
            this.btnBigUps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBigUps.UseVisualStyleBackColor = false;
            this.btnBigUps.Click += new System.EventHandler(this.btnBigUps_Click);
            // 
            // btnSmallInsert
            // 
            this.btnSmallInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnSmallInsert.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnSmallInsert.FlatAppearance.BorderSize = 0;
            this.btnSmallInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSmallInsert.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSmallInsert.ForeColor = System.Drawing.Color.Black;
            this.btnSmallInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnSmallInsert.Image")));
            this.btnSmallInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmallInsert.Location = new System.Drawing.Point(730, 418);
            this.btnSmallInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnSmallInsert.Name = "btnSmallInsert";
            this.btnSmallInsert.Size = new System.Drawing.Size(76, 32);
            this.btnSmallInsert.TabIndex = 27;
            this.btnSmallInsert.Text = "등록";
            this.btnSmallInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSmallInsert.UseVisualStyleBackColor = false;
            this.btnSmallInsert.Click += new System.EventHandler(this.btnSmallInsert_Click);
            // 
            // btnSmallUps
            // 
            this.btnSmallUps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnSmallUps.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnSmallUps.FlatAppearance.BorderSize = 0;
            this.btnSmallUps.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSmallUps.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSmallUps.ForeColor = System.Drawing.Color.Black;
            this.btnSmallUps.Image = ((System.Drawing.Image)(resources.GetObject("btnSmallUps.Image")));
            this.btnSmallUps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmallUps.Location = new System.Drawing.Point(814, 418);
            this.btnSmallUps.Margin = new System.Windows.Forms.Padding(4);
            this.btnSmallUps.Name = "btnSmallUps";
            this.btnSmallUps.Size = new System.Drawing.Size(76, 32);
            this.btnSmallUps.TabIndex = 28;
            this.btnSmallUps.Text = "수정";
            this.btnSmallUps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSmallUps.UseVisualStyleBackColor = false;
            this.btnSmallUps.Click += new System.EventHandler(this.btnSmallUps_Click);
            // 
            // frmMainMgt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.btnSmallUps);
            this.Controls.Add(this.btnBigUps);
            this.Controls.Add(this.btnSmallDelete);
            this.Controls.Add(this.btnSmallInsert);
            this.Controls.Add(this.btnBigDelete);
            this.Controls.Add(this.btnBigInsert);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dgvDownMenu);
            this.Controls.Add(this.dgvUpMenu);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.pictureBox_gudi1);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.pictureBox_gudi3);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMainMgt";
            this.Text = "메뉴관리";
            this.Load += new System.EventHandler(this.frmMainMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label_gudi label_gudi4;
        private PictureBox_gudi pictureBox_gudi2;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private DGV_gudi dgvUpMenu;
        private DGV_gudi dgvDownMenu;
        private PictureBox_gudi pictureBox_gudi3;
        private Label_gudi label_gudi2;
        private System.Windows.Forms.TreeView treeView1;
        private Button_gudi btnBigDelete;
        private Button_gudi btnBigInsert;
        private Button_gudi btnSmallDelete;
        private Button_gudi btnBigUps;
        private Button_gudi btnSmallInsert;
        private Button_gudi btnSmallUps;
    }
}
