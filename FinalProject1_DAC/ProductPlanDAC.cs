using FinalProject1_VO;
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

        public DataTable GetSpecialPlanList(string fromDate, string toDate, string ItemName, string EquipmentName, string planID)
        {
            string sql = "SP_SpecialProductList";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@P_Equipment", EquipmentName);
            da.SelectCommand.Parameters.AddWithValue("@P_StartDT", fromDate);
            da.SelectCommand.Parameters.AddWithValue("@P_EndDT", toDate);
            da.SelectCommand.Parameters.AddWithValue("@P_Item", ItemName);
            da.SelectCommand.Parameters.AddWithValue("@P_PlanID", planID);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public List<BORVO> GetBORInfo(int itemID)
        {
            string sql = @"select Item_Name, B.EquipmentID, EquipmentName, B.ProcessID, ProcessName, PriorDate
                           from BOR B inner join Item I on B.ItemID = I.Item_ID
                                      inner join ProcessInfo P on B.ProcessID = P.ProcessID
                                      inner join Equipment E on B.EquipmentID = E.EquipmentID
                                      where B.ItemID = @ItemID order by B.Priority";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.Parameters.AddWithValue("@ItemID", itemID);

                return Helper.DataReaderMapToList<BORVO>(cmd.ExecuteReader());
            }
        }

        public bool InsertWorkOrder(WorkOrderVO workOrder)
        {
            string sql = "insert into WorkOrder(WorkOrderID,PlanID,EmpID,WorkDate,BORID,Status,OrderQuantity) values(@WorkOrderID, @PlanID, @EmpID, @WorkDate, @BORID, @Status,@OrderQuantity)";

            using (SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.Parameters.AddWithValue("@WorkOrderID", workOrder.WorkOrderID);
                cmd.Parameters.AddWithValue("@PlanID", workOrder.PlanID);
                cmd.Parameters.AddWithValue("@EmpID", workOrder.EmpID);
                cmd.Parameters.AddWithValue("@WorkDate", workOrder.WorkDate);
                cmd.Parameters.AddWithValue("@BORID", workOrder.BORID);
                cmd.Parameters.AddWithValue("@Status", workOrder.Status);
                cmd.Parameters.AddWithValue("@OrderQuantity", workOrder.OrderQuantity);

                int affectRow = cmd.ExecuteNonQuery();

                return (affectRow > 0);
            }
        }
    }
}
