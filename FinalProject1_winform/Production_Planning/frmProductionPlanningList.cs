using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FinalProject1_winform
{
    public partial class frmProductionPlanningList : Basic3
    {
        string FromDate;
        string ToDate;
        public frmProductionPlanningList()
        {
            InitializeComponent();
        }

        private void frmProductionPlanningList_Load(object sender, EventArgs e)
        {
            date.ToDate = DateTime.Now;
            date.FromDate = DateTime.Now.AddDays(-7);

            ProductionPlanService service = new ProductionPlanService();
            DataTable dt = service.GetPlanList(date.FromDate.ToString("yyyy-MM-dd"),date.ToDate.ToString("yyyy-MM-dd"));

            dgvList.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FromDate = date.FromDate.ToString("yyyy-MM-dd");
            ToDate = date.ToDate.ToString("yyyy-MM-dd");

            ProductionPlanService service = new ProductionPlanService();
            DataTable dt = service.GetPlanList(FromDate, ToDate);

            dgvList.DataSource = null;
            dgvList.DataSource = dt;
        }
    }
}
