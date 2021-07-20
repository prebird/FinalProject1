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
    }
}
