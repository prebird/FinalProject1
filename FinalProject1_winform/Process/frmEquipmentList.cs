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
    public partial class frmEquipmentList : Basic3
    {
        List<EquipmentVO> equipments;
        List<ProcessVO> processes;
        List<EquipmentGroupVO> equipmentGroups;
        EquipmentVO equipment = new EquipmentVO();

        public frmEquipmentList()
        {
            InitializeComponent();
        }

        private void frmEquipmentList_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "번호", "EquipmentID", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 60);
            CommonUtil.AddGridTextColumn(dgvList, "공정명", "ProcessName", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvList, "설비군명", "EquipmentGroupName");
            CommonUtil.AddGridTextColumn(dgvList, "설비코드", "EquipmentCode", colWidth: 120);
            CommonUtil.AddGridTextColumn(dgvList, "설비명", "EquipmentName");
            CommonUtil.AddGridTextColumn(dgvList, "특이 사항", "Status", colWidth: 150);
            CommonUtil.AddGridTextColumn(dgvList, "소진 창고", "FromLocationID");
            CommonUtil.AddGridTextColumn(dgvList, "양품 창고", "ToLocationID");
            CommonUtil.AddGridTextColumn(dgvList, "사용", "IsActive", colWidth: 60);
            CommonUtil.AddGridTextColumn(dgvList, "수정자", "INS_EMP");
            CommonUtil.AddGridTextColumn(dgvList, "수정 일시", "INS_DATE", colWidth: 120);
            CommonUtil.AddGridTextColumn(dgvList, "", "ProcessCode", visibility: false);
            CommonUtil.AddGridTextColumn(dgvList, "", "EquipmentGroupCode", visibility: false);



            processEquipmentService service = new processEquipmentService();
            equipments = service.GetAllEquipment();
            processes = service.GetAllProcess();
            equipmentGroups = service.GetAllEquipmentGroup();
            dgvList.DataSource = new BindingList<EquipmentVO>(equipments);

            ProcessVO process = new ProcessVO();
            process.ProcessCode = "";
            process.ProcessName = "선택";
            EquipmentGroupVO equipmentGroup = new EquipmentGroupVO();
            equipmentGroup.EquipmentGroupCode = "";
            equipmentGroup.EquipmentGroupName = "선택";

            equipmentGroups.Insert(0, equipmentGroup);
            processes.Insert(0, process);

            CommonUtil.ComboBinding<ProcessVO>(cboProcess, processes, "ProcessName", "ProcessCode");
            CommonUtil.ComboBinding<EquipmentGroupVO>(cboEquipmentGroup, equipmentGroups, "EquipmentGroupName", "EquipmentGroupCode");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtEquipmnetName.Text) && cboEquipmentGroup.SelectedIndex == 0 && cboProcess.SelectedIndex == 0)
            {
                MessageBox.Show("검색 조건을 입력해주세요");
                return;
            }

            string processCode = null;
            string equipmentGroupCode = null;
            string equipmentName = null;
            
            if(cboProcess.SelectedIndex != 0)
            {
                processCode = cboProcess.Text;
            }
            if(cboEquipmentGroup.SelectedIndex != 0)
            {
                equipmentGroupCode = cboEquipmentGroup.Text;
            }
            if(!string.IsNullOrWhiteSpace(txtEquipmnetName.Text))
            {
                equipmentName = txtEquipmnetName.Text;
            }

            var list = (from item in equipments
                        where (processCode != null ? processCode.Contains(item.ProcessName) : true) &&
                        (equipmentGroupCode != null ? equipmentGroupCode.Contains(item.EquipmentGroupName) : true) &&
                        (equipmentName != null ? equipmentName.Contains(item.EquipmentName) : true)
                        select item
                        ).ToList();

            dgvList.DataSource = null;
            dgvList.DataSource = new BindingList<EquipmentVO>(list);
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            equipment.ProcessCode = dgvList["ProcessCode", e.RowIndex].Value.ToString();
            equipment.EquipmentGroupCode = dgvList["EquipmentGroupCode", e.RowIndex].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmEquipment frm = new frmEquipment();
            frm.ShowDialog();
        }
    }
}
