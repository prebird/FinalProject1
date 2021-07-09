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
    public partial class frmFactoryIns : Form
    {
        FactoryVO FactoryList = new FactoryVO();
        List<CompanyVO> CompanyInfo;
        public frmFactoryIns()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        //   if (MessageBox.Show(btnSave.Text + "하시겠습니까", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //   {
        //       int itemID = (FactoryList != null) ? FactoryList.factory_id : 0;
        //        CompanyService service = new CompanyService();
        //        CompanyInfo = service.GetAllCompanyCode();
                
          
        //        FactoryVO factoryInfo = new FactoryVO()
        //       {
        //           factory_id = FactoryList.factory_id,
        //           factory_grade = cboFactoryGrade.Text,
        //           factory_parent = cboFactoryParent.Text,
        //           factory_name = txtFactoryName.Text,
        //           factory_code = txtFactoryCode.Text,
        //           factory_type = cboCompanyType.Text,
        //           company_id =  
        //           //factory_yn =
        //           //factory_uadmin=
        //           //factory_udate=
        //           //factory_comment=
          
          
        //       };
          
        //       Companylist = companyinfo;
          
               
        //       bool result = service.InsUpCompany(Companylist);
          
        //       if (result)
        //       {
        //           MessageBox.Show("업체 정보가 입력 되었습니다.");
        //       }
          
        //       else
        //       {
        //           MessageBox.Show("처리중 오류가 발생하였습니다.");
        //       }
          
        //   }
          
        //   this.DialogResult = DialogResult.OK;
        //   this.Close();
        }
    }
}
