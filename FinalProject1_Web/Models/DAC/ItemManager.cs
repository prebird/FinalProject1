using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Configuration;

namespace FinalProject1_Web.Models
{
    public class ItemManager : IDisposable
    {
        SqlConnection conn;

        public ItemManager()
        {
            conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
        }

        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        /// <summary>
        /// 현재 페이지에 해당하는 제품목록을 조회
        /// </summary>
        /// <returns></returns>
        public List<Item> GetItems()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "select Item_ID, Item_Name, Item_Category from Item";

                conn.Open();
                List<Item> list = Helper.DataReaderMapToList<Item>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
        }

        
    }
}