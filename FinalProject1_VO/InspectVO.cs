using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class InspectVO
    {
        public int insp_id { get; set; }
        public int ins_id { get; set; }
        public int insp_okCnt { get; set; }
        public int insp_noCnt { get; set; }
        public string insp_date { get; set; }
        public string insp_user { get; set; }
        public string insp_result { get; set; }
        public int Ro_id { get; set; }
        public int ins_cnt { get; set; }
        public string ins_date { get; set; }
        public string Item_Name { get; set; }
        public int Item_ID { get; set; }

    }
}
