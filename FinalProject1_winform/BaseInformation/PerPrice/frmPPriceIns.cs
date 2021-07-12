using FinalProject1_DAC;
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

namespace FinalProject1_winform
{
    public partial class frmPPriceIns : Form
    {
        List<PerPriceVO> PerPrice;
        PerPriceVO info;
        List<CompanyItemVO> CompanyItem;
        public frmPPriceIns()
        {
            InitializeComponent();
        }

        private void frmPPriceIns_Load(object sender, EventArgs e)
        {

            PerPriceService service = new PerPriceService();
            PerPrice = service.GetAllPerPrice();
            CompanyItem = service.GetCompanyItem();
            CompanyItemVO blank = new CompanyItemVO();

            blank.company_id = 0;
            blank.company_code = "선택";
            blank.item_id = 0;
            blank.item_code = "선택";
            blank.item_category = "선택";

            CompanyItem.Insert(0, blank);

            CommonUtil.ComboBinding<CompanyItemVO>(cboCompanyCode, CompanyItem, "company_code", "company_id");
            CommonUtil.ComboBinding<CompanyItemVO>(cboItemCode, CompanyItem, "item_code", "item_id");
            CommonUtil.ComboBinding<CompanyItemVO>(cboItemCategory, CompanyItem, "item_category", "item_id");

        }

        private void cboCompanyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(cboCompanyCode.SelectedValue);
            info = PerPrice.Find((elem) => elem.company_id == companyId && elem.price_edate == "9999-12-31");
           
            if (companyId != 0)
            {
                if (info == null)
                {
                    txtPrice_present.Text = "0";
                }
                else
                {
                    
                    txtPrice_present.Text = info.price_present.ToString();
                    txtPrice_past.Text = info.price_past.ToString();
                    dtpsdate.Text = info.price_sdate;
                    txtedate.Text = info.price_edate;
                    txtUadmin.Text = info.price_uadmin;
                    txtUdate.Text = info.price_udate;
                    txtComment.Text = info.price_comment;
                }          
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPrice_present.Text == "0" || txtPrice_present.Text == "")
            {
                MessageBox.Show("현재단가를 입력해 주십시오.");
                return;
            }
            //최초 단가 등록
            if (info == null)
            {
                info = new PerPriceVO();
                int companyId = Convert.ToInt32(cboCompanyCode.SelectedValue);
                CompanyItemVO id = CompanyItem.Find((elem) => elem.company_id == companyId);
                info.CompanyItem_ID = id.CompanyItem_ID;
                info.company_id = Convert.ToInt32(cboCompanyCode.SelectedValue);
                info.Item_ID = Convert.ToInt32(cboItemCode.SelectedValue);
                info.price_present = Convert.ToInt32(txtPrice_present.Text);
                info.price_past = 0;
                info.price_sdate = DateTime.Now.ToString("yyyy-MM-dd");
                info.price_edate = "9999-12-31";
                info.price_uadmin = txtUadmin.Text;
                info.price_udate = DateTime.Now.ToString("yyyy-MM-dd");
                info.price_comment = txtComment.Text;
                info.price_yn = cboyn.Text;

                PerPriceService service = new PerPriceService();
                bool result = service.InsertPerPrice(info);
                if (result)
                {
                    MessageBox.Show("단가 정보가 입력되었습니다.");
                }

                else
                {
                    MessageBox.Show("처리중 오류가 발생하였습니다.");
                }

            }
            //단가 수정
            else
            {
                int companyId = Convert.ToInt32(cboCompanyCode.SelectedValue);
                CompanyItemVO id = CompanyItem.Find((elem) => elem.company_id == companyId);
                info.CompanyItem_ID = id.CompanyItem_ID;
                info.company_id = Convert.ToInt32(cboCompanyCode.SelectedValue);
                info.Item_ID = Convert.ToInt32(cboItemCode.SelectedValue);
                info.price_past = info.price_present;
                info.price_present = Convert.ToInt32(txtPrice_present.Text);
                info.price_sdate = DateTime.Now.ToString("yyyy-MM-dd");
                info.price_edate = "9999-12-31";
                info.price_uadmin = txtUadmin.Text;
                info.price_udate = DateTime.Now.ToString("yyyy-MM-dd");
                info.price_comment = txtComment.Text;
                info.price_yn = cboyn.Text;

                //트랜잭션(최종일자 수정, 새로운 단가 등록)
                PerPriceService service = new PerPriceService();
                bool result = service.InsUpPerPrice(info);
                if (result)
                {
                    MessageBox.Show("단가 정보가 입력되었습니다.");
                }

                else
                {
                    MessageBox.Show("처리중 오류가 발생하였습니다.");
                }
            }

      

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
