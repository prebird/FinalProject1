using FinalProject1_DAC;
using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmDPInsert : Form
    {
        public frmDPInsert()
        {
            InitializeComponent();
        }

        private void frmDPInsert_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgv_SalesMaster);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "일련 번호", "PO_ID", DataGridViewContentAlignment.MiddleCenter, colWidth: 95);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "WO ID", "PO_WorkOrderID", DataGridViewContentAlignment.MiddleCenter, colWidth: 115);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "계획기준 버전", "PO_PlanID", DataGridViewContentAlignment.MiddleCenter, colWidth: 110);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "업체명", "PO_CompanyName", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "납품처", "PO_CompanyType", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "도착지", "PO_Destination", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "입고P/NO", "PO_CusProductName", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "제품명", "Item_Name", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "계획수량 합계", "PO_OrderCnt", DataGridViewContentAlignment.MiddleCenter, colWidth: 110);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "출고 수량", "PO_OutCnt", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "취소 수량", "PO_CancelCnt", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "납기일", "PO_DeadLine", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "업로드 날짜", "PO_UploadDate", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "수정자", "PO_EditManager", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "수정일", "PO_EditDate", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_SalesMaster, "비고", "PO_Content", DataGridViewContentAlignment.MiddleCenter);
            LoadData();
        }

        // PlanID가 없는 영업 마스터만 조회 하여 수요 계획 생성.
        public void LoadData()
        {
            DemandPlanDAC service = new DemandPlanDAC();
            List<SalesMasterVO> list = service.GetPlanSM();
            dgv_SalesMaster.DataSource = list;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (dgv_SalesMaster.SelectedRows.Count < 1)
            {
                MessageBox.Show("행을 선택해 주십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("생성 하시겠습니까?", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DemandPlanVO dmVO = new DemandPlanVO()
                {
                    PO_ID = Convert.ToInt32(dgv_SalesMaster.SelectedRows[0].Cells[0].Value),
                    PlanID = txt_PlanID.Text,
                    Dplan_Date = dgv_SalesMaster.SelectedRows[0].Cells[11].Value.ToString(),
                    Dplan_Quantity = Convert.ToInt32(dgv_SalesMaster.SelectedRows[0].Cells[8].Value),
                };

                DemandPlanService service = new DemandPlanService();
                bool result = service.DMInsertTrans(dmVO);

                if (result)
                {
                    MessageBox.Show("생성 되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("처리중 오류가 발생했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

 

        }
    }
}
