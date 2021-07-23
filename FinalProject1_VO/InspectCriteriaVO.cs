using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class InspectCriteriaVO
    {
        public int Inc_ID { get; set; }
        public int Item_ID { get; set; }
        public string Item_Name { get; set; }
        public double Mean { get; set; }
        public double USL { get; set; }
        public double LSL { get; set; }
    }
}
