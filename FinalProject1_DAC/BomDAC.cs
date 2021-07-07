using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using FinalProject1_VO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject1_DAC
{
    public class BomDAC : IDisposable
    {
        SqlConnection conn;

        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }
        public BomDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        // 정전개
        public List<BomVO> BOMForward(int MoItemID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_BOMForward";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BOM_MoItemID", MoItemID);

                return Helper.DataReaderMapToList<BomVO>(cmd.ExecuteReader());
            }
        }

        // 역전개
        public List<BomVO> BOMReverse(int JaitemID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "SP_BOMReverse";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BOM_JaItemID", JaitemID);

                return Helper.DataReaderMapToList<BomVO>(cmd.ExecuteReader());
            }
        }

        // 해당 모품목에 등록된 자품목만 조회
        public List<BomVO> SearchJaItem(int MoitemID)
        {
            string sql = @"select BOM_MoItemID, BOM_JaItemID, i.Item_Category, i.Item_Name, i.Item_UnitQTY
                         from BOM B inner
                         join Item i on b.BOM_JaItemID = i.Item_ID
                         where BOM_Deleted = 0 and b.BOM_MoItemID = @BOM_MoItemID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@BOM_MoItemID", MoitemID);

                return Helper.DataReaderMapToList<BomVO>(cmd.ExecuteReader());
            }
        }

        // BOM 등록
        public bool InsertBOM(BomVO bom)
        {
            string sql = @"insert into bom (BOM_MoItemID, BOM_JaItemID, BOM_UseQTY, BOM_YN, BOM_DemandYN, BOM_Content)
                         values(@BOM_MoItemID, @BOM_JaItemID, @BOM_UseQTY, @BOM_YN, @BOM_DemandYN, @BOM_Content)";

            using (SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.Parameters.AddWithValue("@BOM_MoItemID", bom.BOM_MoItemID);
                cmd.Parameters.AddWithValue("@BOM_JaItemID", bom.BOM_JaItemID);
                cmd.Parameters.AddWithValue("@BOM_UseQTY", bom.BOM_UseQTY);
                cmd.Parameters.AddWithValue("@BOM_YN", bom.BOM_YN);
                cmd.Parameters.AddWithValue("@BOM_DemandYN", bom.BOM_DemandYN);
                cmd.Parameters.AddWithValue("@BOM_Content", bom.BOM_Content);

                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
        }

        public bool DeleteJaItem(int JaID)
        {
            string sql = "delete from bom where BOM_JaItemID = @BOM_JaItemID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@BOM_JaItemID", JaID);

                int iCnt = cmd.ExecuteNonQuery();
                return (iCnt > 0);
            }
        }


    }
}
