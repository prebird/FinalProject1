using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public partial class frmFactory : Basic3
    {
        List<FactoryVO> List;
        public frmFactory()
        {
            InitializeComponent();
        }

        private void frmFactory_Load(object sender, EventArgs e)
        {
            cboFactoryGrade.Text = "선택";

            CommonUtil.SetInitGridView(dgv_Factory);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설군", "factory_grade", DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설구분", "common_name", DataGridViewContentAlignment.MiddleCenter, colWidth: 180);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설타입", "factoty_type", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설코드", "factory_code", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설명", "factory_name", DataGridViewContentAlignment.MiddleCenter, colWidth: 200);
            CommonUtil.AddGridTextColumn(dgv_Factory, "상위시설", "factory_parent", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgv_Factory, "사용유무", "factory_yn", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgv_Factory, "시설설명", "factory_comment", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            CommonUtil.AddGridTextColumn(dgv_Factory, "수정일자", "factory_uadmin", DataGridViewContentAlignment.MiddleCenter, colWidth: 170);
            
            LoadData();
        
        }

        private void LoadData()
        {
           // FactoryService service = new FactoryService();
           // List = service.GetAllFactory();
            dgv_Factory.DataSource = List;
            dgv_Factory.ClearSelection();
        }
    }
}
