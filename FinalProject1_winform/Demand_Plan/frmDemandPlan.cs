using FinalProject1_VO;
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

        // 삭제
        private void btn_Delete_Click(object sender, EventArgs e)
        {


        }

        //생산 계획 생성
        private void btn_PlanPP_Click(object sender, EventArgs e)
        {


        }

        // 엑셀 출력 버튼
        private void btn_Excel_Click(object sender, EventArgs e)
        {


        }

        // 부분 조회 검색 패널
        private void btn_Search_Click(object sender, EventArgs e)
        {
            DemandPlanVO dmVO = new DemandPlanVO()
            {
               PlanID = txt_PlanID.Text,
               StartDate = dtp_Start.Value.ToString("yyyy-MM-dd"),
               EndDate = dtp_End.Value.ToString("yyyy-MM-dd"),
            };




        }
    }
}
