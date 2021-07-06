
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFactoryGrade = new FinalProject1_winform.ComboBox_gudi();
            this.txtFactoryCode = new FinalProject1_winform.Controls.TextBox_gudi();
            this.btnSearch = new FinalProject1_winform.Button_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.button_gudi7 = new FinalProject1_winform.Button_gudi();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            this.button_gudi6 = new FinalProject1_winform.Button_gudi();
            this.button_gudi3 = new FinalProject1_winform.Button_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.dgv_Factory = new FinalProject1_winform.DGV_gudi();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.cboFactoryGrade);
            this.panel1.Controls.Add(this.txtFactoryCode);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 50);
            this.panel1.TabIndex = 2;
            // 
            // cboFactoryGrade
            // 
            this.cboFactoryGrade.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboFactoryGrade.FormattingEnabled = true;
            this.cboFactoryGrade.Location = new System.Drawing.Point(472, 11);
            this.cboFactoryGrade.Name = "cboFactoryGrade";
            this.cboFactoryGrade.Size = new System.Drawing.Size(172, 24);
            this.cboFactoryGrade.TabIndex = 11;
            // 
            // txtFactoryCode
            // 
            this.txtFactoryCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtFactoryCode.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtFactoryCode.Location = new System.Drawing.Point(112, 10);
            this.txtFactoryCode.Name = "txtFactoryCode";
            this.txtFactoryCode.Size = new System.Drawing.Size(198, 25);
            this.txtFactoryCode.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSearch.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(959, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 25);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
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
            this.button_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel2.Controls.Add(this.dgv_Factory);
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
            // dgv_Factory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_Factory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Factory.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Factory.CheckBoxAll = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Factory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Factory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Factory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Factory.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_Factory.HeaderCheckStatus = false;
            this.dgv_Factory.Location = new System.Drawing.Point(0, 0);
            this.dgv_Factory.Name = "dgv_Factory";
            this.dgv_Factory.RowHeadersVisible = false;
            this.dgv_Factory.RowTemplate.Height = 23;
            this.dgv_Factory.Size = new System.Drawing.Size(1057, 466);
            this.dgv_Factory.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.frmFactory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Button_gudi btnSearch;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi1;
        private Button_gudi button_gudi7;
        private Button_gudi button_gudi5;
        private Button_gudi button_gudi6;
        private Button_gudi button_gudi3;
        private Label_gudi label_gudi4;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private ComboBox_gudi cboFactoryGrade;
        private Controls.TextBox_gudi txtFactoryCode;
        private DGV_gudi dgv_Factory;
    }
}