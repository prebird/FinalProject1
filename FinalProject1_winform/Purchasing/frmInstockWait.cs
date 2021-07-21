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
        public frmInstockWait()
        {
            InitializeComponent();

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
            reorders = dac.GetInsWaitList(txtRO.Text, dtp1.FromDate.ToString(), dtp1.ToDate.ToString(), cboCompany.SelectedValue.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnGO_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
