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

namespace FinalProject1_winform
{
    public partial class frmEquipment : Form
    {
        public frmEquipment()
        {
            InitializeComponent();
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            //수정 일시 설비 데이터 바인딩


            //수정자 정보 바인딩


            txtINS_DATE.Text = DateTime.Now.ToString("yy/MM/dd-HH:mm:s");
            processEquipmentService service = new processEquipmentService();
            List<ProcessVO> processList = processList = service.GetAllProcess();
            ProcessVO item = new ProcessVO();
            item.ProcessCode = "";
            item.ProcessName = "선택";
            processList.Insert(0, item);
            CommonUtil.ComboBinding<ProcessVO>(cboProcessCode, processList, "ProcessName", "ProcessCode");

            List<EquipmentGroupVO> equipmentGrouplist = equipmentGrouplist = service.GetAllEquipmentGroup();
            EquipmentGroupVO groupVO = new EquipmentGroupVO();
            groupVO.EquipmentGroupCode = "";
            groupVO.EquipmentGroupName = "선택";
            equipmentGrouplist.Insert(0, groupVO);
            CommonUtil.ComboBinding<EquipmentGroupVO>(cboEquipmentGroupCode, equipmentGrouplist, "EquipmentGroupName", "EquipmentGroupCode");

            //창고 바인딩



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboProcessCode.SelectedIndex == 0 || cboEquipmentGroupCode.SelectedIndex == 0)
            {
                MessageBox.Show("공정과 설비군을 선택해 주세요.");
                return;
            }

            if (cboInputLocation.SelectedIndex == 0 || cboOutputLocation.SelectedIndex == 0)
            {
                MessageBox.Show("소진/양품 창고를 선택해주세요.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("설비 코드/명을 선택해주세요.");
                return;
            }

            EquipmentVO equipment = new EquipmentVO();
            

            processEquipmentService service = new processEquipmentService();
            
        }
    }
}
