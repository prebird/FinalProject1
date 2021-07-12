using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    public class PerPriceService
    {
        public List<CompanyItemVO> GetCompanyItem()
        {
            PerPriceDAC dac = new PerPriceDAC();
            List<CompanyItemVO> list = dac.GetCompanyItem();
            dac.Dispose();
            return list;
        }
    }
}
