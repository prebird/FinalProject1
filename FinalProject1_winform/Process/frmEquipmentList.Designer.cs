﻿
namespace FinalProject1_winform
{
    partial class frmEquipmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipmentList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.button_gudi7 = new FinalProject1_winform.Button_gudi();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            this.button_gudi6 = new FinalProject1_winform.Button_gudi();
            this.button_gudi3 = new FinalProject1_winform.Button_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.comboBox_gudi1 = new FinalProject1_winform.ComboBox_gudi();
            this.comboBox_gudi2 = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.textBox_gudi1 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.button_gudi8 = new FinalProject1_winform.Button_gudi();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.button_gudi8);
            this.panel1.Controls.Add(this.textBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi4);
            this.panel1.Controls.Add(this.comboBox_gudi2);
            this.panel1.Controls.Add(this.label_gudi2);
            this.panel1.Controls.Add(this.comboBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 41);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(12, 63);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 5;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 499);
            this.panel2.TabIndex = 6;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(42, 64);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(32, 17);
            this.label_gudi1.TabIndex = 7;
            this.label_gudi1.Text = "설비";
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
            this.button_gudi7.Location = new System.Drawing.Point(960, 59);
            this.button_gudi7.Name = "button_gudi7";
            this.button_gudi7.Size = new System.Drawing.Size(60, 25);
            this.button_gudi7.TabIndex = 30;
            this.button_gudi7.Text = "수정";
            this.button_gudi7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi7.UseVisualStyleBackColor = false;
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
            this.button_gudi5.Location = new System.Drawing.Point(1094, 59);
            this.button_gudi5.Name = "button_gudi5";
            this.button_gudi5.Size = new System.Drawing.Size(60, 25);
            this.button_gudi5.TabIndex = 27;
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
            this.button_gudi6.Location = new System.Drawing.Point(1027, 59);
            this.button_gudi6.Name = "button_gudi6";
            this.button_gudi6.Size = new System.Drawing.Size(60, 25);
            this.button_gudi6.TabIndex = 28;
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
            this.button_gudi3.Location = new System.Drawing.Point(893, 59);
            this.button_gudi3.Name = "button_gudi3";
            this.button_gudi3.Size = new System.Drawing.Size(60, 25);
            this.button_gudi3.TabIndex = 29;
            this.button_gudi3.Text = "등록";
            this.button_gudi3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi3.UseVisualStyleBackColor = false;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(3, 12);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(60, 17);
            this.label_gudi3.TabIndex = 1;
            this.label_gudi3.Text = "■ 공정명";
            // 
            // comboBox_gudi1
            // 
            this.comboBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.comboBox_gudi1.FormattingEnabled = true;
            this.comboBox_gudi1.Location = new System.Drawing.Point(98, 9);
            this.comboBox_gudi1.Name = "comboBox_gudi1";
            this.comboBox_gudi1.Size = new System.Drawing.Size(121, 24);
            this.comboBox_gudi1.TabIndex = 2;
            // 
            // comboBox_gudi2
            // 
            this.comboBox_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.comboBox_gudi2.FormattingEnabled = true;
            this.comboBox_gudi2.Location = new System.Drawing.Point(454, 9);
            this.comboBox_gudi2.Name = "comboBox_gudi2";
            this.comboBox_gudi2.Size = new System.Drawing.Size(121, 24);
            this.comboBox_gudi2.TabIndex = 4;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(343, 12);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(84, 17);
            this.label_gudi2.TabIndex = 3;
            this.label_gudi2.Text = "■ 설비군코드";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(715, 12);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(60, 17);
            this.label_gudi4.TabIndex = 5;
            this.label_gudi4.Text = "■ 설비명";
            // 
            // textBox_gudi1
            // 
            this.textBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi1.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi1.Location = new System.Drawing.Point(819, 9);
            this.textBox_gudi1.Name = "textBox_gudi1";
            this.textBox_gudi1.Size = new System.Drawing.Size(133, 25);
            this.textBox_gudi1.TabIndex = 6;
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
            this.button_gudi8.Location = new System.Drawing.Point(1047, 8);
            this.button_gudi8.Name = "button_gudi8";
            this.button_gudi8.Size = new System.Drawing.Size(78, 25);
            this.button_gudi8.TabIndex = 10;
            this.button_gudi8.Text = "조회";
            this.button_gudi8.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmEquipmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1163, 618);
            this.Controls.Add(this.button_gudi7);
            this.Controls.Add(this.button_gudi5);
            this.Controls.Add(this.button_gudi6);
            this.Controls.Add(this.button_gudi3);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEquipmentList";
            this.Text = "frmEquipmentList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel2;
        private Label_gudi label_gudi1;
        private Button_gudi button_gudi7;
        private Button_gudi button_gudi5;
        private Button_gudi button_gudi6;
        private Button_gudi button_gudi3;
        private Controls.TextBox_gudi textBox_gudi1;
        private Label_gudi label_gudi4;
        private ComboBox_gudi comboBox_gudi2;
        private Label_gudi label_gudi2;
        private ComboBox_gudi comboBox_gudi1;
        private Label_gudi label_gudi3;
        private Button_gudi button_gudi8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}