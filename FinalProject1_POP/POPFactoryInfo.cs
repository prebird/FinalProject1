using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_POP
{
    public partial class POPFactoryInfo : Form
    {
        POPWorkOrderVO Order;

        public POPFactoryInfo(POPWorkOrderVO order)
        {
            InitializeComponent();
            Order = order;
        }

        private void POPFactoryInfo_Load(object sender, EventArgs e)
        {
            if (Order == null)
                return;
            List<taskItem> tasks = (List<taskItem>)ConfigurationManager.GetSection("taskList");
            
            ucMachine1.Task_ID = tasks[0].taskID;
            ucMachine1.Task_IP = tasks[0].hostIP;
            ucMachine1.Task_Port = tasks[0].hostPort;
            ucMachine1.Task_Remark = tasks[0].remark;

            ucMachine1.IsTaskEnable = false;

            ucMachine1.ItemCode = Order.Item_code;
            ucMachine1.Worknum = Order.WorkOrderID;
            ucMachine1.OrderQty = Order.OrderQuantity;
            ucMachine1.MachineName = Order.EquipmentName;
            ucMachine1.ProcessName = Order.processName;
            ucMachine1.YN = "(가동준비)";
            
        }
    }
}
