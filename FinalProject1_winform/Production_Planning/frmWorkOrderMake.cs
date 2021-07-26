using FinalProject1_VO;
using FinalProject1_winform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmWorkOrderMake : FinalProject1_winform.Basic3
    {
        string fromDate;
        string toDate;
        string processName = null;
        string equipmentName = null;
        string itemName = null;
        string PlanID = null;

        WorkOrderVO WorkOrder = new WorkOrderVO();
        public frmWorkOrderMake()
        {
            InitializeComponent();
        }

        private void frmWorkOrderMake_Load(object sender, EventArgs e)
        {
            //CommonUtil.SetInitGridView(dgvList);
            //CommonUtil.AddGridTextColumn(dgvList, "PlanID", "PlanID");
            //CommonUtil.AddGridTextColumn(dgvList, "공정명", "ProcessName");
            //CommonUtil.AddGridTextColumn(dgvList, "설비명", "EquipmentName");
            //CommonUtil.AddGridTextColumn(dgvList, "물품명", "Item_Name");
            //CommonUtil.AddGridTextColumn(dgvList, "상태", "Status");

            processEquipmentService equipmentService = new processEquipmentService();
            List<EquipmentVO> list = equipmentService.GetAllEquipment();

            EquipmentVO vo = new EquipmentVO
            {
                EquipmentName = "선택",
                EquipmentGroupCode = ""
            };
            list.Insert(0, vo);
            CommonUtil.ComboBinding<EquipmentVO>(cboEquipment, list, "EquipmentName", "EquipmentCode");

            fromDate = dateControl.FromDate.ToString("yyyy-MM-dd");
            toDate = dateControl.ToDate.ToString("yyyy-MM-dd");

            ProductionPlanService service = new ProductionPlanService();
            DataTable dt = service.GetPlanList(fromDate, toDate);

            dgvList.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fromDate = dateControl.FromDate.ToString("yyyy-MM-dd");
            toDate = dateControl.ToDate.ToString("yyyy-MM-dd");

            if (cboEquipment.SelectedIndex == 0 && string.IsNullOrWhiteSpace(txtItem.Text) && string.IsNullOrWhiteSpace(txtPlanID.Text))
            {
                ProductionPlanService service1 = new ProductionPlanService();
                DataTable dt1 = service1.GetPlanList(fromDate, toDate);

                dgvList.DataSource = null;
                dgvList.DataSource = dt1;
                return;
            }

            ProductionPlanService service = new ProductionPlanService();
            DataTable dt = service.GetSpecialPlanList(fromDate, toDate, txtItem.Text, cboEquipment.Text, txtPlanID.Text);

            dgvList.DataSource = null;
            dgvList.DataSource = dt;
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //4
            processName = dgvList[1, e.RowIndex].Value.ToString();
            equipmentName = dgvList[2, e.RowIndex].Value.ToString();
            itemName = dgvList[3, e.RowIndex].Value.ToString();
            PlanID = dgvList[0, e.RowIndex].Value.ToString();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            if(processName == null || equipmentName == null || itemName == null || PlanID == null)
            {
                MessageBox.Show("생산계획을 먼저 선택해주세요");
                return;
            }

            frmWorkDate frm = new frmWorkDate();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                WorkOrder.WorkDate = frm.WorkDate;
                WorkOrder.EmpID = frm.user_id;
                WorkOrder.OrderQuantity = frm.OrderQuantity;
            }
            else
            {
                return;
            }

            BorService borService = new BorService();
            BORVO item = borService.GetSpecialBOR(processName, equipmentName, itemName);

            ProductionPlanService service = new ProductionPlanService();
            WorkOrder.BORID = item.BORID;
            WorkOrder.Status = "작업계획";
            WorkOrder.PlanID = PlanID;
            WorkOrder.WorkOrderID = $"{WorkOrder.WorkDate}_{WorkOrder.EmpID}";

            bool result = service.InsertWorkOrder(WorkOrder);

            if(result)
            {
                MessageBox.Show("성공적으로 저장되었습니다.");
            }
            else
            {
                MessageBox.Show("저장 실패");
            }
        }
    }
}
