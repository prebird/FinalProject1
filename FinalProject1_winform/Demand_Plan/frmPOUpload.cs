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
                PlanDate = dtp_Date.Value.ToString("yy-MM-dd");
                txt_FileName.Text = Filename;

                string fileExtension = System.IO.Path.GetExtension(Filename);
                string strConn = string.Empty;

                if (fileExtension == ".xls")
                    strConn = string.Format(Excel03ConString, Filename, "Yes");
                else if (fileExtension == ".xlsx")
                    strConn = string.Format(Excel07ConString, Filename, "Yes");

                //엑셀파일을 OLEDB 방식으로 읽어서 DataTable로 읽어들인다.
                string sheetName = string.Empty;

                OleDbConnection conn = new OleDbConnection(strConn);
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

                ExcelData = dt;
            }
        }
    }
}
