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
    public class ProcessEquipmentDAC : IDisposable
    {
        SqlConnection conn;

        public ProcessEquipmentDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public bool InsertProcess(ProcessVO process)
        {
            string sql = "SP_SaveProcess";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_Code", process.ProcessCode);
                cmd.Parameters.AddWithValue("@P_Name", process.ProcessName);
                cmd.Parameters.AddWithValue("@P_IsActive", process.IsActive);
                cmd.Parameters.AddWithValue("@P_INS_EMP", process.INS_EMP);

                int affectRow = cmd.ExecuteNonQuery();

                return (affectRow > 0);
            }
        }

        public bool SaveEquipmentGroup(EquipmentGroupVO equipmentgroup)
        {
            string sql = "SP_SaveEquipmentGroup";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_Code", equipmentgroup.EquipmentGroupCode);
                cmd.Parameters.AddWithValue("@P_Name", equipmentgroup.EquipmentGroupName);
                cmd.Parameters.AddWithValue("@P_IsActive", equipmentgroup.IsActive);
                cmd.Parameters.AddWithValue("@P_INS_EMP", equipmentgroup.INS_EMP);

                int affectRow = cmd.ExecuteNonQuery();

                return (affectRow > 0);
            }
        }

        public List<ProcessVO> GetAllProcess()
        {
            string sql = "select ProcessCode, ProcessName from ProcessInfo where Deleted = 0 and IsActive = 'Y'";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                return Helper.DataReaderMapToList<ProcessVO>(cmd.ExecuteReader());
            }
        }

        public List<EquipmentGroupVO> GetAllEquipmentGroup()
        {
            string sql = "select EquipmentGroupCode, EquipmentGroupName from EquipmentGroup where Deleted = 0 and IsActive = 'Y'";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                return Helper.DataReaderMapToList<EquipmentGroupVO>(cmd.ExecuteReader());
            }
        }

        public bool SaveEquipment(EquipmentVO equipment)
        {
            string sql = "SP_SaveEquipment";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_ProcessCode", equipment.ProcessCode);
                cmd.Parameters.AddWithValue("@P_EquipmentGroupCode", equipment.EquipmentGroupCode);
                cmd.Parameters.AddWithValue("@P_EquipmentCode", equipment.EquipmentCode);
                cmd.Parameters.AddWithValue("@P_EquipmentName", equipment.EquipmentName);
                cmd.Parameters.AddWithValue("@P_Satus", equipment.Status);
                cmd.Parameters.AddWithValue("@P_INS_EMP", equipment.INS_EMP);
                cmd.Parameters.AddWithValue("@P_IsActive", equipment.IsActive);
                cmd.Parameters.AddWithValue("@P_FromLocationID", equipment.FromLocationID);
                cmd.Parameters.AddWithValue("@P_ToLocationID", equipment.ToLocationID);


                int affectRow = cmd.ExecuteNonQuery();
                return (affectRow > 0);
            }
        }

        public List<EquipmentVO> GetAllEquipment()
        {
            string sql = @"select EquipmentID, ProcessName, EquipmentGroupName, EquipmentCode, EquipmentName, [Status], FromLocationID, 
                            ToLocationID, E.IsActive, E.INS_EMP, CONVERT(nvarchar,E.INS_DATE,120) INS_DATE, ProcessCode, EquipmentGroupCode
                            from Equipment E inner
                            join ProcessInfo P on E.ProcessID = P.ProcessID inner join EquipmentGroup EG on E.EquipmentGroupID = EG.EquipmentGroupID
                            where E.Deleted = 0";

            using(SqlCommand cmd = new SqlCommand(sql,conn))
            {
                return Helper.DataReaderMapToList<EquipmentVO>(cmd.ExecuteReader());
            }
        }
    }
}
