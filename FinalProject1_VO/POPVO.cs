using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_VO
{
    public class POPVO
    {     
        //유저 정보
      public string user_id { get; set; }
      public string user_pwd { get; set; }
      public string user_name { get; set; }
      public string user_Category { get; set; }
      public string user_birthday { get; set; }
      public string user_depart_id { get; set; }
      public string user_email { get; set; }
      public string user_pic { get; set; }
      public int authID { get; set; }
      public string deleted { get; set; }
    }

    public class POPUserVO
    {
        public string WorkOrderID { get; set; }
        public string Item_Code { get; set; }
        public string WorkDate { get; set; }
        public string Status { get; set; }
        public int OrderQuantity { get; set; }

    }

    public class POPProcessVO
    {
        public int ProcessID { get; set; }
        public string ProcessCode { get; set; }
        public string ProcessName { get; set; }
       
    }

    public class POPItemVO
    {
        public int Item_ID { get; set; }
        public string Item_Category { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public int Item_UnitQTY { get; set; }
    }

    public class POPWorkOrderVO
    {
        public string  WorkOrderID { get; set; }
        public string  PlanID { get; set; }
        public string  Item_code { get; set; }
        public string  EquipmentName { get; set; }
        public string  pd_stime { get; set; }
        public string  pd_etim { get; set; }

    }
}
