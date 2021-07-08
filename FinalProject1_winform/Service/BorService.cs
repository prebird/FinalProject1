using FinalProject1_DAC;
using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_winform.Service
{
    public class BorService
    {
        public bool SaveBOR(BORVO bor)
        {
            BORDAC dac = new BORDAC();
            bool result = dac.SaveBOR(bor);
            dac.Dispose();

            return result;
        }
    }
}
