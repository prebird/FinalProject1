using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FinalProject1_winform.Production_Planning
{
    public partial class frmProductionPlanningList : FinalProject1_winform.Basic3
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
            date.ToDate = DateTime.Now.AddDays(-7);


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FromDate = date.FromDate.ToString("yyyy-MM-dd");
            ToDate = date.ToDate.ToString("yyyy-MM-dd");
        }
    }
}
