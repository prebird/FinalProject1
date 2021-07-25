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

        }
    }
}
