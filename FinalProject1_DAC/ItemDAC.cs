using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;
using FinalProject1_winform;

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
            string sql = @"select Item_ID, Item_Category, Item_Code, Item_Name, Item_UnitQTY, Item_InputType, Item_YN, Item_InHouse, 
                         Item_OutHouse, Item_Customer, Item_CheckType, Item_Content, Item_Barcode
                         from Item where Item_Deleted = 0
                         order by Item_Category desc";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<ItemVO>(cmd.ExecuteReader());
            }
        }

        // 특정 조회 
        public ItemVO GetOneItem(int itemID)
        {
            string sql = @"select Item_ID, Item_Category, Item_Code, Item_Name, Item_UnitQTY, Item_InputType, Item_YN, Item_InHouse, 
                         Item_OutHouse, Item_Customer, Item_CheckType, Item_Content, Item_Barcode
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
        public List<ItemVO> GetPartialItem(string itemCategory, string itemName, string inHouse, string outHouse, string yn) // 조건 인수들
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select Item_ID, Item_Category, Item_Code, Item_Name, Item_UnitQTY, Item_InputType, Item_YN, Item_InHouse, 
                         Item_OutHouse, Item_Customer, Item_CheckType, Item_Content, Item_Barcode
                         from Item 
						 where Item_Deleted = 0 and 1=1");

            if (!string.IsNullOrEmpty(itemCategory))
                sb.Append(" and Item_Category like @Item_Category");

            if (!string.IsNullOrEmpty(itemName))
                sb.Append(" and Item_Name like @Item_Name");

            if (!string.IsNullOrEmpty(inHouse))
                sb.Append(" and Item_InHouse like @Item_InHouse");

            if (!string.IsNullOrEmpty(outHouse))
                sb.Append(" and Item_OutHouse = @Item_OutHouse");

            if (!string.IsNullOrEmpty(yn))
                sb.Append(" and Item_YN = @Item_YN");

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();
                cmd.Parameters.AddWithValue("@Item_Category", "%" + itemCategory + "%");
                cmd.Parameters.AddWithValue("@Item_Name", "%" + itemName + "%");
                cmd.Parameters.AddWithValue("@Item_InHouse", "%" + inHouse + "%");
                cmd.Parameters.AddWithValue("@Item_OutHouse", outHouse);
                cmd.Parameters.AddWithValue("@Item_YN", yn);

                return Helper.DataReaderMapToList<ItemVO>(cmd.ExecuteReader());
            }


        }



        // 등록, 수정
        public bool InsertUpdateItem(ItemVO item)
        {
        }

        // 삭제
        public bool DeleteItem(int itemID)
        {
        }



    }
}