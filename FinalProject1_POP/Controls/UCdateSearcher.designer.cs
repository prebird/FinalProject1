
namespace FinalProject1_winform
{
    partial class UCdateSearcher
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnToday = new FinalProject1_winform.Button_gudi();
            this.button_gudi1 = new FinalProject1_winform.Button_gudi();
            this.button_gudi2 = new FinalProject1_winform.Button_gudi();
            this.button_gudi3 = new FinalProject1_winform.Button_gudi();
            this.button_gudi4 = new FinalProject1_winform.Button_gudi();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 26);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(161, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(183, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(154, 26);
            this.dateTimePicker2.TabIndex = 47;
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.btnToday.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(3, 38);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(62, 26);
            this.btnToday.TabIndex = 52;
            this.btnToday.Text = "오늘";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // button_gudi1
            // 
            this.button_gudi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.button_gudi1.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.button_gudi1.FlatAppearance.BorderSize = 0;
            this.button_gudi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_gudi1.ForeColor = System.Drawing.Color.White;
            this.button_gudi1.Location = new System.Drawing.Point(71, 38);
            this.button_gudi1.Name = "button_gudi1";
            this.button_gudi1.Size = new System.Drawing.Size(62, 26);
            this.button_gudi1.TabIndex = 52;
            this.button_gudi1.Text = "일주일";
            this.button_gudi1.UseVisualStyleBackColor = false;
            this.button_gudi1.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // button_gudi2
            // 
            this.button_gudi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.button_gudi2.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.button_gudi2.FlatAppearance.BorderSize = 0;
            this.button_gudi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_gudi2.ForeColor = System.Drawing.Color.White;
            this.button_gudi2.Location = new System.Drawing.Point(139, 38);
            this.button_gudi2.Name = "button_gudi2";
            this.button_gudi2.Size = new System.Drawing.Size(62, 26);
            this.button_gudi2.TabIndex = 52;
            this.button_gudi2.Text = "한달";
            this.button_gudi2.UseVisualStyleBackColor = false;
            this.button_gudi2.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // button_gudi3
            // 
            this.button_gudi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.button_gudi3.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.button_gudi3.FlatAppearance.BorderSize = 0;
            this.button_gudi3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi3.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_gudi3.ForeColor = System.Drawing.Color.White;
            this.button_gudi3.Location = new System.Drawing.Point(207, 38);
            this.button_gudi3.Name = "button_gudi3";
            this.button_gudi3.Size = new System.Drawing.Size(62, 26);
            this.button_gudi3.TabIndex = 52;
            this.button_gudi3.Text = "3개월";
            this.button_gudi3.UseVisualStyleBackColor = false;
            this.button_gudi3.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // button_gudi4
            // 
            this.button_gudi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.button_gudi4.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.button_gudi4.FlatAppearance.BorderSize = 0;
            this.button_gudi4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi4.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_gudi4.ForeColor = System.Drawing.Color.White;
            this.button_gudi4.Location = new System.Drawing.Point(275, 38);
            this.button_gudi4.Name = "button_gudi4";
            this.button_gudi4.Size = new System.Drawing.Size(62, 26);
            this.button_gudi4.TabIndex = 52;
            this.button_gudi4.Text = "6개월";
            this.button_gudi4.UseVisualStyleBackColor = false;
            this.button_gudi4.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // UCdateSearcher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button_gudi4);
            this.Controls.Add(this.button_gudi3);
            this.Controls.Add(this.button_gudi2);
            this.Controls.Add(this.button_gudi1);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Name = "UCdateSearcher";
            this.Size = new System.Drawing.Size(340, 65);
            this.Load += new System.EventHandler(this.UCdateSearcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button_gudi btnToday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Button_gudi button_gudi1;
        private Button_gudi button_gudi2;
        private Button_gudi button_gudi3;
        private Button_gudi button_gudi4;
    }
}
