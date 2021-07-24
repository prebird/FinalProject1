using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class ProcessVO
    {
        public int ProcessID { get; set; }
        public string ProcessCode { get; set; }
        public string ProcessName { get; set; }
        public string IsActive { get; set; }
        public string INS_EMP { get; set; }
        public string INS_DATE { get; set; }
    }
}
