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
        public int Item_ID { get; set; }
        public int company_id { get; set; }
        public int price_present { get; set; }
        public int price_past { get; set; }
        public string price_sdate { get; set; }
        public string price_edate { get; set; }
        public string price_yn { get; set; }
        public string price_uadmin { get; set; }
        public string price_udate { get; set; }
        public string price_comment { get; set; }
        public string item_category { get; set; }
        public string item_name { get; set; }
        public string company_name { get; set; }
        public string company_code { get; set; }
        public string item_code { get; set; }
    }
    public class CompanyItemVO

    {
        public int CompanyItem_ID { get; set; }
        public int item_id { get; set; }
        public string item_category { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public int company_id { get; set; }
        public string company_code { get; set; }

    }

}
