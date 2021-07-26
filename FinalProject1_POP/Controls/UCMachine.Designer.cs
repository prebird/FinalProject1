
namespace FinalProject1_winform.Controls
{
    partial class UCMachine
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
            this.gbProcess = new System.Windows.Forms.GroupBox();
            this.button_gudi2 = new FinalProject1_winform.Button_gudi();
            this.btnStop = new FinalProject1_winform.Button_gudi();
            this.btnStart = new FinalProject1_winform.Button_gudi();
            this.txtNGQty = new System.Windows.Forms.TextBox();
            this.txtOKQty = new System.Windows.Forms.TextBox();
            this.txtRemainQty = new System.Windows.Forms.TextBox();
            this.txtWorkQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtWorkNum = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblYN = new System.Windows.Forms.Label();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.gbProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProcess
            // 
            this.gbProcess.BackColor = System.Drawing.Color.White;
            this.gbProcess.Controls.Add(this.button_gudi2);
            this.gbProcess.Controls.Add(this.btnStop);
            this.gbProcess.Controls.Add(this.btnStart);
            this.gbProcess.Controls.Add(this.txtNGQty);
            this.gbProcess.Controls.Add(this.txtOKQty);
            this.gbProcess.Controls.Add(this.txtRemainQty);
            this.gbProcess.Controls.Add(this.txtWorkQty);
            this.gbProcess.Controls.Add(this.label8);
            this.gbProcess.Controls.Add(this.label7);
            this.gbProcess.Controls.Add(this.label6);
            this.gbProcess.Controls.Add(this.label5);
            this.gbProcess.Controls.Add(this.label4);
            this.gbProcess.Controls.Add(this.label3);
            this.gbProcess.Controls.Add(this.label2);
            this.gbProcess.Controls.Add(this.txtOrderQty);
            this.gbProcess.Controls.Add(this.txtItemCode);
            this.gbProcess.Controls.Add(this.txtWorkNum);
            this.gbProcess.Controls.Add(this.pictureBox1);
            this.gbProcess.Controls.Add(this.lblMachineName);
            this.gbProcess.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbProcess.Location = new System.Drawing.Point(6, 38);
            this.gbProcess.Name = "gbProcess";
            this.gbProcess.Size = new System.Drawing.Size(402, 571);
            this.gbProcess.TabIndex = 0;
            this.gbProcess.TabStop = false;
            // 
            // button_gudi2
            // 
            this.button_gudi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.button_gudi2.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.button_gudi2.FlatAppearance.BorderSize = 0;
            this.button_gudi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi2.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_gudi2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_gudi2.Location = new System.Drawing.Point(273, 508);
            this.button_gudi2.Name = "button_gudi2";
            this.button_gudi2.Size = new System.Drawing.Size(124, 57);
            this.button_gudi2.TabIndex = 18;
            this.button_gudi2.Text = "실적저장";
            this.button_gudi2.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.btnStop.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(139, 508);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(124, 57);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "중지";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.btnStart.ButtonType = FinalProject1_winform.ButtonStyle.Normal;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.ForeColor = System.Drawing.Color.Lime;
            this.btnStart.Location = new System.Drawing.Point(4, 508);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 57);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNGQty
            // 
            this.txtNGQty.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNGQty.ForeColor = System.Drawing.Color.Red;
            this.txtNGQty.Location = new System.Drawing.Point(295, 467);
            this.txtNGQty.Name = "txtNGQty";
            this.txtNGQty.ReadOnly = true;
            this.txtNGQty.Size = new System.Drawing.Size(101, 35);
            this.txtNGQty.TabIndex = 15;
            this.txtNGQty.TabStop = false;
            this.txtNGQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOKQty
            // 
            this.txtOKQty.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOKQty.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtOKQty.Location = new System.Drawing.Point(295, 423);
            this.txtOKQty.Name = "txtOKQty";
            this.txtOKQty.ReadOnly = true;
            this.txtOKQty.Size = new System.Drawing.Size(101, 35);
            this.txtOKQty.TabIndex = 14;
            this.txtOKQty.TabStop = false;
            this.txtOKQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRemainQty
            // 
            this.txtRemainQty.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemainQty.ForeColor = System.Drawing.Color.Black;
            this.txtRemainQty.Location = new System.Drawing.Point(147, 467);
            this.txtRemainQty.Name = "txtRemainQty";
            this.txtRemainQty.ReadOnly = true;
            this.txtRemainQty.Size = new System.Drawing.Size(88, 35);
            this.txtRemainQty.TabIndex = 13;
            this.txtRemainQty.TabStop = false;
            this.txtRemainQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWorkQty
            // 
            this.txtWorkQty.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkQty.Location = new System.Drawing.Point(147, 423);
            this.txtWorkQty.Name = "txtWorkQty";
            this.txtWorkQty.ReadOnly = true;
            this.txtWorkQty.Size = new System.Drawing.Size(88, 35);
            this.txtWorkQty.TabIndex = 12;
            this.txtWorkQty.TabStop = false;
            this.txtWorkQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "불량";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "양품";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "오더 잔량";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "작업 량";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "총 오더량";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "제작 품목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "작업 번호";
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOrderQty.ForeColor = System.Drawing.Color.Black;
            this.txtOrderQty.Location = new System.Drawing.Point(147, 381);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.ReadOnly = true;
            this.txtOrderQty.Size = new System.Drawing.Size(249, 35);
            this.txtOrderQty.TabIndex = 4;
            this.txtOrderQty.TabStop = false;
            this.txtOrderQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemCode.Location = new System.Drawing.Point(147, 337);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(249, 35);
            this.txtItemCode.TabIndex = 3;
            this.txtItemCode.TabStop = false;
            this.txtItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWorkNum
            // 
            this.txtWorkNum.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkNum.Location = new System.Drawing.Point(147, 290);
            this.txtWorkNum.Name = "txtWorkNum";
            this.txtWorkNum.ReadOnly = true;
            this.txtWorkNum.Size = new System.Drawing.Size(249, 35);
            this.txtWorkNum.TabIndex = 2;
            this.txtWorkNum.TabStop = false;
            this.txtWorkNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 216);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblMachineName
            // 
            this.lblMachineName.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMachineName.Location = new System.Drawing.Point(29, 256);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(346, 19);
            this.lblMachineName.TabIndex = 0;
            this.lblMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYN
            // 
            this.lblYN.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblYN.Location = new System.Drawing.Point(267, 10);
            this.lblYN.Name = "lblYN";
            this.lblYN.Size = new System.Drawing.Size(145, 25);
            this.lblYN.TabIndex = 16;
            this.lblYN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Location = new System.Drawing.Point(5, 10);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(44, 12);
            this.lblTaskID.TabIndex = 19;
            this.lblTaskID.Text = "TaskID";
            this.lblTaskID.Visible = false;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(65, 10);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(16, 12);
            this.lblIP.TabIndex = 20;
            this.lblIP.Text = "IP";
            this.lblIP.Visible = false;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(97, 10);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(27, 12);
            this.lblPort.TabIndex = 21;
            this.lblPort.Text = "Port";
            this.lblPort.Visible = false;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(140, 10);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(48, 12);
            this.lblRemark.TabIndex = 22;
            this.lblRemark.Text = "Remark";
            this.lblRemark.Visible = false;
            // 
            // UCMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblTaskID);
            this.Controls.Add(this.lblYN);
            this.Controls.Add(this.gbProcess);
            this.Name = "UCMachine";
            this.Size = new System.Drawing.Size(411, 612);
            this.gbProcess.ResumeLayout(false);
            this.gbProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderQty;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtWorkNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNGQty;
        private System.Windows.Forms.TextBox txtOKQty;
        private System.Windows.Forms.TextBox txtRemainQty;
        private System.Windows.Forms.TextBox txtWorkQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblYN;
        private Button_gudi button_gudi2;
        private Button_gudi btnStop;
        private Button_gudi btnStart;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblRemark;
    }
}
