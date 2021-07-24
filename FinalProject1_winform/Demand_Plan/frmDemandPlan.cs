using FinalProject1_VO;
using FinalProject1_winform.Demand_Plan;
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

            // 그리드뷰 수동 설정 셋팅
            dgv_DemandPlan.AllowUserToAddRows = false;
            dgv_DemandPlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CommonUtil.AddGridTextColumn(dgv_DemandPlan, "수요계획 번호", "Dplan_ID", DataGridViewContentAlignment.MiddleCenter, colWidth : 130);
            CommonUtil.AddGridTextColumn(dgv_DemandPlan, "PlanID", "PlanID", DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
            CommonUtil.AddGridTextColumn(dgv_DemandPlan, "품목 번호", "Item_ID", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_DemandPlan, "품목명", "ItemName", DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
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
            string planID = dgv_DemandPlan.SelectedRows[0].Cells[1].Value.ToString();
            int itemID = Convert.ToInt32(dgv_DemandPlan.SelectedRows[0].Cells[2].Value);
            string itemName = dgv_DemandPlan.SelectedRows[0].Cells[3].Value.ToString();

            frmProductionPlanMake frm = new frmProductionPlanMake(planID, itemID, itemName);
            frm.ShowDialog();



        }
    }
}
