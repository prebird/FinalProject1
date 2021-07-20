using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;

namespace FinalProject1_DAC
{
    public class UserInfoDAC : IDisposable
    {
        SqlConnection conn;

        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }
        public UserInfoDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public int IsUserValid(string UserID, string PWD)
        {
            string sql = "select count(*) from Userinfo Where user_id= @UserID and user_pwd = @PWD";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@PWD", PWD);

                return (int)cmd.ExecuteScalar();
            }
        }

        public UserInfoVO GetUserInfo(string UserID, string PWD)
        {
            string sql = "select user_id, user_pwd, user_name, user_Category, user_birthday, user_depart_id, user_pic, authID, user_email from Userinfo where deleted = 0 and user_id = @UserID and user_pwd=@PWD";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@PWD", PWD);

                return Helper.DataReaderMapToList<UserInfoVO>(cmd.ExecuteReader())[0];
            }
        }

        public List<UserInfoVO> SearchUserInfo(string deptid, string userCategory, string Name)
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select user_id, user_pwd, user_name, user_Category, user_birthday, user_depart_id, user_pic, authID, user_email, cc1.common_name category_name, cc2.common_name depart_name
from Userinfo u inner
join CommonCode cc1 on cc1.common_value = u.user_Category
inner
join CommonCode cc2 on cc2.common_value = u.user_depart_id
where deleted = 0 ");
                if (deptid != "0")
                {
                    sb.Append(" and user_depart_id = @user_depart_id");
                    cmd.Parameters.AddWithValue("@user_depart_id", deptid);
                }
                if (userCategory != "0")
                {
                    sb.Append(" and user_Category = @user_Category");
                    cmd.Parameters.AddWithValue("@user_Category", userCategory);
                }
                sb.Append(" and user_name like @user_name");

                

                cmd.Parameters.AddWithValue("@user_name", $"%{Name}%");

                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                return Helper.DataReaderMapToList<UserInfoVO>(cmd.ExecuteReader());
            }
        }

        public bool IsValidID(string ID)
        {
            string sql = "select count(*) from Userinfo where user_id = @UserID";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", ID);
                int count = (int)cmd.ExecuteScalar();
                if (count < 1)
                {
                    return true; // DB에 없음
                }
                else
                {
                    return false;
                }
            }
        }

        public bool InsertData(UserInfoVO user)
        {
            string sql = @"insert into Userinfo(user_id, user_pwd, user_name, user_Category, user_depart_id, user_email, user_pic, authID)
values(@user_id, @user_pwd, @user_name, @user_Category, @user_depart_id, @user_email, @user_pic, @authID)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@user_id", user.user_id);
                cmd.Parameters.AddWithValue("@user_pwd", user.user_pwd);
                cmd.Parameters.AddWithValue("@user_name", user.user_name);
                cmd.Parameters.AddWithValue("@user_Category", user.user_Category);
                if (user.user_email != null)
                {
                    cmd.Parameters.AddWithValue("@user_email", user.user_email); 
                }
                if (user.user_depart_id != null)
                {
                    cmd.Parameters.AddWithValue("@user_depart_id", user.user_depart_id); 
                }
                else
                {
                    cmd.Parameters.AddWithValue("@user_depart_id", DBNull.Value);
                }
                
                if (user.user_pic != null)
                {
                    cmd.Parameters.AddWithValue("@user_pic", user.user_pic); 
                }
                else
                {
                    cmd.Parameters.AddWithValue("@user_pic", DBNull.Value);
                }
                if (user.authID != null)
                {
                    cmd.Parameters.AddWithValue("@authID", user.authID); 
                }
                else
                {
                    cmd.Parameters.AddWithValue("@authID", DBNull.Value);
                }


                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public bool UpdateData(UserInfoVO user)
        {
            string sql = @"update Userinfo set(user_pwd = @user_pwd, user_name = @user_name, user_Category = @user_Category, 
user_birthday = @user_birthday, user_depart_id = @user_depart_id, user_email = @user_email, user_pic = @user_pic, authID = @authID) where user_id = @user_id";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@user_id", user.user_id);
                cmd.Parameters.AddWithValue("@user_pwd", user.user_pwd);
                cmd.Parameters.AddWithValue("@user_name", user.user_name);
                cmd.Parameters.AddWithValue("@user_Category", user.user_Category);
                if (user.user_email != null)
                {
                    cmd.Parameters.AddWithValue("@user_email", user.user_email);
                }
                if (user.user_depart_id != null)
                {
                    cmd.Parameters.AddWithValue("@user_depart_id", user.user_depart_id);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@user_depart_id", DBNull.Value);
                }

                if (user.user_pic != null)
                {
                    cmd.Parameters.AddWithValue("@user_pic", user.user_pic);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@user_pic", DBNull.Value);
                }
                if (user.authID != null)
                {
                    cmd.Parameters.AddWithValue("@authID", user.authID);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@authID", DBNull.Value);
                }

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
