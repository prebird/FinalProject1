using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    public class ProductionPlanService
    {
        public DataTable GetPlanList(string fromDate, string toDate)
        {
            ProductPlanDAC dac = new ProductPlanDAC();
            DataTable dt = dac.GetPlanList(fromDate,toDate);
            dac.Dispose();
            return dt;
        }

        public DataTable GetSpecialPlanList(string fromDate, string toDate, string ItemName, string EquipmentName, string planID)
        {
            ProductPlanDAC dac = new ProductPlanDAC();
            DataTable dt = dac.GetSpecialPlanList(fromDate, toDate, ItemName, EquipmentName, planID);
            dac.Dispose();
            return dt;
        }
    }
}
