using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class EquipmentVO
    {
        public int EquipmentID { get; set; }
        public int ProcessID { get; set; }
        public string ProcessCode { get; set; }
        public string ProcessName { get; set; }
        public int EquipmentGroupID { get; set; }
        public string EquipmentGroupCode { get; set; }
        public string EquipmentGroupName { get; set; }
        public string EquipmentCode { get; set; }
        public string EquipmentName { get; set; }
        public string Status { get; set; }
        public string INS_EMP { get; set; }
        public string INS_DATE { get; set; }
        public string IsActive { get; set; }
        public int FromLocationID { get; set; }
        public int ToLocationID { get; set; }
    }
}
