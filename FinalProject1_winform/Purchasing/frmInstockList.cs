using FinalProject1_DAC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public partial class frmInstockList : Form
    {
        public frmInstockList()
        {
            InitializeComponent();

            CommonUtil.SetInitGridView(dgv1);
            CommonUtil.AddGridTextColumn(dgv1, "발주번호", "RO_ID", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "품목", "Item_Name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "회사명", "company_name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "입고대기량", "ins_cnt", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "입고일", "ins_date", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "발주상태", "RO_Status", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "창고명", "factory_name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "입고량", "ih_product_count", colWidth: 100);


            CommonUtil.ComboBindingCompanyID(cboCompany);
            CommonUtil.ComboBindingCommonCode(cboStatus, "RO_type");

            dtp1.FromDate = DateTime.Now.AddDays(-30);
            dtp1.ToDate = DateTime.Now;
        }

        private void frmInstockList_Load(object sender, EventArgs e)
        {
            CompeteData();
        }

        private void CompeteData()
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            List<RestockOrderVO> complete = dac.GetCompleteList(txtROID.Text, dtp1.FromDate.ToShortDateString(), dtp1.ToDate.ToShortDateString(), cboCompany.SelectedValue.ToString());
            dgv1.DataSource = complete;
        }

        private void button_gudi8_Click(object sender, EventArgs e)
        {
            CompeteData();
        }
    }
}
