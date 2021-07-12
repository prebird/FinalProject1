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
        List<CompanyItemVO> PerPrice;
        public frmPPriceIns()
        {
            InitializeComponent();
        }

        private void frmPPriceIns_Load(object sender, EventArgs e)
        {
            PerPriceService service = new PerPriceService();
            PerPrice = service.GetCompanyItem();
            CompanyItemVO blank = new CompanyItemVO();

            blank.company_id = 0;
            blank.company_code = "선택";
            blank.item_id = 0;
            blank.item_name = "선택";

           // CommonUtil.ComboBinding<>


        }
    }
}
