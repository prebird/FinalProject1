
namespace FinalProject1_winform
{
    partial class frmWorkOrderMake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkOrderMake));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItem = new FinalProject1_winform.Controls.TextBox_gudi();
            this.cboEquipment = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi5 = new FinalProject1_winform.Label_gudi();
            this.dateControl = new FinalProject1_winform.UcDateTimePicker();
            this.label_gudi2 = new FinalProject1_winform.Label_gudi();
            this.txtPlanID = new FinalProject1_winform.Controls.TextBox_gudi();
            this.btnSearch = new FinalProject1_winform.Button_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.btnMake = new FinalProject1_winform.Button_gudi();
            this.btnDelete = new FinalProject1_winform.Button_gudi();
            this.btnExcel = new FinalProject1_winform.Button_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.txtItem);
            this.panel1.Controls.Add(this.cboEquipment);
            this.panel1.Controls.Add(this.label_gudi5);
            this.panel1.Controls.Add(this.dateControl);
            this.panel1.Controls.Add(this.label_gudi2);
            this.panel1.Controls.Add(this.txtPlanID);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label_gudi3);
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 93);
            this.panel1.TabIndex = 4;
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtItem.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtItem.Location = new System.Drawing.Point(476, 14);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(192, 25);
            this.txtItem.TabIndex = 17;
            // 
            // cboEquipment
            // 
            this.cboEquipment.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.cboEquipment.FormattingEnabled = true;
            this.cboEquipment.Location = new System.Drawing.Point(788, 15);
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(193, 24);
            this.cboEquipment.TabIndex = 16;
            // 
            // label_gudi5
            // 
            this.label_gudi5.AutoSize = true;
            this.label_gudi5.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi5.Location = new System.Drawing.Point(12, 18);
            this.label_gudi5.Name = "label_gudi5";
            this.label_gudi5.Size = new System.Drawing.Size(84, 17);
            this.label_gudi5.TabIndex = 14;
            this.label_gudi5.Text = "■ 계획시작일";
            // 
            // dateControl
            // 
            this.dateControl.FromDate = new System.DateTime(2021, 6, 27, 19, 26, 13, 265);
            this.dateControl.Location = new System.Drawing.Point(99, 10);
            this.dateControl.Name = "dateControl";
            this.dateControl.Size = new System.Drawing.Size(257, 30);
            this.dateControl.TabIndex = 1;
            this.dateControl.ToDate = new System.DateTime(2021, 6, 27, 19, 26, 13, 259);
            // 
            // label_gudi2
            // 
            this.label_gudi2.AutoSize = true;
            this.label_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi2.Location = new System.Drawing.Point(711, 18);
            this.label_gudi2.Name = "label_gudi2";
            this.label_gudi2.Size = new System.Drawing.Size(48, 17);
            this.label_gudi2.TabIndex = 12;
            this.label_gudi2.Text = "■ 설비";
            // 
            // txtPlanID
            // 
            this.txtPlanID.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.txtPlanID.InputType = FinalProject1_winform.Controls.validType.Common;
            this.txtPlanID.Location = new System.Drawing.Point(102, 51);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.Size = new System.Drawing.Size(192, 25);
            this.txtPlanID.TabIndex = 10;
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
            this.btnSearch.Location = new System.Drawing.Point(979, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 25);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(400, 18);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(60, 17);
            this.label_gudi3.TabIndex = 4;
            this.label_gudi3.Text = "■ 품목명";
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(12, 54);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(62, 17);
            this.label_gudi1.TabIndex = 0;
            this.label_gudi1.Text = "■ PlanID";
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(43, 113);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(56, 17);
            this.label_gudi4.TabIndex = 32;
            this.label_gudi4.Text = "작업지시";
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(12, 111);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 31;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // btnMake
            // 
            this.btnMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnMake.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnMake.FlatAppearance.BorderSize = 0;
            this.btnMake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMake.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnMake.ForeColor = System.Drawing.Color.Black;
            this.btnMake.Image = ((System.Drawing.Image)(resources.GetObject("btnMake.Image")));
            this.btnMake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMake.Location = new System.Drawing.Point(836, 109);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(109, 25);
            this.btnMake.TabIndex = 33;
            this.btnMake.Text = "작업지시확정";
            this.btnMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMake.UseVisualStyleBackColor = false;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnDelete.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(951, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 25);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.btnExcel.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1017, 109);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(60, 25);
            this.btnExcel.TabIndex = 35;
            this.btnExcel.Text = "엑셀";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Location = new System.Drawing.Point(12, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 475);
            this.panel2.TabIndex = 36;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1066, 475);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // frmWorkOrderMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.pictureBox_gudi2);
            this.Controls.Add(this.panel1);
            this.Name = "frmWorkOrderMake";
            this.Text = "frmWorkOrderMake";
            this.Load += new System.EventHandler(this.frmWorkOrderMake_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Label_gudi label_gudi5;
        private UcDateTimePicker dateControl;
        private Label_gudi label_gudi2;
        private Controls.TextBox_gudi txtPlanID;
        private Button_gudi btnSearch;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi1;
        private Label_gudi label_gudi4;
        private PictureBox_gudi pictureBox_gudi2;
        private Button_gudi btnMake;
        private Button_gudi btnDelete;
        private Button_gudi btnExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvList;
        private ComboBox_gudi cboEquipment;
        private Controls.TextBox_gudi txtItem;
    }
}
