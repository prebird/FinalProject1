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
        public List<POPUserVO> GetUserWork(string userId)
        {
            string sql = @"select workOrderID, Item_Code, OrderQuantity, WO.[Status]
                from WorkOrder WO inner join Production_Plan PP on WO.PlanID = PP.PlanID
				                  inner join Production_PlanDetail PD on PP.ProductionPlanID = PD.ProductionPlanID
				                  inner join BOR B on PD.BORID = B.BORID
				                  inner Join Item I on B.ItemID = I.Item_ID
                            where EmpID = @EmpID ";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("EmpID", userId);             
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
    }

    
}
