using FinalProject1_DAC;
using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_winform
{
    public class WorkOrderService
    {
        public List<WorkOrderVO> GetAllWorkOrder()
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            List<WorkOrderVO> list = dac.GetAllWorkOrder();
            dac.Dispose();

            return list;
        }
    }
}
