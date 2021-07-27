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

        public List<WorkOrderVO> GetWorkDoneRecord()
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            List<WorkOrderVO> list = dac.GetWorkDoneRecord();
            dac.Dispose();
            return list;
        }

        public bool WorkDone(string planID)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            bool result = dac.WorkDone(planID);
            return result;
        }
    }
}
