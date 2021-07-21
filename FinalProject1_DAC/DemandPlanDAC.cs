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
    public class DemandPlanDAC : IDisposable
    {
        SqlConnection conn;
        string strConn = ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString;

        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }
        public DemandPlanDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<SalesMasterVO> GetPlanSM()
        {
            string sql = @"select PO_ID, PO_WorkOrderID, PO_PlanID, PO_CompanyName, PO_CompanyType, PO_Destination, PO_CusProductName, Item_Name, 
                           PO_OrderCnt, PO_OutCnt, PO_CancelCnt, PO_DeadLine, PO_UploadDate, PO_EditManager, PO_EditDate, PO_Content
                           from PurchaseOrder PO inner join Item I on po.PO_ProductID = i.Item_ID
                           where PO_Deleted = 0 and ISNULL(PO_PlanID,'') = ''";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<SalesMasterVO>(cmd.ExecuteReader());
            }
        }

        public bool DMInsertTrans(DemandPlanVO dmVO)
        {
            string sql = @"SP_DemandPlanTransInsert";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PO_ID", dmVO.PO_ID);
                cmd.Parameters.AddWithValue("@PlanID", dmVO.PlanID);
                cmd.Parameters.AddWithValue("@Dplan_Date", dmVO.Dplan_Date);
                cmd.Parameters.AddWithValue("@Dplan_Quantity", dmVO.Dplan_Quantity);

                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
        }

        public DataTable GetDemandPlanList(DemandPlanVO dmVO)
        {
            string sql = "SP_DemandPlanList";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@PlanID", dmVO.PlanID);
                da.SelectCommand.Parameters.AddWithValue("@StartDate", dmVO.StartDate);
                da.SelectCommand.Parameters.AddWithValue("@EndDate", dmVO.EndDate);

                da.Fill(dt);
            }
            return dt;

        }

    }
}
