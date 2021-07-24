using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class RestockOrderVO
    {
        public int RO_ID { get; set; }
        public int itemid { get; set; }
        public string Item_Name { get; set; }
        public int Companyid { get; set; }
        public string company_name { get; set; }
        public int SuggestQty { get; set; }
        public int Qty { get; set; }
        public string RO_Status { get; set; }
        public string dueDate { get; set; }
        public int unitPrice { get; set; }
        public string RegDate { get; set; }
        public int planid { get; set; }
        public string inputFlag { get; set; }

        public int ins_cnt { get; set; }
        public string ins_date { get; set; }
    }
}
