
namespace FinalProject1_winform.Process
{
    partial class frmProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcess));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_gudi2 = new FinalProject1_winform.Button_gudi();
            this.button_gudi1 = new FinalProject1_winform.Button_gudi();
            this.textBox_gudi2 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.textBox_gudi1 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.comboBox_gudi1 = new FinalProject1_winform.ComboBox_gudi();
            this.placeholderNew2 = new FinalProject1_winform.PlaceholderNew();
            this.placeholderNew1 = new FinalProject1_winform.PlaceholderNew();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox_gudi1);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 37);
            this.panel1.TabIndex = 3;
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
            this.label_gudi1.Text = "공정";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button_gudi2);
            this.panel2.Controls.Add(this.button_gudi1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 65);
            this.panel2.TabIndex = 4;
            // 
            // button_gudi2
            // 
            this.button_gudi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_gudi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.button_gudi2.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.button_gudi2.FlatAppearance.BorderSize = 0;
            this.button_gudi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi2.ForeColor = System.Drawing.Color.White;
            this.button_gudi2.Location = new System.Drawing.Point(150, 16);
            this.button_gudi2.Name = "button_gudi2";
            this.button_gudi2.Size = new System.Drawing.Size(80, 33);
            this.button_gudi2.TabIndex = 5;
            this.button_gudi2.Text = "저장";
            this.button_gudi2.UseVisualStyleBackColor = false;
            // 
            // button_gudi1
            // 
            this.button_gudi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.button_gudi1.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.button_gudi1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_gudi1.FlatAppearance.BorderSize = 0;
            this.button_gudi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi1.ForeColor = System.Drawing.Color.White;
            this.button_gudi1.Location = new System.Drawing.Point(242, 16);
            this.button_gudi1.Name = "button_gudi1";
            this.button_gudi1.Size = new System.Drawing.Size(80, 33);
            this.button_gudi1.TabIndex = 6;
            this.button_gudi1.Text = "닫기";
            this.button_gudi1.UseVisualStyleBackColor = false;
            // 
            // textBox_gudi2
            // 
            this.textBox_gudi2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi2.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi2.Location = new System.Drawing.Point(238, 252);
            this.textBox_gudi2.Name = "textBox_gudi2";
            this.textBox_gudi2.ReadOnly = true;
            this.textBox_gudi2.Size = new System.Drawing.Size(149, 25);
            this.textBox_gudi2.TabIndex = 23;
            // 
            // textBox_gudi1
            // 
            this.textBox_gudi1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi1.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi1.Location = new System.Drawing.Point(238, 210);
            this.textBox_gudi1.Name = "textBox_gudi1";
            this.textBox_gudi1.ReadOnly = true;
            this.textBox_gudi1.Size = new System.Drawing.Size(149, 25);
            this.textBox_gudi1.TabIndex = 22;
            // 
            // label_gudi6
            // 
            this.label_gudi6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(101, 255);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(56, 17);
            this.label_gudi6.TabIndex = 21;
            this.label_gudi6.Text = "수정시간";
            // 
            // label_gudi5
            // 
            this.label_gudi5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(113, 213);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(44, 17);
            this.label_gudi5.TabIndex = 20;
            this.label_gudi5.Text = "수정자";
            // 
            // comboBox_gudi1
            // 
            this.comboBox_gudi1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.comboBox_gudi1.FormattingEnabled = true;
            this.comboBox_gudi1.Items.AddRange(new object[] {
            "선택",
            "사용",
            "사용 안함"});
            this.comboBox_gudi1.Location = new System.Drawing.Point(238, 168);
            this.comboBox_gudi1.Name = "comboBox_gudi1";
            this.comboBox_gudi1.Size = new System.Drawing.Size(149, 24);
            this.comboBox_gudi1.TabIndex = 19;
            // 
            // placeholderNew2
            // 
            this.placeholderNew2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placeholderNew2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.placeholderNew2.InputType = FinalProject1_winform.validType.Common;
            this.placeholderNew2.Location = new System.Drawing.Point(238, 126);
            this.placeholderNew2.Name = "placeholderNew2";
            this.placeholderNew2.PlaceHolderActiveForeColor = System.Drawing.Color.Gray;
            this.placeholderNew2.PlaceHolderFont = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.placeholderNew2.PlaceHolderForeColor = System.Drawing.Color.DarkGray;
            this.placeholderNew2.PlaceHolderText = "필수 입력 사항입니다.";
            this.placeholderNew2.Size = new System.Drawing.Size(149, 25);
            this.placeholderNew2.TabIndex = 18;
            // 
            // placeholderNew1
            // 
            this.placeholderNew1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placeholderNew1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.placeholderNew1.InputType = FinalProject1_winform.validType.Common;
            this.placeholderNew1.Location = new System.Drawing.Point(238, 84);
            this.placeholderNew1.Name = "placeholderNew1";
            this.placeholderNew1.PlaceHolderActiveForeColor = System.Drawing.Color.Gray;
            this.placeholderNew1.PlaceHolderFont = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.placeholderNew1.PlaceHolderForeColor = System.Drawing.Color.DarkGray;
            this.placeholderNew1.PlaceHolderText = "필수 입력 사항입니다.";
            this.placeholderNew1.Size = new System.Drawing.Size(149, 25);
            this.placeholderNew1.TabIndex = 17;
            // 
            // label_gudi4
            // 
            this.label_gudi4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(97, 171);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(60, 17);
            this.label_gudi4.TabIndex = 16;
            this.label_gudi4.Text = "사용 유무";
            // 
            // label_gudi3
            // 
            this.label_gudi3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi3.Location = new System.Drawing.Point(113, 129);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(44, 17);
            this.label_gudi3.TabIndex = 15;
            this.label_gudi3.Text = "공정명";
            // 
            // label_gudi2
            // 
            this.label_gudi2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_gudi2.Location = new System.Drawing.Point(97, 87);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(60, 17);
            this.label_gudi2.TabIndex = 14;
            this.label_gudi2.Text = "공정 코드";
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(474, 386);
            this.Controls.Add(this.textBox_gudi2);
            this.Controls.Add(this.textBox_gudi1);
            this.Controls.Add(this.label_gudi6);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.comboBox_gudi1);
            this.Controls.Add(this.placeholderNew2);
            this.Controls.Add(this.placeholderNew1);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.label_gudi3);
            this.Controls.Add(this.label_gudi2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 425);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(490, 425);
            this.Name = "frmProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProcess";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PictureBox_gudi pictureBox_gudi1;
        private Label_gudi label_gudi1;
        private System.Windows.Forms.Panel panel2;
        private Button_gudi button_gudi2;
        private Button_gudi button_gudi1;
        private FinalProject1_winform.Controls.TextBox_gudi textBox_gudi2;
        private FinalProject1_winform.Controls.TextBox_gudi textBox_gudi1;
        private Label_gudi label_gudi6;
        private Label_gudi label_gudi5;
        private ComboBox_gudi comboBox_gudi1;
        private PlaceholderNew placeholderNew2;
        private PlaceholderNew placeholderNew1;
        private Label_gudi label_gudi4;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi2;
    }
}