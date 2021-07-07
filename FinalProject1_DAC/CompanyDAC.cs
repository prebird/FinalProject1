using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FinalProject1_VO;
using System.Data;


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

        //업체조회(업체코드)
        //public CompanyVO GetCompanyCode(string company_code)  
        //{
        //    string sql = @"select * from Company
        //                    where company_code = @company_code ";

        //    using (SqlCommand cmd = new SqlCommand(sql, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@company_code", company_code);
        //        cmd.ExecuteReader();
              
        //    }
        //}

        //전체 업체정보 조회
        public List<CompanyVO> GetAllCompany()
        {
            string sql = @"select * from Company where deleted = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());
            }
        }

        //업체 코드 조회
        public List<CompanyVO> GetAllCompanyCode()
        {
            string sql = @"select company_code from company where deleted = 0";

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

        //업체정보 등록 및 수정

        public bool InsUpCompany(CompanyVO info)
        {
            string sql = @"SP_InsUpCompany";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@company_id", info.company_id);
                cmd.Parameters.AddWithValue("@company_code", info.company_code);
                cmd.Parameters.AddWithValue("@company_name", info.company_name);
                cmd.Parameters.AddWithValue("@company_type", info.company_type);
                cmd.Parameters.AddWithValue("@company_ceo", info.company_ceo);
                cmd.Parameters.AddWithValue("@company_crum", info.company_crum);
                cmd.Parameters.AddWithValue("@company_email", info.company_email);
                cmd.Parameters.AddWithValue("@company_phone", info.company_phone);
                cmd.Parameters.AddWithValue("@company_yn", info.company_yn);
                cmd.Parameters.AddWithValue("@company_uadmin", info.company_uadmin);
                cmd.Parameters.AddWithValue("@company_udate", info.company_udate);
                cmd.Parameters.AddWithValue("@company_comment", info.company_comment);

                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
        }

        //업체 삭제
        public bool DeleteCompany(int companyid)
        {
            string sql = "update Company set deleted = 1 where company_id = @company_id";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@company_id", companyid);

                int iCnt = cmd.ExecuteNonQuery();
                return (iCnt > 0);
            }
        }


    }
}
