using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_DAC
{
    public class POPDAC : IDisposable
    {
        SqlConnection conn;

        public POPDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        //유저 정보 조회

        public List<POPVO> GetUserInfo(string userId)
        {
            string sql = @"select * from Userinfo where user_id = @user_id";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("user_id", userId);
                return Helper.DataReaderMapToList<POPVO>(cmd.ExecuteReader());
            }
        }
        
        //유저 작업지시정보 조회
        public List<POPUserVO> GetUserWork(string userId, string WorkDate)
        {
            string sql = @"select workOrderID, Item_Code, OrderQuantity, WO.[Status]
                from WorkOrder WO inner join Production_Plan PP on WO.PlanID = PP.PlanID
				                  inner join Production_PlanDetail PD on PP.ProductionPlanID = PD.ProductionPlanID
				                  inner join BOR B on PD.BORID = B.BORID
				                  inner Join Item I on B.ItemID = I.Item_ID
								  where EmpID = @EmpID and WorkDate = @WorkDate";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@EmpID", userId);
                cmd.Parameters.AddWithValue("@WorkDate", WorkDate);
                return Helper.DataReaderMapToList<POPUserVO>(cmd.ExecuteReader());
            }
        }

        //공정 조회
        public List<POPProcessVO> GetProcessInfo()
        {
            string sql = @"select ProcessID, ProcessCode, ProcessName
                                    from ProcessInfo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                
                return Helper.DataReaderMapToList<POPProcessVO>(cmd.ExecuteReader());
            }
        }
        
        //제품 조회
        public List<POPItemVO> GetItemInfo()
        {
            string sql = @"select Item_ID, Item_Category, Item_Code, Item_Name, Item_UnitQTY
                                    from Item
                                    where Item_Category in('완제품','반제품')";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                return Helper.DataReaderMapToList<POPItemVO>(cmd.ExecuteReader());
            }
        }

        //작업계획 상태일때
        public List<POPWorkOrderVO> GetWorkOrder(string workOrderID)
        {
            string sql = @"select WO.WorkOrderID, WO.PlanID, I.Item_code, EquipmentName, OrderQuantity, processName
                           from WorkOrder WO inner join BOR B on WO.BORID = B.BORID
				                             inner join Item I on B.ItemID = I.Item_ID
											 inner join Equipment E on B.EquipmentID = E.EquipmentID
											 inner join ProcessInfo P on B.ProcessID = P.ProcessID
                            where WO.WorkOrderID = @WorkOrderID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@WorkOrderID", workOrderID);
                return Helper.DataReaderMapToList<POPWorkOrderVO>(cmd.ExecuteReader());
            }

        }
        //작업계획 이외의 상태일때
        public List<POPWorkOrderVO> GetStartWork(string workOrderID)
        {
            string sql = @"select WO.WorkOrderID, WO.PlanID, I.Item_code, EquipmentName, pd_stime, pd_etime, ok_cnt, ng_cnt
                           from WorkOrder WO inner join WorkRecord WR on WO.WorkOrderID = WR.WorkOrderID
				                                inner join BOR B on WO.BORID = B.BORID
				                                inner join Item I on B.ItemID = I.Item_ID
												inner join Equipment E on B.EquipmentID = E.EquipmentID
                            where WO.WorkOrderID = @WorkOrderID";
            
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@WorkOrderID", workOrderID);
                return Helper.DataReaderMapToList<POPWorkOrderVO>(cmd.ExecuteReader());
            }

        }


        public List<POPUserVO> GetWOSearch(string userId, string workDate, int processId, int itemId)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"select workOrderID, Item_Code, OrderQuantity, WO.[Status]
                from WorkOrder WO inner join Production_Plan PP on WO.PlanID = PP.PlanID
				                  inner join Production_PlanDetail PD on PP.ProductionPlanID = PD.ProductionPlanID
				                  inner join BOR B on PD.BORID = B.BORID
				                  inner Join Item I on B.ItemID = I.Item_ID
                where EmpID = @EmpID and WorkDate = @WorkDate");

            if (processId != 0)
                sb.Append(" and ProcessID = @ProcessID ");
            if (itemId != 0)
                sb.Append(" and itemid = @itemid");

            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();
                cmd.Parameters.AddWithValue("@EmpID", userId);
                cmd.Parameters.AddWithValue("@WorkDate", workDate);
                cmd.Parameters.AddWithValue("@ProcessID", processId);
                cmd.Parameters.AddWithValue("@itemid", itemId);
                return Helper.DataReaderMapToList<POPUserVO>(cmd.ExecuteReader());
            }
        }
    }

    
}
