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
        //시설군 조회
        public List<FactoryVO> GetFactoryGrade()
        {
            FactoryDAC dac = new FactoryDAC();
            List<FactoryVO> list = dac.GetFactoryGrade();
            dac.Dispose();
            return list;
        }
        //상위시설 조회
        public List<FactoryVO> GetFactoryParent()
        {
            FactoryDAC dac = new FactoryDAC();
            List<FactoryVO> list = dac.GetFactoryParent();
            dac.Dispose();
            return list;
        }

        //업체코드, id 조회
        public List<CompanyVO> GetCompanyInfo()
        {
            FactoryDAC dac = new FactoryDAC();
            List<CompanyVO> list = dac.GetCompanyInfo();
            dac.Dispose();
            return list;
        }
        //공장 조회
        public List<FactoryVO> SearchFactory(string factoryCode, string factoryGrade)
        {
            FactoryDAC dac = new FactoryDAC();
            List<FactoryVO> list = dac.SearchFactory(factoryCode, factoryGrade);
            dac.Dispose();
            return list;
        }


        public bool DeleteFactory(int factoryid)
        {
            FactoryDAC dac = new FactoryDAC();
            bool result = dac.DeleteFactory(factoryid);
            dac.Dispose();
            return result;
        }
    }
}
