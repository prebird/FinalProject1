using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class InventoryVO
    {
        public int Inventory_id { get; set; }
        public int factory_id { get; set; }
        public int count_present { get; set; }
        public string plan_id { get; set; }
        public int ro_id { get; set; }
    }
}
