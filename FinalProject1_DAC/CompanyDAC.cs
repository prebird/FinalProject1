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
        
        public List<CompanyVO> GetCompanyCode()  //업체코드 바인딩
        {
            string sql = @"select company_type from Company";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());
            }
        }

    }
}
