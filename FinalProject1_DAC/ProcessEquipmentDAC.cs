﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;

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

        // Equipmet 다 가져오기
        public List<EquipmentVO> GetAllEquipment()
        {
            string sql = @"select EquipmentID, ProcessID, EquipmentGroupID, EquipmentCode, EquipmentName, Status, Deleted, INS_EMP, INS_DATE, IsActive, FromLocationID, ToLocationID from Equipment";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<EquipmentVO> list = Helper.DataReaderMapToList<EquipmentVO>(dr);
                return list;
            }
        }


    }
}
