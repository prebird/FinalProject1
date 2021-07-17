
namespace FinalProject1_winform
{
    partial class frmBigMenuIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBigMenuIns));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.txtMenuName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.btnSave = new FinalProject1_winform.Button_gudi();
            this.btnClose = new FinalProject1_winform.Button_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.pictureBox1 = new FinalProject1_winform.PictureBox_gudi();
            this.btnSearchPic = new FinalProject1_winform.Button_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.txtUserName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.dtpDate = new FinalProject1_winform.DateTimePicker_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 37);
            this.panel1.TabIndex = 2;
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
            this.label_gudi1.Text = "상위메뉴등록";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtMenuName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtMenuName.Location = new System.Drawing.Point(159, 74);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(242, 25);
            this.txtMenuName.TabIndex = 40;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi3.Location = new System.Drawing.Point(31, 77);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(72, 17);
            this.label_gudi3.TabIndex = 39;
            this.label_gudi3.Text = "■ 메뉴이름";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSave.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(129, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 33);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.btnClose.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(227, 474);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 33);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi2.Location = new System.Drawing.Point(31, 123);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(84, 17);
            this.label_gudi2.TabIndex = 39;
            this.label_gudi2.Text = "■ 메뉴이미지";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(159, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearchPic
            // 
            this.btnSearchPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSearchPic.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSearchPic.FlatAppearance.BorderSize = 0;
            this.btnSearchPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPic.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSearchPic.ForeColor = System.Drawing.Color.White;
            this.btnSearchPic.Location = new System.Drawing.Point(158, 315);
            this.btnSearchPic.Name = "btnSearchPic";
            this.btnSearchPic.Size = new System.Drawing.Size(242, 27);
            this.btnSearchPic.TabIndex = 50;
            this.btnSearchPic.Text = "이미지검색";
            this.btnSearchPic.UseVisualStyleBackColor = false;
            this.btnSearchPic.Click += new System.EventHandler(this.btnSearchPic_Click);
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi4.Location = new System.Drawing.Point(31, 364);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(60, 17);
            this.label_gudi4.TabIndex = 39;
            this.label_gudi4.Text = "■ 수정자";
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi5.Location = new System.Drawing.Point(31, 413);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(72, 17);
            this.label_gudi5.TabIndex = 39;
            this.label_gudi5.Text = "■ 수정일자";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtUserName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtUserName.Location = new System.Drawing.Point(159, 361);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(242, 25);
            this.txtUserName.TabIndex = 40;
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(158, 407);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(243, 25);
            this.dtpDate.TabIndex = 52;
            // 
            // frmBigMenuIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(437, 540);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearchPic);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.panel1);
            this.Name = "frmBigMenuIns";
            this.Text = "상위메뉴등록";
            this.Load += new System.EventHandler(this.frmMainMgtInsert_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private Controls.TextBox_gudi txtMenuName;
        private Label_gudi label_gudi3;
        private Button_gudi btnSave;
        private Button_gudi btnClose;
        private Label_gudi label_gudi2;
        private PictureBox_gudi pictureBox1;
        private Button_gudi btnSearchPic;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi5;
        private Controls.TextBox_gudi txtUserName;
        private DateTimePicker_gudi dtpDate;
    }
}