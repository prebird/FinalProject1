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

        public List<PerPriceVO> GetPerPrice(int company_id)
        {
            PerPriceDAC dac = new PerPriceDAC();
            List<PerPriceVO> list = dac.GetPerPrice(company_id);
            dac.Dispose();
            return list;
        }

        public List<PerPriceVO> GetAllPerPrice()
        {
            PerPriceDAC dac = new PerPriceDAC();
            List<PerPriceVO> list = dac.GetAllPerPrice();
            dac.Dispose();
            return list;
        }

        public bool InsertPerPrice(PerPriceVO info)
        {
            PerPriceDAC dac = new PerPriceDAC();
            bool result = dac.InsertPerPrice(info);
            dac.Dispose();
            return result;
        }

        public bool InsUpPerPrice(PerPriceVO info)
        {
            PerPriceDAC dac = new PerPriceDAC();
            bool result = dac.InsUpPerPrice(info);
            dac.Dispose();
            return result;
        }

    }
}
