
namespace FinalProject1_POP
{
    partial class POPUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbUserPic = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GbUserInfo = new System.Windows.Forms.GroupBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserBirthDay = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.dgv_workList = new FinalProject1_winform.DGV_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUserDept = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.GbUserPic.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GbUserInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_workList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // GbUserPic
            // 
            this.GbUserPic.Controls.Add(this.pictureBoxUser);
            this.GbUserPic.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GbUserPic.Location = new System.Drawing.Point(71, 184);
            this.GbUserPic.Name = "GbUserPic";
            this.GbUserPic.Size = new System.Drawing.Size(385, 380);
            this.GbUserPic.TabIndex = 5;
            this.GbUserPic.TabStop = false;
            this.GbUserPic.Text = "직원 사진";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 75);
            this.panel1.TabIndex = 8;
            // 
            // GbUserInfo
            // 
            this.GbUserInfo.Controls.Add(this.lblUserDept);
            this.GbUserInfo.Controls.Add(this.label5);
            this.GbUserInfo.Controls.Add(this.lblUserEmail);
            this.GbUserInfo.Controls.Add(this.lblUserBirthDay);
            this.GbUserInfo.Controls.Add(this.lblUserId);
            this.GbUserInfo.Controls.Add(this.lblUserName);
            this.GbUserInfo.Controls.Add(this.label4);
            this.GbUserInfo.Controls.Add(this.label3);
            this.GbUserInfo.Controls.Add(this.label2);
            this.GbUserInfo.Controls.Add(this.label1);
            this.GbUserInfo.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GbUserInfo.Location = new System.Drawing.Point(537, 184);
            this.GbUserInfo.Name = "GbUserInfo";
            this.GbUserInfo.Size = new System.Drawing.Size(481, 380);
            this.GbUserInfo.TabIndex = 6;
            this.GbUserInfo.TabStop = false;
            this.GbUserInfo.Text = "직원 정보";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.Location = new System.Drawing.Point(242, 323);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(233, 48);
            this.lblUserEmail.TabIndex = 7;
            this.lblUserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserBirthDay
            // 
            this.lblUserBirthDay.Location = new System.Drawing.Point(242, 260);
            this.lblUserBirthDay.Name = "lblUserBirthDay";
            this.lblUserBirthDay.Size = new System.Drawing.Size(233, 43);
            this.lblUserBirthDay.TabIndex = 6;
            this.lblUserBirthDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(242, 129);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(233, 40);
            this.lblUserId.TabIndex = 5;
            this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(242, 60);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(233, 46);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "생년월일 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "이메일 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "사번 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_workList);
            this.groupBox3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(1096, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 380);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "업무 List";
            // 
            // lblComment
            // 
            this.lblComment.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 20.25F);
            this.lblComment.Location = new System.Drawing.Point(29, 585);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(1600, 96);
            this.lblComment.TabIndex = 9;
            this.lblComment.Text = "label5";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_workList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_workList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_workList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_workList.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_workList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_workList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_workList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_workList.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_workList.HeaderCheckStatus = false;
            this.dgv_workList.Location = new System.Drawing.Point(3, 41);
            this.dgv_workList.Name = "dgv_workList";
            this.dgv_workList.RowHeadersVisible = false;
            this.dgv_workList.RowTemplate.Height = 23;
            this.dgv_workList.Size = new System.Drawing.Size(492, 336);
            this.dgv_workList.TabIndex = 84;
            // 
            // label_gudi1
            // 
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.ForeColor = System.Drawing.Color.White;
            this.label_gudi1.Location = new System.Drawing.Point(0, 0);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(1684, 75);
            this.label_gudi1.TabIndex = 2;
            this.label_gudi1.Text = "직원정보";
            this.label_gudi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(674, 376);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(60, 17);
            this.label_gudi2.TabIndex = 0;
            this.label_gudi2.Text = "작업 일자";
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(674, 423);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(32, 17);
            this.label_gudi3.TabIndex = 1;
            this.label_gudi3.Text = "공정";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(674, 470);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(44, 17);
            this.label_gudi4.TabIndex = 2;
            this.label_gudi4.Text = "작업장";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "부서 :";
            // 
            // lblUserDept
            // 
            this.lblUserDept.Location = new System.Drawing.Point(242, 195);
            this.lblUserDept.Name = "lblUserDept";
            this.lblUserDept.Size = new System.Drawing.Size(233, 40);
            this.lblUserDept.TabIndex = 9;
            this.lblUserDept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxUser.Location = new System.Drawing.Point(3, 41);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(379, 336);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // POPUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1684, 961);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GbUserInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GbUserPic);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.label_gudi4);
            this.Name = "POPUser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.POPUser_Load);
            this.GbUserPic.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.GbUserInfo.ResumeLayout(false);
            this.GbUserInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_workList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbUserPic;
        private FinalProject1_winform.Label_gudi label_gudi4;
        private FinalProject1_winform.Label_gudi label_gudi3;
        private FinalProject1_winform.Label_gudi label_gudi2;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panel1;
        private FinalProject1_winform.Label_gudi label_gudi1;
        private System.Windows.Forms.GroupBox GbUserInfo;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserBirthDay;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FinalProject1_winform.DGV_gudi dgv_workList;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblUserDept;
        private System.Windows.Forms.Label label5;
    }
}