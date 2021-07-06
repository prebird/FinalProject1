
namespace FinalProject1_winform
{
    partial class frmBOMInsert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_JaItemMine = new FinalProject1_winform.DGV_gudi();
            this.label_gudi8 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.cbo_YN = new FinalProject1_winform.ComboBox_gudi();
            this.dgv_JaItemAll = new FinalProject1_winform.DGV_gudi();
            this.label_gudi15 = new FinalProject1_winform.Label_gudi();
            this.txt_Content = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi13 = new FinalProject1_winform.Label_gudi();
            this.label_gudi10 = new FinalProject1_winform.Label_gudi();
            this.label_gudi9 = new FinalProject1_winform.Label_gudi();
            this.cbo_DemandYN = new FinalProject1_winform.ComboBox_gudi();
            this.txt_UseQTY = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi12 = new FinalProject1_winform.Label_gudi();
            this.btn_Insert = new FinalProject1_winform.Button_gudi();
            this.btn_Cancel = new FinalProject1_winform.Button_gudi();
            this.label_gudi7 = new FinalProject1_winform.Label_gudi();
            this.lblItemID = new FinalProject1_winform.Label_gudi();
            this.txt_Category = new FinalProject1_winform.Controls.TextBox_gudi();
            this.txt_UnitQTY = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.txt_ItemCode = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi6 = new FinalProject1_winform.Label_gudi();
            this.txt_ItemName = new FinalProject1_winform.Controls.TextBox_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JaItemMine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JaItemAll)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.lblItemID);
            this.panel4.Controls.Add(this.txt_Category);
            this.panel4.Controls.Add(this.txt_UnitQTY);
            this.panel4.Controls.Add(this.label_gudi5);
            this.panel4.Controls.Add(this.txt_ItemCode);
            this.panel4.Controls.Add(this.label_gudi3);
            this.panel4.Controls.Add(this.label_gudi6);
            this.panel4.Controls.Add(this.txt_ItemName);
            this.panel4.Controls.Add(this.label_gudi4);
            this.panel4.Location = new System.Drawing.Point(22, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(544, 119);
            this.panel4.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.cbo_YN);
            this.panel2.Controls.Add(this.dgv_JaItemAll);
            this.panel2.Controls.Add(this.label_gudi15);
            this.panel2.Controls.Add(this.txt_Content);
            this.panel2.Controls.Add(this.label_gudi13);
            this.panel2.Controls.Add(this.label_gudi10);
            this.panel2.Controls.Add(this.label_gudi9);
            this.panel2.Controls.Add(this.cbo_DemandYN);
            this.panel2.Controls.Add(this.txt_UseQTY);
            this.panel2.Controls.Add(this.label_gudi12);
            this.panel2.Location = new System.Drawing.Point(574, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 539);
            this.panel2.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.dgv_JaItemMine);
            this.panel1.Location = new System.Drawing.Point(22, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 379);
            this.panel1.TabIndex = 51;
            // 
            // dgv_JaItemMine
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_JaItemMine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_JaItemMine.BackgroundColor = System.Drawing.Color.White;
            this.dgv_JaItemMine.CheckBoxAll = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_JaItemMine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_JaItemMine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_JaItemMine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_JaItemMine.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_JaItemMine.HeaderCheckStatus = false;
            this.dgv_JaItemMine.Location = new System.Drawing.Point(0, 0);
            this.dgv_JaItemMine.Name = "dgv_JaItemMine";
            this.dgv_JaItemMine.RowHeadersVisible = false;
            this.dgv_JaItemMine.RowTemplate.Height = 23;
            this.dgv_JaItemMine.Size = new System.Drawing.Size(544, 379);
            this.dgv_JaItemMine.TabIndex = 0;
            // 
            // label_gudi8
            // 
            this.label_gudi8.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi8.Location = new System.Drawing.Point(571, 9);
            this.label_gudi8.Name = "label_gudi8";
            this.label_gudi8.Size = new System.Drawing.Size(94, 18);
            this.label_gudi8.TabIndex = 50;
            this.label_gudi8.Text = "BOM 신규 등록";
            // 
            // label_gudi1
            // 
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi1.Location = new System.Drawing.Point(19, 171);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(99, 18);
            this.label_gudi1.TabIndex = 45;
            this.label_gudi1.Text = "자품목 등록 내역";
            // 
            // cbo_YN
            // 
            this.cbo_YN.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_YN.FormattingEnabled = true;
            this.cbo_YN.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbo_YN.Location = new System.Drawing.Point(113, 321);
            this.cbo_YN.Name = "cbo_YN";
            this.cbo_YN.Size = new System.Drawing.Size(134, 24);
            this.cbo_YN.TabIndex = 76;
            // 
            // dgv_JaItemAll
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv_JaItemAll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_JaItemAll.BackgroundColor = System.Drawing.Color.White;
            this.dgv_JaItemAll.CheckBoxAll = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_JaItemAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_JaItemAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_JaItemAll.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv_JaItemAll.HeaderCheckStatus = false;
            this.dgv_JaItemAll.Location = new System.Drawing.Point(3, 32);
            this.dgv_JaItemAll.Name = "dgv_JaItemAll";
            this.dgv_JaItemAll.RowHeadersVisible = false;
            this.dgv_JaItemAll.RowTemplate.Height = 23;
            this.dgv_JaItemAll.Size = new System.Drawing.Size(479, 226);
            this.dgv_JaItemAll.TabIndex = 75;
            // 
            // label_gudi15
            // 
            this.label_gudi15.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi15.Location = new System.Drawing.Point(11, 10);
            this.label_gudi15.Name = "label_gudi15";
            this.label_gudi15.Size = new System.Drawing.Size(92, 18);
            this.label_gudi15.TabIndex = 52;
            this.label_gudi15.Text = "자품목 전체 조회";
            // 
            // txt_Content
            // 
            this.txt_Content.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_Content.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_Content.Location = new System.Drawing.Point(112, 360);
            this.txt_Content.Multiline = true;
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(358, 133);
            this.txt_Content.TabIndex = 70;
            // 
            // label_gudi13
            // 
            this.label_gudi13.AutoSize = true;
            this.label_gudi13.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi13.Location = new System.Drawing.Point(31, 360);
            this.label_gudi13.Name = "label_gudi13";
            this.label_gudi13.Size = new System.Drawing.Size(48, 17);
            this.label_gudi13.TabIndex = 69;
            this.label_gudi13.Text = "■ 비고";
            // 
            // label_gudi10
            // 
            this.label_gudi10.AutoSize = true;
            this.label_gudi10.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi10.Location = new System.Drawing.Point(254, 325);
            this.label_gudi10.Name = "label_gudi10";
            this.label_gudi10.Size = new System.Drawing.Size(72, 17);
            this.label_gudi10.TabIndex = 68;
            this.label_gudi10.Text = "■ 소요계획";
            // 
            // label_gudi9
            // 
            this.label_gudi9.AutoSize = true;
            this.label_gudi9.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi9.Location = new System.Drawing.Point(31, 324);
            this.label_gudi9.Name = "label_gudi9";
            this.label_gudi9.Size = new System.Drawing.Size(72, 17);
            this.label_gudi9.TabIndex = 66;
            this.label_gudi9.Text = "■ 사용유무";
            // 
            // cbo_DemandYN
            // 
            this.cbo_DemandYN.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cbo_DemandYN.FormattingEnabled = true;
            this.cbo_DemandYN.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbo_DemandYN.Location = new System.Drawing.Point(336, 321);
            this.cbo_DemandYN.Name = "cbo_DemandYN";
            this.cbo_DemandYN.Size = new System.Drawing.Size(134, 24);
            this.cbo_DemandYN.TabIndex = 65;
            // 
            // txt_UseQTY
            // 
            this.txt_UseQTY.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_UseQTY.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_UseQTY.Location = new System.Drawing.Point(112, 282);
            this.txt_UseQTY.Name = "txt_UseQTY";
            this.txt_UseQTY.Size = new System.Drawing.Size(135, 25);
            this.txt_UseQTY.TabIndex = 64;
            // 
            // label_gudi12
            // 
            this.label_gudi12.AutoSize = true;
            this.label_gudi12.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi12.Location = new System.Drawing.Point(31, 286);
            this.label_gudi12.Name = "label_gudi12";
            this.label_gudi12.Size = new System.Drawing.Size(60, 17);
            this.label_gudi12.TabIndex = 63;
            this.label_gudi12.Text = "■ 소요량";
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btn_Insert.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Insert.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.Location = new System.Drawing.Point(487, 577);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 33);
            this.btn_Insert.TabIndex = 41;
            this.btn_Insert.Text = "저장";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.btn_Cancel.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(573, 577);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 33);
            this.btn_Cancel.TabIndex = 42;
            this.btn_Cancel.Text = "닫기";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // label_gudi7
            // 
            this.label_gudi7.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi7.Location = new System.Drawing.Point(19, 11);
            this.label_gudi7.Name = "label_gudi7";
            this.label_gudi7.Size = new System.Drawing.Size(84, 18);
            this.label_gudi7.TabIndex = 40;
            this.label_gudi7.Text = "모품목 정보";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.lblItemID.Location = new System.Drawing.Point(37, 10);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(72, 17);
            this.lblItemID.TabIndex = 50;
            this.lblItemID.Text = "■ 품목번호";
            // 
            // txt_Category
            // 
            this.txt_Category.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_Category.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_Category.Location = new System.Drawing.Point(117, 29);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(135, 25);
            this.txt_Category.TabIndex = 49;
            // 
            // txt_UnitQTY
            // 
            this.txt_UnitQTY.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_UnitQTY.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_UnitQTY.Location = new System.Drawing.Point(362, 67);
            this.txt_UnitQTY.Name = "txt_UnitQTY";
            this.txt_UnitQTY.Size = new System.Drawing.Size(135, 25);
            this.txt_UnitQTY.TabIndex = 48;
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(281, 70);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(72, 17);
            this.label_gudi5.TabIndex = 47;
            this.label_gudi5.Text = "■ 단위수량";
            // 
            // txt_ItemCode
            // 
            this.txt_ItemCode.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_ItemCode.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_ItemCode.Location = new System.Drawing.Point(117, 67);
            this.txt_ItemCode.Name = "txt_ItemCode";
            this.txt_ItemCode.Size = new System.Drawing.Size(135, 25);
            this.txt_ItemCode.TabIndex = 46;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(36, 70);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(72, 17);
            this.label_gudi3.TabIndex = 45;
            this.label_gudi3.Text = "■ 품목코드";
            // 
            // label_gudi6
            // 
            this.label_gudi6.AutoSize = true;
            this.label_gudi6.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi6.Location = new System.Drawing.Point(37, 32);
            this.label_gudi6.Name = "label_gudi6";
            this.label_gudi6.Size = new System.Drawing.Size(72, 17);
            this.label_gudi6.TabIndex = 43;
            this.label_gudi6.Text = "■ 품목유형";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txt_ItemName.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txt_ItemName.Location = new System.Drawing.Point(362, 29);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(135, 25);
            this.txt_ItemName.TabIndex = 42;
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(281, 32);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(60, 17);
            this.label_gudi4.TabIndex = 41;
            this.label_gudi4.Text = "■ 품목명";
            // 
            // frmBOMInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1072, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_gudi8);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label_gudi7);
            this.Controls.Add(this.panel4);
            this.Name = "frmBOMInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBOMInsert";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JaItemMine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JaItemAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button_gudi btn_Insert;
        private Button_gudi btn_Cancel;
        private Label_gudi label_gudi7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private Label_gudi label_gudi1;
        private Label_gudi label_gudi6;
        private Controls.TextBox_gudi txt_ItemName;
        private Label_gudi label_gudi4;
        private Controls.TextBox_gudi txt_ItemCode;
        private Label_gudi label_gudi3;
        private Controls.TextBox_gudi txt_UnitQTY;
        private Label_gudi label_gudi5;
        private Controls.TextBox_gudi txt_Content;
        private Label_gudi label_gudi13;
        private Label_gudi label_gudi10;
        private Label_gudi label_gudi9;
        private ComboBox_gudi cbo_DemandYN;
        private Controls.TextBox_gudi txt_UseQTY;
        private Label_gudi label_gudi12;
        private Label_gudi label_gudi8;
        private System.Windows.Forms.Panel panel1;
        private Label_gudi label_gudi15;
        private Controls.TextBox_gudi txt_Category;
        private Label_gudi lblItemID;
        private DGV_gudi dgv_JaItemAll;
        private DGV_gudi dgv_JaItemMine;
        private ComboBox_gudi cbo_YN;
    }
}