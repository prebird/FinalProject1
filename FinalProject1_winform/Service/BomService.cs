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

        public List<BomVO> SearchJaItem(int MoitemID)
        {
            BomDAC dac = new BomDAC();
            List<BomVO> result = dac.SearchJaItem(MoitemID);
            dac.Dispose();
            return result;
        }

        public bool InsertBOM(BomVO bom)
        {
            BomDAC dac = new BomDAC();
            bool result = dac.InsertBOM(bom);
            dac.Dispose();
            return result;
        }


    }
}
