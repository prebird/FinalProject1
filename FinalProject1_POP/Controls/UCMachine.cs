using FinalProject1_POP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FinalProject1_winform.Controls
{
 
    public partial class UCMachine : UserControl
    {
        POPPLCTASK POP;
        public string Task_ID { get { return lblTaskID.Text; } set { lblTaskID.Text = value; } }
        public string Task_IP { get { return lblIP.Text; } set { lblIP.Text = value; } }
        public string Task_Port { get { return lblPort.Text; } set { lblPort.Text = value; } }
        public string Task_Remark { get { return lblRemark.Text; } set { lblRemark.Text = value; } }

        int process_id = 0;

        public bool IsTaskEnable
        {
            get
            {
                return btnStop.Enabled;
            }
            set
            {
                if (value)
                {
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    
                }
                else
                {
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    
                }
            }
        }
        public UCMachine()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string server = Application.StartupPath + "\\OutputTcpServer.exe";
            Process pro = Process.Start(server, $"{Task_ID} {Task_IP} {Task_Port}");
            process_id = pro.Id;

            POP = new POPPLCTASK(Task_ID, Task_IP, Task_Port);
            POP.Show();
            POP.Hide();

            IsTaskEnable = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            POP.bExit = true;
            POP.Close();
            IsTaskEnable = false;

            foreach (Process process in Process.GetProcesses())
            {
                if (process.Id.Equals(process_id))
                {
                    process.Kill();
                }
            }
        }
    }
}
