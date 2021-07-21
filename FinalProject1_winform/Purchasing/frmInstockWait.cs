using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    public partial class frmInstockWait : FinalProject1_winform.Basic3
    {
        List<RestockOrderVO> reorders;
        List<RestockOrderVO> waits = new List<RestockOrderVO>();
        
        public frmInstockWait()
        {
            InitializeComponent();

            dtp1.FromDate = DateTime.Now.AddDays(-7);
            dtp1.ToDate = DateTime.Now;
            CommonUtil.ComboBindingCompanyID(cboCompany);

            Columnsettings(dgv1);
            Columnsettings1(dgv2);

            CommonUtil.SetInitGridView(dgv1);
            CommonUtil.AddGridTextColumn(dgv1, "발주번호", "RO_ID", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "품명", "Item_Name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "회사명", "company_name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "납기일", "dueDate", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "발주량", "Qty", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "입고량", "ins_cnt", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "잔량", "abletoCancel", colWidth: 90);

            CommonUtil.SetInitGridView(dgv2);
            CommonUtil.AddGridTextColumn(dgv2, "발주번호", "RO_ID", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv2, "품명", "Item_Name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv2, "회사명", "company_name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv2, "발주상태", "RO_Status", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv2, "납기일", "dueDate", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv2, "발주량", "Qty", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv2, "입고량", "ins_cnt", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv2, "입고일자", "ins_date", colWidth: 90);
        }

        private void frmInstockWait_Load(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            reorders = dac.GetInsWaitList(txtRO.Text, dtp1.FromDate.ToShortDateString(), dtp1.ToDate.ToShortDateString(), cboCompany.SelectedValue.ToString());
            dgv1.DataSource = reorders;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // reorders에서 체크된거 찾기
            List<string> chkUserIDList = new List<string>();
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dgv1[0, i].EditedFormattedValue;

                if (isCellChecked)
                {
                    chkUserIDList.Add(dgv1[1, i].Value.ToString());
                }
            }

            // 체크한거 waits 전역변수에 담기
            foreach (var reo in reorders)
            {
                foreach (var chk in chkUserIDList)
                {
                    if (reo.RO_ID.Equals(Convert.ToInt32(chk)))
                    {
                        waits.Add(reo);
                    }
                }
            }

            dgv2.DataSource = waits;

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            // 체크된거 찾기
            List<string> chkUserIDList = new List<string>();
            for (int i = 0; i < dgv2.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dgv2[0, i].EditedFormattedValue;

                if (isCellChecked)
                {
                    chkUserIDList.Add(dgv2[1, i].Value.ToString());
                }
            }
            // 체크된거 없으면
            if (chkUserIDList.Count < 1)
            {
                MessageBox.Show("입고처리할 품목을 선택해 주세요"); return;

            }

            // 체크한거 찾아서 던져주기
            List<RestockOrderVO> throwWaits = new List<RestockOrderVO>();
            foreach (var w in waits)
            {
                foreach (var chk in chkUserIDList)
                {
                    if (w.RO_ID.Equals(Convert.ToInt32(chk)))
                    {
                        throwWaits.Add(w);
                    }
                }
            }

            // frmInstockWaitPopUp
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }



        #region dgv1
        CheckBox headerCheckBox1 = new CheckBox();
        private void Columnsettings(DataGridView dgv)
        {

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "chk";
            chk.Width = 30;
            dgv.Columns.Add(chk);

            Point headerPT = dgv.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox1.Location = new Point(headerPT.X + 8, headerPT.Y + 2);
            headerCheckBox1.Size = new Size(18, 18);
            headerCheckBox1.BackColor = Color.White;
            headerCheckBox1.Click += HeaderCheckBox1_Click;
            dgv.Controls.Add(headerCheckBox1);

            dgv.Columns[0].Frozen = true;
        }

        private void HeaderCheckBox1_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            dgv.EndEdit();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)row.Cells["chk"];

                chkCell.Value = headerCheckBox1.Checked;
            }
        }
        #endregion
        #region dgv2
        CheckBox headerCheckBox2 = new CheckBox();
        private void Columnsettings1(DataGridView dgv)
        {

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "chk";
            chk.Width = 30;
            dgv.Columns.Add(chk);

            Point headerPT = dgv.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox2.Location = new Point(headerPT.X + 8, headerPT.Y + 2);
            headerCheckBox2.Size = new Size(18, 18);
            headerCheckBox2.BackColor = Color.White;
            headerCheckBox2.Click += HeaderCheckBox2_Click;
            dgv.Controls.Add(headerCheckBox2);

            dgv.Columns[0].Frozen = true;
        }

        private void HeaderCheckBox2_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            dgv.EndEdit();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)row.Cells["chk"];

                chkCell.Value = headerCheckBox1.Checked;
            }
        }
        #endregion
    }
}
