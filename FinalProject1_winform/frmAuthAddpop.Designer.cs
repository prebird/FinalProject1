
namespace FinalProject1_winform
{
    partial class frmAuthAddpop
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lstSelect = new System.Windows.Forms.ListBox();
            this.lstAll = new System.Windows.Forms.ListBox();
            this.btnRemove = new FinalProject1_winform.Button_gudi();
            this.btnAdd = new FinalProject1_winform.Button_gudi();
            this.button_gudi1 = new FinalProject1_winform.Button_gudi();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView1.Location = new System.Drawing.Point(26, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(281, 369);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lstSelect
            // 
            this.lstSelect.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstSelect.FormattingEnabled = true;
            this.lstSelect.ItemHeight = 16;
            this.lstSelect.Location = new System.Drawing.Point(314, 23);
            this.lstSelect.Name = "lstSelect";
            this.lstSelect.Size = new System.Drawing.Size(236, 308);
            this.lstSelect.TabIndex = 1;
            // 
            // lstAll
            // 
            this.lstAll.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstAll.FormattingEnabled = true;
            this.lstAll.ItemHeight = 16;
            this.lstAll.Location = new System.Drawing.Point(654, 23);
            this.lstAll.Name = "lstAll";
            this.lstAll.Size = new System.Drawing.Size(230, 308);
            this.lstAll.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnRemove.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(578, 197);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(49, 45);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "▶";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.btnAdd.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(578, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "◀";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button_gudi1
            // 
            this.button_gudi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(146)))), ((int)(((byte)(209)))));
            this.button_gudi1.ButtonType = FinalProject1_winform.ButtonStyle.Highlight;
            this.button_gudi1.FlatAppearance.BorderSize = 0;
            this.button_gudi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gudi1.Font = new System.Drawing.Font("AppleSDGothicNeoB00", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_gudi1.ForeColor = System.Drawing.Color.White;
            this.button_gudi1.Location = new System.Drawing.Point(314, 347);
            this.button_gudi1.Name = "button_gudi1";
            this.button_gudi1.Size = new System.Drawing.Size(236, 45);
            this.button_gudi1.TabIndex = 2;
            this.button_gudi1.Text = "저장";
            this.button_gudi1.UseVisualStyleBackColor = false;
            this.button_gudi1.Click += new System.EventHandler(this.button_gudi1_Click);
            // 
            // frmAuthAddpop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(896, 421);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button_gudi1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstAll);
            this.Controls.Add(this.lstSelect);
            this.Controls.Add(this.treeView1);
            this.Name = "frmAuthAddpop";
            this.Text = "권한추가";
            this.Load += new System.EventHandler(this.frmAuthAddpop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lstSelect;
        private System.Windows.Forms.ListBox lstAll;
        private Button_gudi btnRemove;
        private Button_gudi btnAdd;
        private Button_gudi button_gudi1;
    }
}