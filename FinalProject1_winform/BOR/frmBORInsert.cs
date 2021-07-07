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
    public partial class frmBORInsert : Form
    {
        public frmBORInsert()
        {
            InitializeComponent();
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
        }

        private void txtTactTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
