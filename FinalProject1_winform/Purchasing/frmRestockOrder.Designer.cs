
namespace FinalProject1_winform
{
    partial class frmRestockOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestockOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_gudi5 = new FinalProject1_winform.Button_gudi();
            this.btnAddRestock = new FinalProject1_winform.Button_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv1 = new FinalProject1_winform.DGV_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.dtp1 = new FinalProject1_winform.UcDateTimePicker();
            this.cboProductID = new FinalProject1_winform.ComboBox_gudi();
            this.cboPlanID = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.btnSearch = new FinalProject1_winform.Button_gudi();
            this.button_gudi4 = new FinalProject1_winform.Button_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_gudi5
            // 
            this.button_gudi5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi5.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi5.FlatAppearance.BorderSize = 0;
            this.button_gudi5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi5.ForeColor = System.Drawing.Color.Black;
            this.button_gudi5.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi5.Image")));
            this.button_gudi5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi5.Location = new System.Drawing.Point(1170, 109);
            this.button_gudi5.Name = "button_gudi5";
            this.button_gudi5.Size = new System.Drawing.Size(60, 25);
            this.button_gudi5.TabIndex = 28;
            this.button_gudi5.Text = "엑셀";
            this.button_gudi5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi5.UseVisualStyleBackColor = false;
            // 
            // btnAddRestock
            // 
            this.btnAddRestock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnAddRestock.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnAddRestock.FlatAppearance.BorderSize = 0;
            this.btnAddRestock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRestock.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnAddRestock.ForeColor = System.Drawing.Color.Black;
            this.btnAddRestock.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRestock.Image")));
            this.btnAddRestock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRestock.Location = new System.Drawing.Point(1038, 109);
            this.btnAddRestock.Name = "btnAddRestock";
            this.btnAddRestock.Size = new System.Drawing.Size(60, 25);
            this.btnAddRestock.TabIndex = 30;
            this.btnAddRestock.Text = "발주";
            this.btnAddRestock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRestock.UseVisualStyleBackColor = false;
            this.btnAddRestock.Click += new System.EventHandler(this.btnAddRestock_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv1);
            this.panel2.Location = new System.Drawing.Point(18, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 570);
            this.panel2.TabIndex = 26;
            // 
            // dgv1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.CheckBoxAll = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dgv1.HeaderCheckStatus = false;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(1212, 570);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv1_CellFormatting);
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(18, 115);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 25;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.label_gudi2);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.cboProductID);
            this.panel1.Controls.Add(this.cboPlanID);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(18, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 79);
            this.panel1.TabIndex = 24;
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(779, 28);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(48, 17);
            this.label_gudi2.TabIndex = 15;
            this.label_gudi2.Text = "■ 품목";
            // 
            // dtp1
            // 
            this.dtp1.FromDate = new System.DateTime(2021, 6, 25, 14, 0, 31, 72);
            this.dtp1.Location = new System.Drawing.Point(461, 20);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(257, 30);
            this.dtp1.TabIndex = 14;
            this.dtp1.ToDate = new System.DateTime(2021, 6, 25, 14, 0, 31, 69);
            // 
            // cboProductID
            // 
            this.cboProductID.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboProductID.FormattingEnabled = true;
            this.cboProductID.Location = new System.Drawing.Point(847, 25);
            this.cboProductID.Name = "cboProductID";
            this.cboProductID.Size = new System.Drawing.Size(194, 24);
            this.cboProductID.TabIndex = 13;
            // 
            // cboPlanID
            // 
            this.cboPlanID.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboPlanID.FormattingEnabled = true;
            this.cboPlanID.Location = new System.Drawing.Point(104, 26);
            this.cboPlanID.Name = "cboPlanID";
            this.cboPlanID.Size = new System.Drawing.Size(194, 24);
            this.cboPlanID.TabIndex = 13;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(372, 28);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(60, 17);
            this.label_gudi3.TabIndex = 11;
            this.label_gudi3.Text = "■ 발주일";
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(36, 30);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(62, 17);
            this.label_gudi1.TabIndex = 12;
            this.label_gudi1.Text = "■ PlanID";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnSearch.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1122, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 25);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button_gudi8_Click);
            // 
            // button_gudi4
            // 
            this.button_gudi4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gudi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi4.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi4.FlatAppearance.BorderSize = 0;
            this.button_gudi4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi4.ForeColor = System.Drawing.Color.Black;
            this.button_gudi4.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi4.Image")));
            this.button_gudi4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi4.Location = new System.Drawing.Point(1104, 109);
            this.button_gudi4.Name = "button_gudi4";
            this.button_gudi4.Size = new System.Drawing.Size(60, 25);
            this.button_gudi4.TabIndex = 31;
            this.button_gudi4.Text = "MRP";
            this.button_gudi4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi4.UseVisualStyleBackColor = false;
            // 
            // label_gudi5
            // 
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_gudi5.Location = new System.Drawing.Point(49, 116);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(82, 18);
            this.label_gudi5.TabIndex = 17;
            this.label_gudi5.Text = "정규 발주";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 30;
            // 
            // frmRestockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1248, 731);
            this.Controls.Add(this.label_gudi5);
            this.Controls.Add(this.button_gudi4);
            this.Controls.Add(this.button_gudi5);
            this.Controls.Add(this.btnAddRestock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRestockOrder";
            this.Text = "정규발주";
            this.Load += new System.EventHandler(this.frmRestockOrder_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button_gudi button_gudi5;
        private Button_gudi btnAddRestock;
        private System.Windows.Forms.Panel panel2;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel1;
        private Button_gudi btnSearch;
        private Button_gudi button_gudi4;
        private UcDateTimePicker dtp1;
        private ComboBox_gudi cboPlanID;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi1;
        private Label_gudi label_gudi5;
        private DGV_gudi dgv1;
        private Label_gudi label_gudi2;
        private ComboBox_gudi cboProductID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
