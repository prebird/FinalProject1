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
            CompanyService service = new CompanyService();
            list = service.GetCompanyCode();

            cboCompanyType.DisplayMember = "선택";
            cboCompanyType.DataSource = list;
        
        }

        //private void ComboBinding<T>(ComboBox cbo, List<T> list, string displayMember, string valueMember)
        //{
        //    cbo.DisplayMember = displayMember;
        //    cbo.ValueMember = valueMember;
        //    cbo.DataSource = list;
        //}
    }
}
