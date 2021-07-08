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

            
        }
    }
}
