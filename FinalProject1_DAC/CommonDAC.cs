﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using FinalProject1_VO;

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

            string sql = @"select m.MenuID, MenuName, MenuLevel, refMenuID, ProgramName, a.AuthName , a.AuthID  
from Menu m left outer join MenuAuth ma on m.MenuID = ma.MenuID
left outer join Authority a on ma.AuthID = a.AuthID";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<MenuVO> list = Helper.DataReaderMapToList<MenuVO>(dr);
                return list;
            }
        }


        public List<MenuVO> GetAllMenuMgt()
        {

            string sql = @"select m.MenuID, MenuName, MenuLevel, refMenuID, ProgramName, menu_uadmin ,u.user_name, menu_udate
from Menu m left outer join MenuAuth ma on m.MenuID = ma.MenuID
left outer join Userinfo u on  u.user_id = m.menu_uadmin";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<MenuVO> list = Helper.DataReaderMapToList<MenuVO>(dr);
                return list;
            }
        }

    }
}
