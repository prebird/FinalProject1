using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class DemandPlanVO
    {
        public int Dplan_ID { get; set; }
        public int PO_ID { get; set; } // SalesMaster 번호
        public string PlanID { get; set; } // 생성시 SalesMaster 또한 Update
        public string Dplan_Date { get; set; } // SalesMaster 납기일
        public int Dplan_Quantity { get; set; } // SalesMaster 계획 총합량

        // 수요 계획 검색을 위한 VO

        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }


       

}
