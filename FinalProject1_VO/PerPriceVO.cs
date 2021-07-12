using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class PerPriceVO
    {
       public int price_id { get; set; }
       public int CompanyItem_ID { get; set; }
       public int product_id { get; set; }
       public int company_id { get; set; }
       public string price_present { get; set; }
       public string price_past { get; set; }
       public string price_sdate { get; set; }
       public string price_edate { get; set; }
       public string price_yn { get; set; }
       public string price_uadmin { get; set; }
       public string price_udate { get; set; }
       public string price_comment { get; set; }
    }
}
