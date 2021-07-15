using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class MRPVO
    {
        public int itemid { get; set; }
        public string Item_Name { get; set; }
        public string gubun { get; set; }
        public int SortNum { get; set; }
    }

    public class MRPSearchVO
    {
        public string PlanID { get; set; } // dp에서 planid에 해당하는거 보여주기
        public string FromDate { get; set; }
        public string Todate { get; set; }
        public int ProductID { get; set; }
    }
}
