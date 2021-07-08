
namespace FinalProject1_winform
{
    partial class frmCommonCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommonCode));
            this.dgvCommonCode = new FinalProject1_winform.DGV_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.txtMenuName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.textBox_gudi1 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.textBox_gudi2 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.textBox_gudi3 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.button_gudi1 = new FinalProject1_winform.Button_gudi();
            this.button_gudi2 = new FinalProject1_winform.Button_gudi();
            this.button_gudi3 = new FinalProject1_winform.Button_gudi();
            this.button_gudi4 = new FinalProject1_winform.Button_gudi();
            this.textBox_gudi4 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommonCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommonCode
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvCommonCode.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCommonCode.BackgroundColor = System.Drawing.Color.White;
            this.dgvCommonCode.CheckBoxAll = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommonCode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCommonCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommonCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvCommonCode.HeaderCheckStatus = false;
            this.dgvCommonCode.Location = new System.Drawing.Point(12, 37);
            this.dgvCommonCode.Name = "dgvCommonCode";
            this.dgvCommonCode.RowHeadersVisible = false;
            this.dgvCommonCode.RowTemplate.Height = 23;
            this.dgvCommonCode.Size = new System.Drawing.Size(626, 623);
            this.dgvCommonCode.TabIndex = 27;
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi4.Location = new System.Drawing.Point(43, 14);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(77, 16);
            this.label_gudi4.TabIndex = 26;
            this.label_gudi4.Text = "공통코드 목록";
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 25;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi1.Location = new System.Drawing.Point(746, 286);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(88, 17);
            this.label_gudi1.TabIndex = 69;
            this.label_gudi1.Text = "■ 공통코드 값";
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi2.Location = new System.Drawing.Point(746, 240);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(100, 17);
            this.label_gudi2.TabIndex = 70;
            this.label_gudi2.Text = "■ 공통코드 타입";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtMenuName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtMenuName.Location = new System.Drawing.Point(874, 191);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(343, 25);
            this.txtMenuName.TabIndex = 73;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi3.Location = new System.Drawing.Point(746, 194);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(85, 17);
            this.label_gudi3.TabIndex = 71;
            this.label_gudi3.Text = "■ 공통코드ID";
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi5.Location = new System.Drawing.Point(746, 332);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(100, 17);
            this.label_gudi5.TabIndex = 69;
            this.label_gudi5.Text = "■ 공통코드 이름";
            // 
            // textBox_gudi1
            // 
            this.textBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi1.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi1.Location = new System.Drawing.Point(874, 237);
            this.textBox_gudi1.Name = "textBox_gudi1";
            this.textBox_gudi1.Size = new System.Drawing.Size(343, 25);
            this.textBox_gudi1.TabIndex = 73;
            // 
            // textBox_gudi2
            // 
            this.textBox_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi2.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi2.Location = new System.Drawing.Point(874, 283);
            this.textBox_gudi2.Name = "textBox_gudi2";
            this.textBox_gudi2.Size = new System.Drawing.Size(343, 25);
            this.textBox_gudi2.TabIndex = 73;
            // 
            // textBox_gudi3
            // 
            this.textBox_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi3.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi3.Location = new System.Drawing.Point(874, 329);
            this.textBox_gudi3.Name = "textBox_gudi3";
            this.textBox_gudi3.Size = new System.Drawing.Size(343, 25);
            this.textBox_gudi3.TabIndex = 73;
            // 
            // button_gudi1
            // 
            this.button_gudi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.button_gudi1.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.button_gudi1.FlatAppearance.BorderSize = 0;
            this.button_gudi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi1.ForeColor = System.Drawing.Color.White;
            this.button_gudi1.Location = new System.Drawing.Point(828, 422);
            this.button_gudi1.Name = "button_gudi1";
            this.button_gudi1.Size = new System.Drawing.Size(85, 37);
            this.button_gudi1.TabIndex = 74;
            this.button_gudi1.Tag = "";
            this.button_gudi1.Text = "추가";
            this.button_gudi1.UseVisualStyleBackColor = false;
            // 
            // button_gudi2
            // 
            this.button_gudi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.button_gudi2.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.button_gudi2.FlatAppearance.BorderSize = 0;
            this.button_gudi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi2.ForeColor = System.Drawing.Color.White;
            this.button_gudi2.Location = new System.Drawing.Point(919, 422);
            this.button_gudi2.Name = "button_gudi2";
            this.button_gudi2.Size = new System.Drawing.Size(85, 37);
            this.button_gudi2.TabIndex = 74;
            this.button_gudi2.Tag = "";
            this.button_gudi2.Text = "수정";
            this.button_gudi2.UseVisualStyleBackColor = false;
            // 
            // button_gudi3
            // 
            this.button_gudi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.button_gudi3.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.button_gudi3.FlatAppearance.BorderSize = 0;
            this.button_gudi3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi3.ForeColor = System.Drawing.Color.White;
            this.button_gudi3.Location = new System.Drawing.Point(1010, 422);
            this.button_gudi3.Name = "button_gudi3";
            this.button_gudi3.Size = new System.Drawing.Size(85, 37);
            this.button_gudi3.TabIndex = 74;
            this.button_gudi3.Tag = "";
            this.button_gudi3.Text = "삭제";
            this.button_gudi3.UseVisualStyleBackColor = false;
            // 
            // button_gudi4
            // 
            this.button_gudi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.button_gudi4.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.button_gudi4.FlatAppearance.BorderSize = 0;
            this.button_gudi4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi4.ForeColor = System.Drawing.Color.White;
            this.button_gudi4.Location = new System.Drawing.Point(1101, 422);
            this.button_gudi4.Name = "button_gudi4";
            this.button_gudi4.Size = new System.Drawing.Size(85, 37);
            this.button_gudi4.TabIndex = 74;
            this.button_gudi4.Tag = "";
            this.button_gudi4.Text = "초기화";
            this.button_gudi4.UseVisualStyleBackColor = false;
            // 
            // textBox_gudi4
            // 
            this.textBox_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi4.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi4.Location = new System.Drawing.Point(188, 6);
            this.textBox_gudi4.Name = "textBox_gudi4";
            this.textBox_gudi4.Size = new System.Drawing.Size(343, 25);
            this.textBox_gudi4.TabIndex = 73;
            // 
            // button_gudi5
            // 
            this.button_gudi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.button_gudi5.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.button_gudi5.FlatAppearance.BorderSize = 0;
            this.button_gudi5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi5.ForeColor = System.Drawing.Color.White;
            this.button_gudi5.Location = new System.Drawing.Point(537, 6);
            this.button_gudi5.Name = "button_gudi5";
            this.button_gudi5.Size = new System.Drawing.Size(101, 25);
            this.button_gudi5.TabIndex = 74;
            this.button_gudi5.Tag = "";
            this.button_gudi5.Text = "검색";
            this.button_gudi5.UseVisualStyleBackColor = false;
            // 
            // frmCommonCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1395, 672);
            this.Controls.Add(this.button_gudi4);
            this.Controls.Add(this.button_gudi3);
            this.Controls.Add(this.button_gudi2);
            this.Controls.Add(this.button_gudi5);
            this.Controls.Add(this.button_gudi1);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.textBox_gudi3);
            this.Controls.Add(this.textBox_gudi2);
            this.Controls.Add(this.textBox_gudi1);
            this.Controls.Add(this.textBox_gudi4);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.dgvCommonCode);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Name = "frmCommonCode";
            this.Text = "공통코드관리";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommonCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DGV_gudi dgvCommonCode;
        private Label_gudi label_gudi4;
        private PictureBox_gudi pictureBox_gudi2;
        private Label_gudi label_gudi1;
        private Label_gudi label_gudi2;
        private Controls.TextBox_gudi txtMenuName;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi5;
        private Controls.TextBox_gudi textBox_gudi1;
        private Controls.TextBox_gudi textBox_gudi2;
        private Controls.TextBox_gudi textBox_gudi3;
        private Button_gudi button_gudi1;
        private Button_gudi button_gudi2;
        private Button_gudi button_gudi3;
        private Button_gudi button_gudi4;
        private Controls.TextBox_gudi textBox_gudi4;
        private Button_gudi button_gudi5;
    }
}
