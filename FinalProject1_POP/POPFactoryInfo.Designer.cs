
namespace FinalProject1_POP
{
    partial class POPFactoryInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_gudi1 = new FinalProject1_winform.Label_gudi();
            this.ucMachine1 = new FinalProject1_winform.Controls.UCMachine();
            this.ucMachine2 = new FinalProject1_winform.Controls.UCMachine();
            this.ucMachine3 = new FinalProject1_winform.Controls.UCMachine();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.label_gudi1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1634, 75);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucMachine3);
            this.panel2.Controls.Add(this.ucMachine2);
            this.panel2.Controls.Add(this.ucMachine1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1634, 911);
            this.panel2.TabIndex = 14;
            // 
            // label_gudi1
            // 
            this.label_gudi1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoEB00", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gudi1.ForeColor = System.Drawing.Color.White;
            this.label_gudi1.Location = new System.Drawing.Point(0, 0);
            this.label_gudi1.Name = "label_gudi1";
            this.label_gudi1.Size = new System.Drawing.Size(1634, 75);
            this.label_gudi1.TabIndex = 3;
            this.label_gudi1.Text = "장비/공정관리";
            this.label_gudi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucMachine1
            // 
            this.ucMachine1.IsTaskEnable = true;
            this.ucMachine1.Location = new System.Drawing.Point(31, 156);
            this.ucMachine1.Name = "ucMachine1";
            this.ucMachine1.Size = new System.Drawing.Size(411, 612);
            this.ucMachine1.TabIndex = 0;
            this.ucMachine1.Task_ID = "TaskID";
            this.ucMachine1.Task_IP = "IP";
            this.ucMachine1.Task_Port = "Port";
            this.ucMachine1.Task_Remark = "Remark";
            // 
            // ucMachine2
            // 
            this.ucMachine2.IsTaskEnable = true;
            this.ucMachine2.Location = new System.Drawing.Point(582, 156);
            this.ucMachine2.Name = "ucMachine2";
            this.ucMachine2.Size = new System.Drawing.Size(411, 612);
            this.ucMachine2.TabIndex = 1;
            this.ucMachine2.Task_ID = "TaskID";
            this.ucMachine2.Task_IP = "IP";
            this.ucMachine2.Task_Port = "Port";
            this.ucMachine2.Task_Remark = "Remark";
            // 
            // ucMachine3
            // 
            this.ucMachine3.IsTaskEnable = true;
            this.ucMachine3.Location = new System.Drawing.Point(1133, 156);
            this.ucMachine3.Name = "ucMachine3";
            this.ucMachine3.Size = new System.Drawing.Size(411, 612);
            this.ucMachine3.TabIndex = 2;
            this.ucMachine3.Task_ID = "TaskID";
            this.ucMachine3.Task_IP = "IP";
            this.ucMachine3.Task_Port = "Port";
            this.ucMachine3.Task_Remark = "Remark";
            // 
            // POPFactoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1634, 911);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "POPFactoryInfo";
            this.Text = "POPFactory";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FinalProject1_winform.Label_gudi label_gudi1;
        private System.Windows.Forms.Panel panel2;
        private FinalProject1_winform.Controls.UCMachine ucMachine3;
        private FinalProject1_winform.Controls.UCMachine ucMachine2;
        private FinalProject1_winform.Controls.UCMachine ucMachine1;
    }
}