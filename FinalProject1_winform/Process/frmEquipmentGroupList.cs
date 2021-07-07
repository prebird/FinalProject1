using FinalProject1_VO;
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
    public partial class frmEquipmentGroupList : FinalProject1_winform.Basic3
    {
        List<EquipmentGroupVO> equipmentGroups;
        EquipmentGroupVO equipmentGroup = new EquipmentGroupVO();
        public EquipmentGroupVO EquipmentGroup { get { return equipmentGroup; } }
        public frmEquipmentGroupList()
        {
            InitializeComponent();
        }

        private void frmEquipmentGroupList_Load(object sender, EventArgs e)
        {
            processEquipmentService service = new processEquipmentService();
            List<EquipmentGroupVO> list = service.GetAllEquipmentGroup();
            EquipmentGroupVO item = new EquipmentGroupVO();
            item.EquipmentGroupCode = "";
            item.EquipmentGroupName = "선택";
            list.Insert(0, item);

            CommonUtil.ComboBinding<EquipmentGroupVO>(cboEquipmentGroup, list, "EquipmentGroupName", "EquipmentGroupCode");

            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "설비군 코드", "EquipmentGroupCode", align: DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvList, "설비군명", "EquipmentGroupName");
            CommonUtil.AddGridTextColumn(dgvList, "사용", "IsActive", align: DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvList, "수정자", "INS_EMP");
            CommonUtil.AddGridTextColumn(dgvList, "수정 일시", "INS_DATE", colWidth: 120);
            LoadData();
        }

        private void LoadData()
        {
            processEquipmentService service = new processEquipmentService();
            equipmentGroups = service.GetEquipmentGroupInfo();
            dgvList.DataSource = null;
            dgvList.DataSource = new BindingList<EquipmentGroupVO>(equipmentGroups);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var list = (from item in equipmentGroups
                        where item.EquipmentGroupName == cboEquipmentGroup.Text
                        select item
                       ).ToList();

            dgvList.DataSource = null;
            dgvList.DataSource = new BindingList<EquipmentGroupVO>(list);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmEquipmentGroup frm = new frmEquipmentGroup();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(equipmentGroup.EquipmentGroupCode))
            {
                MessageBox.Show("설비군을 먼저 선택해 주세요");
                return;
            }

            frmEquipmentGroup frm = new frmEquipmentGroup();
            frm.Owner = this;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }

        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            equipmentGroup.EquipmentGroupCode = dgvList["EquipmentGroupCode", e.RowIndex].Value.ToString();
            equipmentGroup.EquipmentGroupName = dgvList["EquipmentGroupName", e.RowIndex].Value.ToString();
            equipmentGroup.IsActive = dgvList["IsActive", e.RowIndex].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(equipmentGroup.EquipmentGroupCode))
            {
                MessageBox.Show("설비군을 먼저 선택해 주세요");
                return;
            }

            processEquipmentService service = new processEquipmentService();
            bool result = service.DeleteEquipmentGroup(equipmentGroup.EquipmentGroupCode);
            if (result)
            {
                MessageBox.Show("성공적으로 삭제되었습니다.");
                LoadData();
                return;
            }
            else
            {
                MessageBox.Show("삭제 실패");
                return;
            }
        }
    }
}
