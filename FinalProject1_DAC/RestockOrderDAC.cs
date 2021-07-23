﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;

namespace FinalProject1_DAC
{
    public class RestockOrderDAC : IDisposable
    {
        SqlConnection conn;
        string strConn = ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString;
        //private static LoggingUtility log = new LoggingUtility("FinalProject1_DAC ItemDAC", Level.Info, 30);
        //public static LoggingUtility Log { get { return log; } }

        public RestockOrderDAC()
        {
            
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<RestockOrderVO> GetROList()
        {
            string sql = @"select RO_ID, itemid, Companyid, SuggestQty, Qty, dueDate, inputFlag, RegDate, RO_Status from RestockOrder";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                List<RestockOrderVO> list = Helper.DataReaderMapToList<RestockOrderVO>(cmd.ExecuteReader());
                return list;
            }
        }

        public List<RestockOrderVO> GetROandInsList(string ro_id, string fromdate, string todate, string companyid)
        {
            StringBuilder sb = new StringBuilder(); 
            sb.Append(@"select ro.RO_ID, itemid, i.Item_Name ,Companyid, c.company_name ,SuggestQty, Qty, cc.common_name RO_Status ,dueDate, Qty-isnull(ins_cnt,0) abletoCancel, inputFlag, ins.ins_cnt, ins.ins_date from RestockOrder ro
inner join item i on i.Item_ID = ro.itemid
inner join Company c on c.company_id = ro.Companyid
left outer join CommonCode cc on cc.common_value = RO_Status
left outer join InstockWait ins on ins.Ro_id = ro.RO_ID
where 1=1 ");
            using (SqlCommand cmd = new SqlCommand())
            {
                if (!string.IsNullOrEmpty(ro_id))
                {
                    sb.Append(" and ro.ro_id like @ro_id");
                    cmd.Parameters.AddWithValue("@ro_id", $"%{ro_id}%");
                }
                if (companyid != "0")
                {
                    sb.Append(" and Companyid = @companyid");
                    cmd.Parameters.AddWithValue("@companyid", companyid);
                }
                sb.Append(" and dueDate >= @fromdate");
                cmd.Parameters.AddWithValue("@fromdate", fromdate);
                sb.Append(" and dueDate <= @todate");
                cmd.Parameters.AddWithValue("@todate", todate);


                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                List<RestockOrderVO> list = Helper.DataReaderMapToList<RestockOrderVO>(cmd.ExecuteReader());
                return list;
            }
        }

        public List<RestockOrderVO> GetInsWaitList(string ro_id, string fromdate, string todate, string companyid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select ro.RO_ID, itemid, i.Item_Name ,Companyid, c.company_name ,SuggestQty, Qty, cc.common_name RO_Status ,dueDate, Qty-isnull(ins_cnt,0) abletoCancel, inputFlag, ins.ins_cnt, ins.ins_date from RestockOrder ro
inner join item i on i.Item_ID = ro.itemid
inner join Company c on c.company_id = ro.Companyid
left outer join CommonCode cc on cc.common_value = RO_Status
left outer join InstockWait ins on ins.Ro_id = ro.RO_ID
where 1=1 and RO_Status = 'RO_01'");

            using (SqlCommand cmd = new SqlCommand())
            {
                if (!string.IsNullOrEmpty(ro_id))
                {
                    sb.Append(" and ro.ro_id like @ro_id");
                    cmd.Parameters.AddWithValue("@ro_id", $"%{ro_id}%");
                }
                if (companyid != "0")
                {
                    sb.Append(" and Companyid = @companyid");
                    cmd.Parameters.AddWithValue("@companyid", companyid);
                }
                sb.Append(" and dueDate >= @fromdate");
                cmd.Parameters.AddWithValue("@fromdate", fromdate);
                sb.Append(" and dueDate <= @todate");
                cmd.Parameters.AddWithValue("@todate", todate);


                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                List<RestockOrderVO> list = Helper.DataReaderMapToList<RestockOrderVO>(cmd.ExecuteReader());
                return list;
            }
        }

        public DataTable GetPrintData(string strCheckBarCodeID)
        {
            string sql = @"select RO_ID Item_Name, company_name, Qty from RestockOrder RO
inner join item i on i.Item_ID = ro.itemid
inner join Company c on c.company_id = ro.Companyid
where ro.ro_id in (" + strCheckBarCodeID + ")";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetMRP(MRPSearchVO search)
        {
            string sql = "SP_ShowMRP";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@P_StartDT", search.FromDate);
                da.SelectCommand.Parameters.AddWithValue("@P_EndDT", search.Todate);
                da.SelectCommand.Parameters.AddWithValue("@PlanID", search.PlanID);
                da.SelectCommand.Parameters.AddWithValue("@ProductID", search.ProductID);
                da.Fill(dt);
            }
            return dt;

        }

        public DataTable GetROSuggest(MRPSearchVO search)
        {
            string sql = "SP_GetROSuggest";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@P_StartDT", search.FromDate);
                da.SelectCommand.Parameters.AddWithValue("@P_EndDT", search.Todate);
                da.SelectCommand.Parameters.AddWithValue("@PlanID", search.PlanID);
                da.SelectCommand.Parameters.AddWithValue("@ProductID", search.ProductID);
                da.Fill(dt);
            }
            return dt;

        }

