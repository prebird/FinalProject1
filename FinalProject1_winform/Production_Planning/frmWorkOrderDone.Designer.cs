
namespace FinalProject1_winform
{
    partial class frmWorkOrderDone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkOrderDone));
            this.label_gudi4 = new FinalProject1_winform.Label_gudi();
            this.pictureBox_gudi2 = new FinalProject1_winform.PictureBox_gudi();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.pictureBox_gudi1 = new FinalProject1_winform.PictureBox_gudi();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_gudi12 = new FinalProject1_winform.Button_gudi();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_gudi2 = new FinalProject1_winform.Button_gudi();
            this.button_gudi1 = new FinalProject1_winform.Button_gudi();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_gudi4
            // 
            this.label_gudi4.AutoSize = true;
            this.label_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi4.Location = new System.Drawing.Point(43, 14);
            this.label_gudi4.Name = "label_gudi4";
            this.label_gudi4.Size = new System.Drawing.Size(84, 17);
            this.label_gudi4.TabIndex = 38;
            this.label_gudi4.Text = "작업실적 등록";
            // 
            // pictureBox_gudi2
            // 
            this.pictureBox_gudi2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi2.Image")));
            this.pictureBox_gudi2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_gudi2.Name = "pictureBox_gudi2";
            this.pictureBox_gudi2.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi2.TabIndex = 37;
            this.pictureBox_gudi2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 137);
            this.panel2.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 137);
            this.dataGridView1.TabIndex = 0;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(43, 182);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(80, 17);
            this.label_gudi1.TabIndex = 41;
            this.label_gudi1.Text = "실적등록이력";
            // 
            // pictureBox_gudi1
            // 
            this.pictureBox_gudi1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_gudi1.Image")));
            this.pictureBox_gudi1.Location = new System.Drawing.Point(12, 180);
            this.pictureBox_gudi1.Name = "pictureBox_gudi1";
            this.pictureBox_gudi1.Size = new System.Drawing.Size(25, 19);
            this.pictureBox_gudi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_gudi1.TabIndex = 40;
            this.pictureBox_gudi1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(12, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 206);
            this.panel1.TabIndex = 42;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1066, 206);
            this.dataGridView2.TabIndex = 0;
            // 
            // button_gudi12
            // 
            this.button_gudi12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.button_gudi12.ButtonType = FinalProject1_winform.ButtonStyle.Middle;
            this.button_gudi12.FlatAppearance.BorderSize = 0;
            this.button_gudi12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_gudi12.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 10F);
            this.button_gudi12.ForeColor = System.Drawing.Color.Black;
            this.button_gudi12.Image = ((System.Drawing.Image)(resources.GetObject("button_gudi12.Image")));
            this.button_gudi12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_gudi12.Location = new System.Drawing.Point(989, 177);
            this.button_gudi12.Name = "button_gudi12";
            this.button_gudi12.Size = new System.Drawing.Size(89, 25);
            this.button_gudi12.TabIndex = 43;
            this.button_gudi12.Text = "실적취소";
            this.button_gudi12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_gudi12.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button_gudi2);
            this.panel3.Controls.Add(this.button_gudi1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 65);
            this.panel3.TabIndex = 44;
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
            this.button_gudi2.Location = new System.Drawing.Point(353, 16);
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
            this.button_gudi1.Location = new System.Drawing.Point(623, 16);
            this.button_gudi1.Name = "button_gudi1";
            this.button_gudi1.Size = new System.Drawing.Size(80, 33);
            this.button_gudi1.TabIndex = 6;
            this.button_gudi1.Text = "닫기";
            this.button_gudi1.UseVisualStyleBackColor = false;
            // 
            // frmWorkOrderDone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_gudi12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.pictureBox_gudi1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_gudi4);
            this.Controls.Add(this.pictureBox_gudi2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1109, 519);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1109, 519);
            this.Name = "frmWorkOrderDone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmWorkOrderDone";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_gudi1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label_gudi label_gudi4;
        private PictureBox_gudi pictureBox_gudi2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Label_gudi label_gudi1;
        private PictureBox_gudi pictureBox_gudi1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Button_gudi button_gudi12;
        private System.Windows.Forms.Panel panel3;
        private Button_gudi button_gudi2;
        private Button_gudi button_gudi1;
    }
}
