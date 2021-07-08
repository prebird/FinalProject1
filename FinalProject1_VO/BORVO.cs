using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class BORVO
    {
        public int BORID { get; set; }
        public int ItemID { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ProcessID { get; set; }
        public string ProcessCode { get; set; }
        public int EquipmentID { get; set; }
        public string EquipmentCode { get; set; }
        public int Tact_Time { get; set; }
        public int Priority { get; set; }
        public string IsUse { get; set; }
        public int Deleted { get; set; }
        public string INS_EMP { get; set; }
        public string INS_DATE { get; set; }
        public string Remark { get; set; }
    }
}
