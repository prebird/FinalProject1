
namespace FinalProject1_winform
{
    partial class frmRestockOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestockOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            this.button_gudi3 = new FinalProject1_winform.Button_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp1 = new FinalProject1_winform.UcDateTimePicker();
            this.comboBox_gudi1 = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.button_gudi8 = new FinalProject1_winform.Button_gudi();
            this.button_gudi4 = new FinalProject1_winform.Button_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.button_gudi1 = new FinalProject1_winform.Button_gudi();
            this.dgV_gudi1 = new FinalProject1_winform.DGV_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.comboBox_gudi2 = new FinalProject1_winform.ComboBox_gudi();
            this.comboBox_gudi3 = new FinalProject1_winform.ComboBox_gudi();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_gudi1)).BeginInit();
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
            this.button_gudi5.Location = new System.Drawing.Point(1015, 109);
            this.button_gudi5.Name = "button_gudi5";
            this.button_gudi5.Size = new System.Drawing.Size(60, 25);
            this.button_gudi5.TabIndex = 28;
            this.button_gudi5.Text = "엑셀";
            this.button_gudi5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi5.UseVisualStyleBackColor = false;
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
            this.button_gudi3.Location = new System.Drawing.Point(778, 109);
            this.button_gudi3.Name = "button_gudi3";
            this.button_gudi3.Size = new System.Drawing.Size(60, 25);
            this.button_gudi3.TabIndex = 30;
            this.button_gudi3.Text = "발주";
            this.button_gudi3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi3.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.label_gudi2);
            this.panel1.Controls.Add(this.label_gudi7);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.comboBox_gudi2);
            this.panel1.Controls.Add(this.comboBox_gudi3);
            this.panel1.Controls.Add(this.comboBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Controls.Add(this.button_gudi8);
            this.panel1.Location = new System.Drawing.Point(18, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 79);
            this.panel1.TabIndex = 24;
            // 
            // dtp1
            // 
            this.dtp1.FromDate = new System.DateTime(2021, 6, 25, 14, 0, 31, 72);
            this.dtp1.Location = new System.Drawing.Point(449, 5);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(257, 30);
            this.dtp1.TabIndex = 14;
            this.dtp1.ToDate = new System.DateTime(2021, 6, 25, 14, 0, 31, 69);
            // 
            // comboBox_gudi1
            // 
            this.comboBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.comboBox_gudi1.FormattingEnabled = true;
            this.comboBox_gudi1.Location = new System.Drawing.Point(92, 11);
            this.comboBox_gudi1.Name = "comboBox_gudi1";
            this.comboBox_gudi1.Size = new System.Drawing.Size(194, 24);
            this.comboBox_gudi1.TabIndex = 13;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(360, 13);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(60, 17);
            this.label_gudi3.TabIndex = 11;
            this.label_gudi3.Text = "■ 발주일";
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(24, 15);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(62, 17);
            this.label_gudi1.TabIndex = 12;
            this.label_gudi1.Text = "■ PlanID";
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
            this.button_gudi4.Location = new System.Drawing.Point(844, 109);
            this.button_gudi4.Name = "button_gudi4";
            this.button_gudi4.Size = new System.Drawing.Size(60, 25);
            this.button_gudi4.TabIndex = 31;
            this.button_gudi4.Text = "MRP";
            this.button_gudi4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi4.UseVisualStyleBackColor = false;
            // 
            // label_gudi5
            // 
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi5.Location = new System.Drawing.Point(49, 116);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(82, 18);
            this.label_gudi5.TabIndex = 17;
            this.label_gudi5.Text = "정규 발주";
            // 
            // button_gudi1
            // 
            this.button_gudi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi1.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi1.FlatAppearance.BorderSize = 0;
            this.button_gudi1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi1.ForeColor = System.Drawing.Color.Black;
            this.button_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi1.Image")));
            this.button_gudi1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi1.Location = new System.Drawing.Point(910, 109);
            this.button_gudi1.Name = "button_gudi1";
            this.button_gudi1.Size = new System.Drawing.Size(99, 25);
            this.button_gudi1.TabIndex = 31;
            this.button_gudi1.Text = "발주서 출력";
            this.button_gudi1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi1.UseVisualStyleBackColor = false;
            this.button_gudi1.Click += new System.EventHandler(this.button_gudi1_Click);
            // 
            // dgV_gudi1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgV_gudi1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgV_gudi1.BackgroundColor = System.Drawing.Color.White;
            this.dgV_gudi1.CheckBoxAll = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgV_gudi1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgV_gudi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_gudi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgV_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgV_gudi1.HeaderCheckStatus = false;
            this.dgV_gudi1.Location = new System.Drawing.Point(0, 0);
            this.dgV_gudi1.Name = "dgV_gudi1";
            this.dgV_gudi1.RowHeadersVisible = false;
            this.dgV_gudi1.RowTemplate.Height = 23;
            this.dgV_gudi1.Size = new System.Drawing.Size(1057, 459);
            this.dgV_gudi1.TabIndex = 0;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(24, 49);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(60, 17);
            this.label_gudi2.TabIndex = 15;
            this.label_gudi2.Text = "■ 거래처";
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi7.Location = new System.Drawing.Point(360, 49);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(72, 17);
            this.label_gudi7.TabIndex = 15;
            this.label_gudi7.Text = "■ 발주상태";
            // 
            // comboBox_gudi2
            // 
            this.comboBox_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.comboBox_gudi2.FormattingEnabled = true;
            this.comboBox_gudi2.Location = new System.Drawing.Point(452, 45);
            this.comboBox_gudi2.Name = "comboBox_gudi2";
            this.comboBox_gudi2.Size = new System.Drawing.Size(191, 24);
            this.comboBox_gudi2.TabIndex = 13;
            // 
            // comboBox_gudi3
            // 
            this.comboBox_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.comboBox_gudi3.FormattingEnabled = true;
            this.comboBox_gudi3.Location = new System.Drawing.Point(92, 46);
            this.comboBox_gudi3.Name = "comboBox_gudi3";
            this.comboBox_gudi3.Size = new System.Drawing.Size(194, 24);
            this.comboBox_gudi3.TabIndex = 13;
            // 
            // frmRestockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.button_gudi1);
            this.Controls.Add(this.button_gudi4);
            this.Controls.Add(this.button_gudi5);
            this.Controls.Add(this.button_gudi3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRestockOrder";
            this.Text = "정규발주";
            this.Load += new System.EventHandler(this.frmRestockOrder_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_gudi1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button_gudi button_gudi5;
        private Button_gudi button_gudi3;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi button_gudi8;
        private Button_gudi button_gudi4;
        private UcDateTimePicker dtp1;
        private ComboBox_gudi comboBox_gudi1;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi1;
        private Label_gudi label_gudi5;
        private Button_gudi button_gudi1;
        private DGV_gudi dgV_gudi1;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi7;
        private ComboBox_gudi comboBox_gudi2;
        private ComboBox_gudi comboBox_gudi3;
    }
}
