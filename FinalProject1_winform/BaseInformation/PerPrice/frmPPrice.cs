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
   
    public partial class frmPPrice : Basic3
    {
        List<PerPriceVO> List;
        public frmPPrice()
        {
            InitializeComponent();
        }

        private void frmMaterialPrice_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvPprice);

            CommonUtil.AddGridTextColumn(dgvPprice, "업체", "Company_code", DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
            CommonUtil.AddGridTextColumn(dgvPprice, "업체명", "Company_name", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);
            CommonUtil.AddGridTextColumn(dgvPprice, "품목", "Item_code", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvPprice, "품명", "Item_name", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvPprice, "품명분류", "Item_Category", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvPprice, "현재단가", "price_present", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvPprice, "이전단가", "price_past", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvPprice, "시작일", "price_sdate", DataGridViewContentAlignment.MiddleCenter, colWidth: 200);
            CommonUtil.AddGridTextColumn(dgvPprice, "종료일", "price_edate", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgvPprice, "비고", "price_comment", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgvPprice, "사용유무", "price_yn", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgvPprice, "수정일", "price_udate", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgvPprice, "수정자", "price_uadmin", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);

            dtpdate.Value = DateTime.Now;
          

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerPriceService service = new PerPriceService();
            List = service.GetSelectedPrice(txtItemCode.Text, dtpdate.Text, cboCompanyCode.Text);
            dgvPprice.DataSource = List;
            dgvPprice.ClearSelection();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmPPriceIns frm = new frmPPriceIns();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
