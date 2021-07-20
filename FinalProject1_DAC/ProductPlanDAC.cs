using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_DAC
{
    public class ProductPlanDAC : IDisposable
    {
        SqlConnection conn;

        public ProductPlanDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetPlanList(string fromDate, string toDate)
        {
            string sql = "SP_ProductPlanLIst";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@P_StartDT", fromDate);
            da.SelectCommand.Parameters.AddWithValue("@P_EndDT", toDate);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            return dt;
        }
    }
}
