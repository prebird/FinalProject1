using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmMaterialPrice : Basic3
    {
        public frmMaterialPrice()
        {
            InitializeComponent();
        }

        private void frmMaterialPrice_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvMaterialPrice);

            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "업체", "Company_code", DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "업체명", "Company_name", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "품목", "Item_code", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "품명", "Item_name", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "현재단가", "", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "이전단가", "", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "시작일", "inspect_result", DataGridViewContentAlignment.MiddleCenter, colWidth: 200);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "종료일", "inspect_date", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "비고", "inspect_user", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "사용유무", "inspect_user", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "수정일", "inspect_user", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgvMaterialPrice, "수정자", "inspect_user", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);

        }
    }
}
