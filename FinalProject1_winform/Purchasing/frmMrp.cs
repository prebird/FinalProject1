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
        List<MRPVO> mrpDatas;
        public frmMrp()
        {
            InitializeComponent();
        }

        private void frmMrp_Load(object sender, EventArgs e)
        {
            dtp1.FromDate = DateTime.Now.AddDays(-10);
            dtp1.ToDate = DateTime.Now;

            // 콤보바인딩
            

            // dgv



            btnSearch.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MRPSearchVO search = new MRPSearchVO();
            search.PlanID = cboPlanID.SelectedText;
            search.FromDate = dtp1.FromDate.ToString();
            search.Todate = dtp1.ToDate.ToString();
            search.ProductID = Convert.ToInt32(cboProductID.SelectedValue.ToString());

            RestockService service = new RestockService();
            mrpDatas =  service.GetMRP(search);

            dgv1.DataSource = mrpDatas;
        }
    }
}
