
namespace FinalProject1_winform
{
    partial class frmDemandPlannig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemandPlannig));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            this.button_gudi6 = new FinalProject1_winform.Button_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgV_gudi1 = new FinalProject1_winform.DGV_gudi();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_gudi3 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.dateTimePicker_gudi2 = new FinalProject1_winform.DateTimePicker_gudi();
            this.dateTimePicker_gudi1 = new FinalProject1_winform.DateTimePicker_gudi();
            this.label_gudi14 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.textBox_gudi1 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.textBox_gudi2 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.button_gudi8 = new FinalProject1_winform.Button_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.button_gudi4 = new FinalProject1_winform.Button_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_gudi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.button_gudi5.Location = new System.Drawing.Point(896, 112);
            this.button_gudi5.Name = "button_gudi5";
            this.button_gudi5.Size = new System.Drawing.Size(60, 25);
            this.button_gudi5.TabIndex = 28;
            this.button_gudi5.Text = "엑셀";
            this.button_gudi5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi5.UseVisualStyleBackColor = false;
            // 
            // button_gudi6
            // 
            this.button_gudi6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi6.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi6.FlatAppearance.BorderSize = 0;
            this.button_gudi6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi6.ForeColor = System.Drawing.Color.Black;
            this.button_gudi6.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi6.Image")));
            this.button_gudi6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi6.Location = new System.Drawing.Point(830, 112);
            this.button_gudi6.Name = "button_gudi6";
            this.button_gudi6.Size = new System.Drawing.Size(60, 25);
            this.button_gudi6.TabIndex = 29;
            this.button_gudi6.Text = "삭제";
            this.button_gudi6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgV_gudi1);
            this.panel2.Location = new System.Drawing.Point(18, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 459);
            this.panel2.TabIndex = 26;
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
            this.Column5});
            this.dgV_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgV_gudi1.HeaderCheckStatus = false;
            this.dgV_gudi1.Location = new System.Drawing.Point(3, 3);
            this.dgV_gudi1.Name = "dgV_gudi1";
            this.dgV_gudi1.RowHeadersVisible = false;
            this.dgV_gudi1.RowTemplate.Height = 23;
            this.dgV_gudi1.Size = new System.Drawing.Size(1051, 453);
            this.dgV_gudi1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "수요계획번호";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PO 번호";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "계획번호";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "수요날짜";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "수요계획";
            this.Column5.Name = "Column5";
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
            this.panel1.Controls.Add(this.textBox_gudi3);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Controls.Add(this.dateTimePicker_gudi2);
            this.panel1.Controls.Add(this.dateTimePicker_gudi1);
            this.panel1.Controls.Add(this.label_gudi14);
            this.panel1.Controls.Add(this.label_gudi6);
            this.panel1.Controls.Add(this.textBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi4);
            this.panel1.Controls.Add(this.textBox_gudi2);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.button_gudi8);
            this.panel1.Location = new System.Drawing.Point(18, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 79);
            this.panel1.TabIndex = 24;
            // 
            // textBox_gudi3
            // 
            this.textBox_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi3.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi3.Location = new System.Drawing.Point(659, 32);
            this.textBox_gudi3.Name = "textBox_gudi3";
            this.textBox_gudi3.Size = new System.Drawing.Size(91, 25);
            this.textBox_gudi3.TabIndex = 89;
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
            // dateTimePicker_gudi2
            // 
            this.dateTimePicker_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dateTimePicker_gudi2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_gudi2.Location = new System.Drawing.Point(454, 32);
            this.dateTimePicker_gudi2.Name = "dateTimePicker_gudi2";
            this.dateTimePicker_gudi2.Size = new System.Drawing.Size(111, 25);
            this.dateTimePicker_gudi2.TabIndex = 87;
            // 
            // dateTimePicker_gudi1
            // 
            this.dateTimePicker_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dateTimePicker_gudi1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_gudi1.Location = new System.Drawing.Point(315, 32);
            this.dateTimePicker_gudi1.Name = "dateTimePicker_gudi1";
            this.dateTimePicker_gudi1.Size = new System.Drawing.Size(111, 25);
            this.dateTimePicker_gudi1.TabIndex = 86;
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
            // textBox_gudi1
            // 
            this.textBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi1.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi1.Location = new System.Drawing.Point(827, 32);
            this.textBox_gudi1.Name = "textBox_gudi1";
            this.textBox_gudi1.Size = new System.Drawing.Size(91, 25);
            this.textBox_gudi1.TabIndex = 82;
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
            // textBox_gudi2
            // 
            this.textBox_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi2.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi2.Location = new System.Drawing.Point(114, 32);
            this.textBox_gudi2.Name = "textBox_gudi2";
            this.textBox_gudi2.Size = new System.Drawing.Size(92, 25);
            this.textBox_gudi2.TabIndex = 80;
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
            // button_gudi8
            // 
            this.button_gudi8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.button_gudi8.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.button_gudi8.FlatAppearance.BorderSize = 0;
            this.button_gudi8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi8.ForeColor = System.Drawing.Color.White;
            this.button_gudi8.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi8.Image")));
            this.button_gudi8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi8.Location = new System.Drawing.Point(967, 45);
            this.button_gudi8.Name = "button_gudi8";
            this.button_gudi8.Size = new System.Drawing.Size(78, 25);
            this.button_gudi8.TabIndex = 10;
            this.button_gudi8.Text = "조회";
            this.button_gudi8.UseVisualStyleBackColor = false;
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
            // button_gudi4
            // 
            this.button_gudi4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi4.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi4.FlatAppearance.BorderSize = 0;
            this.button_gudi4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi4.ForeColor = System.Drawing.Color.Black;
            this.button_gudi4.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi4.Image")));
            this.button_gudi4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi4.Location = new System.Drawing.Point(962, 112);
            this.button_gudi4.Name = "button_gudi4";
            this.button_gudi4.Size = new System.Drawing.Size(113, 25);
            this.button_gudi4.TabIndex = 31;
            this.button_gudi4.Text = "생산 계획 생성";
            this.button_gudi4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi4.UseVisualStyleBackColor = false;
            // 
            // frmDemandPlannig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.button_gudi4);
            this.Controls.Add(this.button_gudi5);
            this.Controls.Add(this.button_gudi6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDemandPlannig";
            this.Text = "frmDemandPlannig";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgV_gudi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button_gudi button_gudi5;
        private Button_gudi button_gudi6;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi button_gudi8;
        private Label_gudi label_gudi2;
        private Controls.TextBox_gudi textBox_gudi2;
        private Label_gudi label_gudi3;
        private Controls.TextBox_gudi textBox_gudi3;
        private Label_gudi label_gudi1;
        private DateTimePicker_gudi dateTimePicker_gudi2;
        private DateTimePicker_gudi dateTimePicker_gudi1;
        private Label_gudi label_gudi14;
        private Label_gudi label_gudi6;
        private Controls.TextBox_gudi textBox_gudi1;
        private Label_gudi label_gudi4;
        private DGV_gudi dgV_gudi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Button_gudi button_gudi4;
    }
}
