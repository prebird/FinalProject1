using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class CompanyItemVO

    {
        public int CompanyItem_ID { get; set; }
        public int item_id { get; set; }
        public string Item_Name { get; set; }
        public string item_category { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public int company_id { get; set; }
        public string company_name { get; set; }
        public string company_code { get; set; }
        public int LeadTime { get; set; }
        public int MOQ { get; set; }
        public int UnitQuantity { get; set; }
        public int price { get; set; }

    }
}
