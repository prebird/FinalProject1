using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    public class BOMService
    {
        public List<BomVO> BOMForward (int JaItemID)
        {
            BomDAC dac = new BomDAC();
            List<BomVO> result = dac.BOMForward(JaItemID);
            dac.Dispose();
            return result;
        }
        public List<BomVO> BOMReverse(int JaItemID)
        {
            BomDAC dac = new BomDAC();
            List<BomVO> result = dac.BOMForward(JaItemID);
            dac.Dispose();
            return result;
        }
    }
}
