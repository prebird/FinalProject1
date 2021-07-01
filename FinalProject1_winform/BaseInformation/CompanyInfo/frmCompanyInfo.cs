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
    public partial class frmCompanyInfo : Basic3
    {
        List<CompanyVO> list;

        public frmCompanyInfo()
        {
            InitializeComponent();
        }

        private void frmCompanyInfo_Load(object sender, EventArgs e)
        {
            cboCompanyType.Text = "선택";

            CommonUtil.SetInitGridView(dgV_Company);
            CommonUtil.AddGridTextColumn(dgV_Company, "업체코드", "company_code", DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
            CommonUtil.AddGridTextColumn(dgV_Company, "업체명", "company_name", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);
            CommonUtil.AddGridTextColumn(dgV_Company, "업체타입", "company_type", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgV_Company, "대표자명", "company_ceo", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgV_Company, "사업자등록번호", "company_crum", DataGridViewContentAlignment.MiddleCenter, colWidth: 200);
            CommonUtil.AddGridTextColumn(dgV_Company, "이메일", "company_email", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgV_Company, "전화번호", "company_phone", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);

            LoadData();
        }

        //전체 조회
        private void LoadData()
        {
            CompanyService service = new CompanyService();
            list = service.GetAllCompany();
            dgV_Company.DataSource = list;
            dgV_Company.ClearSelection();
        }

        //검색조건 조회
        private void btmSearch_Click(object sender, EventArgs e) 
        {
            string companyCode = txtCompanyCode.Text;
            string companyName = txtCompanyName.Text;
            string companyCrum = txtCompanyCrum.Text;
            string companyType = cboCompanyType.Text;

            CompanyService service = new CompanyService();
            list = service.SearchCompany(companyCode, companyName, companyCrum, companyType);
            dgV_Company.DataSource = list;
            dgV_Company.ClearSelection();
           
        }

        //업체 등록
        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmCompanyInfoIns companyIns = new frmCompanyInfoIns();
            companyIns.ShowDialog();

        }
    }
}
