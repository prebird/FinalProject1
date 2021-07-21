using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public partial class frmMrp : FinalProject1_winform.Basic3
    {
        DataTable dtMRP;
        public frmMrp()
        {
            InitializeComponent();
        }

        private void frmMrp_Load(object sender, EventArgs e)
        {
            dtp1.FromDate = DateTime.Now.AddDays(-10);
            dtp1.ToDate = DateTime.Now;

            // 콤보바인딩
            CommonUtil.ComboBindingPlanID(cboPlanID);

            //
            CommonUtil.ComboBindingProductID(cboProductID);

            // dgv
            //CommonUtil.SetInitGridView(dgv1);
            CommonUtil.AddGridTextColumn(dgv1, "품번", "itemid", colWidth: 80);
            CommonUtil.AddGridTextColumn(dgv1, "품명", "Item_Name", colWidth: 200);
            CommonUtil.AddGridTextColumn(dgv1, "구분", "gubun", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "카테고리", "Category", colWidth: 100, visibility: false);
            CommonUtil.AddGridTextColumn(dgv1, "정렬", "SortNum", colWidth: 100, visibility: false);
            CommonUtil.AddGridTextColumn(dgv1, "a", "a", colWidth: 200, visibility: false);





            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MRPSearchVO search = new MRPSearchVO();
            search.PlanID = (cboPlanID.SelectedText == "선택")? "": cboPlanID.SelectedText;
            search.FromDate = dtp1.FromDate.ToString();
            search.Todate = dtp1.ToDate.ToString();
            search.ProductID = cboProductID.SelectedValue.ToString().ZeroOrNum();

            RestockService service = new RestockService();
            dtMRP =  service.GetMRP(search);

            dgv1.DataSource = dtMRP;
        }
    }
}
