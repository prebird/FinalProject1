using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using FinalProject1_VO;
using System.Data;

namespace FinalProject1_DAC
{
    public class CommonDAC : IDisposable
    {
        SqlConnection conn;
        public CommonDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<MenuVO> GetAllMenu()
        {

            string sql = @"select MenuID, MenuName, MenuLevel, refMenuID, ProgramName, menu_uadmin, menu_udate, menu_Img, sortorder  from Menu order by sortorder" ;
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<MenuVO> list = Helper.DataReaderMapToList<MenuVO>(dr);
                return list;
            }
        }


        public List<MenuVO> GetAllMenuMgt()
        {

            string sql = @"select MenuID, MenuName, MenuLevel, refMenuID, ProgramName, menu_uadmin, menu_udate, menu_Img  from Menu";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<MenuVO> list = Helper.DataReaderMapToList<MenuVO>(dr);
                return list;
            }
        }

        public List<CommonCodeVO> GetCommonCode(string common_type)
        {
            string sql = "select common_id, common_type, common_value, common_name from CommonCode where common_type = @common_type";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@common_type", common_type);
                return Helper.DataReaderMapToList<CommonCodeVO>(cmd.ExecuteReader());
            }
        }

        // Equipmet 테이블 열 다 가져오기
        public List<EquipmentVO> GetAllEquipment()
        {
            string sql = @"select EquipmentID, ProcessID, EquipmentGroupID, EquipmentCode, EquipmentName, Status, Deleted, INS_EMP, INS_DATE, IsActive, FromLocationID, ToLocationID from Equipment";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<EquipmentVO> list = Helper.DataReaderMapToList<EquipmentVO>(dr);
                return list;
            }
        }

        // 콤보박스 planid 가져오기용
        public List<DemandPlanVO> GetCommboDemandPlan()
        {
            string sql = "Select distinct PlanID from Demandplan ";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<DemandPlanVO>(cmd.ExecuteReader());
            }
        }

        // RO_id 콤보바인딩
        public List<RestockOrderVO> GetCommboROID()
        {
            string sql = "Select distinct RO_ID from RestockOrder ";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<RestockOrderVO>(cmd.ExecuteReader());
            }
        }

        // 콤보박스 productName 가져오기용
        public List<ItemVO> GetCommboProductName()
        {
            string sql = "select Item_ID, Item_Name from Item where Item_Category = '완제품'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<ItemVO>(cmd.ExecuteReader());
            }
        }

        public List<ItemVO> GetCommboItemName()
        {
            string sql = "select Item_ID, Item_Name from Item";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<ItemVO>(cmd.ExecuteReader());
            }
        }

        public List<CompanyVO> GetCommboCompanyName()
        {
            string sql = "select company_id, company_name from Company";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<CompanyVO>(cmd.ExecuteReader());
            }
        }

        public DataTable GetMenuList()
        {
            string sql = "select MenuID, MenuName, MenuLevel, refMenuID, ProgramName, menu_uadmin, menu_udate, menu_Img from Menu";

            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }
            return dt;
        }




    }
}
