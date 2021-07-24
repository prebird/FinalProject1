using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;

namespace FinalProject1_DAC
{
    public class BORDAC : IDisposable
    {
        SqlConnection conn;

        public BORDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public bool SaveBOR(BORVO bor)
        {
            string sql = "SP_SaveBOR";
            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_BORID", bor.BORID);
                cmd.Parameters.AddWithValue("@P_ItemCode", bor.ItemCode);
                cmd.Parameters.AddWithValue("@P_ItemName", bor.Item_Name);
                cmd.Parameters.AddWithValue("@P_ProcessCode", bor.ProcessCode);
                cmd.Parameters.AddWithValue("@P_EquipmentCode", bor.EquipmentCode);
                cmd.Parameters.AddWithValue("@P_Tact_Time", bor.Tact_Time);
                cmd.Parameters.AddWithValue("@P_Priority", bor.Priority);
                cmd.Parameters.AddWithValue("@P_IsUse", bor.IsUse);
                cmd.Parameters.AddWithValue("@P_INS_EMP", bor.INS_EMP);
                cmd.Parameters.AddWithValue("@P_Remark", bor.Remark);

                int affecRow = cmd.ExecuteNonQuery();

                return (affecRow > 0);
            }
        }

        public List<BORVO> GetAllBOR()
        {
            string sql = @"select BORID, Item_Name, ProcessName, EquipmentName, EquipmentCode, Tact_Time, [Priority], IsUse, B.INS_EMP, CONVERT(nvarchar,B.INS_DATE,120) INS_DATE, Remark
                                  from BOR B inner join Item I on B.ItemID = I.Item_ID
                                             inner join ProcessInfo P on B.ProcessID = P.ProcessID
                                             inner join Equipment E on E.EquipmentID = B.EquipmentID ";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                return Helper.DataReaderMapToList<BORVO>(cmd.ExecuteReader());
            }
        }

        public bool DeleteBOR(int borID)
        {
            string sql = "update BOR set Deleted = 1 where BORID = @BORID";
            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.Parameters.AddWithValue("@BORID", borID);

                int affectRow = cmd.ExecuteNonQuery();

                return (affectRow > 0);
            }
        }

        public BORVO GetSpecialBOR(string processName, string EquipmentName, string itemName)
        {
            string sql = @"select B.ProcessID, B.EquipmentID, BORID
                           from BOR B inner join ProcessInfo P on B.ProcessID = P.ProcessID
		                              inner join Equipment E  on B.EquipmentID = E.EquipmentID
		                              inner join Item I on B.ItemID = I.Item_ID
                           where ProcessName = @ProcessName and EquipmentName = @EquipmentName and Item_Name = @Item_Name";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.Parameters.AddWithValue("@ProcessName", processName);
                cmd.Parameters.AddWithValue("@EquipmentName", EquipmentName);
                cmd.Parameters.AddWithValue("@Item_Name", itemName);

                List<BORVO> list = Helper.DataReaderMapToList<BORVO>(cmd.ExecuteReader());

                return list[0];
            }
        }
    }
}
