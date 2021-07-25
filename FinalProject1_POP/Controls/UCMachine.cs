using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform.Controls
{
    public partial class UCMachine : UserControl
    {

        //public string Task_ID { get { return lblMachineName.Text; } set { lblMachineName.Text = value; } }
        //public string Task_IP { get { return lblIP.Text; } set { lblIP.Text = value; } }
        //public string Task_Port { get { return lblPort.Text; } set { lblPort.Text = value; } }
        //public string Task_Remark { get { return lblRemark.Text; } set { lblRemark.Text = value; } }

        int process_id = 0;

        public UCMachine()
        {
            InitializeComponent();
        }
    }
}
