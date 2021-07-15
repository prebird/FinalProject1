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
        List<FactoryVO> FactoryInfo;
        List<CommonCodeVO> TypeInfo;
        bool isUpdate = false;
        public frmFactoryIns()
        {
            InitializeComponent();
        }

        public frmFactoryIns(FactoryVO selected)
        {
            InitializeComponent();

            isUpdate = true;

            FactoryList = selected;

            FactoryList.factory_id = selected.factory_id;
            cboFactoryGrade.Text = selected.factory_grade;
            txtFactoryName.Text = selected.factory_name;
            txtFactoryCode.Text = selected.factory_code;
            cboFactoryYN.Text = selected.factory_yn;
            txtUadmin.Text = selected.factory_uadmin;
            dtpUdate.Value = DateTime.Now;
            txtFactoryComment.Text = selected.factory_comment;


        }

        private void frmFactoryIns_Load(object sender, EventArgs e)
        {

            dtpUdate.Value = DateTime.Now;

            FactoryService service = new FactoryService();
            CommonService sservice = new CommonService();
            TypeInfo = sservice.GetCommonCode("Facility_type");
            FactoryInfo = service.GetFactoryGrade();
            List<FactoryVO> factoryParent = service.GetFactoryParent();
            CompanyInfo = service.GetCompanyInfo();

          //  FactoryVO fitem = new FactoryVO();
           // fitem.factory_code = "";
            // fitem.factory_grade = "선택";
           // fitem.factory_parent = "선택";
            CompanyVO citem = new CompanyVO();
            citem.company_code = "선택";
            citem.company_id = 0;
            CommonCodeVO type = new CommonCodeVO();
            type.common_value = "";
            type.common_name = "선택";

          //  FactoryInfo.Insert(0, fitem);
          //  factoryParent.Insert(0, fitem);
            CompanyInfo.Insert(0, citem);
            TypeInfo.Insert(0, type);

            //FactroyInfo를 다르게 줘야할 듯 
            // CommonUtil.ComboBinding<FactoryVO>(cboFactoryGrade, FactoryInfo, "factory_grade", "factory_code");
            //CommonUtil.ComboBinding<FactoryVO>(cboFactoryParent, factoryParent, "factory_parent", "factory_code");
            CommonUtil.ComboBinding<CompanyVO>(cboCompanyCode, CompanyInfo, "Company_code", "Company_id");
            CommonUtil.ComboBinding<CommonCodeVO>(cboCompanyType, TypeInfo, "common_name", "common_value");

            if (isUpdate)
            {
                cboFactoryParent.Text = FactoryList.factory_parent;
                int company_id = FactoryList.company_id;
                
                CompanyVO companyCode = CompanyInfo.Find((elem) => elem.company_id == company_id);
                cboCompanyCode.Text = companyCode.company_code;
                cboCompanyType.Text = FactoryList.factory_type;
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnSave.Text + "하시겠습니까", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int itemID = (FactoryList != null) ? FactoryList.factory_id : 0;
                FactoryService service = new FactoryService();


                FactoryVO factoryInfo = new FactoryVO()
                {
                    factory_id = FactoryList.factory_id,
                    factory_grade = cboFactoryGrade.Text,
                    factory_parent = cboFactoryParent.Text,
                    factory_name = txtFactoryName.Text,
                    factory_code = txtFactoryCode.Text,
                    factory_type = cboCompanyType.Text,
                    company_id = Convert.ToInt32(cboCompanyCode.SelectedValue),
                    factory_yn = cboFactoryYN.Text,
                    factory_uadmin = txtUadmin.Text,
                    factory_udate = dtpUdate.Value.ToString(),
                    factory_comment = txtFactoryComment.Text
                };

                FactoryList = factoryInfo;


                bool result = service.InsUpFactory(FactoryList);
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
    }

}
