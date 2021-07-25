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


        public POPFactoryInfo()
        {
            InitializeComponent();
        }

        private void ucMachine1_Load(object sender, EventArgs e)
        {
            //List<taskItem> tasks = (List<taskItem>)ConfigurationManager.GetSection("taskList");

            
            //foreach (Control in panel2)
            //{      
            //    ucMachine1.Task_ID = tasks[i].taskID;
            //    ucMachine1.Task_IP = tasks[i].hostIP;
            //    ucMachine1.Task_Port = tasks[i].hostPort;
            //    ucMachine1.Task_Remark = tasks[i].remark;

            //    ucMachine1.IsTaskEnable = false;
            //}
        }
    }
}
