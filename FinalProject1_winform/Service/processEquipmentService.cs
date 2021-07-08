using FinalProject1_DAC;
using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_winform
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

        public List<ProcessVO> GetAllProcess()
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            List<ProcessVO> list = dac.GetAllProcess();
            dac.Dispose();

            return list;
        }

        public List<EquipmentGroupVO> GetAllEquipmentGroup()
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            List<EquipmentGroupVO> list = dac.GetAllEquipmentGroup();
            dac.Dispose();

            return list;
        }

        public bool SaveEquipment(EquipmentVO equipment)
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            bool result = dac.SaveEquipment(equipment);
            dac.Dispose();

            return result;
        }

        public List<EquipmentVO> GetAllEquipment()
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            List<EquipmentVO> list = dac.GetAllEquipment();
            dac.Dispose();

            return list;
        }

        public bool DeleteEquipment(string equipmentCode)
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            bool result = dac.DeleteEquipment(equipmentCode);
            dac.Dispose();

            return result;
        }

        public List<ProcessVO> GetAllProcessInfo()
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            List<ProcessVO> list = dac.GetAllProcessInfo();
            dac.Dispose();

            return list;
        }

        public bool DeleteProcess(string processCode)
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            bool result = dac.DeleteProcess(processCode);
            dac.Dispose();

            return result;
        }

        public List<EquipmentGroupVO> GetEquipmentGroupInfo()
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            List<EquipmentGroupVO> list = dac.GetEquipmentGroupInfo();
            dac.Dispose();

            return list;
        }

        public bool DeleteEquipmentGroup(string equipmentgroupCode)
        {
            ProcessEquipmentDAC dac = new ProcessEquipmentDAC();
            bool result = dac.DeleteEquipmentGroup(equipmentgroupCode);
            dac.Dispose();

            return result;
        }
    }
}
