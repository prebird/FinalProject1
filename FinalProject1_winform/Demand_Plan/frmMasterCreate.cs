﻿using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmMasterCreate : FinalProject1_winform.Basic3
    {
        string _PlanID;

        public frmMasterCreate()
        {
            InitializeComponent();
        }

        // 발주서 엑셀 등록.
        private void btn_POExcel_Click(object sender, EventArgs e)
        {
            frmPOUpload frm = new frmPOUpload();

            if(frm.ShowDialog() == DialogResult.OK)
            {
                dgv_PO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_PO.AllowUserToAddRows = false;

                DataTable dt = frm.ExcelData;
                string planDate = frm.PlanDate;
                _PlanID = frm.PlanID;

                // 계획일자를 POUpload 폼에서 받아와 그리드뷰 맨 첫칸에 표시.
                dt.Columns.Add(new DataColumn("planDate", typeof(string)));
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    dt.Rows[i]["planDate"] = planDate;
                }
                dt.AcceptChanges();
                dgv_PO.DataSource = dt;
 
            }   
        }
        
        // 영업 마스터 생성
        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (dgv_PO.SelectedRows.Count < 1)
            {
                MessageBox.Show("발주서 엑셀을 업로드 해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            if (MessageBox.Show("생성 하시겠습니까?", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                SalesMasterVO smVO = new SalesMasterVO()
                {
                    PO_PlanID = _PlanID,
                    PO_WorkOrderID = dgv_PO.SelectedRows[0].Cells[1].Value.ToString(),
                    PO_CompanyName = dgv_PO.SelectedRows[0].Cells[2].Value.ToString(),
                    PO_CompanyType = dgv_PO.SelectedRows[0].Cells[3].Value.ToString(),
                    PO_CusProductName = dgv_PO.SelectedRows[0].Cells[4].Value.ToString(),
                    PO_ProductID = Convert.ToInt32(dgv_PO.SelectedRows[0].Cells[5].Value),
                    PO_OrderCnt = Convert.ToInt32(dgv_PO.SelectedRows[0].Cells[6].Value),
                    PO_DeadLine = Convert.ToDateTime(dgv_PO.SelectedRows[0].Cells[7].Value).ToString("yyyy-MM-dd"),
                    PO_UploadDate = DateTime.Now.ToString("yyyy-MM-dd")
                };

                SalesMasterService service = new SalesMasterService();
                bool result = service.InsertSalesMaster(smVO);

                if (result)
                    MessageBox.Show("정보가 입력 되었습니다.");
                else
                    MessageBox.Show("처리중 오류가 발생 했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMasterCreate_Load(object sender, EventArgs e)
        {
            CommonUtil.AddGridTextColumn(dgv_PO, "계획 날짜", "planDate", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_PO, "순번", "순번", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_PO, "WORK_ORDER_ID", "WORK_ORDER_ID", DataGridViewContentAlignment.MiddleCenter, colWidth: 150);
            CommonUtil.AddGridTextColumn(dgv_PO, "업체명", "업체명", DataGridViewContentAlignment.MiddleCenter, colWidth: 120);
            CommonUtil.AddGridTextColumn(dgv_PO, "납품처", "납품처", DataGridViewContentAlignment.MiddleCenter, colWidth: 120);
            CommonUtil.AddGridTextColumn(dgv_PO, "입고P/NO", "입고P/NO", DataGridViewContentAlignment.MiddleCenter, colWidth: 120);
            CommonUtil.AddGridTextColumn(dgv_PO, "품목 번호", "품목ID", DataGridViewContentAlignment.MiddleCenter, colWidth: 150);
            CommonUtil.AddGridTextColumn(dgv_PO, "계획수량합계", "계획수량합계", DataGridViewContentAlignment.MiddleCenter, colWidth: 150);
            CommonUtil.AddGridTextColumn(dgv_PO, "납기일", "납기일", DataGridViewContentAlignment.MiddleCenter, colWidth: 120);


        }
    }
}
