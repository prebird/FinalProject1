using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class InventoryHistVO
    {
        public int ih_id { get; set; }
        public int factory_id { get; set; }
        public int Item_id { get; set; }
        public string PO_ID { get; set; }
        public int? RO_ID { get; set; }
        public int ih_product_count { get; set; }
        public string ih_category { get; set; }
        public string ih_uadmin { get; set; }
        public string ih_udate { get; set; }
        public string ih_comment { get; set; }
    }
}
