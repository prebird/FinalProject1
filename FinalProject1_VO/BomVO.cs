using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class BomVO
    {
        public int BOM_ID { get; set; }
        public int BOM_MoItemID { get; set; }
        public int BOM_JaItemID { get; set; }
        public int BOM_UseQTY { get; set; } // 소요량
        public int BOM_LEVEL { get; set; }
        public string BOM_YN { get; set; }
        public string BOM_DemandYN { get; set; } // 소요 계획 사용 여부
        public string BOM_Content { get; set; }
    }
}
