using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FinalProject1_VO;
using System.Data;
using FinalProject1_winform;

namespace FinalProject1_DAC
{
    public class CompanyDAC : IDisposable
    {
        SqlConnection conn;

        public CompanyDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        //업체코드 바인딩
        public List<CompanyVO> GetCompanyCode()  
        {
            string sql = @"select company_type from Company";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());
            }
        }

        //전체 업체정보 조회
        public List<CompanyVO> GetAllCompany()
        {
            string sql = @"select * from Company";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());
            }
        }

        //검색조건 조회
        public List<CompanyVO> SearchCompany(string companyCode, string companyName, string companyCrum, string companyType) 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select company_code, company_name, company_type, company_ceo, company_crum, company_email, company_phone
                        from Company where deleted = 0 ");

            if (!string.IsNullOrEmpty(companyCode))
                sb.Append(" and company_code like @company_code");
            if (!string.IsNullOrEmpty(companyName))
                sb.Append(" and company_name like @company_name");
            if (!string.IsNullOrEmpty(companyCrum))
                sb.Append(" and company_crum like @company_crum");
            if (!string.IsNullOrEmpty(companyType))
                sb.Append(" and company_type like @company_type");

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();
                cmd.Parameters.AddWithValue("@company_code", "%" + companyCode + "%");
                cmd.Parameters.AddWithValue("@company_name", "%"+ companyName + "%");
                cmd.Parameters.AddWithValue("@company_crum", "%" + companyCrum + "%");
                cmd.Parameters.AddWithValue("@company_type",  companyType);

                return Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());
            }
        }

        //업체정보 등록

        //public bool InsertCompany(CompanyVO list)
        //{
        //    string sql = @""

        //}

    }
}
