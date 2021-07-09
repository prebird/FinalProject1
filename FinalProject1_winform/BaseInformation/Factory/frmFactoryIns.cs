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

        public frmFactoryIns()
        {
            InitializeComponent();
        }

        public frmFactoryIns(FactoryVO factory)
        {
            InitializeComponent();

            FactoryList = factory;

            cboFactoryGrade.Text = factory.factory_grade;
            cboFactoryParent.Text = factory.factory_parent;
            txtFactoryName.Text = factory.factory_name;
            txtFactoryCode.Text = factory.factory_code;
            cboCompanyType.Text = factory.factory_type;
            cboCompanyCode.SelectedValue = factory.company_id;
            cboFactoryYN.Text = factory.factory_yn;
            txtuadmin.Text = factory.factory_uadmin;
            dtpDateTime.Value = DateTime.Now;
            txtFactoryComment.Text = factory.factory_comment;
        }

        private void frmFactoryIns_Load(object sender, EventArgs e)
        {

            CompanyService service = new CompanyService();
            List<CompanyVO> list = service.GetAllCompanyCode();
            CompanyVO com = new CompanyVO();
            com.company_id = 0;
            com.company_code = "선택";
            list.Insert(0, com);
            CommonUtil.ComboBinding<CompanyVO>(cboCompanyCode, list, "company_code", "company_id");

            dtpDateTime.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnSave.Text + "하시겠습니까", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int itemID = (FactoryList != null) ? FactoryList.factory_id : 0;


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
                    factory_uadmin = txtuadmin.Text,
                    factory_udate = dtpDateTime.Text,
                    factory_comment = txtFactoryComment.Text
                };

                FactoryList = factoryInfo;

                FactoryService fService = new FactoryService();
                bool result = fService.InsUpFactory(FactoryList);

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

