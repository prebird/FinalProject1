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
            BorService service = new BorService();
            processEquipmentService service1 = new processEquipmentService();
            List<ProcessVO> processes = service1.GetAllProcess();
            ProcessVO item = new ProcessVO();
            item.ProcessCode = "";
            item.ProcessName = "선택";
            processes.Insert(0, item);
            CommonUtil.ComboBinding<ProcessVO>(cboProcess, processes, "ProcessName", "ProcessCode");

            
            bors = service.GetAllBOR();

            CommonUtil.SetInitGridView(dgvList);
            CommonUtil.AddGridTextColumn(dgvList, "번호", "BORID", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 60);
            CommonUtil.AddGridTextColumn(dgvList, "공정명", "Item_Name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvList, "설비군명", "ProcessName");
            CommonUtil.AddGridTextColumn(dgvList, "설비코드", "EquipmentName", colWidth: 120);
            CommonUtil.AddGridTextColumn(dgvList, "설비명", "EquipmentCode");
            CommonUtil.AddGridTextColumn(dgvList, "특이 사항", "Tact_Time", colWidth: 150);
            CommonUtil.AddGridTextColumn(dgvList, "소진 창고", "Priority");
            CommonUtil.AddGridTextColumn(dgvList, "양품 창고", "IsUse");
            CommonUtil.AddGridTextColumn(dgvList, "사용", "INS_EMP", colWidth: 60);
            CommonUtil.AddGridTextColumn(dgvList, "수정자", "INS_DATE");
            CommonUtil.AddGridTextColumn(dgvList, "수정 일시", "Remark", colWidth: 120);
        }
    }
}
