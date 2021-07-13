using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    public class ShiftService
    {
        public List<ShiftVO> GetAllShifts()
        {
            ShiftDAC dac = new ShiftDAC();
            return dac.GetAllShifts();
        }
    }
}
