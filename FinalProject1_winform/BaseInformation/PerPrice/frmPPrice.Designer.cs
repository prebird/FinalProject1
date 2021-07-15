
namespace FinalProject1_winform
{
    partial class frmPPrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPPrice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_gudi8 = new FinalProject1_winform.Button_gudi();
            this.cboCompanyCode = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.txtItemCode = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.dtpdate = new FinalProject1_winform.DateTimePicker_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPprice = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.button_gudi10 = new FinalProject1_winform.Button_gudi();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            this.button_gudi6 = new FinalProject1_winform.Button_gudi();
            this.button_gudi3 = new FinalProject1_winform.Button_gudi();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.button_gudi8);
            this.panel1.Controls.Add(this.cboCompanyCode);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.txtItemCode);
            this.panel1.Controls.Add(this.label_gudi2);
            this.panel1.Controls.Add(this.dtpdate);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 50);
            this.panel1.TabIndex = 1;
            // 
            // button_gudi8
            // 
            this.button_gudi8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.button_gudi8.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.button_gudi8.FlatAppearance.BorderSize = 0;
            this.button_gudi8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi8.ForeColor = System.Drawing.Color.White;
            this.button_gudi8.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi8.Image")));
            this.button_gudi8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi8.Location = new System.Drawing.Point(959, 11);
            this.button_gudi8.Name = "button_gudi8";
            this.button_gudi8.Size = new System.Drawing.Size(78, 25);
            this.button_gudi8.TabIndex = 1;
            this.button_gudi8.Text = "조회";
            this.button_gudi8.UseVisualStyleBackColor = false;
            // 
            // cboCompanyCode
            // 
            this.cboCompanyCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompanyCode.FormattingEnabled = true;
            this.cboCompanyCode.Location = new System.Drawing.Point(736, 11);
            this.cboCompanyCode.Name = "cboCompanyCode";
            this.cboCompanyCode.Size = new System.Drawing.Size(121, 24);
            this.cboCompanyCode.TabIndex = 5;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(669, 15);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(48, 17);
            this.label_gudi3.TabIndex = 4;
            this.label_gudi3.Text = "■ 업체";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtItemCode.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtItemCode.Location = new System.Drawing.Point(426, 11);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(187, 25);
            this.txtItemCode.TabIndex = 0;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(360, 15);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(48, 17);
            this.label_gudi2.TabIndex = 2;
            this.label_gudi2.Text = "■ 품목";
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(90, 11);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(200, 25);
            this.dtpdate.TabIndex = 1;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(12, 15);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(72, 17);
            this.label_gudi1.TabIndex = 9;
            this.label_gudi1.Text = "■ 기준일자";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvPprice);
            this.panel2.Location = new System.Drawing.Point(17, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 466);
            this.panel2.TabIndex = 8;
            // 
            // dgvPprice
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvPprice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPprice.BackgroundColor = System.Drawing.Color.White;
            this.dgvPprice.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPprice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPprice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPprice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPprice.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvPprice.HeaderCheckStatus = false;
            this.dgvPprice.Location = new System.Drawing.Point(0, 0);
            this.dgvPprice.Name = "dgvPprice";
            this.dgvPprice.RowHeadersVisible = false;
            this.dgvPprice.RowTemplate.Height = 23;
            this.dgvPprice.Size = new System.Drawing.Size(1057, 466);
            this.dgvPprice.TabIndex = 0;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(18, 78);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 7;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(49, 80);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(56, 17);
            this.label_gudi4.TabIndex = 10;
            this.label_gudi4.Text = "단가관리";
            // 
            // button_gudi10
            // 
            this.button_gudi10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi10.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi10.FlatAppearance.BorderSize = 0;
            this.button_gudi10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi10.ForeColor = System.Drawing.Color.Black;
            this.button_gudi10.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi10.Image")));
            this.button_gudi10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi10.Location = new System.Drawing.Point(926, 76);
            this.button_gudi10.Name = "button_gudi10";
            this.button_gudi10.Size = new System.Drawing.Size(149, 25);
            this.button_gudi10.TabIndex = 5;
            this.button_gudi10.Text = "양식(양식이름) 다운";
            this.button_gudi10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi10.UseVisualStyleBackColor = false;
            // 
            // button_gudi5
            // 
            this.button_gudi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi5.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi5.FlatAppearance.BorderSize = 0;
            this.button_gudi5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi5.ForeColor = System.Drawing.Color.Black;
            this.button_gudi5.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi5.Image")));
            this.button_gudi5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi5.Location = new System.Drawing.Point(861, 76);
            this.button_gudi5.Name = "button_gudi5";
            this.button_gudi5.Size = new System.Drawing.Size(60, 25);
            this.button_gudi5.TabIndex = 4;
            this.button_gudi5.Text = "엑셀";
            this.button_gudi5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi5.UseVisualStyleBackColor = false;
            // 
            // button_gudi6
            // 
            this.button_gudi6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi6.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi6.FlatAppearance.BorderSize = 0;
            this.button_gudi6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi6.ForeColor = System.Drawing.Color.Black;
            this.button_gudi6.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi6.Image")));
            this.button_gudi6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi6.Location = new System.Drawing.Point(795, 76);
            this.button_gudi6.Name = "button_gudi6";
            this.button_gudi6.Size = new System.Drawing.Size(60, 25);
            this.button_gudi6.TabIndex = 3;
            this.button_gudi6.Text = "삭제";
            this.button_gudi6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi6.UseVisualStyleBackColor = false;
            // 
            // button_gudi3
            // 
            this.button_gudi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi3.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi3.FlatAppearance.BorderSize = 0;
            this.button_gudi3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi3.ForeColor = System.Drawing.Color.Black;
            this.button_gudi3.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi3.Image")));
            this.button_gudi3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi3.Location = new System.Drawing.Point(729, 76);
            this.button_gudi3.Name = "button_gudi3";
            this.button_gudi3.Size = new System.Drawing.Size(60, 25);
            this.button_gudi3.TabIndex = 2;
            this.button_gudi3.Text = "등록";
            this.button_gudi3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi3.UseVisualStyleBackColor = false;
            // 
            // frmPPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.button_gudi10);
            this.Controls.Add(this.button_gudi5);
            this.Controls.Add(this.button_gudi6);
            this.Controls.Add(this.button_gudi3);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPPrice";
            this.Text = "frmMaterialPrice";
            this.Load += new System.EventHandler(this.frmMaterialPrice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private Label_gudi label_gudi1;
        private DateTimePicker_gudi dtpdate;
        private ComboBox_gudi cboCompanyCode;
        private Label_gudi label_gudi3;
        private Controls.TextBox_gudi txtItemCode;
        private Label_gudi label_gudi2;
        private Button_gudi button_gudi8;
        private Label_gudi label_gudi4;
        private Button_gudi button_gudi10;
        private Button_gudi button_gudi5;
        private Button_gudi button_gudi6;
        private Button_gudi button_gudi3;
        private DGV_gudi dgvPprice;
    }
}