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
    public class CompanyItemDAC : IDisposable
    {
        SqlConnection conn;

        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }
        public CompanyItemDAC()
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
            string sql = @"select ci.CompanyItem_ID, c.company_name, ci.company_id, i.Item_Name, ci.item_id, LeadTime, MOQ, UnitQuantity, (select price_present from P_Price pp where pp.CompanyItem_ID = ci.CompanyItem_ID and price_edate = '9999-12-31') price from CompanyItem ci
inner join Company c on c.company_id = ci.company_id 
inner join Item i on i.Item_ID = ci.item_id
where ci.deleted = 0";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<CompanyItemVO>(cmd.ExecuteReader());
            }
        }

        public List<CompanyItemVO> GetCompanyItemByItemid(int itemid)
        {
            string sql = @"select ci.CompanyItem_ID, c.company_name, ci.company_id, i.Item_Name, ci.item_id, LeadTime, MOQ, UnitQuantity, (select price_present from P_Price pp where pp.CompanyItem_ID = ci.CompanyItem_ID and price_edate = '9999-12-31') price from CompanyItem ci
inner join Company c on c.company_id = ci.company_id 
inner join Item i on i.Item_ID = ci.item_id
where ci.item_id = @item_id and ci.deleted = 0";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@item_id", itemid);
                return Helper.DataReaderMapToList<CompanyItemVO>(cmd.ExecuteReader());
            }
        }
    }
}
