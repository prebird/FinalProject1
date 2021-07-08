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
        CompanyVO Companylist = new CompanyVO();

        public frmCompanyInfoIns()
        {
            InitializeComponent();
        }

        public frmCompanyInfoIns(CompanyVO company)
        {
            InitializeComponent();

            Companylist = company;

            txtCompanyCode.Text = company.company_code;
            txtCompanyName.Text = company.company_name;
            cboCompanyType.Text = company.company_type;
            txtCompanyCeo.Text = company.company_ceo;
            txtCompanyCrum.Text = company.company_crum;
            txtCompanyEmail.Text = company.company_email;
            txtCompanyPhone.Text = company.company_phone;
            cboCompanyYN.Text = company.company_yn;
            txtCompanyUadmin.Text = company.company_uadmin;
            dtpDateTime.Value = DateTime.Now;
            txtCompanyComment.Text = company.company_comment;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnSave.Text + "하시겠습니까", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int itemID = (Companylist != null) ? Companylist.company_id : 0;

                CompanyVO companyinfo = new CompanyVO()
                {
                    company_id = Companylist.company_id,
                    company_code = txtCompanyCode.Text,
                    company_name = txtCompanyName.Text,
                    company_type = cboCompanyType.Text,
                    company_ceo = txtCompanyCeo.Text,
                    company_crum = txtCompanyCrum.Text,
                    company_email = txtCompanyEmail.Text,
                    company_phone = txtCompanyPhone.Text,
                    company_yn = cboCompanyYN.Text,
                    company_uadmin = txtCompanyUadmin.Text,
                    company_udate = dtpDateTime.Text,
                    company_comment = txtCompanyComment.Text
                };

                Companylist = companyinfo;
               
                CompanyService service = new CompanyService();
                bool result = service.InsUpCompany(Companylist);

                if (result)
                {
                    MessageBox.Show("업체 정보가 입력 되었습니다.");
                }

                else
                {
                    MessageBox.Show("처리중 오류가 발생하였습니다.");
                }

            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmCompanyInfoIns_Load(object sender, EventArgs e)
        {
            dtpDateTime.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
