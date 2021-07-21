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
    public partial class frmMateriaInspect : Basic3
    {
        public frmMateriaInspect()
        {
            InitializeComponent();
        }

        private void frmMateriaInspect_Load(object sender, EventArgs e)
        {
            

            CommonUtil.SetInitGridView(dgvInspect);
            CommonUtil.AddGridTextColumn(dgvInspect, "검사유형", "inspect_type", DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
            CommonUtil.AddGridTextColumn(dgvInspect, "품명", "Item_Name", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);
            CommonUtil.AddGridTextColumn(dgvInspect, "품목", "Item_Code", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvInspect, "입고량", "", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvInspect, "입고일자", "", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvInspect, "검사결과", "inspect_result", DataGridViewContentAlignment.MiddleCenter, colWidth: 200);
            CommonUtil.AddGridTextColumn(dgvInspect, "검사날짜", "inspect_date", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgvInspect, "검사자", "inspect_user", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            

            LoadData();
        }

        private void LoadData()
        {
            
        }

        //조회
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        //검사 확인
        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
