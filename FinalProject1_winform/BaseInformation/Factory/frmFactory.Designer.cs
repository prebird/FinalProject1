
namespace FinalProject1_winform
{
    partial class frmFactory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_gudi1 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.button_gudi8 = new FinalProject1_winform.Button_gudi();
            this.comboBox_gudi1 = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.button_gudi7 = new FinalProject1_winform.Button_gudi();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            this.button_gudi6 = new FinalProject1_winform.Button_gudi();
            this.button_gudi3 = new FinalProject1_winform.Button_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.textBox_gudi1);
            this.panel1.Controls.Add(this.button_gudi8);
            this.panel1.Controls.Add(this.comboBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 50);
            this.panel1.TabIndex = 2;
            // 
            // textBox_gudi1
            // 
            this.textBox_gudi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_gudi1.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi1.Location = new System.Drawing.Point(107, 10);
            this.textBox_gudi1.Name = "textBox_gudi1";
            this.textBox_gudi1.Size = new System.Drawing.Size(192, 23);
            this.textBox_gudi1.TabIndex = 10;
            // 
            // button_gudi8
            // 
            this.button_gudi8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.button_gudi8.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.button_gudi8.FlatAppearance.BorderSize = 0;
            this.button_gudi8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_gudi8.ForeColor = System.Drawing.Color.White;
            this.button_gudi8.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi8.Image")));
            this.button_gudi8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi8.Location = new System.Drawing.Point(959, 11);
            this.button_gudi8.Name = "button_gudi8";
            this.button_gudi8.Size = new System.Drawing.Size(78, 25);
            this.button_gudi8.TabIndex = 9;
            this.button_gudi8.Text = "조회";
            this.button_gudi8.UseVisualStyleBackColor = false;
            // 
            // comboBox_gudi1
            // 
            this.comboBox_gudi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_gudi1.FormattingEnabled = true;
            this.comboBox_gudi1.Location = new System.Drawing.Point(460, 11);
            this.comboBox_gudi1.Name = "comboBox_gudi1";
            this.comboBox_gudi1.Size = new System.Drawing.Size(156, 24);
            this.comboBox_gudi1.TabIndex = 5;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gudi3.Location = new System.Drawing.Point(394, 15);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(55, 16);
            this.label_gudi3.TabIndex = 4;
            this.label_gudi3.Text = "■ 시설군";
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gudi1.Location = new System.Drawing.Point(12, 15);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(82, 16);
            this.label_gudi1.TabIndex = 0;
            this.label_gudi1.Text = "■ 시설코드/명";
            // 
            // button_gudi7
            // 
            this.button_gudi7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi7.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi7.FlatAppearance.BorderSize = 0;
            this.button_gudi7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_gudi7.ForeColor = System.Drawing.Color.Black;
            this.button_gudi7.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi7.Image")));
            this.button_gudi7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi7.Location = new System.Drawing.Point(879, 81);
            this.button_gudi7.Name = "button_gudi7";
            this.button_gudi7.Size = new System.Drawing.Size(60, 25);
            this.button_gudi7.TabIndex = 26;
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
            this.button_gudi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_gudi5.ForeColor = System.Drawing.Color.Black;
            this.button_gudi5.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi5.Image")));
            this.button_gudi5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi5.Location = new System.Drawing.Point(1013, 81);
            this.button_gudi5.Name = "button_gudi5";
            this.button_gudi5.Size = new System.Drawing.Size(60, 25);
            this.button_gudi5.TabIndex = 22;
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
            this.button_gudi6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_gudi6.ForeColor = System.Drawing.Color.Black;
            this.button_gudi6.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi6.Image")));
            this.button_gudi6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi6.Location = new System.Drawing.Point(946, 81);
            this.button_gudi6.Name = "button_gudi6";
            this.button_gudi6.Size = new System.Drawing.Size(60, 25);
            this.button_gudi6.TabIndex = 23;
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
            this.button_gudi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_gudi3.ForeColor = System.Drawing.Color.Black;
            this.button_gudi3.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi3.Image")));
            this.button_gudi3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi3.Location = new System.Drawing.Point(812, 81);
            this.button_gudi3.Name = "button_gudi3";
            this.button_gudi3.Size = new System.Drawing.Size(60, 25);
            this.button_gudi3.TabIndex = 24;
            this.button_gudi3.Text = "등록";
            this.button_gudi3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi3.UseVisualStyleBackColor = false;
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gudi4.Location = new System.Drawing.Point(49, 81);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(52, 16);
            this.label_gudi4.TabIndex = 20;
            this.label_gudi4.Text = "공장정의";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(17, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 466);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(18, 79);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 18;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // frmFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.button_gudi7);
            this.Controls.Add(this.button_gudi5);
            this.Controls.Add(this.button_gudi6);
            this.Controls.Add(this.button_gudi3);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmFactory";
            this.Text = "frmFactory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Button_gudi button_gudi8;
        private ComboBox_gudi comboBox_gudi1;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi1;
        private Controls.TextBox_gudi textBox_gudi1;
        private Button_gudi button_gudi7;
        private Button_gudi button_gudi5;
        private Button_gudi button_gudi6;
        private Button_gudi button_gudi3;
        private Label_gudi label_gudi4;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
    }
}