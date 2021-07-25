using FinalProject1_VO;
using FinalProject1_winform.Service;
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
        public frmProductionPlanMake(string planID, int itemID, string itemName)
        {
            //PlanID와 아이템명, 아이템ID 수요계획화면에서 가져와 바인딩
            //아이템ID는 텍스트박스의 태그로 저장해놓는게 좋아보임

            InitializeComponent();
            txtPlanID.Text = planID;
            txtItemName.Text = itemName;
            txtItemName.Tag = itemID;
        }

        private void frmProductionPlanMake_Load(object sender, EventArgs e)
        {
            //아이템명과 ID를 바탕으로 공정명, 설비명 콤보바인딩(BOR 테이블에 있는것만)
            int itemID = (int)txtItemName.Tag;
            ProductionPlanService service = new ProductionPlanService();
            List<BORVO> list = service.GetBORInfo(itemID);

            List<ProcessVO> processes = new List<ProcessVO>();
            List<EquipmentVO> equipments = new List<EquipmentVO>();

            foreach (var item in list)
            {
                ProcessVO process = new ProcessVO();
                EquipmentVO equipment = new EquipmentVO();
                process.ProcessID = item.ProcessID;
                process.ProcessName = item.ProcessName;
                processes.Add(process);

                equipment.EquipmentID = item.EquipmentID;
                equipment.EquipmentName = item.EquipmentName;
                equipments.Add(equipment);
                txtPriorDate.Text = item.PriorDate.ToString();
            }

            CommonUtil.ComboBinding<ProcessVO>(cboProcess, processes, "ProcessName", "ProcessID");
            CommonUtil.ComboBinding<EquipmentVO>(cboEquipment, equipments, "EquipmentName", "EquipmentID");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //BORID 불러오기
            BorService service = new BorService();
            BORVO bor = service.GetSpecialBOR(cboProcess.Text, cboEquipment.Text, txtItemName.Text);
            int borID = bor.BORID;


        }
    }
}
