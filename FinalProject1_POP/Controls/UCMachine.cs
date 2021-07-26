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
        public string Worknum { get { return txtWorkNum.Text; } set { txtWorkNum.Text = value; } }
        public string ItemCode { get { return txtItemCode.Text; } set { txtItemCode.Text = value; } }

        public string MachineName { get { return lblMachineName.Text; } set { lblMachineName.Text = value; } }
        public string ProcessName { get { return gbProcess.Text; } set { gbProcess.Text = value; } }
        public string YN { get { return lblYN.Text; } set { lblYN.Text = value; } }
        public int OrderQty { get { return Convert.ToInt32(txtOrderQty.Text); } set { txtOrderQty.Text = value.ToString(); } }
        public int WorkQty { get { return Convert.ToInt32(txtWorkQty.Text); } set { txtWorkQty.Text = value.ToString(); } }
        public int RemainQty { get { return Convert.ToInt32(txtRemainQty.Text); } set { txtRemainQty.Text = value.ToString(); } }
        public int OKQty { get { return Convert.ToInt32(txtOKQty.Text); } set { txtOKQty.Text = value.ToString(); } }
        public int NGQty { get { return Convert.ToInt32(txtNGQty.Text); } set { txtNGQty.Text = value.ToString(); } }



        int process_id = 0;

        int totQty = 0, totBadQty = 0;

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
            if (YN == "(작업완료)")
            {
                MessageBox.Show("완료된 작업입니다.");
                return;
            }
            string server = Application.StartupPath + "\\OutputTcpServer.exe";
            Process pro = Process.Start(server, $"{Task_ID} {Task_IP} {Task_Port}");
            process_id = pro.Id;
            YN = "(가동 중)";
            lblYN.ForeColor = Color.Lime;

            POP = new POPPLCTASK(Worknum ,Task_ID, Task_IP, Task_Port);
            POP.UCReadData += POP_UCReadData;
            POP.Show();
            POP.Hide();
            
            IsTaskEnable = true;
        }

        private void POP_UCReadData(object sender, ReadDataEventArgs args)
        {
            if (POP.InvokeRequired == true)
            {
                POP.Invoke((MethodInvoker)delegate
                {

                    string[] datas = args.Data.Split('|');
                    totQty += int.Parse(datas[1]);
                    totBadQty += int.Parse(datas[2]);

                    txtWorkQty.Text = totQty.ToString();
                    txtNGQty.Text = totBadQty.ToString();
                    txtOKQty.Text = (totQty - totBadQty).ToString();
                    txtNGQty.Text = totBadQty.ToString();
                    txtRemainQty.Text = (Convert.ToInt32(txtOrderQty.Text) - Convert.ToInt32(txtWorkQty.Text)).ToString();

                    if (Convert.ToInt32(txtOrderQty.Text) == Convert.ToInt32(txtWorkQty.Text))
                    {
                       
                        IsTaskEnable = false;
                        YN = "(작업완료)";
                        lblYN.ForeColor = Color.Blue;
                        POP.bExit = true;
                        //POP.Close();

                        foreach (Process process in Process.GetProcesses())
                        {
                            if (process.Id.Equals(process_id))
                            {
                                process.Kill();
                            }
                        }
                    }
                });
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            POP.bExit = true;
            POP.Close();
            IsTaskEnable = false;
            YN = "(중지)";
            lblYN.ForeColor = Color.Red;

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
