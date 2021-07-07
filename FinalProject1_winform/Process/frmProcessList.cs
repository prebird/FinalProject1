using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public partial class frmProcessList : FinalProject1_winform.Basic3
    {
        List<ProcessVO> processes;
        ProcessVO process = new ProcessVO();
        public ProcessVO Process { get { return process; } }

        public frmProcessList()
        {
            InitializeComponent();
        }

        private void frmProcessList_Load(object sender, EventArgs e)
        {
            processEquipmentService service = new processEquipmentService();
            List<ProcessVO> processList = processList = service.GetAllProcess();
            ProcessVO item = new ProcessVO();
            item.ProcessCode = "";
            item.ProcessName = "선택";
            processList.Insert(0, item);
            CommonUtil.ComboBinding<ProcessVO>(cboProcess, processList, "ProcessName", "ProcessCode");

            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "공정코드", "ProcessCode", align: DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgvList, "공정명", "ProcessName");
            CommonUtil.AddGridTextColumn(dgvList, "사용", "IsActive");
            CommonUtil.AddGridTextColumn(dgvList, "수정자", "INS_EMP");
            CommonUtil.AddGridTextColumn(dgvList, "수정 일시", "INS_DATE", colWidth: 125);

            LoadData();
        }

        private void LoadData()
        {
            processEquipmentService service = new processEquipmentService();
            processes = service.GetAllProcessInfo();
            dgvList.DataSource = null;
            dgvList.DataSource = new BindingList<ProcessVO>(processes);
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            process.ProcessCode = dgvList["ProcessCode", e.RowIndex].Value.ToString();
            process.ProcessName = dgvList["ProcessName", e.RowIndex].Value.ToString();
            process.IsActive = dgvList["IsActive", e.RowIndex].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var list = (from item in processes
                        where item.ProcessName == cboProcess.Text
                        select item
                        ).ToList();

            dgvList.DataSource = null;
            dgvList.DataSource = new BindingList<ProcessVO>(list);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmProcess frm = new frmProcess();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(process.ProcessCode))
            {
                MessageBox.Show("공정을 먼저 선택해 주세요");
                return;
            }

            frmProcess frm = new frmProcess();
            frm.Owner = this;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(process.ProcessCode))
            {
                MessageBox.Show("설비를 먼저 선택해 주세요");
                return;
            }

            processEquipmentService service = new processEquipmentService();
            bool result = service.DeleteProcess(process.ProcessCode);
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
