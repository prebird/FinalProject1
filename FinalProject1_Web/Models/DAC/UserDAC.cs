using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace FinalProject1_Web.Models
{

    public class UserDAC
    {
        SqlConnection conn;

        public UserDAC()
        {
            conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
        }

        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        // 로그인 시도
        public int IsUserValid(string UserID, string PWD)
        {
            string sql = "select count(*) from UserInfo Where UserID= @UserID and Password = @PWD";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@PWD", PWD);

                return (int)cmd.ExecuteScalar();
            }
        }

        // 유저 정보 받아오기
        public UserInfo GetUserInfo(string UserID, string PWD)
        {
            string sql = "select UserID, Password, UserName, Dept, CompanyID ,Authority, Gender, Email, Addr1, Addr2, ZipCode, Deleted from UserInfo Where UserID= @UserID and Password = @PWD";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@PWD", PWD);

                return Helper.DataReaderMapToList<UserInfo>(cmd.ExecuteReader())[0];
            }
        }

        public bool IsValidID(string ID)
        {
            string sql = "select count(*) from UserInfo where UserID = @UserID";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", ID);
                int count = (int)cmd.ExecuteScalar();
                if (count < 1)
                {
                    return true; //사용가능한 아이디입니다.
                }
                else
                {
                    return false; //이미 있는 아이디입니다.
                }
            }
        }
    }
}