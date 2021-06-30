using System;
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

            string sql = "";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                List<MenuVO> list = null;
                return list;

            }
        }
    }
}
