using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using FinalProject1_VO;

namespace FinalProject1_DAC
{
    public class MenuDAC : IDisposable
    {
        SqlConnection conn;
        public MenuDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public bool insertBigMenu(MenuVO menu)
        {
            string sql = @"insert into Menu (MenuName, MenuLevel, menu_uadmin, menu_udate, menu_Img) 
values (@MenuName, @MenuLevel, @menu_uadmin, @menu_udate, @menu_Img)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MenuName", menu.MenuName);
                cmd.Parameters.AddWithValue("@MenuLevel", 0);
                cmd.Parameters.AddWithValue("@menu_uadmin", menu.menu_uadmin);
                cmd.Parameters.AddWithValue("@menu_udate", menu.menu_udate);
                cmd.Parameters.AddWithValue("@menu_Img", menu.menu_Img);

                int irows = cmd.ExecuteNonQuery();

                return irows > 0;
            }
        }

        public bool insertSmallMenu(MenuVO menu)
        {
            string sql = @"insert into Menu (MenuName, MenuLevel, refMenuID, ProgramName, menu_uadmin, menu_udate) 
values (@MenuName, @MenuLevel, @refMenuID, @ProgramName, @menu_uadmin, @menu_udate)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MenuName", menu.MenuName);
                cmd.Parameters.AddWithValue("@MenuLevel", 1);
                cmd.Parameters.AddWithValue("@refMenuID", menu.refMenuID);
                cmd.Parameters.AddWithValue("@ProgramName", menu.ProgramName);
                cmd.Parameters.AddWithValue("@menu_uadmin", menu.menu_uadmin);
                cmd.Parameters.AddWithValue("@menu_udate", menu.menu_udate);

                int irows = cmd.ExecuteNonQuery();

                return irows > 0;
            }
        }
    }
}
