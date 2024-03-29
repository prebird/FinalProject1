﻿using System;
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
    public class SalesMasterDAC : IDisposable
    {
        SqlConnection conn;

        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }
        public SalesMasterDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }
    
        public bool InsertSalesMaster(SalesMasterVO smVO)
        {
            string sql = @"insert into PurchaseOrder (PO_PlanID, PO_WorkOrderID, PO_CompanyName, PO_CompanyType, PO_CusProductName, PO_ProductID, PO_OrderCnt, PO_DeadLine, PO_UploadDate)
                         values (@PO_PlanID, @PO_WorkOrderID, @PO_CompanyName, @PO_CompanyType, @PO_CusProductName, @PO_ProductID, @PO_OrderCnt, @PO_DeadLine, @PO_UploadDate)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@PO_PlanID", DBNull.Value);
                cmd.Parameters.AddWithValue("@PO_WorkOrderID", smVO.PO_WorkOrderID);
                cmd.Parameters.AddWithValue("@PO_CompanyName", smVO.PO_CompanyName);
                cmd.Parameters.AddWithValue("@PO_CompanyType", smVO.PO_CompanyType);
                cmd.Parameters.AddWithValue("@PO_CusProductName", smVO.PO_CusProductName);
                cmd.Parameters.AddWithValue("@PO_ProductID", smVO.PO_ProductID);
                cmd.Parameters.AddWithValue("@PO_OrderCnt", smVO.PO_OrderCnt);
                cmd.Parameters.AddWithValue("@PO_DeadLine", smVO.PO_DeadLine);
                cmd.Parameters.AddWithValue("@PO_UploadDate", smVO.PO_UploadDate);

                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }
        }

        public bool UpdateSM(SalesMasterVO smVO)
        {
            string sql = @"update PurchaseOrder set PO_Destination = @PO_Destination, PO_OutCnt=@PO_OutCnt, PO_CancelCnt=@PO_CancelCnt, 
                         PO_EditManager = @PO_EditManager, PO_EditDate = @PO_EditDate, PO_Content = @PO_Content
                         where PO_ID = @PO_ID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@PO_ID", smVO.PO_ID);
                cmd.Parameters.AddWithValue("@PO_Destination", smVO.PO_Destination);
                cmd.Parameters.AddWithValue("@PO_OutCnt", smVO.PO_OutCnt);
                cmd.Parameters.AddWithValue("@PO_CancelCnt", smVO.PO_CancelCnt);
                cmd.Parameters.AddWithValue("@PO_EditManager", smVO.PO_EditManager);
                cmd.Parameters.AddWithValue("@PO_EditDate", smVO.PO_EditDate);
                cmd.Parameters.AddWithValue("@PO_Content", smVO.PO_Content);

                int iRowAffect = cmd.ExecuteNonQuery();
                return iRowAffect > 0;
            }

        }
            // 전체 조회
        public List<SalesMasterVO> GetAllSM()
        {
            string sql = @"select PO_ID, PO_WorkOrderID, PO_PlanID, PO_CompanyName, PO_CompanyType, PO_Destination, PO_CusProductName, Item_Name, 
                           PO_OrderCnt, PO_OutCnt, PO_CancelCnt, PO_DeadLine, PO_UploadDate, PO_EditManager, PO_EditDate, PO_Content
                           from PurchaseOrder PO inner join Item I on po.PO_ProductID = i.Item_ID
                           where PO_Deleted = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<SalesMasterVO>(cmd.ExecuteReader());
            }
        }

        // 특정 조회 
        //public SalesMasterVO GetOneSM(int itemID)
        //{
        //    string sql = @"select Item_ID, Item_Category, Item_Code, Item_Name, Item_UnitQTY, Item_OrderType, Item_YN, Item_InHouse, 
        //                 Item_OutHouse, Item_SafetyQTY, Item_CheckType, Item_Content, Item_Barcode
        //                 from Item
        //                 where Item_ID = @Item_ID and Item_Deleted = 0";

        //    using (SqlCommand cmd = new SqlCommand(sql, conn))
        //    {
        //        cmd.Parameters.AddWithValue("Item_ID", itemID);
        //        List<SalesMasterVO> list = Helper.DataReaderMapToList<SalesMasterVO>(cmd.ExecuteReader());

        //        if (list != null && list.Count > 0)
        //            return list[0];
        //        else
        //            return null;
        //    }
        //}

        // 부분 조회
        public List<SalesMasterVO> GetPartialSM(DateTime StartDate, DateTime EndDate, string companyName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select PO_ID, PO_WorkOrderID, PO_PlanID, PO_CompanyName, PO_CompanyType, PO_Destination, PO_CusProductName, 
                        PO_ProductID, PO_OrderCnt, PO_OutCnt, PO_CancelCnt, PO_DeadLine, PO_UploadDate, PO_EditManager, PO_EditDate, PO_Content
                        from PurchaseOrder
                        where PO_Deleted = 0 and 1=1 and PO_DeadLine between @StartDate and @EndDate");

            if (!string.IsNullOrEmpty(companyName))
                sb.Append(" and PO_CompanyName like @PO_CompanyName");

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();
                cmd.Parameters.AddWithValue("@PO_CompanyName", companyName);
                cmd.Parameters.AddWithValue("@StartDate","'" + StartDate + "'");
                cmd.Parameters.AddWithValue("@EndDate", "'" + EndDate + "'");

                return Helper.DataReaderMapToList<SalesMasterVO>(cmd.ExecuteReader());

            }
        }

        // 삭제
        public bool DeleteSM(int SalesMasterID)
        {
            string sql = "update PurchaseOrder set PO_Deleted = 1 where PO_ID = @PO_ID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@PO_ID", SalesMasterID);

                int iCnt = cmd.ExecuteNonQuery();
                return (iCnt > 0);
            }
        }



    }

}
