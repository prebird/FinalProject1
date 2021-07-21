using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class ItemVO
    {
        public int Item_ID { get; set; }
        public string Item_Category { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public int Item_UnitQTY { get; set; }
        public string Item_CheckType { get; set; }
        public string Item_OrderType { get; set; }
        public int Item_SafetyQTY { get; set; }
        public string Item_InHouse { get; set; }
        public string Item_OutHouse { get; set; }
        public string Item_YN { get; set; }
        public string Item_Content { get; set; }

        public string Item_img { get; set; }
    }
}
