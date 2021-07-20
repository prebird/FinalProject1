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
        List<SalesMasterVO> _list;

        public frmMasterList()
        {
            InitializeComponent();
        }

        private void frmMasterList_Load(object sender, EventArgs e)
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
        public void LoadData()
        {
            SalesMasterService service = new SalesMasterService();
            _list = service.GetAllSM();
            dgv_SalesMaster.DataSource = _list;
        }

        // 삭제
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_SalesMaster.SelectedRows.Count < 1)
            {
                MessageBox.Show("행을 선택해 주십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("삭제 하시겠습니까?", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int SalesMasterID = Convert.ToInt32(dgv_SalesMaster.SelectedRows[0].Cells[0].Value);

                SalesMasterService service = new SalesMasterService();
                bool result = service.DeleteSM(SalesMasterID);

                if (result)
                {
                    MessageBox.Show("삭제 되었습니다.");
                    LoadData();
                }
                else
                    MessageBox.Show("처리중 오류가 발생했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 영업마스터 정보 취합 등록.
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (dgv_SalesMaster.SelectedRows.Count < 1)
            {
                MessageBox.Show("행을 선택해 주십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int SalesMasterID = Convert.ToInt32(dgv_SalesMaster.SelectedRows[0].Cells[0].Value);

            frmMasterInsert frm = new frmMasterInsert(SalesMasterID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("입력 되었습니다.");
                LoadData();
            }
        }

        private void btn_PlanCreate_Click(object sender, EventArgs e)
        {
            if (dgv_SalesMaster.SelectedRows.Count < 1)
            {
                MessageBox.Show("행을 선택해 주십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmDPInsert frm = new frmDPInsert();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel Files(*.xls)|*.xls|Excel Files(*.xlsx)|*.xlsx";
            dlg.Title = "엑셀파일로 내보내기";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bool result = ExcelUtil.ExportExcelToList<SalesMasterVO>(_list, dlg.FileName, "deleted");

                if (result)
                {
                    MessageBox.Show("엑셀 다운로드 완료");
                }
            }
        }
    }
}

