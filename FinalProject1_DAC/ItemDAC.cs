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
    public class ItemDAC : IDisposable
    {
        SqlConnection conn;

        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }
        public ItemDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        // 전체 조회
        public List<ItemVO> GetAllItem()
        {
            string sql = @"select Item_ID, Item_Category, Item_Code, Item_Name, Item_UnitQTY, Item_OrderType, Item_YN, Item_InHouse, 
                         Item_OutHouse, Item_SafetyQTY, Item_CheckType, Item_Content, Item_img
                         from Item where Item_Deleted = 0
                         order by (case Item_Category when '완제품' then 0
                                                      when '반제품' then 1
                                                      when '원자재' then 2 end)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<ItemVO>(cmd.ExecuteReader());
            }
        }

        // 특정 조회 
        public ItemVO GetOneItem(int itemID)
        {
            string sql = @"select Item_ID, Item_Category, Item_Code, Item_Name, Item_UnitQTY, Item_OrderType, Item_YN, Item_InHouse, 
                         Item_OutHouse, Item_SafetyQTY, Item_CheckType, Item_Content, Item_img
                         from Item
                         where Item_ID = @Item_ID and Item_Deleted = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("Item_ID", itemID);
                List<ItemVO> list = Helper.DataReaderMapToList<ItemVO>(cmd.ExecuteReader());

                if (list != null && list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }

        // 부분 조회
        public List<ItemVO> GetPartialItem(string itemCategory, string itemName, string yn)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select Item_ID, Item_Category, Item_Code, Item_Name, Item_UnitQTY, Item_OrderType, Item_YN, Item_InHouse, 
                         Item_OutHouse, Item_SafetyQTY, Item_CheckType, Item_Content, Item_img
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

                return Helper.DataReaderMapToList<ItemVO>(cmd.ExecuteReader());
            }
        }

        // 등록, 수정
        public bool InsertUpdateItem(ItemVO item)
        {
            string sql = @"SP_InsUpItem";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Item_ID", item.Item_ID);
                cmd.Parameters.AddWithValue("@Item_Category", item.Item_Category);
                cmd.Parameters.AddWithValue("@Item_Code", item.Item_Code);
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                cmd.Parameters.AddWithValue("@Item_UnitQTY", item.Item_UnitQTY);
                cmd.Parameters.AddWithValue("@Item_CheckType", item.Item_CheckType);
                cmd.Parameters.AddWithValue("@Item_OrderType", item.Item_OrderType);
                cmd.Parameters.AddWithValue("@Item_SafetyQTY", item.Item_SafetyQTY);
                cmd.Parameters.AddWithValue("@Item_InHouse", item.Item_InHouse);
                cmd.Parameters.AddWithValue("@Item_OutHouse", item.Item_OutHouse);
                cmd.Parameters.AddWithValue("@Item_YN", item.Item_YN);
                cmd.Parameters.AddWithValue("@Item_Content", item.Item_Content);
                if (item.Item_img != null)
                {
                    cmd.Parameters.AddWithValue("@Item_img", item.Item_img); 
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Item_img", DBNull.Value);
                }


                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
        }

        // 삭제
        public bool DeleteItem(int itemID)
        {
            string sql = "update Item set Item_deleted = 1 where Item_ID = @Item_ID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Item_ID", itemID);

                int iCnt = cmd.ExecuteNonQuery();
                return (iCnt > 0);
            }
        }


        // 차트
        public List<OrderStatsVO> GetOrderBestProduct()
        {
            string sql = @" with Best3Product as
 (
	select top 3 po.PO_ProductID ProductID, i.Item_Name ProductName
	from PurchaseOrder po inner join Item i on po.PO_ProductID = i.Item_ID 
	group by po.PO_ProductID, i.Item_Name
	order by Sum(po.PO_OrderCnt) desc
 ), B_Month as
 (
	select 1 as mon
	union all
	select mon+1 as mon from B_Month where mon < 12
 ), BaseData as
 (
	select ProductID, ProductName, mon
	from Best3Product, B_Month
 )

 select B.ProductID, B.ProductName, B.mon MM, isnull(O.qty, 0) qty
  from BaseData B left outer join
			(select po.PO_ProductID, P.ProductName, Month(po.PO_UploadDate) MM, sum(po.PO_OrderCnt) qty
			  from PurchaseOrder po inner join Best3Product P on po.PO_ProductID = P.ProductID
			 group by po.PO_ProductID, P.ProductName, Month(po.PO_UploadDate)
			 ) O 
			 on B.ProductID = O.PO_ProductID and B.mon = O.MM
 order by 1, 2";

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = sql;

                
                List<OrderStatsVO> list = Helper.DataReaderMapToList<OrderStatsVO>(cmd.ExecuteReader());


                return list;
            }
        }
    }
}