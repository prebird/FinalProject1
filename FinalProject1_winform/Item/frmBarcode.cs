using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FinalProject1_winform
{
    public partial class frmBarcode : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
        CheckBox headerCheckBox = new CheckBox();

        public frmBarcode()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BarcodeID, B.ProductID, P.ProductName, BoxLevel, Qty
            CommonUtil.SetInitGridView(dataGridView1);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "chk";
            chk.Width = 30;
            dataGridView1.Columns.Add(chk);

            Point headerCellLocation = this.dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;

            headerCheckBox.Location = new Point(headerCellLocation.X + 8, headerCellLocation.Y + 2);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Clicked);
            dataGridView1.Controls.Add(headerCheckBox);

            CommonUtil.AddGridTextColumn(dataGridView1, "바코드ID", "BarcodeID", visibility: false);
            CommonUtil.AddGridTextColumn(dataGridView1, "제품ID", "ProductID", visibility: false);
            CommonUtil.AddGridTextColumn(dataGridView1, "제품명", "ProductName", colWidth:200 );
            CommonUtil.AddGridTextColumn(dataGridView1, "포장레벨", "BoxLevel");
            CommonUtil.AddGridTextColumn(dataGridView1, "수량", "Qty");

            //제품정보 바인딩
            string sql = "select ProductID,ProductName from Products order by ProductName";
            DataTable dt = new DataTable();
            using(SqlConnection conn = new SqlConnection(strConn))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);

                cboProduct.DisplayMember = "ProductName";
                cboProduct.ValueMember = "ProductID";
                cboProduct.DataSource = dt;
            }

            DataBinding();
        }

        private void HeaderCheckBox_Clicked(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells["chk"] as DataGridViewCheckBoxCell;
                checkBox.Value = headerCheckBox.Checked;
            }
        }

        private void cboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBox.Text.Equals("대"))
                txtQty.Text = "30";
            else if (cboBox.Text.Equals("중"))
                txtQty.Text = "5";
            else if (cboBox.Text.Equals("소"))
                txtQty.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into BarCodeOutput (ProductID, BoxLevel, Qty) values (@ProductID, @BoxLevel, @Qty)";

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(cboProduct.SelectedValue));
                    cmd.Parameters.AddWithValue("@BoxLevel", cboBox.Text);
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtQty.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            DataBinding();
        }

        private void DataBinding()
        {
            string sql = @"select BarcodeID, B.ProductID, P.ProductName, BoxLevel, Qty
from BarCodeOutput B inner join Products P on B.ProductID = P.ProductID";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> chkList = new List<int>();
            for (int i=0; i<dataGridView1.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue;
                if (isCellChecked)
                    chkList.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
            }

            if (chkList.Count == 0)
            {
                MessageBox.Show("출력할 바코드를 선택해주세요.");
                return;
            }

            string strCheckBarCodeID = string.Join(",", chkList);  // "11, 12, 13"

            string sql = @"select BarcodeID, B.ProductID, P.ProductName, BoxLevel, Qty
from BarCodeOutput B inner join Products P on B.ProductID = P.ProductID
where BarcodeID in (" + strCheckBarCodeID + ")";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {                    
                    da.Fill(dt);
                }
             }

            XtraReport1 rpt = new XtraReport1();
            rpt.DataSource = dt;
            ReportPreviewForm frm = new ReportPreviewForm(rpt);
        }
    }
}
