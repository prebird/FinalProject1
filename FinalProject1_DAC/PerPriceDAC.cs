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
    public class PerPriceDAC : IDisposable
    {
        SqlConnection conn;

        public PerPriceDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<CompanyItemVO> GetCompanyItem()
        {
            
                string sql = @"select I.item_id, I.item_name, C.company_id, C.company_code
	                                    from CompanyItem R join Item I ON R.Item_id = I.item_id
		                                    join company C ON R.company_id = C.company_id
                                          where R.deleted = 0
										  order by 1,2,3,4";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return Helper.DataReaderMapToList<CompanyItemVO>(cmd.ExecuteReader());
                }
            

        }
    }
}
