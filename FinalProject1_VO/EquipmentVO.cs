using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class EquipmentVO
    {
        public int ProcessID { get; set; }
        public int EquipmentGroupID { get; set; }
        public string EquipmentCode { get; set; }
        public string EquipmentName { get; set; }
        public string Status { get; set; }
        public string INS_EMP { get; set; }
        public char IsActive { get; set; }
        public string FromLocationID { get; set; }
        public string ToLocationID { get; set; }
    }
}
