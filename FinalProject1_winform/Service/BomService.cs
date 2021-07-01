using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    class BOMService
    {
        public int BOM_ID { get; set; }
        public int Item_ID { get; set; }
        public int BOM_UseQTY { get; set; }
        public int BOM_LEVEL { get; set; }
        public string BOM_YN { get; set; }
        public string BOM_DemandYN { get; set; }
        public string BOM_EditManager { get; set; }
        public string BOM_EditDate { get; set; }
        public string BOM_Content { get; set; }
    }
}
