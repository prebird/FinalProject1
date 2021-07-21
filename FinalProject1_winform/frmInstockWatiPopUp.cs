using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_DAC;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public partial class frmInstockWatiPopUp : Form
    {
        List<RestockOrderVO> throwedWaits;
        public frmInstockWatiPopUp(List<RestockOrderVO> waits)
        {
            InitializeComponent();
            throwedWaits = waits;

            CommonUtil.SetInitGridView(dgv1);
            CommonUtil.AddGridTextColumn(dgv1, "발주번호", "RO_ID", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "품명", "Item_Name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "회사명", "company_name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "발주상태", "RO_Status", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "납기일", "dueDate", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "발주량", "Qty", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "입고량", "ins_cnt", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv1, "입고일자", "ins_date", colWidth: 90);
        }

        private void frmInstockWatiPopUp_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = throwedWaits;
        }

        private void dgV_gudi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 바인딩
            int roid = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[0].Value);
            RestockOrderVO thisRO = throwedWaits.Find((x) => x.RO_ID == roid);

            txtRO.Text = thisRO.RO_ID.ToString();
            txtItem.Text = thisRO.Item_Name;
            txtCompany.Text = thisRO.company_name;
            txtDue.Text = thisRO.dueDate;
            txtQty.Text = thisRO.Qty.ToString();
        }

        //저장
        private void button_gudi2_Click(object sender, EventArgs e)
        {
            // 유효성체크
            if (!txtInQty.CheckNullOrEmptyOk("입고수량")) return;

            // DB업데이트
            

            // 전역변수 바꾸기

        }

        //닫기
        private void button_gudi1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