        public bool insertRO(RestockOrderVO ro)
        {
            string sql = @"insert into RestockOrder (itemid, Companyid, SuggestQty, Qty,dueDate, unitPrice, RegDate)
values (@itemid, @Companyid, @SuggestQty, @Qty,@dueDate, @unitPrice, @RegDate)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("itemid", ro.itemid);
                cmd.Parameters.AddWithValue("companyid", ro.Companyid);
                cmd.Parameters.AddWithValue("SuggestQty", ro.SuggestQty);
                cmd.Parameters.AddWithValue("Qty", ro.Qty);
                cmd.Parameters.AddWithValue("dueDate", ro.dueDate);
                cmd.Parameters.AddWithValue("unitPrice", ro.unitPrice);
                cmd.Parameters.AddWithValue("RegDate", ro.RegDate);

                int irows  = cmd.ExecuteNonQuery();
                if (irows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public bool InsertInsWait(int roid, int ins_cnt, string ins_date)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlTransaction trans = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = trans;

                try
                {
                    cmd.CommandText = "insert InstockWait(Ro_id, ins_cnt, ins_date) values (@Ro_id, @ins_cnt, @ins_date)";
                    cmd.Parameters.AddWithValue("@Ro_id", roid);
                    cmd.Parameters.AddWithValue("@ins_cnt", ins_cnt);
                    cmd.Parameters.AddWithValue("@ins_date", ins_date);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "update RestockOrder set RO_Status = @RO_Status where RO_ID = @RO_ID";
                    cmd.Parameters.AddWithValue("@RO_Status", "RO_02");
                    cmd.Parameters.AddWithValue("@RO_ID", roid);

                    cmd.ExecuteNonQuery();

                    trans.Commit();
                    Dispose();
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

        public List<InspectVO> GetAllInspect()
        {
            string sql = @"select iw.ins_id, i.Item_Name, i.Item_ID ,ins_cnt, iw.ins_id, insp_noCnt, iw.Ro_id , insp_result ,insp_date, insp_user, iw.Ro_id, ins_date from InstockWait iw
left outer join Inspect ip on ip.ins_id = iw.ins_id
inner join RestockOrder ro on ro.RO_ID = iw.Ro_id
inner join item i on i.Item_ID = ro.itemid
where RO_Status = 'RO_02'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<InspectVO>(cmd.ExecuteReader());
            }
        }

        public List<InspectCriteriaVO> GetInspectCriteriaByID(int itemid)
        {
            string sql = @"select Inc_ID, ic.Item_ID, Mean, USL, LSL, Item_Name from InspectCriteria ic
inner join Item i on i.Item_ID = ic.Item_ID
where ic.Item_ID = @Item_ID";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Item_ID", itemid);
                return Helper.DataReaderMapToList<InspectCriteriaVO>(cmd.ExecuteReader());
            }
        }

        public List<InspectVO> SearchInspectData(string fromdate, string todate, int ROid, string status, string result)
        {
            string status_code;
            if (status == "입고대기중")
            {
                status_code = "RO_02";
            }
            else if (status == "검사완료")
            {
                status_code = "RO_03";
            }
            else 
            {
                status_code = "";
            }


            using (SqlCommand cmd = new SqlCommand())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(@"select iw.ins_id, i.Item_Name, ins_cnt, iw.ins_id, insp_noCnt, insp_result ,insp_date, insp_user, iw.Ro_id, ins_date from InstockWait iw
left outer join Inspect ip on ip.ins_id = iw.ins_id
inner join RestockOrder ro on ro.RO_ID = iw.Ro_id
inner join item i on i.Item_ID = ro.itemid");

                if (ROid != 0)
                {
                    sb.Append(" and Ro_id == @Ro_id");
                    cmd.Parameters.AddWithValue("@RO_id", ROid);
                }
                if (status != "선택")
                {
                    sb.Append(" and ro.Ro_Status == @Ro_Status");
                    cmd.Parameters.AddWithValue("@Ro_Status", status_code);
                }
                if (result != "선택")
                {
                    sb.Append(" and insp_result == @insp_result");
                    cmd.Parameters.AddWithValue("@insp_result", result);
                }

                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                cmd.Parameters.AddWithValue("@fromdate", fromdate);
                cmd.Parameters.AddWithValue("@todate", todate);
                return Helper.DataReaderMapToList<InspectVO>(cmd.ExecuteReader());
            }
        }

        public bool InsertInspectData(int ins_id, int insp_noCnt, string insp_result, string insp_user, int roid)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlTransaction trans = conn.BeginTransaction();
                cmd.Connection = conn;  
                cmd.Transaction = trans;

                try
                {
                    cmd.CommandText = "insert inspect (ins_id, insp_noCnt, insp_result, insp_user) values (@ins_id, @insp_noCnt, @insp_result, @insp_user)";
                    cmd.Parameters.AddWithValue("@ins_id", ins_id);
                    cmd.Parameters.AddWithValue("@insp_noCnt", insp_noCnt);
                    cmd.Parameters.AddWithValue("@insp_result", insp_result);
                    if (insp_user != null)
                    {
                        cmd.Parameters.AddWithValue("@insp_user", insp_user); 
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@insp_user", DBNull.Value);
                    }
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "update RestockOrder set RO_Status = @RO_Status where RO_ID = @RO_ID";
                    cmd.Parameters.AddWithValue("@RO_Status", "RO_03");
                    cmd.Parameters.AddWithValue("@RO_ID", roid);

                    cmd.ExecuteNonQuery();

                    trans.Commit();
                    Dispose();
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

        
    }
}
