using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalProject1_DAC;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public partial class frmInstock : FinalProject1_winform.Basic3
    {
        
        List<RestockOrderVO> allList;
        List<RestockOrderVO> complete;
        UserInfoVO user;

        public frmInstock()
        {
            InitializeComponent();
            

            CommonUtil.SetInitGridView(dgvWait);
            CommonUtil.AddGridTextColumn(dgvWait, "발주번호", "RO_ID", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvWait, "품목", "Item_Name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvWait, "회사명", "company_name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvWait, "입고대기량", "ins_cnt", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvWait, "입고일", "ins_date", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvWait, "발주상태", "RO_Status", colWidth: 100);


            CommonUtil.SetInitGridView(dgvIn);
            CommonUtil.AddGridTextColumn(dgvIn, "발주번호", "RO_ID", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvIn, "품목", "Item_Name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvIn, "회사명", "company_name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvIn, "입고대기량", "ins_cnt", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvIn, "입고일", "ins_date", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvIn, "발주상태", "RO_Status", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvIn, "창고명", "factory_name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvIn, "입고량", "RO_Status", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvIn, "발주상태", "in_product_count", colWidth: 100);

        }

        private void frmInstock_Load(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            user = frm.User;

            CommonUtil.ComboBindingCompanyID(cboCompany);
            CommonUtil.ComboBindingCommonCode(cboStatus, "RO_type");

            
            GetAllData();
            CompeteData();
        }

        // 추가
        private void button_gudi8_Click(object sender, EventArgs e)
        {
            GetAllData();
            CompeteData();
        }

        private void GetAllData()
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            allList = dac.GetInsWaitAndAfterInspectList(txtROID.Text, dtp1.FromDate.ToShortDateString(), dtp1.ToDate.ToShortDateString(), cboCompany.SelectedValue.ToString(), cboStatus.SelectedValue.ToString());
            dgvWait.DataSource = allList;
        }
        private void CompeteData()
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            complete = dac.GetCompleteList(txtROID.Text, dtp1.FromDate.ToShortDateString(), dtp1.ToDate.ToShortDateString(), cboCompany.SelectedValue.ToString());
            dgvIn.DataSource = complete;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RestockOrderVO throwVO = allList.Find((x) => x.RO_ID == Convert.ToInt32(dgvWait.SelectedRows[0].Cells[0].Value));

            frmInstockAdd frm = new frmInstockAdd(throwVO, user);
            frm.ShowDialog();
        }
    }
}
