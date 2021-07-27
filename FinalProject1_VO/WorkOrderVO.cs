using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class WorkOrderVO
    {
        public string WorkOrderID { get; set; }
        public string PlanID { get; set; }
        public string EmpID { get; set; }
        public string user_name { get; set; }
        public string WorkDate { get; set; }
        public int BORID { get; set; }
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public int Item_ID { get; set; }
        public string Item_Name { get; set; }
        public string Status { get; set; }
        public int OrderQuantity { get; set; }
        public string pro_date { get; set; }
    }
}
