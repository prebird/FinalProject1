using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using FinalProject1_VO;
using System.Data;

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

        

        public DataTable GetMenuList()
        {

            string sql = @"select MenuID, MenuName, MenuLevel, refMenuID, ProgramName, menu_uadmin, menu_udate, menu_Img, sortorder  from Menu order by sortorder";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetAuthList()
        {
            string sql = "select AuthID, AuthName from Authority order by AuthID";

            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetMenuAuthList()
        {
            string sql = "select MenuAuthID, MenuID, m.AuthID, AuthName from MenuAuth m inner join Authority a on m.AuthID = a.AuthID order by MenuID, AuthID";

            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        public bool SaveMenuAuth(int menu_id, List<int> authList)
        {
            string authStr = string.Join(",", authList);
            string sql = @"delete from MenuAuth where MenuID = @MenuID;
                                insert into MenuAuth (MenuID, AuthID)
                                select @MenuID, item from dbo.SplitString(@auths, ',')";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@menu_id", menu_id);
                cmd.Parameters.AddWithValue("@auths", authStr);
                conn.Open();
                int icnt = cmd.ExecuteNonQuery();
                conn.Close();

                return (icnt > 0);
            }
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
                if (menu.menu_Img != null)
                {
                    cmd.Parameters.AddWithValue("@menu_Img", menu.menu_Img);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@menu_Img", DBNull.Value);
                }

                int irows = cmd.ExecuteNonQuery();

                return irows > 0;
            }
        }

        public bool updateBigMenu(MenuVO menu)
        {
            string sql = @"update menu set MenuName=@MenuName, MenuLevel=@MenuLevel, menu_uadmin=@menu_uadmin, menu_udate=@menu_udate, menu_Img=@menu_Img where menuid = @menuid";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MenuName", menu.MenuName);
                cmd.Parameters.AddWithValue("@MenuLevel", 0);
                cmd.Parameters.AddWithValue("@menu_uadmin", menu.menu_uadmin);
                cmd.Parameters.AddWithValue("@menu_udate", menu.menu_udate);
                if (menu.menu_Img != null)
                {
                    cmd.Parameters.AddWithValue("@menu_Img", menu.menu_Img);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@menu_Img", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@menuid", menu.MenuID);

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

        public bool updateSmallMenu(MenuVO menu)
        {
            string sql = @"update Menu set MenuName = @MenuName, MenuLevel = @MenuLevel, refMenuID = @refMenuID, ProgramName = @ProgramName, menu_uadmin = @menu_uadmin, menu_udate = @menu_udate
where MenuID = @menuid";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MenuName", menu.MenuName);
                cmd.Parameters.AddWithValue("@MenuLevel", 1);
                cmd.Parameters.AddWithValue("@refMenuID", menu.refMenuID);
                cmd.Parameters.AddWithValue("@ProgramName", menu.ProgramName);
                cmd.Parameters.AddWithValue("@menu_uadmin", menu.menu_uadmin);
                cmd.Parameters.AddWithValue("@menu_udate", menu.menu_udate);
                cmd.Parameters.AddWithValue("@menuid", menu.MenuID);

                int irows = cmd.ExecuteNonQuery();

                return irows > 0;
            }
        }

    }
}
