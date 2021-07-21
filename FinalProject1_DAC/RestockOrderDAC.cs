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
            string sql = @"select RO_ID, itemid, Companyid, SuggestQty, Qty, dueDate, inputFlag, RegDate, RO_Status from RestockOrder";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                List<RestockOrderVO> list = Helper.DataReaderMapToList<RestockOrderVO>(cmd.ExecuteReader());
                return list;
            }
        }

        public List<RestockOrderVO> GetROandInsList(string ro_id, string fromdate, string todate, string companyid)
        {
            StringBuilder sb = new StringBuilder(); 
            sb.Append(@"select ro.RO_ID, itemid, i.Item_Name ,Companyid, c.company_name ,SuggestQty, Qty, cc.common_name RO_Status ,dueDate, Qty-isnull(ins_cnt,0) abletoCancel, inputFlag, ins.ins_cnt, ins.ins_date from RestockOrder ro
inner join item i on i.Item_ID = ro.itemid
inner join Company c on c.company_id = ro.Companyid
left outer join CommonCode cc on cc.common_value = RO_Status
left outer join Instock ins on ins.Ro_id = ro.RO_ID
where 1=1 ");
            using (SqlCommand cmd = new SqlCommand())
            {
                if (!string.IsNullOrEmpty(ro_id))
                {
                    sb.Append(" and ro.ro_id like @ro_id");
                    cmd.Parameters.AddWithValue("@ro_id", $"%{ro_id}%");
                }
                if (companyid != "0")
                {
                    sb.Append(" and Companyid = @companyid");
                    cmd.Parameters.AddWithValue("@companyid", companyid);
                }
                sb.Append(" and dueDate >= @fromdate");
                cmd.Parameters.AddWithValue("@fromdate", fromdate);
                sb.Append(" and dueDate <= @todate");
                cmd.Parameters.AddWithValue("@todate", todate);


                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                List<RestockOrderVO> list = Helper.DataReaderMapToList<RestockOrderVO>(cmd.ExecuteReader());
                return list;
            }
        }

        public List<RestockOrderVO> GetInsWaitList(string ro_id, string fromdate, string todate, string companyid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select ro.RO_ID, itemid, i.Item_Name ,Companyid, c.company_name ,SuggestQty, Qty, cc.common_name RO_Status ,dueDate, Qty-isnull(ins_cnt,0) abletoCancel, inputFlag, ins.ins_cnt, ins.ins_date from RestockOrder ro
inner join item i on i.Item_ID = ro.itemid
inner join Company c on c.company_id = ro.Companyid
left outer join CommonCode cc on cc.common_value = RO_Status
left outer join Instock ins on ins.Ro_id = ro.RO_ID
where 1=1 and RO_Status = 'RO_01'");

            using (SqlCommand cmd = new SqlCommand())
            {
                if (!string.IsNullOrEmpty(ro_id))
                {
                    sb.Append(" and ro.ro_id like @ro_id");
                    cmd.Parameters.AddWithValue("@ro_id", $"%{ro_id}%");
                }
                if (companyid != "0")
                {
                    sb.Append(" and Companyid = @companyid");
                    cmd.Parameters.AddWithValue("@companyid", companyid);
                }
                sb.Append(" and dueDate >= @fromdate");
                cmd.Parameters.AddWithValue("@fromdate", fromdate);
                sb.Append(" and dueDate <= @todate");
                cmd.Parameters.AddWithValue("@todate", todate);


                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                List<RestockOrderVO> list = Helper.DataReaderMapToList<RestockOrderVO>(cmd.ExecuteReader());
                return list;
            }
        }

        public DataTable GetPrintData(string strCheckBarCodeID)
        {
            string sql = @"select RO_ID Item_Name, company_name, Qty from RestockOrder RO
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

        public DataTable GetROSuggest(MRPSearchVO search)
        {
            string sql = "SP_GetROSuggest";
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

        public bool insertRO(RestockOrderVO ro)
        {
            string sql = @"insert into RestockOrder (itemid, Companyid, SuggestQty, Qty,dueDate, unitPrice, RegDate)
values (@itemid, @Companyid, @SuggestQty, @Qty,@dueDate, @unitPrice, @RegDate)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("itemid", ro.itemid);
                cmd.Parameters.AddWithValue("companyid", ro.Companyid);
                cmd.Parameters.AddWithValue("SuggestQty", ro.SuggestQty);
                cmd.Parameters.AddWithValue("Qty", ro.Qty);
                cmd.Parameters.AddWithValue("dueDate", ro.dueDate);
                cmd.Parameters.AddWithValue("unitPrice", ro.unitPrice);
                cmd.Parameters.AddWithValue("RegDate", ro.RegDate);

                int irows  = cmd.ExecuteNonQuery();
                if (irows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
}
