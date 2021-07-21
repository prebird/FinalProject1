
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Excel = new FinalProject1_winform.Button_gudi();
            this.btn_Delete = new FinalProject1_winform.Button_gudi();
            this.btn_PlanCreate = new FinalProject1_winform.Button_gudi();
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
            this.btn_Insert = new FinalProject1_winform.Button_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Excel
            // 
            this.btn_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_Excel.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_Excel.FlatAppearance.BorderSize = 0;
            this.btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Excel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Excel.ForeColor = System.Drawing.Color.Black;
            this.btn_Excel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel.Image")));
            this.btn_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel.Location = new System.Drawing.Point(1016, 113);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(60, 25);
            this.btn_Excel.TabIndex = 28;
            this.btn_Excel.Text = "엑셀";
            this.btn_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel.UseVisualStyleBackColor = false;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
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
            // btn_PlanCreate
            // 
            this.btn_PlanCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PlanCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btn_PlanCreate.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btn_PlanCreate.FlatAppearance.BorderSize = 0;
            this.btn_PlanCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PlanCreate.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_PlanCreate.ForeColor = System.Drawing.Color.Black;
            this.btn_PlanCreate.Image = ((System.Drawing.Image)(resources.GetObject("btn_PlanCreate.Image")));
            this.btn_PlanCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PlanCreate.Location = new System.Drawing.Point(699, 113);
            this.btn_PlanCreate.Name = "btn_PlanCreate";
            this.btn_PlanCreate.Size = new System.Drawing.Size(113, 25);
            this.btn_PlanCreate.TabIndex = 30;
            this.btn_PlanCreate.Text = "수요 계획 생성";
            this.btn_PlanCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PlanCreate.UseVisualStyleBackColor = false;
            this.btn_PlanCreate.Click += new System.EventHandler(this.btn_PlanCreate_Click);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_SalesMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SalesMaster.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SalesMaster.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SalesMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.btn_Insert.Location = new System.Drawing.Point(818, 113);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(60, 25);
            this.btn_Insert.TabIndex = 77;
            this.btn_Insert.Text = "등록";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // frmMasterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.button_gudi7);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_PlanCreate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMasterList";
            this.Text = "frmMasterList";
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
        private Button_gudi btn_Excel;
        private Button_gudi btn_Delete;
        private Button_gudi btn_PlanCreate;
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
        private Button_gudi btn_Insert;
    }
}
