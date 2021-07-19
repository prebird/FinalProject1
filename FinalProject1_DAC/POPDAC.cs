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

    }
}
