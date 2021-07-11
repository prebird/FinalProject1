using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmMasterCreate : FinalProject1_winform.Basic3
    {
        public frmMasterCreate()
        {
            InitializeComponent();
        }

        // 영업 마스터 업로드 후 그리드뷰 출력
        private void btn_POExcel_Click(object sender, EventArgs e)
        {
            frmPOUpload frm = new frmPOUpload();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                dgv_PO.DataSource = frm.ExcelData;
                
            }
            
        }
        
        // 영업 마스터 생성
        private void btn_Create_Click(object sender, EventArgs e)
        {


        }
    }
}
