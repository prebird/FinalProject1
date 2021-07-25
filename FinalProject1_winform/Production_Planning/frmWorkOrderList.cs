using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject1_winform
{ 
    public partial class frmWorkOrderList : FinalProject1_winform.Basic3
    {
        List<WorkOrderVO> worklist = new List<WorkOrderVO>();
        public frmWorkOrderList()
        {
            InitializeComponent();
        }

        private void frmWorkOrderList_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "작업지시번호", "WorkOrderID");
            CommonUtil.AddGridTextColumn(dgvList, "계획 ID", "PlanID");
            CommonUtil.AddGridTextColumn(dgvList, "작업자 ID", "EmpID");
            CommonUtil.AddGridTextColumn(dgvList, "작업자", "user_name");
            CommonUtil.AddGridTextColumn(dgvList, "작업일", "WorkDate");
            CommonUtil.AddGridTextColumn(dgvList, "BORID", "BORID", visibility: false);
            CommonUtil.AddGridTextColumn(dgvList, "설비ID", "EquipmentID", visibility: false);
            CommonUtil.AddGridTextColumn(dgvList, "설비", "EquipmentName");
            CommonUtil.AddGridTextColumn(dgvList, "물품ID", "Item_ID", visibility: false);
            CommonUtil.AddGridTextColumn(dgvList, "물품", "Item_Name");
            CommonUtil.AddGridTextColumn(dgvList, "작업상태", "Status");
            CommonUtil.AddGridTextColumn(dgvList, "지시수량", "OrderQuantity");

            LoadData();
        }

        private void LoadData()
        {
            WorkOrderService service = new WorkOrderService();
            worklist = service.GetAllWorkOrder();

            dgvList.DataSource = null;
            dgvList.DataSource = new BindingList<WorkOrderVO>(worklist);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cboStatus.SelectedIndex == 0 || string.IsNullOrWhiteSpace(txtPlanID.Text) || string.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("검색 조건을 입력해 주세요");
                return;
            }

            string status = null;
            string planID = null;
            string itemName = null;

            if (cboStatus.SelectedIndex != 0)
            {
                status = cboStatus.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtPlanID.Text))
            {
                planID = txtPlanID.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtItem.Text))
            {
                itemName = txtItem.Text;
            }

            var list = (from item in worklist
                        where (status != null ? status.Contains(item.Status) : true) &&
                        (planID != null ? planID.Contains(item.PlanID) : true) &&
                        (itemName != null ? itemName.Contains(item.Item_Name) : true) &&
                        Convert.ToDateTime(item.WorkDate) <= dateControl.ToDate &&
                        Convert.ToDateTime(item.WorkDate) >= dateControl.FromDate
                        select item
                        ).ToList();

            dgvList.DataSource = null;
            dgvList.DataSource = new BindingList<WorkOrderVO>(list);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }
    }
}
