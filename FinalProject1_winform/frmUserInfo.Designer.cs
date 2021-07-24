
namespace FinalProject1_winform
{
    partial class frmUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search = new FinalProject1_winform.Button_gudi();
            this.cbo_searchDepart = new FinalProject1_winform.ComboBox_gudi();
            this.cbo_searchUserCategory = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.txtSearchName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.dgvAuth = new FinalProject1_winform.DGV_gudi();
            this.Pic1 = new FinalProject1_winform.PictureBox_gudi();
            this.dgvUser = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi4 = new FinalProject1_winform.PictureBox_gudi();
            this.pictureBox_gudi3 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi13 = new FinalProject1_winform.Label_gudi();
            this.label_gudi12 = new FinalProject1_winform.Label_gudi();
            this.label_gudi11 = new FinalProject1_winform.Label_gudi();
            this.label_gudi10 = new FinalProject1_winform.Label_gudi();
            this.label_gudi9 = new FinalProject1_winform.Label_gudi();
            this.label_gudi14 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.txtCategory = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtPwd = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtDepart = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtEmail = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txtUserId = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.btnAdd = new FinalProject1_winform.Button_gudi();
            this.btnUpdate = new FinalProject1_winform.Button_gudi();
            this.btnDel = new FinalProject1_winform.Button_gudi();
            this.btnPrint = new FinalProject1_winform.Button_gudi();
            this.btnAdd2 = new FinalProject1_winform.Button_gudi();
            this.btnDel2 = new FinalProject1_winform.Button_gudi();
            this.btnUpdate2 = new FinalProject1_winform.Button_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.cbo_searchDepart);
            this.panel1.Controls.Add(this.cbo_searchUserCategory);
            this.panel1.Controls.Add(this.label_gudi8);
            this.panel1.Controls.Add(this.label_gudi7);
            this.panel1.Controls.Add(this.label_gudi6);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Location = new System.Drawing.Point(17, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 112);
            this.panel1.TabIndex = 7;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btn_Search.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(651, 70);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(78, 25);
            this.btn_Search.TabIndex = 42;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbo_searchDepart
            // 
            this.cbo_searchDepart.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_searchDepart.FormattingEnabled = true;
            this.cbo_searchDepart.Items.AddRange(new object[] {
            "완제품",
            "반제품",
            "원자재"});
            this.cbo_searchDepart.Location = new System.Drawing.Point(105, 62);
            this.cbo_searchDepart.Name = "cbo_searchDepart";
            this.cbo_searchDepart.Size = new System.Drawing.Size(134, 24);
            this.cbo_searchDepart.TabIndex = 47;
            // 
            // cbo_searchUserCategory
            // 
            this.cbo_searchUserCategory.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_searchUserCategory.FormattingEnabled = true;
            this.cbo_searchUserCategory.Items.AddRange(new object[] {
            "완제품",
            "반제품",
            "원자재"});
            this.cbo_searchUserCategory.Location = new System.Drawing.Point(105, 19);
            this.cbo_searchUserCategory.Name = "cbo_searchUserCategory";
            this.cbo_searchUserCategory.Size = new System.Drawing.Size(134, 24);
            this.cbo_searchUserCategory.TabIndex = 47;
            // 
            // label_gudi8
            // 
            this.label_gudi8.AutoSize = true;
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi8.Location = new System.Drawing.Point(23, 65);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(72, 17);
            this.label_gudi8.TabIndex = 46;
            this.label_gudi8.Text = "■ 부서분류";
            // 
            // label_gudi7
            // 
            this.label_gudi7.AutoSize = true;
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi7.Location = new System.Drawing.Point(331, 23);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(48, 17);
            this.label_gudi7.TabIndex = 43;
            this.label_gudi7.Text = "■ 이름";
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(23, 22);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(72, 17);
            this.label_gudi6.TabIndex = 46;
            this.label_gudi6.Text = "■ 유저분류";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtSearchName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtSearchName.Location = new System.Drawing.Point(391, 20);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(166, 25);
            this.txtSearchName.TabIndex = 44;
            // 
            // dgvAuth
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvAuth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuth.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuth.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuth.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvAuth.HeaderCheckStatus = false;
            this.dgvAuth.Location = new System.Drawing.Point(784, 352);
            this.dgvAuth.Name = "dgvAuth";
            this.dgvAuth.RowHeadersVisible = false;
            this.dgvAuth.RowTemplate.Height = 23;
            this.dgvAuth.Size = new System.Drawing.Size(688, 410);
            this.dgvAuth.TabIndex = 46;
            // 
            // Pic1
            // 
            this.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic1.Location = new System.Drawing.Point(1158, 80);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(279, 209);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic1.TabIndex = 45;
            this.Pic1.TabStop = false;
            // 
            // dgvUser
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.CheckBoxAll = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgvUser.HeaderCheckStatus = false;
            this.dgvUser.Location = new System.Drawing.Point(17, 203);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.Size = new System.Drawing.Size(751, 560);
            this.dgvUser.TabIndex = 6;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // pictureBox_gudi4
            // 
            this.pictureBox_gudi4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi4.Image")));
            this.pictureBox_gudi4.Location = new System.Drawing.Point(783, 321);
            this.pictureBox_gudi4.Name = "pictureBox_gudi4";
            this.pictureBox_gudi4.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi4.TabIndex = 5;
            this.pictureBox_gudi4.TabStop = false;
            // 
            // pictureBox_gudi3
            // 
            this.pictureBox_gudi3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi3.Image")));
            this.pictureBox_gudi3.Location = new System.Drawing.Point(786, 18);
            this.pictureBox_gudi3.Name = "pictureBox_gudi3";
            this.pictureBox_gudi3.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi3.TabIndex = 5;
            this.pictureBox_gudi3.TabStop = false;
            // 
            // label_gudi13
            // 
            this.label_gudi13.AutoSize = true;
            this.label_gudi13.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi13.Location = new System.Drawing.Point(790, 267);
            this.label_gudi13.Name = "label_gudi13";
            this.label_gudi13.Size = new System.Drawing.Size(60, 17);
            this.label_gudi13.TabIndex = 43;
            this.label_gudi13.Text = "■ 이메일";
            // 
            // label_gudi12
            // 
            this.label_gudi12.AutoSize = true;
            this.label_gudi12.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi12.Location = new System.Drawing.Point(790, 226);
            this.label_gudi12.Name = "label_gudi12";
            this.label_gudi12.Size = new System.Drawing.Size(48, 17);
            this.label_gudi12.TabIndex = 43;
            this.label_gudi12.Text = "■ 부서";
            // 
            // label_gudi11
            // 
            this.label_gudi11.AutoSize = true;
            this.label_gudi11.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi11.Location = new System.Drawing.Point(790, 185);
            this.label_gudi11.Name = "label_gudi11";
            this.label_gudi11.Size = new System.Drawing.Size(48, 17);
            this.label_gudi11.TabIndex = 43;
            this.label_gudi11.Text = "■ 분류";
            // 
            // label_gudi10
            // 
            this.label_gudi10.AutoSize = true;
            this.label_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi10.Location = new System.Drawing.Point(790, 144);
            this.label_gudi10.Name = "label_gudi10";
            this.label_gudi10.Size = new System.Drawing.Size(48, 17);
            this.label_gudi10.TabIndex = 43;
            this.label_gudi10.Text = "■ 이름";
            // 
            // label_gudi9
            // 
            this.label_gudi9.AutoSize = true;
            this.label_gudi9.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi9.Location = new System.Drawing.Point(790, 103);
            this.label_gudi9.Name = "label_gudi9";
            this.label_gudi9.Size = new System.Drawing.Size(72, 17);
            this.label_gudi9.TabIndex = 43;
            this.label_gudi9.Text = "■ 비밀번호";
            // 
            // label_gudi14
            // 
            this.label_gudi14.AutoSize = true;
            this.label_gudi14.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi14.Location = new System.Drawing.Point(1155, 59);
            this.label_gudi14.Name = "label_gudi14";
            this.label_gudi14.Size = new System.Drawing.Size(48, 17);
            this.label_gudi14.TabIndex = 43;
            this.label_gudi14.Text = "■ 사진";
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(790, 62);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(60, 17);
            this.label_gudi5.TabIndex = 43;
            this.label_gudi5.Text = "■ 아이디";
            // 
            // pictureBox_gudi1
            // 
            this.pictureBox_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi1.Image")));
            this.pictureBox_gudi1.Location = new System.Drawing.Point(17, 178);
            this.pictureBox_gudi1.Name = "pictureBox_gudi1";
            this.pictureBox_gudi1.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi1.TabIndex = 5;
            this.pictureBox_gudi1.TabStop = false;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(17, 18);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 5;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtCategory.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtCategory.Location = new System.Drawing.Point(874, 182);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(243, 25);
            this.txtCategory.TabIndex = 44;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtName.Location = new System.Drawing.Point(874, 141);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(243, 25);
            this.txtName.TabIndex = 44;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtPwd.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtPwd.Location = new System.Drawing.Point(874, 100);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.ReadOnly = true;
            this.txtPwd.Size = new System.Drawing.Size(243, 25);
            this.txtPwd.TabIndex = 44;
            // 
            // txtDepart
            // 
            this.txtDepart.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtDepart.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtDepart.Location = new System.Drawing.Point(874, 223);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.ReadOnly = true;
            this.txtDepart.Size = new System.Drawing.Size(243, 25);
            this.txtDepart.TabIndex = 44;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtEmail.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtEmail.Location = new System.Drawing.Point(874, 264);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(243, 25);
            this.txtEmail.TabIndex = 44;
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtUserId.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtUserId.Location = new System.Drawing.Point(874, 59);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(243, 25);
            this.txtUserId.TabIndex = 44;
            // 
            // label_gudi4
            // 
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi4.Location = new System.Drawing.Point(814, 322);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(71, 18);
            this.label_gudi4.TabIndex = 4;
            this.label_gudi4.Text = "권한정보";
            // 
            // label_gudi3
            // 
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi3.Location = new System.Drawing.Point(814, 20);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(71, 18);
            this.label_gudi3.TabIndex = 4;
            this.label_gudi3.Text = "유저정보";
            // 
            // label_gudi1
            // 
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi1.Location = new System.Drawing.Point(45, 180);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(71, 18);
            this.label_gudi1.TabIndex = 4;
            this.label_gudi1.Text = "유저정보";
            // 
            // label_gudi2
            // 
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi2.Location = new System.Drawing.Point(45, 20);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(71, 18);
            this.label_gudi2.TabIndex = 4;
            this.label_gudi2.Text = "유저검색";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnAdd.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(510, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 25);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "등록";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnUpdate.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(576, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(60, 25);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnDel.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(642, 172);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 25);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "삭제";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnPrint.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(708, 172);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 25);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "인쇄";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnAdd2.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnAdd2.FlatAppearance.BorderSize = 0;
            this.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnAdd2.ForeColor = System.Drawing.Color.Black;
            this.btnAdd2.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd2.Image")));
            this.btnAdd2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd2.Location = new System.Drawing.Point(1280, 19);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(60, 25);
            this.btnAdd2.TabIndex = 4;
            this.btnAdd2.Text = "등록";
            this.btnAdd2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel2
            // 
            this.btnDel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnDel2.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnDel2.FlatAppearance.BorderSize = 0;
            this.btnDel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnDel2.ForeColor = System.Drawing.Color.Black;
            this.btnDel2.Image = ((System.Drawing.Image)(resources.GetObject("btnDel2.Image")));
            this.btnDel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel2.Location = new System.Drawing.Point(1412, 20);
            this.btnDel2.Name = "btnDel2";
            this.btnDel2.Size = new System.Drawing.Size(60, 25);
            this.btnDel2.TabIndex = 4;
            this.btnDel2.Text = "삭제";
            this.btnDel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel2.UseVisualStyleBackColor = false;
            this.btnDel2.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnUpdate2.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnUpdate2.FlatAppearance.BorderSize = 0;
            this.btnUpdate2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnUpdate2.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate2.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate2.Image")));
            this.btnUpdate2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate2.Location = new System.Drawing.Point(1346, 20);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(60, 25);
            this.btnUpdate2.TabIndex = 4;
            this.btnUpdate2.Text = "수정";
            this.btnUpdate2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate2.UseVisualStyleBackColor = false;
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUserInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1484, 773);
            this.Controls.Add(this.dgvAuth);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.pictureBox_gudi4);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pictureBox_gudi3);
            this.Controls.Add(this.label_gudi13);
            this.Controls.Add(this.label_gudi12);
            this.Controls.Add(this.label_gudi11);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label_gudi10);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.label_gudi9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label_gudi14);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.pictureBox_gudi1);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.label_gudi2);
            this.Name = "frmUserInfo";
            this.Text = "유저정보";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox_gudi pictureBox_gudi2;
        private Label_gudi label_gudi2;
        private Label_gudi label_gudi1;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi3;
        private PictureBox_gudi pictureBox_gudi3;
        private Label_gudi label_gudi4;
        private PictureBox_gudi pictureBox_gudi4;
        private DGV_gudi dgvUser;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi btn_Search;
        private ComboBox_gudi cbo_searchDepart;
        private ComboBox_gudi cbo_searchUserCategory;
        private Label_gudi label_gudi8;
        private Label_gudi label_gudi7;
        private Label_gudi label_gudi6;
        private Controls.TextBox_gudi txtSearchName;
        private Controls.TextBox_gudi txtUserId;
        private Label_gudi label_gudi5;
        private Controls.TextBox_gudi txtPwd;
        private Label_gudi label_gudi9;
        private Controls.TextBox_gudi txtName;
        private Label_gudi label_gudi10;
        private Controls.TextBox_gudi txtCategory;
        private Label_gudi label_gudi11;
        private Label_gudi label_gudi12;
        private Label_gudi label_gudi13;
        private Controls.TextBox_gudi txtEmail;
        private Controls.TextBox_gudi txtDepart;
        private Label_gudi label_gudi14;
        private PictureBox_gudi Pic1;
        private DGV_gudi dgvAuth;
        private Button_gudi btnAdd;
        private Button_gudi btnUpdate;
        private Button_gudi btnDel;
        private Button_gudi btnPrint;
        private Button_gudi btnAdd2;
        private Button_gudi btnDel2;
        private Button_gudi btnUpdate2;
    }
}