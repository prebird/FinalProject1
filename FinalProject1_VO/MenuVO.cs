﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class MenuVO
    {
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public int MenuLevel { get; set; }
        public int refMenuID { get; set; }
        public string ProgramName { get; set; }
        public int AuthID { get; set; }
        public string AuthName { get; set; }
        public string menu_uadmin { get; set; }
        public string user_name { get; set; }
        public string menu_udate { get; set; }
        public string menu_Img { get; set; }

    }
}
