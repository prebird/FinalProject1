using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    public class FactoryService
    {
        public List<FactoryVO> GetAllFactory()
        {
            FactoryDAC dac = new FactoryDAC();
            List<FactoryVO> list = dac.GetAllFactory();
            dac.Dispose();
            return list;
        }

    }
}
