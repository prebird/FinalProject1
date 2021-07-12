using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmRestockOrder : FinalProject1_winform.Basic3
    {
        public frmRestockOrder()
        {
            InitializeComponent();
        }

        private void frmRestockOrder_Load(object sender, EventArgs e)
        {
            dtp1.FromDate = DateTime.Now.AddDays(-7);
            dtp1.ToDate = DateTime.Now;
            dataLoad();
        }

        private void button_gudi1_Click(object sender, EventArgs e)
        {
            List<int> chkList = new List<int>();
            for (int i = 0; i < dgV_gudi1.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dgV_gudi1.Rows[i].Cells[0].EditedFormattedValue;
                if (isCellChecked)
                    chkList.Add(Convert.ToInt32(dgV_gudi1.Rows[i].Cells[1].Value));
            }

            if (chkList.Count == 0)
            {
                MessageBox.Show("출력할 바코드를 선택해주세요.");
                return;
            }

            string strCheckBarCodeID = string.Join(",", chkList);  // "11, 12, 13"
            RestockService service = new RestockService();

            XtraReport1 rpt = new XtraReport1();
            rpt.DataSource = service.GetPrintData(strCheckBarCodeID);
            ReportPreviewForm frm = new ReportPreviewForm(rpt);

            
        }

        private void dataLoad()
        {
            RestockService service = new RestockService();
            dgV_gudi1.DataSource = service.GetROList();
        }

        
    }
}
