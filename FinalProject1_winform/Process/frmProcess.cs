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
    public partial class frmProcess : Form
    {
        public frmProcess()
        {
            InitializeComponent();
        }

        private void frmProcess_Load(object sender, EventArgs e)
        {
            txtIns_Date.Text = DateTime.Now.ToString("yy/MM/dd-HH:mm:s");
            //유저 정보 txt박스에 저장

            //수정일 경우 데이터 자동 바인딩
            if(this.Owner is frmProcessList frm)
            {
                ProcessVO process = frm.Process;
                txtCode.Text = process.ProcessCode;
                txtName.Text = process.ProcessName;
                if (process.IsActive == "Y")
                    cboIsUse.SelectedIndex = 1;
                else if (process.IsActive == "N")
                    cboIsUse.SelectedIndex = 2;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCode.Text)||string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("필수 입력사항을 입력해주세요");
                return;
            }
            if(cboIsUse.SelectedIndex == 0)
            {
                MessageBox.Show("사용 유무를 선택해 주세요.");
                return;
            }


            ProcessVO process = new ProcessVO();
            process.ProcessCode = txtCode.Text;
            process.ProcessName = txtName.Text;
            process.INS_EMP = txtIns_Emp.Text;
            if(cboIsUse.SelectedIndex == 1)
            {
                process.IsActive = "Y";
            }
            else if(cboIsUse.SelectedIndex == 2)
            {
                process.IsActive = "N";
            }

            processEquipmentService service = new processEquipmentService();
            bool result = service.InsertProcess(process);

            if(result)
            {
                MessageBox.Show("저장이 성공적으로 이루어졌습니다.");
                this.DialogResult = DialogResult.OK;
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
