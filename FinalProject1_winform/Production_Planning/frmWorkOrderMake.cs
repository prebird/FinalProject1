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
    public partial class frmWorkOrderMake : FinalProject1_winform.Basic3
    {
        string fromDate;
        string toDate;
        public frmWorkOrderMake()
        {
            InitializeComponent();
        }

        private void frmWorkOrderMake_Load(object sender, EventArgs e)
        {
            processEquipmentService equipmentService = new processEquipmentService();
            List<EquipmentVO> list = equipmentService.GetAllEquipment();

            CommonUtil.ComboBinding<EquipmentVO>(cboEquipment, list, "EquipmentName", "EquipmentCode");

            fromDate = dateControl.FromDate.ToString("yyyy-MM-dd");
            toDate = dateControl.ToDate.ToString("yyyy-MM-dd");

            ProductionPlanService service = new ProductionPlanService();
            DataTable dt = service.GetPlanList(fromDate, toDate);

            dgvList.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboEquipment.Text) || string.IsNullOrWhiteSpace(txtItem.Text) || string.IsNullOrWhiteSpace(txtPlanID.Text))
            {
                MessageBox.Show("검색 조건을 선택해 주세요");
            }

            fromDate = dateControl.FromDate.ToString("yyyy-MM-dd");
            toDate = dateControl.ToDate.ToString("yyyy-MM-dd");

            ProductionPlanService service = new ProductionPlanService();
            DataTable dt = service.GetSpecialPlanList(fromDate, toDate, txtItem.Text, cboEquipment.Text, txtPlanID.Text);

            dgvList.DataSource = null;
            dgvList.DataSource = dt;
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
