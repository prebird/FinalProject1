using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;


namespace FinalProject1_DAC
{
   public class FactoryDAC : IDisposable
    {
        SqlConnection conn;

        public FactoryDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<FactoryVO> GetAllFactory()
        {
            string sql = @"select * from Factory where deleted = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<FactoryVO>(cmd.ExecuteReader());
            }
        }

        public List<FactoryVO> GetFactoryGrade()
        {
            string sql = @"select factory_grade, factory_code from Factory where deleted = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<FactoryVO>(cmd.ExecuteReader());
            }
        }

        public bool InsUpFactory(FactoryVO info)
        {
            string sql = @"SP_InsUpFactory";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@factory_id", info.factory_id);
                cmd.Parameters.AddWithValue("@factory_grade", info.factory_grade);
                cmd.Parameters.AddWithValue("@factory_parent", info.factory_parent);
                cmd.Parameters.AddWithValue("@factory_name", info.factory_name);
                cmd.Parameters.AddWithValue("@factory_code", info.factory_code);
                cmd.Parameters.AddWithValue("@factory_type", info.factory_type);
                cmd.Parameters.AddWithValue("@company_id", info.company_id);
                cmd.Parameters.AddWithValue("@factory_yn", info.factory_yn);
                cmd.Parameters.AddWithValue("@factory_uadmin", info.factory_uadmin);
                cmd.Parameters.AddWithValue("@factory_udate", info.factory_udate);  
                cmd.Parameters.AddWithValue("@factory_comment", info.factory_comment);

                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
        }
        // 업체 코드 조회
        public List<CompanyVO> GetCompanyCode(string company_id)  
        {
            string sql = @"select company_code 
                            from company
                            where company_id = @company_id ";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@company_id", company_id);
                cmd.ExecuteReader();
                return Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());

            }
        }

        //검색 조건 조회
        public List<FactoryVO> SearchFactory(string factoryCode, string factoryGrade)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select factory_code, factory_grade
                        from factory where deleted = 0 ");

            if (!string.IsNullOrEmpty(factoryCode))
                sb.Append(" and factory_code like @factory_Code");
            if (!string.IsNullOrEmpty(factoryGrade))
                sb.Append(" and factory_grade like @factory_grade");


            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();
                cmd.Parameters.AddWithValue("@factory_code", "%" + factoryCode + "%");
                cmd.Parameters.AddWithValue("@factory_grade", factoryGrade);

                return Helper.DataReaderMapToList<FactoryVO>(cmd.ExecuteReader());
            }
        }

        public bool DeleteFactory(int factoryid)
        {
            string sql = "update factory set deleted = 1 where factory_id = @factory_id";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@factory_id", factoryid);

                int iCnt = cmd.ExecuteNonQuery();
                return (iCnt > 0);
            }
        }
    }
}
