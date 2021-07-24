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
    public partial class frmrestockList : FinalProject1_winform.Basic3
    {
        List<RestockOrderVO> reorders;
        public frmrestockList()
        {
            InitializeComponent();

            CommonUtil.SetInitGridView(dgv1);
            CommonUtil.AddGridTextColumn(dgv1, "발주번호", "RO_ID", colWidth:90);
            CommonUtil.AddGridTextColumn(dgv1, "품명", "Item_Name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "회사명", "company_name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "발주상태", "RO_Status", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "납기일", "dueDate", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "제안량", "SuggestQty", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "발주량", "Qty", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "취소가능량", "abletoCancel", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "입고량", "ins_cnt", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "입고일자", "ins_date", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "입고검사유무", "inputFlag", colWidth: 90);
        }

        private void frmrestockList_Load(object sender, EventArgs e)
        {
            // 콤보바인딩
            CommonUtil.ComboBindingCompanyID(cboCompany);

            dtp1.FromDate = DateTime.Now.AddDays(-7);
            dtp1.ToDate = DateTime.Now;
            searchRoInsData();
        }


        //private void dataLoad()
        //{
        //    RestockService service = new RestockService();
        //    dgv1.DataSource = service.GetROList();
        //}

        private void button_gudi10_Click(object sender, EventArgs e)
        {
            List<int> chkList = new List<int>();
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dgv1.Rows[i].Cells[0].EditedFormattedValue;
                if (isCellChecked)
                    chkList.Add(Convert.ToInt32(dgv1.Rows[i].Cells[1].Value));
            }

            if (chkList.Count == 0)
            {
                MessageBox.Show("출력할 바코드를 선택해주세요.");
                return;
            }

            string strCheckBarCodeID = string.Join(",", chkList);  // "11, 12, 13"
            RestockService service = new RestockService();

            XtraReport1 rpt = new XtraReport1();
            rpt.DataSource = service.GetPrintData(strCheckBarCodeID);
            ReportPreviewForm frm = new ReportPreviewForm(rpt);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchRoInsData();
        }

        private void searchRoInsData()
        {
            RestockOrderDAC dac = new RestockOrderDAC();
            reorders = dac.GetROandInsList(txtROID.Text, dtp1.FromDate.ToShortDateString(), dtp1.ToDate.ToShortDateString(), cboCompany.SelectedValue.ToString());
            dgv1.DataSource = reorders;
        }

        private void btnDueChange_Click(object sender, EventArgs e)
        {

        }
    }
}
