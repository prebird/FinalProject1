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
    }
}
