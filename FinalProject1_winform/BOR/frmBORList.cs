using FinalProject1_VO;
using FinalProject1_winform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmBORList : FinalProject1_winform.Basic3
    {
        List<BORVO> bors = new List<BORVO>();
        BORVO bor = new BORVO();
        public UserInfoVO user { get; set; }
        public BORVO BOR { get { return bor; } }

        public frmBORList()
        {
            InitializeComponent();
        }

        private void frmBORList_Load(object sender, EventArgs e)
        {
            processEquipmentService service1 = new processEquipmentService();
            List<ProcessVO> processes = service1.GetAllProcess();
            ProcessVO item = new ProcessVO();
            item.ProcessCode = "";
            item.ProcessName = "선택";
            processes.Insert(0, item);
            CommonUtil.ComboBinding<ProcessVO>(cboProcess, processes, "ProcessName", "ProcessCode");

           

            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "번호", "BORID", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 60);
            CommonUtil.AddGridTextColumn(dgvList, "품목명", "Item_Name");
            CommonUtil.AddGridTextColumn(dgvList, "공정명", "ProcessName");
            CommonUtil.AddGridTextColumn(dgvList, "설비명", "EquipmentName");
            CommonUtil.AddGridTextColumn(dgvList, "설비 코드", "EquipmentCode", colWidth: 120);
            CommonUtil.AddGridTextColumn(dgvList, "Tact-Time", "Tact_Time", align: DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgvList, "우선순위", "Priority", align: DataGridViewContentAlignment.MiddleRight, colWidth: 80);
            CommonUtil.AddGridTextColumn(dgvList, "사용", "IsUse", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 60);
            CommonUtil.AddGridTextColumn(dgvList, "수정자", "INS_EMP");
            CommonUtil.AddGridTextColumn(dgvList, "수정 일시", "INS_DATE", colWidth: 120);
            CommonUtil.AddGridTextColumn(dgvList, "특이 사항", "Remark", colWidth: 150);

            if(this.MdiParent is frmMain frm)
            {
                user = frm.User;
            }

            LoadData();
        }

        private void LoadData()
        {
            BorService service = new BorService();
            bors = service.GetAllBOR();
            dgvList.DataSource = new BindingList<BORVO>(bors);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cboProcess.SelectedIndex == 0 && string.IsNullOrWhiteSpace(txtEquipment.Text) && string.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("검색조건을 먼저 입력해주세요.");
                return;
            }

            string processCode = null;
            string equipmentName = null;
            string itemName = null;

            if (cboProcess.SelectedIndex != 0)
            {
                processCode = cboProcess.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtEquipment.Text))
            {
                equipmentName = txtEquipment.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtItem.Text))
            {
                itemName = txtItem.Text;
            }

            var list = (from item in bors
                        where (processCode != null ? processCode.Contains(item.ProcessName) : true) &&
                        (equipmentName != null ? equipmentName.Contains(item.EquipmentName) : true) &&
                        (itemName != null ? itemName.Contains(item.Item_Name) : true)
                        select item
                        ).ToList();

            dgvList.DataSource = null;
            dgvList.DataSource = new BindingList<BORVO>(list);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmBORInsert frm = new frmBORInsert(user);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bor.EquipmentCode))
            {
                MessageBox.Show("항목을 먼저 선택해 주세요");
                return;
            }

            bor.BORID = 0;
            frmBORInsert frm = new frmBORInsert(user);
            frm.Owner = this;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(bor.EquipmentCode))
            {
                MessageBox.Show("항목을 먼저 선택해 주세요");
                return;
            }

            frmBORInsert frm = new frmBORInsert(user);
            frm.Owner = this;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bor.BORID = Convert.ToInt32(dgvList["BORID", e.RowIndex].Value);
            bor.Item_Name = dgvList["Item_Name", e.RowIndex].Value.ToString();
            bor.ProcessName = dgvList["ProcessName", e.RowIndex].Value.ToString();
            bor.EquipmentName = dgvList["EquipmentName", e.RowIndex].Value.ToString();
            bor.EquipmentCode = dgvList["EquipmentCode", e.RowIndex].Value.ToString();
            bor.Tact_Time = Convert.ToInt32(dgvList["Tact_Time", e.RowIndex].Value);
            bor.Priority = Convert.ToInt32(dgvList["Priority", e.RowIndex].Value);
            bor.IsUse = dgvList["IsUse", e.RowIndex].Value.ToString();
            bor.INS_EMP = dgvList["INS_EMP", e.RowIndex].Value.ToString();
            bor.INS_DATE = dgvList["INS_DATE", e.RowIndex].Value.ToString();
            bor.Remark = dgvList["Remark", e.RowIndex].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bor.EquipmentCode))
            {
                MessageBox.Show("항목을 먼저 선택해 주세요");
                return;
            }

            BorService service = new BorService();
            bool result = service.DeleteBOR(bor.BORID);
            if(result)
            {
                MessageBox.Show("삭제가 성공적으로 이루어졌습니다.");
            }
            else
            {
                MessageBox.Show("삭제 실패");
            }
        }
    }
}
