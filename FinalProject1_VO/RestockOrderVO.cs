using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class RestockOrderVO
    {
        public string RO_ID { get; set; }
        public string RO_Serial { get; set; }
        public string itemid { get; set; }
        public string Companyid { get; set; }
        public string SuggestQty { get; set; }
        public string Qty { get; set; }
        public string dueDate { get; set; }
        public string unitPrice { get; set; }
        public string RegDate { get; set; }
        public string planid { get; set; }
        public string inputFlag { get; set; }
    }
}
