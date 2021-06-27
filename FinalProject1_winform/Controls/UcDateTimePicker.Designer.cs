
namespace FinalProject1_winform
{
    partial class UcDateTimePicker
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
            this.dateTimePicker_gudi1 = new FinalProject1_winform.DateTimePicker_gudi();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.dateTimePicker_gudi2 = new FinalProject1_winform.DateTimePicker_gudi();
            this.SuspendLayout();
            // 
            // dateTimePicker_gudi1
            // 
            this.dateTimePicker_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dateTimePicker_gudi1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_gudi1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker_gudi1.Name = "dateTimePicker_gudi1";
            this.dateTimePicker_gudi1.Size = new System.Drawing.Size(112, 25);
            this.dateTimePicker_gudi1.TabIndex = 0;
            // 
            // label_gudi1
            // 
            this.label_gudi1.AutoSize = true;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.label_gudi1.Location = new System.Drawing.Point(121, 9);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(16, 17);
            this.label_gudi1.TabIndex = 1;
            this.label_gudi1.Text = "~";
            // 
            // dateTimePicker_gudi2
            // 
            this.dateTimePicker_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoM00", 10F);
            this.dateTimePicker_gudi2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_gudi2.Location = new System.Drawing.Point(143, 3);
            this.dateTimePicker_gudi2.Name = "dateTimePicker_gudi2";
            this.dateTimePicker_gudi2.Size = new System.Drawing.Size(112, 25);
            this.dateTimePicker_gudi2.TabIndex = 0;
            // 
            // UcDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_gudi1);
            this.Controls.Add(this.dateTimePicker_gudi2);
            this.Controls.Add(this.dateTimePicker_gudi1);
            this.Name = "UcDateTimePicker";
            this.Size = new System.Drawing.Size(257, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker_gudi dateTimePicker_gudi1;
        private Label_gudi label_gudi1;
        private DateTimePicker_gudi dateTimePicker_gudi2;
    }
}
