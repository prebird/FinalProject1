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
    public class ShiftDAC : IDisposable
    {
        SqlConnection conn;

        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }
        public ShiftDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<ShiftVO> GetAllShifts()
        {
            string sql = "select Shift_ID, m_ID, shift_stime, shift_etime, shift_edate, shift_sdate, shift_yn, shift_uadmin, shift_udate, shift_comment from Shift";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                List<ShiftVO> list = Helper.DataReaderMapToList<ShiftVO>(cmd.ExecuteReader());
                return list;
            }


        }
    

    }
}
