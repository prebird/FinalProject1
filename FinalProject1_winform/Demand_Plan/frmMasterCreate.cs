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
    public partial class frmMasterCreate : FinalProject1_winform.Basic3
    {
        public frmMasterCreate()
        {
            InitializeComponent();
        }

        // 영업 마스터 업로드 후 그리드뷰 출력
        private void btn_POExcel_Click(object sender, EventArgs e)
        {
            frmPOUpload frm = new frmPOUpload();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                dgv_PO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_PO.AllowUserToAddRows = false;

                DataTable dt = frm.ExcelData;
                string planDate = frm.PlanDate;

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

            if (MessageBox.Show("생성 하시겠습니까?", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


            SalesMasterVO smVO = new SalesMasterVO()
            {
                



            };

                //SMService service = new SMService();
                ////bool result = service.InsertUpdateItem(item);

                //if (result)
                //    MessageBox.Show("정보가 입력 되었습니다.");
                //else
                //    MessageBox.Show("처리중 오류가 발생 했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void frmMasterCreate_Load(object sender, EventArgs e)
        {
            CommonUtil.AddGridTextColumn(dgv_PO, "계획 날짜", "planDate", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);

        }
    }
}
