using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_winform
{
    public class CompanyService
    {
        //public List<CompanyVO> GetCompanyCode()
        //{
        //    CompanyDAC dac = new CompanyDAC();
        //    List<CompanyVO> list = dac.GetCompanyCode();
        //    dac.Dispose();
        //    return list;
        //}

        public List<CompanyVO> GetAllCompany()
        {
            CompanyDAC dac = new CompanyDAC();
            List<CompanyVO> list = dac.GetAllCompany();
            dac.Dispose();
            return list;
        }

        public List<CompanyVO> SearchCompany(string companyCode, string companyName, string companyCrum, string companyType)
        {
            CompanyDAC dac = new CompanyDAC();
            List<CompanyVO> list = dac.SearchCompany(companyCode, companyName, companyCrum, companyType);
            dac.Dispose();
            return list;
        }
    }
}
