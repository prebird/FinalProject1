using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using FinalProject1_VO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject1_DAC
{
    public class BomDAC : IDisposable
    {
        SqlConnection conn;

        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }
        public BomDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        // 정전개
        public List<BomVO> BOMForward(int JaitemID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_BOMForward";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BOM_JaItemID", JaitemID);

                return Helper.DataReaderMapToList<BomVO>(cmd.ExecuteReader());
            }
        }

        // 역전개
        public List<BomVO> BOMReverse(int JaitemID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_BOMReverse";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BOM_JaItemID", JaitemID);

                return Helper.DataReaderMapToList<BomVO>(cmd.ExecuteReader());
            }
        }



    }
}
