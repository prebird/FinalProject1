﻿using log4net.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_POP
{
    public partial class POPPLCTASK : Form
    {

        TcpControl client;
        NetworkStream recvData;
        SqlConnection conn;

        string hostIP;
        int hostPort;
        int taskID;
        string pgmID;

        bool logVisible = false;
        string clientName;
        string clientIP;

        public bool bExit = false;

        LoggingUtility _logging;
        public LoggingUtility Log { get { return _logging; } }

        ThreadPLCTask m_thread;
        int timer_CONNECT = 1000;
        int timer_KEEP_ALIVE = 1000;
        int timer_READ_PLC = 1000;

       public POPPLCTASK(string taskid, string ip, string port)
       {
           InitializeComponent();
       
           hostIP = ip;
           hostPort = int.Parse(port);
           taskID = int.Parse(taskid.Replace("PLC_", ""));
           pgmID = taskid;
       
           _logging = new LoggingUtility(pgmID, Level.Debug, 30);
       
           timer_CONNECT = timer_Connect.Interval = int.Parse(ConfigurationManager.AppSettings["timer_Connect"]);
           timer_KEEP_ALIVE = int.Parse(ConfigurationManager.AppSettings["timer_KeepAlive"]);
           timer_READ_PLC = int.Parse(ConfigurationManager.AppSettings["timer_R_PLC"]);
       
           lblIP.Text = hostIP;
           lblPort.Text = hostPort.ToString();
           this.Text = lblTitle.Text = $"PLC_{taskID}";
       
           Assembly assembly = Assembly.GetExecutingAssembly();
           lblVersion.Text = File.GetLastWriteTime(assembly.Location).ToString("yyyy.MM.dd");
       
           clientName = Dns.GetHostName();
       
           IPAddress[] locals = Dns.GetHostAddresses(clientName);
           if (locals.Length > 0)
           {
               clientIP = locals[1].ToString();
           }
       }
        public POPPLCTASK()
        {
            InitializeComponent();
        }

        private void POPPLCTASK_Load(object sender, EventArgs e)
        {
            try
            {
                Log.WriteInfo("DB서버 연결");

                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
                conn.Open();

                m_thread = new ThreadPLCTask(conn, _logging, taskID, hostIP, hostPort, timer_CONNECT, timer_KEEP_ALIVE, timer_READ_PLC, clientName, clientIP);
                m_thread.ReadData += M_thread_ReadData;
                m_thread.ThreadStart();

                timer_Connect.Start();
            }
            catch (Exception err)
            {
                Log.WriteError("DB접속 실패:" + err.Message);
            }
        }

        /// <summary>
        /// 데이터를 수신받았을때 UI 컨트롤에 데이터 표현
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void M_thread_ReadData(object sender, ReadDataEventArgs args)
        {
            if (logVisible)
            {
                if (listBox1.Items.Count > 50)
                    listBox1.Items.Clear();

                this.Invoke((MethodInvoker)(() => listBox1.Items.Add($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {args.Data}")));
                this.Invoke((MethodInvoker)(() => listBox1.SelectedIndex = listBox1.Items.Count - 1));
            }

            this.Invoke((MethodInvoker)(() => txtReadPLC.Text = args.Data));
        }

        private void frmPLCTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                if (this.Height == 145)
                {
                    this.Height = 400;
                    logVisible = true;
                }
                else
                {
                    this.Height = 145;
                    logVisible = false;
                }
            }
        }

        /// <summary>
        /// 기계와의 연결상태에 따라서 UI 컨트롤에 표시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Connect_Tick(object sender, EventArgs e)
        {
            try
            {
                if (m_thread.Connection)
                {
                    lblState.BackColor = Color.Green;
                }
                else
                {
                    lblState.BackColor = Color.Red;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
            }
        }

        private void POPPLCTASK_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bExit)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void POPPLCTASK_FormClosed(object sender, FormClosedEventArgs e)
        {
            //로그 레퍼지토리 삭제
            Log.RemoveRepository(pgmID);

            //DB접속 종료
            conn.Close();

            //소켓 종료
            m_thread.ThreadStop();
        }
    }
}
