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
        //전체 조회
        public List<FactoryVO> GetAllFactory()
        {
            FactoryDAC dac = new FactoryDAC();
            List<FactoryVO> list = dac.GetAllFactory();
            dac.Dispose();
            return list;
        }

        //등록/수정
        public bool InsUpFactory(FactoryVO info)
        {
            FactoryDAC dac = new FactoryDAC();
            bool result = dac.InsUpFactory(info);
            dac.Dispose();

            return result;
        }

       public List<CompanyVO> GetCompanyCode(string companyid)
        {
            FactoryDAC dac = new FactoryDAC();
            List<CompanyVO> list = dac.GetCompanyCode(companyid);
            dac.Dispose();
            return list;
        }


    }
}
