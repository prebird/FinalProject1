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
    public partial class frmFactory : Basic3
    {
        public frmFactory()
        {
            InitializeComponent();
        }

        private void frmFactory_Load(object sender, EventArgs e)
        {
            cboFactoryGrade.Text = "선택";

            CommonUtil.SetInitGridView(dgv_Factory);
            CommonUtil.AddGridTextColumn(dgv_Factory, "업체코드", "company_code", DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
            CommonUtil.AddGridTextColumn(dgv_Factory, "업체명", "company_name", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);
            CommonUtil.AddGridTextColumn(dgv_Factory, "업체타입", "company_type", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_Factory, "대표자명", "company_ceo", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_Factory, "사업자등록번호", "company_crum", DataGridViewContentAlignment.MiddleCenter, colWidth: 200);
            CommonUtil.AddGridTextColumn(dgv_Factory, "이메일", "company_email", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgv_Factory, "전화번호", "company_phone", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
        }
    }
}
