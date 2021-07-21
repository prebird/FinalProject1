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
            CommonUtil.ComboBindingPlanID(cbo_PlanID);

            //CommonUtil.SetInitGridView(dgv_DemandPlan);
            CommonUtil.AddGridTextColumn(dgv_DemandPlan, "수요 계획 PlanID", "Planid", DataGridViewContentAlignment.MiddleCenter, colWidth : 150);
            CommonUtil.AddGridTextColumn(dgv_DemandPlan, "품목 번호", "itemid", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_DemandPlan, "품목명", "Item_Name", DataGridViewContentAlignment.MiddleCenter);

            
        }

        // 삭제 (구현 X)
        private void btn_Delete_Click(object sender, EventArgs e)
        {


        }

        // 엑셀 출력 버튼 (구현 X)
        private void btn_Excel_Click(object sender, EventArgs e)
        {    


        }

        // 부분 조회 검색 패널
        private void btn_Search_Click(object sender, EventArgs e)
        {
            DemandPlanVO dmVO = new DemandPlanVO()
            {
               PlanID = cbo_PlanID.Text,
               StartDate = dtp_Start.Value.ToString("yyyy-MM-dd"),
               EndDate = dtp_End.Value.ToString("yyyy-MM-dd"),
            };

            DemandPlanService service = new DemandPlanService();
            DataTable DemandPlanDT = service.GetDemandPlanList(dmVO);

            dgv_DemandPlan.DataSource = DemandPlanDT;

        }

        // 생산 계획 생성
        private void btn_ProductionPlan_Click(object sender, EventArgs e)
        {




        }
    }
}
