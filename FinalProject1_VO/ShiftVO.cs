using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class ShiftVO
    {
        public int Shift_ID { get; set; }
        public int m_ID { get; set; }
        public string shift_stime { get; set; }
        public string shift_etime { get; set; }
        public string shift_sdate { get; set; }
        public string shift_edate { get; set; }
        public string shift_yn { get; set; }
        public string shift_uadmin { get; set; }
        public string shift_udate { get; set; }
        public string shift_comment { get; set; }

    }
}
