using FinalProject1_VO;
using FinalProject1_winform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmBORList : FinalProject1_winform.Basic3
    {
        List<BORVO> bors = new List<BORVO>();

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

            BorService service = new BorService();
            bors = service.GetAllBOR();

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

            dgvList.DataSource = new BindingList<BORVO>(bors);
        }
    }
}
