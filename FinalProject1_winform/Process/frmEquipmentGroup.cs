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

namespace FinalProject1_winform.Process
{
    public partial class frmEquipmentGroup : Form
    {
        public frmEquipmentGroup()
        {
            InitializeComponent();
        }

        private void frmEquipmentGroup_Load(object sender, EventArgs e)
        {
            txtINS_DATE.Text = DateTime.Now.ToString("yy/MM/dd-HH:mm:s");
            //수정자 데이터 바인딩

            //수정일 경우 정보 바인딩
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("필수 입력사항을 입력해주세요");
                return;
            }
            if (cboIsUse.SelectedIndex == 0)
            {
                MessageBox.Show("사용 유무를 선택해 주세요.");
                return;
            }

            EquipmentGroupVO equipmentGroup = new EquipmentGroupVO();
            equipmentGroup.EquipmentGroupCode = txtCode.Text;
            equipmentGroup.EquipmentGroupName = txtName.Text;
            equipmentGroup.INS_EMP = txtINS_EMP.Text;
            if (cboIsUse.SelectedIndex == 1)
            {
                equipmentGroup.IsActive = 'Y';
            }
            else if (cboIsUse.SelectedIndex == 2)
            {
                equipmentGroup.IsActive = 'N';
            }

            processEquipmentService service = new processEquipmentService();
            bool result = service.SaveEquipmentGroup(equipmentGroup);

            if (result)
            {
                MessageBox.Show("저장이 성공적으로 이루어졌습니다.");
                btnSave.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("저장 실패");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
