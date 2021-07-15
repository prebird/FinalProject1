using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmDemandPlan : FinalProject1_winform.Basic3
    {
        public frmDemandPlan()
        {
            InitializeComponent();
        }

        private void frmDemandPlan_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgv_DemandPlan);


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_DemandPlan.SelectedRows.Count < 1)
            {
                MessageBox.Show("행을 선택 해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btn_Search_Click(object sender, EventArgs e)
        {



        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {

        }
    }
}
