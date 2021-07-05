using FinalProject1_DAC;
using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_winform.Service
{
    public class processEquipmentService
    {
        public bool InsertProcess(ProcessVO process)
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            bool result = dac.InsertProcess(process);
            dac.Dispose();

            return result;
        }

        public bool SaveEquipmentGroup(EquipmentGroupVO equipmentgroup)
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            bool result = dac.SaveEquipmentGroup(equipmentgroup);
            dac.Dispose();

            return result;
        }
    }
}
