using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    public partial class frmRestockOrderPopUP : Form
    {
        MRPSearchVO _search = new MRPSearchVO();
        int _companyid = 0;
        string checkValid = "";

        public frmRestockOrderPopUP(MRPSearchVO search)
        {
            InitializeComponent();
            _search = search;
            
        }

        private void frmRestockOrderPopUP_Load(object sender, EventArgs e)
        {
            CommonUtil.ComboBindingCompanyID(cboCompany);
            CommonUtil.ComboBindingItemID(cboParts);

            CommonUtil.SetInitGridView(dgvRO);
            CommonUtil.AddGridTextColumn(dgvRO, "품번", "Itemid", colWidth: 60);
            CommonUtil.AddGridTextColumn(dgvRO, "품명", "Item_Name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvRO, "발주제안일", "out_dt", colWidth: 80);
            CommonUtil.AddGridTextColumn(dgvRO, "발주제안량", "suggestQty", colWidth:80);
            CommonUtil.AddGridTextColumn(dgvRO, "발주량", "Qty", colWidth:70);

            CommonUtil.SetInitGridView(dgvCompany);
            CommonUtil.AddGridTextColumn(dgvCompany, "번호", "company_id", colWidth: 60);
            CommonUtil.AddGridTextColumn(dgvCompany, "사명", "company_name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvCompany, "리드타임", "LeadTime", colWidth: 80);
            CommonUtil.AddGridTextColumn(dgvCompany, "최소주문량", "MOQ", colWidth: 80);
            CommonUtil.AddGridTextColumn(dgvCompany, "단위수량", "UnitQuantity", colWidth: 80);
            CommonUtil.AddGridTextColumn(dgvCompany, "가격", "price", colWidth: 60);

            ROSuggestBinding();
        }

        //닫기
        private void button_gudi1_Click(object sender, EventArgs e)
        {

        }

        private void ROSuggestBinding()
        {
            RestockService service = new RestockService();
            DataTable dt =  service.GetROSuggest(_search);
            dgvRO.DataSource = dt;
        }

        private void CompanyItemBinding(int itemid)
        {
            CompanyItemDAC dac = new CompanyItemDAC();
            List<CompanyItemVO> list = dac.GetCompanyItemByItemid(itemid);
            dgvCompany.DataSource = list;
        }

        // 그리드뷰
        private void dgvRO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int itemid = Convert.ToInt32(dgvRO.Rows[e.RowIndex].Cells[0].Value);
            CompanyItemBinding(itemid);

            //
            dtpSuggest.Value = Convert.ToDateTime(dgvRO.Rows[e.RowIndex].Cells[2].Value);
            txtSQ.Text = (dgvRO.Rows[e.RowIndex].Cells[3].Value == null) ? "" : dgvRO.Rows[e.RowIndex].Cells[3].Value.ToString();
            checkValid = (dgvRO.Rows[e.RowIndex].Cells[4].Value == null)? "" : dgvRO.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        // 그리드뷰
        private void dgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCompany.Text = dgvCompany.Rows[e.RowIndex].Cells[1].Value.ToString();
            _companyid = Convert.ToInt32(dgvCompany.Rows[e.RowIndex].Cells[0].Value);
        }

        // dtp
        private void dtpSuggest_ValueChanged(object sender, EventArgs e)
        {
            dtpRO.Value = dtpSuggest.Value;
        }

        //txt
        private void txtSQ_TextChanged(object sender, EventArgs e)
        {
            txtQty.Text = txtSQ.Text;
        }

        //발주넣기
        private void btnRO_Click(object sender, EventArgs e)
        {
            // 유효성체크
            if (!txtQty.CheckNullOrEmptyOk("발주수량")) return;
            if (!txtCompany.CheckNullOrEmptyOk("거래처")) return;
            if (checkValid != "")
            {
                MessageBox.Show("이미 발주가 이루어진 주문입니다.");
                return;

            }

            // 발주 넣기
            RestockOrderVO restockOrderVO = new RestockOrderVO
            {
                itemid = Convert.ToInt32(dgvRO.SelectedRows[0].Cells[0].Value),
                Companyid = _companyid,
                SuggestQty = Convert.ToInt32(txtSQ.Text),
                Qty = Convert.ToInt32(txtQty.Text),
                RO_Status = "RO_1",
                dueDate = dtpRO.Value.ToString("yyyy-MM-dd"),
                unitPrice = Convert.ToInt32(dgvCompany.SelectedRows[0].Cells[5].Value),
                RegDate = DateTime.Now.ToShortDateString(),
            };

            RestockService service = new RestockService();
            if (service.insertRO(restockOrderVO))
            {
                MessageBox.Show("성공적으로 발주되었습니다.");
            }
            else
            {
                MessageBox.Show("다시 시도하여 주세요.");
            }
        }

        private void button_gudi1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
