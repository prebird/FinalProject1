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

        //등록 및 수정
        public bool InsUpCompany(CompanyVO info)
        {
            CompanyDAC dac = new CompanyDAC();
            bool result = dac.InsUpCompany(info);
            dac.Dispose();

            return result;
        }

        //삭제
        public bool DeleteCompany(int companyid)
        {
            CompanyDAC dac = new CompanyDAC();
            bool result = dac.DeleteCompany(companyid);
            dac.Dispose();
            return result;
        }
    }
}
