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
    public partial class frmBORInsert : Form
    {
        BORVO ownerBOR = new BORVO();
        string INS_EMP = null;
        public frmBORInsert(UserInfoVO user)
        {
            InitializeComponent();
            INS_EMP = user.user_name;
        }

        private void frmBORInsert_Load(object sender, EventArgs e)
        {
            ItemService service = new ItemService();
            List<ItemVO> items = service.GetAllItem();
            ItemVO item = new ItemVO();
            item.Item_Code = "";
            item.Item_Name = "선택";
            items.Insert(0, item);
            CommonUtil.ComboBinding<ItemVO>(cboItem, items, "Item_Name", "Item_Code");

            processEquipmentService equipmentService = new processEquipmentService();
            List<ProcessVO> processes = equipmentService.GetAllProcess();
            ProcessVO process = new ProcessVO();
            process.ProcessCode = "";
            process.ProcessName = "선택";
            processes.Insert(0, process);
            CommonUtil.ComboBinding<ProcessVO>(cboProcess, processes, "ProcessName", "ProcessCode");

            //수정일 경우 바인딩
            if(this.Owner is frmBORList frm)
            {
                ownerBOR = frm.BOR;
                cboProcess.Text = ownerBOR.ProcessName;
                cboItem.Text = ownerBOR.Item_Name;
                cboEquipment.Text = ownerBOR.EquipmentName;
                txtTactTime.Text = ownerBOR.Tact_Time.ToString();
                txtPriority.Text = ownerBOR.Priority.ToString();
                if(ownerBOR.IsUse == "Y")
                {
                    cboIsUse.SelectedIndex = 1;
                }
                else if(ownerBOR.IsUse == "N")
                {
                    cboIsUse.SelectedIndex = 2;
                }
                txtStatus.Text = ownerBOR.Remark;
            }


            //수정자 정보
        }

        private void txtTactTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cboProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProcess.SelectedIndex != 0)
            {
                processEquipmentService service = new processEquipmentService();
                List<EquipmentVO> equipments = service.GetSpecficEquipment(cboProcess.SelectedValue.ToString());
                EquipmentVO item = new EquipmentVO();
                item.EquipmentCode = "";
                item.EquipmentName = "선택";
                equipments.Insert(0, item);
                CommonUtil.ComboBinding<EquipmentVO>(cboEquipment, equipments, "EquipmentName", "EquipmentCode");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cboProcess.SelectedIndex == 0 || cboEquipment.SelectedIndex == 0 || cboItem.SelectedIndex == 0)
            {
                MessageBox.Show("설비와 품목명을 선택해주세요");
                return;
            }
            if(string.IsNullOrWhiteSpace(txtTactTime.Text))
            {
                MessageBox.Show("Tact Time을 입력해주세요");
                return;
            }

            BORVO bor = new BORVO();
            bor.BORID = ownerBOR.BORID;
            bor.ItemCode = cboItem.SelectedValue.ToString();
            bor.Item_Name = cboItem.Text;
            bor.ProcessCode = cboProcess.SelectedValue.ToString();
            bor.EquipmentCode = cboEquipment.SelectedValue.ToString();
            bor.Tact_Time = Convert.ToInt32(txtTactTime.Text);
            bor.Priority = Convert.ToInt32(txtPriority.Text);
            if(cboIsUse.SelectedIndex == 0 || cboIsUse.SelectedIndex == 1)
            {
                bor.IsUse = "Y";
            }
            else if(cboIsUse.SelectedIndex == 2)
            {
                bor.IsUse = "N";
            }
            bor.INS_EMP = INS_EMP;
            bor.Remark = txtStatus.Text;

            BorService service = new BorService();
            bool result = service.SaveBOR(bor);
            if(result)
            {
                MessageBox.Show("성공적으로 저장했습니다.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("저장 실패");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
