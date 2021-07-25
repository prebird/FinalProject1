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
    }
}
