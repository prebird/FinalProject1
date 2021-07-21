using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FinalProject1_winform
{
    public partial class frmPOUpload : Form
    {
        public DataTable ExcelData { get; set; }
        public string PlanDate { get; set; }
        public string PlanID { get; set; }
        
        string _strConn = string.Empty;

        public frmPOUpload()
        {
            InitializeComponent();
        }
                
        private void btn_SearchFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel Files(*.xlsx)| *.xlsx|Excel Files(*.xls)|*.xls";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
                string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

                string Filename = dlg.FileName;
                txt_FileName.Text = Filename;

                string fileExtension = System.IO.Path.GetExtension(Filename);

                if (fileExtension == ".xls")
                    _strConn = string.Format(Excel03ConString, Filename, "Yes");
                else if (fileExtension == ".xlsx")
                    _strConn = string.Format(Excel07ConString, Filename, "Yes");         
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // 유효성 체크
            if (string.IsNullOrWhiteSpace(txt_FileName.Text))
            {
                MessageBox.Show("업로드할 파일을 선택 하세요.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
                return;
            }

            //if (dtp_Date.Value <= DateTime.Now)
            //{
            //    MessageBox.Show("계획 일자 금일 이전일 수 없습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.DialogResult = DialogResult.No;
            //    return;
            //}    

            PlanDate = dtp_Date.Value.ToString("yy-MM-dd");

            //엑셀파일을 OLEDB 방식으로 읽어서 DataTable로 읽어들인다.
            string sheetName = string.Empty;

            OleDbConnection conn = new OleDbConnection(_strConn);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            conn.Open();
            DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            sheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString();

            string sql = "select * from [" + sheetName + "]";
            OleDbDataAdapter oda = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            conn.Close();

            if (dt != null)
                ExcelData = dt; // 바인딩 할 자료를 DataTable로 전달.
            else
                MessageBox.Show("데이터가 없습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
