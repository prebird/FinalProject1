using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class ProductionPlanVO
    {
        public int ProductionPlanID { get; set; }
        public string PlanID { get; set; }
        public string Status { get; set; }
        public string INS_EMP { get; set; }
        public DateTime INS_DATE { get; set; }

        //DetailVO
        public int PlanDetailID { get; set; }
        public int BORID { get; set; }
        public DateTime PlanDate { get; set; }
        public int Quantity { get; set; }
    }
}
