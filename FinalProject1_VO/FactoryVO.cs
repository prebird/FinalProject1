using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public  class FactoryVO
    {
        public int factory_id { get; set; }
        public string factory_grade { get; set; }
        public string factory_parent { get; set; }
        public string factory_name { get; set; }
        public string factory_code { get; set; }
        public string factory_type { get; set; }
        public int company_id { get; set; }
        public string factory_yn { get; set; }
        public string factory_uadmin { get; set; }
        public string factory_udate { get; set; }
        public string factory_comment { get; set; }
        public int deleted { get; set; }
    }
}
