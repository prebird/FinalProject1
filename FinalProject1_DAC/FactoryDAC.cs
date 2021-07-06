using System;
using System.Collections.Generic;
using System.Configuration;
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




    }
}
