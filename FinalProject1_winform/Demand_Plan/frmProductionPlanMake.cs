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


            if (MessageBox.Show("생성 하시겠습니까?", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProductionPlanVO ppVO = new ProductionPlanVO()
                {
                    //생산 계획 Insert
                    PlanID = txtPlanID.Text,
                    Status = "계획 생성",
                    INS_EMP = txtINS_EMP.Text,

                    //생산 계획 Detail Insert
                    BORID = borID,
                    PlanDate = Convert.ToDateTime(dtpMakeDate.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text)
                };

                DemandPlanService service2 = new DemandPlanService();
                bool result = service2.ProductionPlanTrans(ppVO);

                if (result)
                {
                    MessageBox.Show("생성 되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("처리중 오류가 발생했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
