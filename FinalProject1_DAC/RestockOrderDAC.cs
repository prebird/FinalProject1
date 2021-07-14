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
    public class RestockOrderDAC : IDisposable
    {
        SqlConnection conn;
        string strConn = ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString;
        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }

        public RestockOrderDAC()
        {
            
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<RestockOrderVO> GetROList()
        {
            string sql = @"select RO_ID, RO_Serial, itemid, Companyid, SuggestQty, Qty, dueDate from RestockOrder";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                List<RestockOrderVO> list = Helper.DataReaderMapToList<RestockOrderVO>(cmd.ExecuteReader());
                return list;
            }
        }

        public DataTable GetPrintData(string strCheckBarCodeID)
        {
            string sql = @"select RO_Serial, Item_Name, company_name, Qty from RestockOrder RO
inner join item i on i.Item_ID = ro.itemid
inner join Company c on c.company_id = ro.Companyid
where ro.ro_id in (" + strCheckBarCodeID + ")";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetMRP(MRPSearchVO search)
        {
            string sql = "SP_ShowMRP";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@P_StartDT", search.FromDate);
                da.SelectCommand.Parameters.AddWithValue("@P_EndDT", search.Todate);
                da.SelectCommand.Parameters.AddWithValue("@PlanID", search.PlanID);
                da.SelectCommand.Parameters.AddWithValue("@ProductID", search.ProductID);
                da.Fill(dt);
            }
            return dt;

        }
    }
}
