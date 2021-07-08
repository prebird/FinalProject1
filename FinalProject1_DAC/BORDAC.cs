﻿using System;
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
                cmd.Parameters.AddWithValue("@P_ItemName", bor.ItemName);
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
    }
}
