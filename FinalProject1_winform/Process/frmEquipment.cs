using FinalProject1_VO;
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
        string INS_EMP = null;
        public frmEquipment(UserInfoVO user)
        {
            InitializeComponent();
            INS_EMP = user.user_name;
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            //수정자 정보 바인딩
            txtINS_EMP.Text = INS_EMP;

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



            //수정일시 설비 데이터 바인딩
            if (this.Owner is frmEquipmentList frm)
            {
                EquipmentVO equipment = frm.Equipment;
                cboProcessCode.Text = equipment.ProcessName;
                cboEquipmentGroupCode.Text = equipment.EquipmentGroupName;
                txtCode.Text = equipment.EquipmentCode.Split('-').Last();
                txtName.Text = equipment.EquipmentName;
                cboInputLocation.Text = equipment.FromLocationID;
                cboOutputLocation.Text = equipment.ToLocationID;
                if (equipment.IsActive == "Y")
                    cboIsUse.SelectedIndex = 1;
                else if (equipment.IsActive == "N")
                    cboIsUse.SelectedIndex = 2;
                txtSpecific.Text = equipment.Status;
            }

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
            equipment.ProcessCode = cboProcessCode.SelectedValue.ToString();
            equipment.EquipmentGroupCode = cboEquipmentGroupCode.SelectedValue.ToString();
            equipment.EquipmentCode = $"{cboProcessCode.SelectedValue}-{cboEquipmentGroupCode.SelectedValue}-{txtCode.Text}";
            equipment.EquipmentName = txtName.Text;
            equipment.Status = txtSpecific.Text;
            equipment.INS_EMP = txtINS_EMP.Text;
            equipment.FromLocationID = cboInputLocation.SelectedValue.ToString();
            equipment.ToLocationID = cboOutputLocation.SelectedValue.ToString();
            if(cboIsUse.SelectedIndex == 0 || cboIsUse.SelectedIndex == 1)
            {
                equipment.IsActive = "Y";
            }
            else if(cboIsUse.SelectedIndex == 2)
            {
                equipment.IsActive = "N";
            }

            processEquipmentService service = new processEquipmentService();
            bool result = service.SaveEquipment(equipment);

            if(result)
            {
                MessageBox.Show("성공적으로 저장되었습니다.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("저장 실패");
                return;
            }
        }
    }
}
