
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
            this.lblFactoryGrade = new FinalProject1_winform.Label_gudi();
            this.lblFactoryName = new FinalProject1_winform.Label_gudi();
            this.btmUpdate = new FinalProject1_winform.Button_gudi();
            this.btnExcel = new FinalProject1_winform.Button_gudi();
            this.btnDelete = new FinalProject1_winform.Button_gudi();
            this.btnInsert = new FinalProject1_winform.Button_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Factory = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
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
            this.panel1.Controls.Add(this.lblFactoryGrade);
            this.panel1.Controls.Add(this.lblFactoryName);
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
            this.btnSearch.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // lblFactoryGrade
            // 
            this.lblFactoryGrade.AutoSize = true;
            this.lblFactoryGrade.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactoryGrade.Location = new System.Drawing.Point(394, 15);
            this.lblFactoryGrade.Name = "lblFactoryGrade";
            this.lblFactoryGrade.Size = new System.Drawing.Size(55, 16);
            this.lblFactoryGrade.TabIndex = 4;
            this.lblFactoryGrade.Text = "■ 시설군";
            // 
            // lblFactoryName
            // 
            this.lblFactoryName.AutoSize = true;
            this.lblFactoryName.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactoryName.Location = new System.Drawing.Point(12, 15);
            this.lblFactoryName.Name = "lblFactoryName";
            this.lblFactoryName.Size = new System.Drawing.Size(82, 16);
            this.lblFactoryName.TabIndex = 0;
            this.lblFactoryName.Text = "■ 시설코드/명";
            // 
            // btmUpdate
            // 
            this.btmUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btmUpdate.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btmUpdate.FlatAppearance.BorderSize = 0;
            this.btmUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmUpdate.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmUpdate.ForeColor = System.Drawing.Color.Black;
            this.btmUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btmUpdate.Image")));
            this.btmUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmUpdate.Location = new System.Drawing.Point(879, 81);
            this.btmUpdate.Name = "btmUpdate";
            this.btmUpdate.Size = new System.Drawing.Size(60, 25);
            this.btmUpdate.TabIndex = 26;
            this.btmUpdate.Text = "수정";
            this.btmUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmUpdate.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnExcel.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1013, 81);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(60, 25);
            this.btnExcel.TabIndex = 22;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnDelete.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(946, 81);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 25);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnInsert.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(812, 81);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(60, 25);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "등록";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.btmUpdate);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Button_gudi btnSearch;
        private Label_gudi lblFactoryGrade;
        private Label_gudi lblFactoryName;
        private Button_gudi btmUpdate;
        private Button_gudi btnExcel;
        private Button_gudi btnDelete;
        private Button_gudi btnInsert;
        private Label_gudi label_gudi4;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private ComboBox_gudi cboFactoryGrade;
        private Controls.TextBox_gudi txtFactoryCode;
        private DGV_gudi dgv_Factory;
    }
}