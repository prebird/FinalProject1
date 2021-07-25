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
        RestockOrderDAC dac = new RestockOrderDAC();
        List<RestockOrderVO> allList;
        List<RestockOrderVO> complete;

        public frmInstock()
        {
            InitializeComponent();
        }

        private void frmInstock_Load(object sender, EventArgs e)
        {
            CommonUtil.ComboBindingCompanyID(cboCompany);
            CommonUtil.ComboBindingCommonCode(cboStatus, "RO_type");


            GetAllData();
            CompeteData();
        }

        // 추가
        private void button_gudi8_Click(object sender, EventArgs e)
        {
            
        }

        private void GetAllData()
        {
            allList = dac.GetInsWaitAndAfterInspectList(txtROID.Text, dtp1.FromDate.ToShortDateString(), dtp1.ToDate.ToShortDateString(), cboCompany.SelectedValue.ToString(), cboStatus.SelectedValue.ToString());
            dgvWait.DataSource = allList;
        }
        private void CompeteData()
        {
            complete = dac.GetCompleteList(txtROID.Text, dtp1.FromDate.ToShortDateString(), dtp1.ToDate.ToShortDateString(), cboCompany.SelectedValue.ToString());
            dgvIn.DataSource = complete;
        }

        
    }
}
