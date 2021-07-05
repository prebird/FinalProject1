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
    public partial class frmCompanyInfoIns : Form
    {
       

        public frmCompanyInfoIns()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CompanyVO list = new CompanyVO();

            list.company_code = txtCompanyCode.Text;
            list.company_name = txtCompanyName.Text;
            list.company_type = cboCompanyType.Text;
            list.company_ceo = txtCompanyCeo.Text;
            list.company_crum = txtCompanyCrum.Text;
            list.company_email = txtCompanyEmail.Text;
            list.company_phone = txtCompanyPhone.Text;
            list.company_yn = cboCompanyYN.Text;
            list.company_uadmin = txtCompanyUadmin.Text;
            list.company_udate = dtpDateTime.Text;
            list.company_comment = txtCompanyComment.Text;

            CompanyService service = new CompanyService();
            bool result = service.InsUpCompany(list);

            if(result)
            {
                MessageBox.Show("업체 정보가 입력 되었습니다.");
            }

            else
            {
                MessageBox.Show("처리중 오류가 발생하였습니다.");
            }

            
        }

        private void frmCompanyInfoIns_Load(object sender, EventArgs e)
        {
            dtpDateTime.Value = DateTime.Now;
        }
    }
}
