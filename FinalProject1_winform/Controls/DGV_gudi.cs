using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class DGV_gudi : DataGridView
    {
        DataGridViewCheckBoxColumn chk = null;

        private bool checkBoxAll = false;
        public bool CheckBoxAll 
        {
            get { return checkBoxAll; }
            set
            {
                checkBoxAll = value;
                Columnsettings();
            } 
        }

        private bool headerCheckStatus;
        public bool HeaderCheckStatus 
        {
            get { return headerCheckStatus; } 
            set 
            { 
                headerCheckStatus = value;
                if (headerCheckStatus == true)
                {
                    headerCheckBox.Checked = true;
                }
                else
                {
                    headerCheckBox.Checked = false;
                }
            } 
        }

        CheckBox headerCheckBox = new CheckBox();
        public DGV_gudi()
        {
            InitializeComponent();

            this.BackgroundColor = Color.White;
            this.Font = new Font("AppleSDGothicNeoM00", 10);
            this.RowHeadersVisible = false;

            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 241, 241);
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            

        }



        

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void Columnsettings()
        {  
            if (checkBoxAll == true && chk == null)
            {
                chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "";
                chk.Name = "chk";
                chk.Width = 30;
                this.Columns.Add(chk);

                Point headerPT = this.GetCellDisplayRectangle(0, -1, true).Location;
                headerCheckBox.Location = new Point(headerPT.X + 8, headerPT.Y + 2);
                headerCheckBox.Size = new Size(18, 18);
                headerCheckBox.BackColor = Color.White;
                headerCheckBox.Click += HeaderCheckBox_Click;
                this.Controls.Add(headerCheckBox); 
            }
            else if(! checkBoxAll)
            {
                chk = null;
                this.Columns.Clear();
                this.Controls.Remove(headerCheckBox); 
            }            
        }

        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            this.EndEdit();

            foreach (DataGridViewRow row in this.Rows)
            {
                DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)row.Cells["chk"];

                chkCell.Value = headerCheckBox.Checked;
            }
        }

        public void headerFalse()
        {
            headerCheckBox.Checked = false;
        }
        


        // 샘플코드
        /* 이 코드는 체크 박스에서 체크된 것들만 가져오는 샘플코드 입니다.
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> chkUserIDList = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dataGridView1[0, i].EditedFormattedValue;

                if (isCellChecked)
                {
                    chkUserIDList.Add(dataGridView1[1, i].Value.ToString());
                }
            }
            MessageBox.Show(string.Join(", ", chkUserIDList));
        }
        */
    }
}
