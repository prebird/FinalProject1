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
    public class WorkOrderDAC : IDisposable
    {
        SqlConnection conn;

        public WorkOrderDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<WorkOrderVO> GetAllWorkOrder()
        {
            string sql = @"select WorkOrderID, PlanID, EmpID, user_name, CONVERT(nvarchar,WorkDate,23) WorkDate, W.BORID, E.EquipmentID, EquipmentName, I.Item_ID, Item_Name, W.Status, ISNULL(OrderQuantity,0) OrderQuantity
                           from WorkOrder W inner join Userinfo U on W.EmpID = U.user_id
				                            inner join BOR B on W.BORID = B.BORID
				                            inner join Equipment E on B.EquipmentID = E.EquipmentID
				                            inner join Item I on B.ItemID = I.Item_ID";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                return Helper.DataReaderMapToList<WorkOrderVO>(cmd.ExecuteReader());
            }
        }

        public List<WorkOrderVO> GetWorkDoneRecord()
        {
            string sql = @"select distinct WR.WorkOrderID, Item_Name, pro_date, W.Status, W.PlanID
                          from WorkRecord WR inner join WorkOrder W on W.WorkOrderID = WR.WorkOrderID
				                             inner join Item I on WR.Item_Code = I.Item_Code
				                             inner join Production_Plan P on W.PlanID = P.PlanID
                          where P.Status = '작업생성' and WR.pro_date is not null";
            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                return Helper.DataReaderMapToList<WorkOrderVO>(cmd.ExecuteReader());
            }
        }

        public bool WorkDone(string planID)
        {
            string sql = "update Production_Plan set Status = '작업완료' where PlanID = @PlanID";
            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.Parameters.AddWithValue("@PlanID", planID);

                int affectRow = cmd.ExecuteNonQuery();

                return (affectRow > 0);
            }
        }
    }
}
