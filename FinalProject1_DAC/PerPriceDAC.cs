using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
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

        //콤보바인딩 
        public List<CompanyItemVO> GetCompanyItem()
        {

            string sql = @"select I.item_id, I.item_code, C.company_id, C.company_code, Item_Category, CompanyItem_id
	                                    from CompanyItem R join Item I ON R.Item_id = I.item_id
		                                    join company C ON R.company_id = C.company_id
                                          where R.deleted = 0
										  ";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<CompanyItemVO>(cmd.ExecuteReader());
            }

        }

        //단가테이블 정보 바인딩(common_id)
        public List<PerPriceVO> GetPerPrice(int company_id)
        {

            string sql = @"select price_id, CompanyItem_ID, Item_ID, company_id, price_present, price_past, price_sdate, price_edate, price_yn, price_uadmin, price_udate, price_comment
	                               from P_Price
	                               where company_id = @company_id";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@company_id", company_id);
                cmd.ExecuteReader();
                return Helper.DataReaderMapToList<PerPriceVO>(cmd.ExecuteReader());

            }

        }

        //전체 조회

        public List<PerPriceVO> GetAllPerPrice()
        {
            string sql = @"select *	from P_Price";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<PerPriceVO>(cmd.ExecuteReader());
            }

        }

        //신규 등록
        public bool InsertPerPrice(PerPriceVO info)
        {
            string sql = @"insert into p_price(CompanyItem_ID, Item_ID, company_id, price_present, price_past, price_sdate, price_edate, price_yn, price_uadmin, price_udate, price_comment)
    values(@CompanyItem_ID, @Item_ID, @company_id, @price_present, @price_past, @price_sdate, @price_edate, @price_yn, @price_uadmin, @price_udate, @price_comment)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                cmd.Parameters.AddWithValue("@CompanyItem_ID", info.CompanyItem_ID);
                cmd.Parameters.AddWithValue("@Item_ID", info.Item_ID);
                cmd.Parameters.AddWithValue("@company_id", info.company_id);
                cmd.Parameters.AddWithValue("@price_present", info.price_present);
                cmd.Parameters.AddWithValue("@price_past", info.price_past);
                cmd.Parameters.AddWithValue("@price_sdate", info.price_sdate);
                cmd.Parameters.AddWithValue("@price_edate", info.price_edate);
                cmd.Parameters.AddWithValue("@price_yn", info.price_yn);
                cmd.Parameters.AddWithValue("@price_uadmin", info.price_uadmin);
                cmd.Parameters.AddWithValue("@price_udate", info.price_udate);
                cmd.Parameters.AddWithValue("@price_comment", info.price_comment);

                int iaffectedRows = cmd.ExecuteNonQuery();
                return iaffectedRows > 0;
            }

        }

        //단가 변경
        public bool InsUpPerPrice(PerPriceVO info)
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                SqlTransaction trans = conn.BeginTransaction();
                cmd.Transaction = trans;
                cmd.Connection = conn;
                try
                {
                    //현재 단가 => 이전 단가
                    cmd.CommandText = @"UPDATE P_Price  SET  price_edate = @price_edate                           
						where price_edate = '9999-12-31' and CompanyItem_ID = @CompanyItem_ID";
                    cmd.Parameters.AddWithValue("@price_edate", info.price_sdate);
                    cmd.Parameters.AddWithValue("@CompanyItem_ID", info.CompanyItem_ID);

                    int iAffectRowsP = cmd.ExecuteNonQuery();

                    //현재 단가 등록
                    string sql = @"insert into p_price(CompanyItem_ID, Item_ID, company_id, price_present, price_past, price_sdate, price_edate, price_yn, price_uadmin, price_udate, price_comment)
                     values(@CompanyItem_ID, @Item_ID, @company_id, @price_present, @price_past, @price_sdate, @price_edate, @price_yn, @price_uadmin, @price_udate, @price_comment);";
                    cmd.Parameters.Clear();
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue("@CompanyItem_ID", info.CompanyItem_ID);
                    cmd.Parameters.AddWithValue("@Item_ID", info.Item_ID);
                    cmd.Parameters.AddWithValue("@company_id", info.company_id);
                    cmd.Parameters.AddWithValue("@price_present", info.price_present);
                    cmd.Parameters.AddWithValue("@price_past", info.price_past);
                    cmd.Parameters.AddWithValue("@price_sdate", info.price_sdate);
                    cmd.Parameters.AddWithValue("@price_edate", info.price_edate);
                    cmd.Parameters.AddWithValue("@price_yn", info.price_yn);
                    cmd.Parameters.AddWithValue("@price_uadmin", info.price_uadmin);
                    cmd.Parameters.AddWithValue("@price_udate", info.price_udate);
                    cmd.Parameters.AddWithValue("@price_comment", info.price_comment);

                    int iAffectRowsD = cmd.ExecuteNonQuery();

                    trans.Commit();
                    return true;

                }
                catch (Exception err)
                {
                    Debug.WriteLine(err.Message);
                    trans.Rollback();
                    Dispose();
                    return false;
                }
            }
        }

        public List<PerPriceVO> GetSelectedPrice(string itemCode, string price_sdate, string itemCategory)
        {
            string sql = @"select Company_code, Company_name, Item_code, Item_name, Item_Category, price_present, price_past, price_sdate,price_edate,price_comment,price_yn,price_udate,price_uadmin
                                         from P_Price P join CompanyItem T on P.CompanyItem_ID = T.CompanyItem_ID
                                         join Company C on T.company_id = C.company_id
                                         join Item I on T.item_id = I.item_id
                                where item_code = @item_code and price_sdate >= @price_sdate and Item_Category = @Item_Category";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@item_code", itemCode);
                cmd.Parameters.AddWithValue("@price_sdate", price_sdate);
                cmd.Parameters.AddWithValue("@Item_Category", itemCategory);
                return Helper.DataReaderMapToList<PerPriceVO>(cmd.ExecuteReader());
            }
        }


    }
}
