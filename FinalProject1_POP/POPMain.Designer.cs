
namespace FinalProject1_POP
{
    partial class POPMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMachine = new System.Windows.Forms.Button();
            this.btnFactory = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.PanelCildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 156);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject1_POP.Properties.Resources.수정됨_logo1___복사본;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnMachine);
            this.panel2.Controls.Add(this.btnFactory);
            this.panel2.Controls.Add(this.btnWork);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 805);
            this.panel2.TabIndex = 1;
            // 
            // btnMachine
            // 
            this.btnMachine.BackColor = System.Drawing.Color.White;
            this.btnMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachine.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMachine.Image = global::FinalProject1_POP.Properties.Resources.engineer128x;
            this.btnMachine.Location = new System.Drawing.Point(3, 412);
            this.btnMachine.Name = "btnMachine";
            this.btnMachine.Size = new System.Drawing.Size(248, 131);
            this.btnMachine.TabIndex = 3;
            this.btnMachine.Text = "공정관리";
            this.btnMachine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMachine.UseVisualStyleBackColor = false;
            // 
            // btnFactory
            // 
            this.btnFactory.BackColor = System.Drawing.Color.White;
            this.btnFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactory.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFactory.Image = global::FinalProject1_POP.Properties.Resources.factory128x;
            this.btnFactory.Location = new System.Drawing.Point(3, 276);
            this.btnFactory.Name = "btnFactory";
            this.btnFactory.Size = new System.Drawing.Size(248, 131);
            this.btnFactory.TabIndex = 2;
            this.btnFactory.Text = "장비관리";
            this.btnFactory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFactory.UseVisualStyleBackColor = false;
            // 
            // btnWork
            // 
            this.btnWork.BackColor = System.Drawing.Color.White;
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWork.Image = global::FinalProject1_POP.Properties.Resources.pie_chart128x;
            this.btnWork.Location = new System.Drawing.Point(3, 140);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(248, 131);
            this.btnWork.TabIndex = 1;
            this.btnWork.Text = "작업관리";
            this.btnWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWork.UseVisualStyleBackColor = false;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUser.Image = global::FinalProject1_POP.Properties.Resources.user128x;
            this.btnUser.Location = new System.Drawing.Point(3, 6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(248, 131);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "유저관리";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // PanelCildForm
            // 
            this.PanelCildForm.BackColor = System.Drawing.Color.White;
            this.PanelCildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCildForm.Location = new System.Drawing.Point(257, 156);
            this.PanelCildForm.Name = "PanelCildForm";
            this.PanelCildForm.Size = new System.Drawing.Size(1427, 805);
            this.PanelCildForm.TabIndex = 2;
            // 
            // POPMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 961);
            this.Controls.Add(this.PanelCildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "POPMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "(주)OKDOL COMPONY POP SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.POPMain_FormClosed);
            this.Load += new System.EventHandler(this.POPMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelCildForm;
        private System.Windows.Forms.Button btnMachine;
        private System.Windows.Forms.Button btnFactory;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}