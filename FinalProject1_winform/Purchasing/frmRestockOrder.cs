using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinalProject1_VO;
using Microsoft.VisualBasic;
    
namespace FinalProject1_winform
{
    public partial class frmRestockOrder : FinalProject1_winform.Basic3
    {
        DataTable dtMRP;
        public frmRestockOrder()
        {
            InitializeComponent();
        }

        private void frmRestockOrder_Load(object sender, EventArgs e)
        {
            dtp1.FromDate = DateTime.Now.AddDays(-7);
            dtp1.ToDate = DateTime.Now;


            // 콤보바인딩
            CommonUtil.ComboBindingPlanID(cboPlanID);

            //
            CommonUtil.ComboBindingProductID(cboProductID);

            // dgv
            //CommonUtil.SetInitGridView(dgv1);
            CommonUtil.AddGridTextColumn(dgv1, "품번", "itemid", colWidth: 80);
            CommonUtil.AddGridTextColumn(dgv1, "품명", "Item_Name", colWidth: 200);
            
            CommonUtil.AddGridTextColumn(dgv1, "구분", "gubun", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv1, "카테고리", "Category", colWidth: 100, visibility: false);
            CommonUtil.AddGridTextColumn(dgv1, "정렬", "SortNum", colWidth: 100, visibility: false);
            CommonUtil.AddGridTextColumn(dgv1, "a", "a", colWidth: 200, visibility: false);


            btnSearch.PerformClick();
        }

        

        //검색
        private void button_gudi8_Click(object sender, EventArgs e)
        {
            MRPSearchVO search = new MRPSearchVO();
            search.PlanID = (cboPlanID.SelectedText == "선택") ? "" : cboPlanID.SelectedText;
            search.FromDate = dtp1.FromDate.ToString();
            search.Todate = dtp1.ToDate.ToString();
            search.ProductID = cboProductID.SelectedValue.ToString().ZeroOrNum();

            RestockService service = new RestockService();
            dtMRP = service.GetMRP(search);

            dgv1.DataSource = dtMRP;
        }

       

        private void dgv1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

            if((e.ColumnIndex != 0 && e.ColumnIndex != 1&& e.ColumnIndex != 2) && dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value )
            {
                if (Information.IsNumeric(dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                {
                    if (Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < 0)
                    {
                        dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    }
                }
                
            }


            
                if (dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != DBNull.Value)
                {
                if ((dgv1.Rows[e.RowIndex].Cells[3].Value.ToString() == "생산제안" || dgv1.Rows[e.RowIndex].Cells[3].Value.ToString() == "발주제안")  &&(e.ColumnIndex != 0 && e.ColumnIndex != 1 && e.ColumnIndex != 2))
                {
                    if (Information.IsNumeric(dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                    {
                        if (Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > 0)
                        {
                            dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;
                        }
                    } 
                }
                }  
            
            
        }

        private void btnAddRestock_Click(object sender, EventArgs e)
        {
            DataView dvMRP = new DataView(dtMRP);
            dvMRP.RowFilter = "gubun = '발주제안'";

            frmRestockOrderPopUP frm = new frmRestockOrderPopUP(dvMRP);
            frm.ShowDialog();
        }
    }
}
