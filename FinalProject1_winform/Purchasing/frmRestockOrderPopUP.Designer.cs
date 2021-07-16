
namespace FinalProject1_winform
{
    partial class frmRestockOrderPopUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestockOrderPopUP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_gudi8 = new FinalProject1_winform.Button_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.cboParts = new FinalProject1_winform.ComboBox_gudi();
            this.cboCompany = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.dgvRO = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi3 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.dgvCompany = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.btnRO = new FinalProject1_winform.Button_gudi();
            this.button_gudi1 = new FinalProject1_winform.Button_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.dtpSuggest = new FinalProject1_winform.DateTimePicker_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.txtCompany = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.txtSQ = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi9 = new FinalProject1_winform.Label_gudi();
            this.txtQty = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi10 = new FinalProject1_winform.Label_gudi();
            this.dtpRO = new FinalProject1_winform.DateTimePicker_gudi();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.button_gudi8);
            this.panel2.Controls.Add(this.label_gudi6);
            this.panel2.Controls.Add(this.cboParts);
            this.panel2.Controls.Add(this.cboCompany);
            this.panel2.Controls.Add(this.label_gudi2);
            this.panel2.Location = new System.Drawing.Point(17, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 62);
            this.panel2.TabIndex = 25;
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
            this.button_gudi8.Location = new System.Drawing.Point(893, 22);
            this.button_gudi8.Name = "button_gudi8";
            this.button_gudi8.Size = new System.Drawing.Size(93, 25);
            this.button_gudi8.TabIndex = 17;
            this.button_gudi8.Text = "조회";
            this.button_gudi8.UseVisualStyleBackColor = false;
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(361, 26);
            this.label_gudi6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(69, 17);
            this.label_gudi6.TabIndex = 15;
            this.label_gudi6.Text = "■ Part No";
            // 
            // cboParts
            // 
            this.cboParts.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboParts.FormattingEnabled = true;
            this.cboParts.Location = new System.Drawing.Point(438, 23);
            this.cboParts.Margin = new System.Windows.Forms.Padding(4);
            this.cboParts.Name = "cboParts";
            this.cboParts.Size = new System.Drawing.Size(231, 24);
            this.cboParts.TabIndex = 13;
            // 
            // cboCompany
            // 
            this.cboCompany.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(82, 23);
            this.cboCompany.Margin = new System.Windows.Forms.Padding(4);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(231, 24);
            this.cboCompany.TabIndex = 13;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(26, 28);
            this.label_gudi2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(48, 17);
            this.label_gudi2.TabIndex = 12;
            this.label_gudi2.Text = "■ 업체";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 37);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox_gudi1
            // 
            this.pictureBox_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi1.Image")));
            this.pictureBox_gudi1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_gudi1.Name = "pictureBox_gudi1";
            this.pictureBox_gudi1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox_gudi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi1.TabIndex = 3;
            this.pictureBox_gudi1.TabStop = false;
            // 
            // label_gudi1
            // 
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_gudi1.Location = new System.Drawing.Point(48, 11);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(155, 23);
            this.label_gudi1.TabIndex = 2;
            this.label_gudi1.Text = "발주";
            // 
            // dgvRO
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRO.BackgroundColor = System.Drawing.Color.White;
            this.dgvRO.CheckBoxAll = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRO.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvRO.HeaderCheckStatus = false;
            this.dgvRO.Location = new System.Drawing.Point(13, 155);
            this.dgvRO.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRO.Name = "dgvRO";
            this.dgvRO.RowHeadersVisible = false;
            this.dgvRO.RowTemplate.Height = 23;
            this.dgvRO.Size = new System.Drawing.Size(506, 346);
            this.dgvRO.TabIndex = 34;
            this.dgvRO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRO_CellClick);
            // 
            // pictureBox_gudi3
            // 
            this.pictureBox_gudi3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi3.Image")));
            this.pictureBox_gudi3.Location = new System.Drawing.Point(15, 131);
            this.pictureBox_gudi3.Name = "pictureBox_gudi3";
            this.pictureBox_gudi3.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi3.TabIndex = 36;
            this.pictureBox_gudi3.TabStop = false;
            // 
            // label_gudi3
            // 
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi3.Location = new System.Drawing.Point(43, 133);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(71, 18);
            this.label_gudi3.TabIndex = 35;
            this.label_gudi3.Text = "발주";
            // 
            // dgvCompany
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvCompany.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCompany.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompany.CheckBoxAll = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvCompany.HeaderCheckStatus = false;
            this.dgvCompany.Location = new System.Drawing.Point(527, 156);
            this.dgvCompany.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.RowHeadersVisible = false;
            this.dgvCompany.RowTemplate.Height = 23;
            this.dgvCompany.Size = new System.Drawing.Size(520, 345);
            this.dgvCompany.TabIndex = 39;
            this.dgvCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_CellClick);
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(528, 132);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 41;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // label_gudi4
            // 
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi4.Location = new System.Drawing.Point(556, 134);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(71, 18);
            this.label_gudi4.TabIndex = 40;
            this.label_gudi4.Text = "발주업체";
            // 
            // btnRO
            // 
            this.btnRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnRO.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnRO.FlatAppearance.BorderSize = 0;
            this.btnRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRO.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnRO.ForeColor = System.Drawing.Color.White;
            this.btnRO.Location = new System.Drawing.Point(779, 525);
            this.btnRO.Name = "btnRO";
            this.btnRO.Size = new System.Drawing.Size(80, 33);
            this.btnRO.TabIndex = 42;
            this.btnRO.Text = "발주넣기";
            this.btnRO.UseVisualStyleBackColor = false;
            // 
            // button_gudi1
            // 
            this.button_gudi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.button_gudi1.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.button_gudi1.FlatAppearance.BorderSize = 0;
            this.button_gudi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi1.ForeColor = System.Drawing.Color.White;
            this.button_gudi1.Location = new System.Drawing.Point(473, 597);
            this.button_gudi1.Name = "button_gudi1";
            this.button_gudi1.Size = new System.Drawing.Size(80, 33);
            this.button_gudi1.TabIndex = 43;
            this.button_gudi1.Text = "닫기";
            this.button_gudi1.UseVisualStyleBackColor = false;
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(18, 531);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(56, 17);
            this.label_gudi5.TabIndex = 45;
            this.label_gudi5.Text = "제안일자";
            // 
            // dtpSuggest
            // 
            this.dtpSuggest.Enabled = false;
            this.dtpSuggest.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtpSuggest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSuggest.Location = new System.Drawing.Point(80, 527);
            this.dtpSuggest.Name = "dtpSuggest";
            this.dtpSuggest.Size = new System.Drawing.Size(158, 25);
            this.dtpSuggest.TabIndex = 46;
            this.dtpSuggest.ValueChanged += new System.EventHandler(this.dtpSuggest_ValueChanged);
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi7.Location = new System.Drawing.Point(267, 532);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(56, 17);
            this.label_gudi7.TabIndex = 45;
            this.label_gudi7.Text = "발주일자";
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCompany.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCompany.Location = new System.Drawing.Point(596, 527);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(158, 25);
            this.txtCompany.TabIndex = 44;
            // 
            // label_gudi8
            // 
            this.label_gudi8.AutoSize = true;
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi8.Location = new System.Drawing.Point(539, 532);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(56, 17);
            this.label_gudi8.TabIndex = 45;
            this.label_gudi8.Text = "발주업체";
            // 
            // txtSQ
            // 
            this.txtSQ.Enabled = false;
            this.txtSQ.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtSQ.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtSQ.Location = new System.Drawing.Point(80, 567);
            this.txtSQ.Name = "txtSQ";
            this.txtSQ.Size = new System.Drawing.Size(158, 25);
            this.txtSQ.TabIndex = 44;
            this.txtSQ.TextChanged += new System.EventHandler(this.txtSQ_TextChanged);
            // 
            // label_gudi9
            // 
            this.label_gudi9.AutoSize = true;
            this.label_gudi9.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi9.Location = new System.Drawing.Point(6, 571);
            this.label_gudi9.Name = "label_gudi9";
            this.label_gudi9.Size = new System.Drawing.Size(68, 17);
            this.label_gudi9.TabIndex = 45;
            this.label_gudi9.Text = "발주제안량";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtQty.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtQty.Location = new System.Drawing.Point(333, 562);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(158, 25);
            this.txtQty.TabIndex = 44;
            // 
            // label_gudi10
            // 
            this.label_gudi10.AutoSize = true;
            this.label_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi10.Location = new System.Drawing.Point(276, 565);
            this.label_gudi10.Name = "label_gudi10";
            this.label_gudi10.Size = new System.Drawing.Size(44, 17);
            this.label_gudi10.TabIndex = 45;
            this.label_gudi10.Text = "발주량";
            // 
            // dtpRO
            // 
            this.dtpRO.Enabled = false;
            this.dtpRO.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtpRO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRO.Location = new System.Drawing.Point(333, 527);
            this.dtpRO.Name = "dtpRO";
            this.dtpRO.Size = new System.Drawing.Size(158, 25);
            this.dtpRO.TabIndex = 46;
            // 
            // frmRestockOrderPopUP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 642);
            this.Controls.Add(this.dtpRO);
            this.Controls.Add(this.dtpSuggest);
            this.Controls.Add(this.label_gudi8);
            this.Controls.Add(this.label_gudi10);
            this.Controls.Add(this.label_gudi9);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtSQ);
            this.Controls.Add(this.btnRO);
            this.Controls.Add(this.button_gudi1);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.dgvCompany);
            this.Controls.Add(this.pictureBox_gudi3);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.dgvRO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRestockOrderPopUP";
            this.Text = "발주";
            this.Load += new System.EventHandler(this.frmRestockOrderPopUP_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Label_gudi label_gudi6;
        private ComboBox_gudi cboCompany;
        private Label_gudi label_gudi2;
        private System.Windows.Forms.Panel panel1;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private Button_gudi button_gudi8;
        private ComboBox_gudi cboParts;
        private DGV_gudi dgvRO;
        private PictureBox_gudi pictureBox_gudi3;
        private Label_gudi label_gudi3;
        private DGV_gudi dgvCompany;
        private PictureBox_gudi pictureBox_gudi2;
        private Label_gudi label_gudi4;
        private Button_gudi btnRO;
        private Button_gudi button_gudi1;
        private Label_gudi label_gudi5;
        private DateTimePicker_gudi dtpSuggest;
        private Label_gudi label_gudi7;
        private Controls.TextBox_gudi txtCompany;
        private Label_gudi label_gudi8;
        private Controls.TextBox_gudi txtSQ;
        private Label_gudi label_gudi9;
        private Controls.TextBox_gudi txtQty;
        private Label_gudi label_gudi10;
        private DateTimePicker_gudi dtpRO;
    }
}