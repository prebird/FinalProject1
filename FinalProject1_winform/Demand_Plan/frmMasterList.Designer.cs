
namespace FinalProject1_winform
{
    partial class frmMasterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            this.btn_Delete = new FinalProject1_winform.Button_gudi();
            this.button_gudi3 = new FinalProject1_winform.Button_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_SalesMaster = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.dateTimePicker_gudi2 = new FinalProject1_winform.DateTimePicker_gudi();
            this.dateTimePicker_gudi1 = new FinalProject1_winform.DateTimePicker_gudi();
            this.label_gudi14 = new FinalProject1_winform.Label_gudi();
            this.comboBox_gudi1 = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.textBox_gudi1 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.button_gudi8 = new FinalProject1_winform.Button_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.button_gudi7 = new FinalProject1_winform.Button_gudi();
            this.button_gudi1 = new FinalProject1_winform.Button_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesMaster)).BeginInit();
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
            this.button_gudi5.Location = new System.Drawing.Point(1016, 113);
            this.button_gudi5.Name = "button_gudi5";
            this.button_gudi5.Size = new System.Drawing.Size(60, 25);
            this.button_gudi5.TabIndex = 28;
            this.button_gudi5.Text = "엑셀";
            this.button_gudi5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi5.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_Delete.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(950, 113);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(60, 25);
            this.btn_Delete.TabIndex = 29;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.button_gudi3.Location = new System.Drawing.Point(699, 113);
            this.button_gudi3.Name = "button_gudi3";
            this.button_gudi3.Size = new System.Drawing.Size(113, 25);
            this.button_gudi3.TabIndex = 30;
            this.button_gudi3.Text = "수요 계획 생성";
            this.button_gudi3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_SalesMaster);
            this.panel2.Location = new System.Drawing.Point(19, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 459);
            this.panel2.TabIndex = 26;
            // 
            // dgv_SalesMaster
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_SalesMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SalesMaster.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SalesMaster.CheckBoxAll = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SalesMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_SalesMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SalesMaster.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_SalesMaster.HeaderCheckStatus = false;
            this.dgv_SalesMaster.Location = new System.Drawing.Point(3, 3);
            this.dgv_SalesMaster.Name = "dgv_SalesMaster";
            this.dgv_SalesMaster.RowHeadersVisible = false;
            this.dgv_SalesMaster.RowTemplate.Height = 23;
            this.dgv_SalesMaster.Size = new System.Drawing.Size(1051, 453);
            this.dgv_SalesMaster.TabIndex = 0;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(19, 116);
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
            this.panel1.Controls.Add(this.label_gudi2);
            this.panel1.Controls.Add(this.dateTimePicker_gudi2);
            this.panel1.Controls.Add(this.dateTimePicker_gudi1);
            this.panel1.Controls.Add(this.label_gudi14);
            this.panel1.Controls.Add(this.comboBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi6);
            this.panel1.Controls.Add(this.textBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi4);
            this.panel1.Controls.Add(this.button_gudi8);
            this.panel1.Location = new System.Drawing.Point(19, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 79);
            this.panel1.TabIndex = 24;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(263, 24);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(16, 17);
            this.label_gudi2.TabIndex = 76;
            this.label_gudi2.Text = "~";
            // 
            // dateTimePicker_gudi2
            // 
            this.dateTimePicker_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dateTimePicker_gudi2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_gudi2.Location = new System.Drawing.Point(285, 20);
            this.dateTimePicker_gudi2.Name = "dateTimePicker_gudi2";
            this.dateTimePicker_gudi2.Size = new System.Drawing.Size(134, 25);
            this.dateTimePicker_gudi2.TabIndex = 75;
            // 
            // dateTimePicker_gudi1
            // 
            this.dateTimePicker_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dateTimePicker_gudi1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_gudi1.Location = new System.Drawing.Point(123, 20);
            this.dateTimePicker_gudi1.Name = "dateTimePicker_gudi1";
            this.dateTimePicker_gudi1.Size = new System.Drawing.Size(134, 25);
            this.dateTimePicker_gudi1.TabIndex = 74;
            // 
            // label_gudi14
            // 
            this.label_gudi14.AutoSize = true;
            this.label_gudi14.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi14.Location = new System.Drawing.Point(28, 24);
            this.label_gudi14.Name = "label_gudi14";
            this.label_gudi14.Size = new System.Drawing.Size(88, 17);
            this.label_gudi14.TabIndex = 73;
            this.label_gudi14.Text = "■ 고객 납기일";
            // 
            // comboBox_gudi1
            // 
            this.comboBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.comboBox_gudi1.FormattingEnabled = true;
            this.comboBox_gudi1.Location = new System.Drawing.Point(521, 20);
            this.comboBox_gudi1.Name = "comboBox_gudi1";
            this.comboBox_gudi1.Size = new System.Drawing.Size(134, 24);
            this.comboBox_gudi1.TabIndex = 48;
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(440, 24);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(72, 17);
            this.label_gudi6.TabIndex = 47;
            this.label_gudi6.Text = "■ 고객사명";
            // 
            // textBox_gudi1
            // 
            this.textBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi1.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi1.Location = new System.Drawing.Point(757, 20);
            this.textBox_gudi1.Name = "textBox_gudi1";
            this.textBox_gudi1.Size = new System.Drawing.Size(135, 25);
            this.textBox_gudi1.TabIndex = 46;
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(676, 24);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(60, 17);
            this.label_gudi4.TabIndex = 45;
            this.label_gudi4.Text = "■ 품목명";
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
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(49, 117);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(72, 17);
            this.label_gudi1.TabIndex = 75;
            this.label_gudi1.Text = "영업 마스터";
            // 
            // button_gudi7
            // 
            this.button_gudi7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi7.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi7.FlatAppearance.BorderSize = 0;
            this.button_gudi7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi7.ForeColor = System.Drawing.Color.Black;
            this.button_gudi7.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi7.Image")));
            this.button_gudi7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi7.Location = new System.Drawing.Point(884, 113);
            this.button_gudi7.Name = "button_gudi7";
            this.button_gudi7.Size = new System.Drawing.Size(60, 25);
            this.button_gudi7.TabIndex = 76;
            this.button_gudi7.Text = "수정";
            this.button_gudi7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi7.UseVisualStyleBackColor = false;
            // 
            // button_gudi1
            // 
            this.button_gudi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi1.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi1.FlatAppearance.BorderSize = 0;
            this.button_gudi1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi1.ForeColor = System.Drawing.Color.Black;
            this.button_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi1.Image")));
            this.button_gudi1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi1.Location = new System.Drawing.Point(818, 113);
            this.button_gudi1.Name = "button_gudi1";
            this.button_gudi1.Size = new System.Drawing.Size(60, 25);
            this.button_gudi1.TabIndex = 77;
            this.button_gudi1.Text = "등록";
            this.button_gudi1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi1.UseVisualStyleBackColor = false;
            // 
            // frmMasterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.button_gudi1);
            this.Controls.Add(this.button_gudi7);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.button_gudi5);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.button_gudi3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMasterList";
            this.Text = "frmSalesMaster";
            this.Load += new System.EventHandler(this.frmMasterList_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button_gudi button_gudi5;
        private Button_gudi btn_Delete;
        private Button_gudi button_gudi3;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi button_gudi8;
        private ComboBox_gudi comboBox_gudi1;
        private Label_gudi label_gudi6;
        private Controls.TextBox_gudi textBox_gudi1;
        private Label_gudi label_gudi4;
        private DGV_gudi dgv_SalesMaster;
        private Label_gudi label_gudi2;
        private DateTimePicker_gudi dateTimePicker_gudi2;
        private DateTimePicker_gudi dateTimePicker_gudi1;
        private Label_gudi label_gudi14;
        private Label_gudi label_gudi1;
        private Button_gudi button_gudi7;
        private Button_gudi button_gudi1;
    }
}
