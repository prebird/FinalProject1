
namespace FinalProject1_winform.Production_Planning
{
    partial class frmProductionPlanningList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionPlanningList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_gudi1 = new FinalProject1_winform.Controls.TextBox_gudi();
            this.button_gudi8 = new FinalProject1_winform.Button_gudi();
            this.comboBox_gudi1 = new FinalProject1_winform.ComboBox_gudi();
            this.label_gudi3 = new FinalProject1_winform.Label_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 50);
            this.panel1.TabIndex = 3;
            // 
            // textBox_gudi1
            // 
            this.textBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.textBox_gudi1.InputType = FinalProject1_winform.Controls.validType.Common;
            this.textBox_gudi1.Location = new System.Drawing.Point(107, 10);
            this.textBox_gudi1.Name = "textBox_gudi1";
            this.textBox_gudi1.Size = new System.Drawing.Size(192, 25);
            this.textBox_gudi1.TabIndex = 10;
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
            this.button_gudi8.Location = new System.Drawing.Point(959, 11);
            this.button_gudi8.Name = "button_gudi8";
            this.button_gudi8.Size = new System.Drawing.Size(78, 25);
            this.button_gudi8.TabIndex = 9;
            this.button_gudi8.Text = "조회";
            this.button_gudi8.UseVisualStyleBackColor = false;
            // 
            // comboBox_gudi1
            // 
            this.comboBox_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.comboBox_gudi1.FormattingEnabled = true;
            this.comboBox_gudi1.Location = new System.Drawing.Point(460, 11);
            this.comboBox_gudi1.Name = "comboBox_gudi1";
            this.comboBox_gudi1.Size = new System.Drawing.Size(156, 24);
            this.comboBox_gudi1.TabIndex = 5;
            // 
            // label_gudi3
            // 
            this.label_gudi3.AutoSize = true;
            this.label_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi3.Location = new System.Drawing.Point(394, 15);
            this.label_gudi3.Name = "label_gudi3";
            this.label_gudi3.Size = new System.Drawing.Size(60, 17);
            this.label_gudi3.TabIndex = 4;
            this.label_gudi3.Text = "■ 시설군";
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(12, 15);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(89, 17);
            this.label_gudi1.TabIndex = 0;
            this.label_gudi1.Text = "■ 시설코드/명";
            // 
            // frmProductionPlanningList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.panel1);
            this.Name = "frmProductionPlanningList";
            this.Text = "frmProductionPlanningList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Controls.TextBox_gudi textBox_gudi1;
        private Button_gudi button_gudi8;
        private ComboBox_gudi comboBox_gudi1;
        private Label_gudi label_gudi3;
        private Label_gudi label_gudi1;
    }
}
