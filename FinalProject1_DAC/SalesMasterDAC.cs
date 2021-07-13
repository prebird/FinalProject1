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
    public class SalesMasterDAC : IDisposable
    {
        SqlConnection conn;

        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }
        public SalesMasterDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }
    
        public bool InsertSalesMaster(SalesMasterVO smVO)
        {
            string sql = @"insert into PurchaseOrder (PO_PlanID, PO_WorkOrderID, PO_CompanyName, PO_CompanyType, PO_CusProductName, PO_ProductID, PO_OrderCnt, PO_DeadLine, PO_UploadDate)
                         values (@PO_PlanID, @PO_WorkOrderID, @PO_CompanyName, @PO_CompanyType, @PO_CusProductName, @PO_ProductID, @PO_OrderCnt, @PO_DeadLine, @PO_UploadDate)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@PO_PlanID", smVO.PO_PlanID);
                cmd.Parameters.AddWithValue("@PO_WorkOrderID", smVO.PO_WorkOrderID);
                cmd.Parameters.AddWithValue("@PO_CompanyName", smVO.PO_CompanyName);
                cmd.Parameters.AddWithValue("@PO_CompanyType", smVO.PO_CompanyType);
                cmd.Parameters.AddWithValue("@PO_CusProductName", smVO.PO_CusProductName);
                cmd.Parameters.AddWithValue("@PO_ProductID", smVO.PO_ProductID);
                cmd.Parameters.AddWithValue("@PO_OrderCnt", smVO.PO_OrderCnt);
                cmd.Parameters.AddWithValue("@PO_DeadLine", smVO.PO_DeadLine);
                cmd.Parameters.AddWithValue("@PO_UploadDate", smVO.PO_UploadDate);

                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
        }

        // 전체 조회
        public List<SalesMasterVO> GetAllSM()
        {
            string sql = @"select PO_ID, PO_WorkOrderID, PO_PlanID, PO_CompanyName, PO_CompanyType, PO_Destination, PO_CusProductName, Item_Name, 
                           PO_OrderCnt, PO_OutCnt, PO_CancelCnt, PO_DeadLine, PO_UploadDate, PO_EditManger, PO_EditDate, PO_Content
                           from PurchaseOrder PO inner join Item I on po.PO_ProductID = i.Item_ID
                           where PO_Deleted = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<SalesMasterVO>(cmd.ExecuteReader());
            }
        }

        // 특정 조회 
        public SalesMasterVO GetOneSM(int itemID)
        {
            string sql = @"select Item_ID, Item_Category, Item_Code, Item_Name, Item_UnitQTY, Item_OrderType, Item_YN, Item_InHouse, 
                         Item_OutHouse, Item_SafetyQTY, Item_CheckType, Item_Content, Item_Barcode
                         from Item
                         where Item_ID = @Item_ID and Item_Deleted = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("Item_ID", itemID);
                List<SalesMasterVO> list = Helper.DataReaderMapToList<SalesMasterVO>(cmd.ExecuteReader());

                if (list != null && list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }

        // 부분 조회
        public List<SalesMasterVO> GetPartialSM(string itemCategory, string itemName, string yn)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select Item_ID, Item_Category, Item_Code, Item_Name, Item_UnitQTY, Item_OrderType, Item_YN, Item_InHouse, 
                         Item_OutHouse, Item_SafetyQTY, Item_CheckType, Item_Content, Item_Barcode
                         from Item 
						 where Item_Deleted = 0 and 1=1");

            if (!string.IsNullOrEmpty(itemCategory))
                sb.Append(" and Item_Category like @Item_Category");

            if (!string.IsNullOrEmpty(itemName))
                sb.Append(" and Item_Name like @Item_Name");

            if (!string.IsNullOrEmpty(yn))
                sb.Append(" and Item_YN = @Item_YN");

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();
                cmd.Parameters.AddWithValue("@Item_Category", itemCategory);
                cmd.Parameters.AddWithValue("@Item_Name", "%" + itemName + "%");

                cmd.Parameters.AddWithValue("@Item_YN", yn);

                return Helper.DataReaderMapToList<SalesMasterVO>(cmd.ExecuteReader());
            }
        }



    }

}
