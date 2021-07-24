using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1_DAC
{
    public class ProductPlanDAC : IDisposable
    {
        SqlConnection conn;

        public ProductPlanDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public DataTable GetPlanList(string fromDate, string toDate)
        {
            string sql = "SP_ProductPlanLIst";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@P_StartDT", fromDate);
            da.SelectCommand.Parameters.AddWithValue("@P_EndDT", toDate);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            return dt;
        }

        public DataTable GetSpecialPlanList(string fromDate, string toDate, string ItemName, string EquipmentName, string planID)
        {
            string sql = @"DECLARE @v_date		nvarchar(MAX),
             @QRY nvarchar(MAX)

;

            WITH Dates

    AS(
        select @fromDate as CalDate

        union all

        select convert(nvarchar(10), DATEADD(day, 1, CalDate), 23) CalDate

        from Dates

        where CalDate < @toDate 

    )
select distinct @v_date = STUFF((SELECT ',' + '[' + CalDate + ']' FROM Dates FOR XML PATH('')), 1, 1, '') FROM Dates
print @v_date

SET @QRY = 'select PlanID, ProcessName,EquipmentName,Item_Name, Status, ' + @v_date + '
from
(select P.ProductionPlanID, Item_Name, ProcessName, EquipmentName, Quantity, PlanDate, PlanID, PP.Status
 from Production_PlanDetail P inner
 join BOR B on P.BORID = B.BORID

inner
 join Item I on B.ItemID = I.Item_ID

inner
 join Equipment E on B.EquipmentID = E.EquipmentID

inner
 join ProcessInfo Pr on Pr.ProcessID = B.ProcessID

inner
 join Production_Plan PP on PP.ProductionPlanID = P.ProductionPlanID
where EquipmentName = ''@EquipmentName'' and Item_Name = ''@Item_Name'' and PlanID = ''@PlanID''
 ) AS src
pivot(
    sum(Quantity)

    for PlanDate in (' + @v_date + ')
) D'

print @QRY

EXEC(@QRY)

";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@EquipmentName", EquipmentName);
            da.SelectCommand.Parameters.AddWithValue("@fromDate", fromDate);
            da.SelectCommand.Parameters.AddWithValue("@toDate", toDate);
            da.SelectCommand.Parameters.AddWithValue("@Item_Name", ItemName);
            da.SelectCommand.Parameters.AddWithValue("@PlanID", planID);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public List<BORVO> GetBORInfo(int itemID)
        {
            string sql = @"select Item_Name, B.EquipmentID, EquipmentName, B.ProcessID, ProcessName, PriorDate
                           from BOR B inner join Item I on B.ItemID = I.Item_ID
                                      inner join ProcessInfo P on B.ProcessID = P.ProcessID
                                      inner join Equipment E on B.EquipmentID = E.EquipmentID
                                      where B.ItemID = @ItemID order by B.Priority";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.Parameters.AddWithValue("@ItemID", itemID);

                return Helper.DataReaderMapToList<BORVO>(cmd.ExecuteReader());
            }
        }
    }
}
