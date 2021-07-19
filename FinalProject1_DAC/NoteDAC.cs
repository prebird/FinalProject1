using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1_VO;
using System.Data;

namespace FinalProject1_DAC
{
    public class NoteDAC : IDisposable
    {
        SqlConnection conn;

        public NoteDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalProject1"].ConnectionString);
        }

        public void Dispose()
        {
            conn.Close();
        }

        public List<NoteVO> GetAllList(int pageNo, int pageSize)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "GetNoteList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PAGE_NO", pageNo);
                cmd.Parameters.AddWithValue("@PAGE_SIZE", pageSize);
                

                conn.Open();
                List<NoteVO> list = Helper.DataReaderMapToList<NoteVO>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
        }

        /// <summary>
        /// 등록된 전체 메모목록 갯수를 조회
        /// </summary>
        /// <returns></returns>
        public int GetNoteTotalCount()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "select count(*) from Note where 1=1 ";



                conn.Open();
                int tot = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return tot;
            }
        }

        /// <summary>
        /// 특정 제품ID의 제품정보를 조회
        /// </summary>
        /// <param name="note_id"></param>
        /// <returns></returns>
        public NoteVO GetProductInfo(int note_id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "select note_id, note_userid, note_subject, note_contents, note_readCount, note_date from Note where note_id = @note_id";
                cmd.Parameters.AddWithValue("@note_id", note_id);

                conn.Open();
                List<NoteVO> list = Helper.DataReaderMapToList<NoteVO>(cmd.ExecuteReader());
                conn.Close();

                return (list != null && list.Count > 0) ? list[0] : null;
            }
        }


    }
}
