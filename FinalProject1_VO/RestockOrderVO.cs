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
        public string RO_Serial { get; set; }
        public int itemid { get; set; }
        public int Companyid { get; set; }
        public int SuggestQty { get; set; }
        public int Qty { get; set; }
        public string dueDate { get; set; }
        public int unitPrice { get; set; }
        public string RegDate { get; set; }
        public int planid { get; set; }
        public string inputFlag { get; set; }
    }
}
