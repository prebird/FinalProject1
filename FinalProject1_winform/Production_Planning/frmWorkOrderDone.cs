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
    public partial class frmWorkOrderDone : FinalProject1_winform.Basic3
    {
        List<WorkOrderVO> worklist = new List<WorkOrderVO>();
        public frmWorkOrderDone()
        {
            InitializeComponent();
        }

        private void frmWorkOrderDone_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvDone);
            CommonUtil.SetInitGridView(dgvCart);
            CommonUtil.AddGridTextColumn(dgvDone, "PlanID", "PlanID");
            CommonUtil.AddGridTextColumn(dgvDone, "작업번호", "WorkOrderID", colWidth: 150);
            CommonUtil.AddGridTextColumn(dgvDone, "품목명", "Item_Name");
            CommonUtil.AddGridTextColumn(dgvDone, "완료날짜", "pro_date");
            CommonUtil.AddGridTextColumn(dgvDone, "상태", "Status");
            CommonUtil.AddGridTextColumn(dgvCart, "PlanID", "PlanID");
            CommonUtil.AddGridTextColumn(dgvCart, "작업번호", "WorkOrderID", colWidth: 150);
            CommonUtil.AddGridTextColumn(dgvCart, "품목명", "Item_Name");
            CommonUtil.AddGridTextColumn(dgvCart, "완료날짜", "pro_date");
            CommonUtil.AddGridTextColumn(dgvCart, "상태", "Status");

            WorkOrderService service = new WorkOrderService();
            List<WorkOrderVO> list = service.GetWorkDoneRecord();
            dgvCart.DataSource = new BindingList<WorkOrderVO>(list);

        }

        private void dgvCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            WorkOrderVO item = new WorkOrderVO();
            item.PlanID = dgvCart["PlanID", e.RowIndex].Value.ToString();
            item.WorkOrderID = dgvCart["WorkOrderID", e.RowIndex].Value.ToString();
            item.Item_Name = dgvCart["Item_Name", e.RowIndex].Value.ToString();
            item.pro_date = dgvCart["pro_date", e.RowIndex].Value.ToString();
            item.Status = dgvCart["Status", e.RowIndex].Value.ToString();

            worklist.Add(item);
            dgvDone.DataSource = null;
            dgvDone.DataSource = worklist;
        }

        private void button_gudi2_Click(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            for (int i = 0; i < worklist.Count; i++)
            {
                WorkOrderVO item = worklist[i];
                bool result = service.WorkDone(item.PlanID);
                if (!result)
                {
                    MessageBox.Show("저장 실패");
                    return;
                }
                else if (result)
                {
                    worklist.Remove(item);
                    dgvDone.DataSource = null;
                    dgvDone.DataSource = worklist;
                    if(worklist.Count == 0)
                    {
                        MessageBox.Show("저장 성공");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    return;
                }
            }
        }
    }
}
