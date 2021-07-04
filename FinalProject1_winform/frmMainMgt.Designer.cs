
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label_gudi4.Location = new System.Drawing.Point(53, 21);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(77, 16);
            this.label_gudi4.TabIndex = 23;
            this.label_gudi4.Text = "메뉴 상위목록";
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(22, 19);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 22;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // pictureBox_gudi1
            // 
            this.pictureBox_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi1.Image")));
            this.pictureBox_gudi1.Location = new System.Drawing.Point(22, 341);
            this.pictureBox_gudi1.Name = "pictureBox_gudi1";
            this.pictureBox_gudi1.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi1.TabIndex = 22;
            this.pictureBox_gudi1.TabStop = false;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.Location = new System.Drawing.Point(53, 343);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(77, 16);
            this.label_gudi1.TabIndex = 23;
            this.label_gudi1.Text = "메뉴 하위목록";
            // 
            // dgvUpMenu
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvUpMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvUpMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpMenu.CheckBoxAll = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvUpMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpMenu.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvUpMenu.HeaderCheckStatus = false;
            this.dgvUpMenu.Location = new System.Drawing.Point(22, 44);
            this.dgvUpMenu.Name = "dgvUpMenu";
            this.dgvUpMenu.RowHeadersVisible = false;
            this.dgvUpMenu.RowTemplate.Height = 23;
            this.dgvUpMenu.Size = new System.Drawing.Size(657, 291);
            this.dgvUpMenu.TabIndex = 24;
            this.dgvUpMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpMenu_CellClick);
            // 
            // dgvDownMenu
            // 
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvDownMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvDownMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDownMenu.CheckBoxAll = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDownMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvDownMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDownMenu.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvDownMenu.HeaderCheckStatus = false;
            this.dgvDownMenu.Location = new System.Drawing.Point(22, 366);
            this.dgvDownMenu.Name = "dgvDownMenu";
            this.dgvDownMenu.RowHeadersVisible = false;
            this.dgvDownMenu.RowTemplate.Height = 23;
            this.dgvDownMenu.Size = new System.Drawing.Size(657, 351);
            this.dgvDownMenu.TabIndex = 24;
            // 
            // pictureBox_gudi3
            // 
            this.pictureBox_gudi3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi3.Image")));
            this.pictureBox_gudi3.Location = new System.Drawing.Point(687, 20);
            this.pictureBox_gudi3.Name = "pictureBox_gudi3";
            this.pictureBox_gudi3.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi3.TabIndex = 22;
            this.pictureBox_gudi3.TabStop = false;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi2.Location = new System.Drawing.Point(718, 22);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(66, 16);
            this.label_gudi2.TabIndex = 23;
            this.label_gudi2.Text = "메뉴 트리뷰";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(687, 44);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(677, 673);
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
            this.btnBigDelete.Location = new System.Drawing.Point(619, 14);
            this.btnBigDelete.Name = "btnBigDelete";
            this.btnBigDelete.Size = new System.Drawing.Size(60, 25);
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
            this.btnBigInsert.Location = new System.Drawing.Point(487, 14);
            this.btnBigInsert.Name = "btnBigInsert";
            this.btnBigInsert.Size = new System.Drawing.Size(60, 25);
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
            this.btnSmallDelete.Location = new System.Drawing.Point(619, 339);
            this.btnSmallDelete.Name = "btnSmallDelete";
            this.btnSmallDelete.Size = new System.Drawing.Size(60, 25);
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
            this.btnBigUps.Location = new System.Drawing.Point(553, 14);
            this.btnBigUps.Name = "btnBigUps";
            this.btnBigUps.Size = new System.Drawing.Size(60, 25);
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
            this.btnSmallInsert.Location = new System.Drawing.Point(487, 339);
            this.btnSmallInsert.Name = "btnSmallInsert";
            this.btnSmallInsert.Size = new System.Drawing.Size(60, 25);
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
            this.btnSmallUps.Location = new System.Drawing.Point(553, 339);
            this.btnSmallUps.Name = "btnSmallUps";
            this.btnSmallUps.Size = new System.Drawing.Size(60, 25);
            this.btnSmallUps.TabIndex = 28;
            this.btnSmallUps.Text = "수정";
            this.btnSmallUps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSmallUps.UseVisualStyleBackColor = false;
            this.btnSmallUps.Click += new System.EventHandler(this.btnSmallUps_Click);
            // 
            // frmMainMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1376, 728);
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
