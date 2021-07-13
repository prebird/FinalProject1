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
    public partial class frmMasterList : FinalProject1_winform.Basic3
    {
        public frmMasterList()
        {
            InitializeComponent();
        }

        private void frmMasterList_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgv_SalesMaster);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "영업마스터 번호", "PO_ID", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "WO", "PO_WorkOrderID", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "계획기준 버전", "PO_PlanID", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "업체명", "PO_CompanyName", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "납품처", "PO_CompanyType", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "도착지", "PO_Destination", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "제품명", "Item_Name", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "계획수량 합계", "PO_OrderCnt", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "출고 수량", "PO_OutCnt", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "취소 수량", "PO_CancelCnt", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "납기일", "PO_DeadLine", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "업로드 날짜", "PO_UploadDate", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "수정자", "PO_EditManger", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "수정일", "PO_EditDate", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "비고", "PO_Content", DataGridViewContentAlignment.MiddleCenter);
            LoadData();

        }
        public void LoadData()
        {
            SMService service = new SMService();
            List<SalesMasterVO> list = service.GetAllSM();
            dgv_SalesMaster.DataSource = list;
        }
    }
}
