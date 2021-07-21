using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform.Demand_Plan
{
    public partial class frmProductionPlanMake : Form
    {
        public frmProductionPlanMake()
        {
            InitializeComponent();
        }

        private void frmProductionPlanMake_Load(object sender, EventArgs e)
        {
            //PlanID와 아이템명, 아이템ID 수요계획화면에서 가져와 바인딩
            //아이템ID는 텍스트박스의 태그로 저장해놓는게 좋아보임


            //아이템명과 ID를 바탕으로 공정명, 설비명 바인딩

        }
    }
}
