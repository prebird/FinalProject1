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

namespace FinalProject1_POP
{
    public partial class POPWorkInfo : Form
    {
        POPVO User;
        List<POPItemVO> Item;
        List<POPProcessVO> Process;
        POPWorkOrderVO Order;
        public POPWorkInfo(POPVO user)
        {
            InitializeComponent();
            User = user;
        }

        private void POPWorkInfo_Load(object sender, EventArgs e)
        {
            dtpWorkDate.Value = DateTime.Now;

            POPService service = new POPService();
            Item = service.GetItemInfo();
            POPItemVO iBlank = new POPItemVO();
            iBlank.Item_ID = 0;
            iBlank.Item_Name = "전체";
            Item.Insert(0, iBlank);

            POPService service2 = new POPService();
            Process = service2.GetProcessInfo();
            POPProcessVO pBlank = new POPProcessVO();
            pBlank.ProcessID = 0;
            pBlank.ProcessName = "전체";
            Process.Insert(0, pBlank);
           
            CommonUtil.ComboBinding<POPItemVO>(cboItem, Item, "Item_Name", "Item_id");
            CommonUtil.ComboBinding<POPProcessVO>(cboProcess, Process, "ProcessName", "ProcessID");


            CommonUtil.SetInitGridView(dgv_WorkList);
                  
            CommonUtil.AddGridTextColumn(dgv_WorkList, "작업지시번호", "WorkOrderID", DataGridViewContentAlignment.MiddleCenter, colWidth: 500);
            CommonUtil.AddGridTextColumn(dgv_WorkList, "품목", "Item_Code", DataGridViewContentAlignment.MiddleCenter, colWidth: 500);
            CommonUtil.AddGridTextColumn(dgv_WorkList, "계획수량", "OrderQuantity", DataGridViewContentAlignment.MiddleCenter, colWidth: 300);
            CommonUtil.AddGridTextColumn(dgv_WorkList, "작업지시상태", "Status", DataGridViewContentAlignment.MiddleCenter, colWidth: 350);

            LoadData();
        }

        private void LoadData()
        {
            POPService service = new POPService();
            List<POPUserVO> WList = service.GetUserWork(User.user_id, DateTime.Now.ToString("yyyy-MM-dd"));
            dgv_WorkList.DataSource = WList;
            dgv_WorkList.ClearSelection();
            dgv_WorkList.Font = new Font("AppleSDGothicNeoB00", 18, FontStyle.Regular);
            dgv_WorkList.DefaultCellStyle.Font = new Font("AppleSDGothicNeoB00", 15, FontStyle.Regular);


        }

        private void dgv_WorkList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string workorderid = dgv_WorkList.SelectedRows[0].Cells[0].Value.ToString();
            string workState = dgv_WorkList.SelectedRows[0].Cells[3].Value.ToString();
            POPService service = new POPService();
            if (workState == "작업계획")
            {
                List<POPWorkOrderVO> List = service.GetWorkOrder(workorderid);
                txtWorkid.Text = List[0].WorkOrderID;
                txtPlanid.Text = List[0].PlanID;
                txtItemCode.Text = List[0].Item_code;
                txtEName.Text = List[0].EquipmentName;
                txtStart.Text = "00:00"; //List[0].pd_stime;
                txtEnd.Text = "00:00"; //List[0].pd_etim;
                txtOrderQty.Text = List[0].OrderQuantity.ToString();
                Order = List[0];
                
            }
            else
            {
                List<POPWorkOrderVO> List = service.GetStartWork(workorderid);
                txtWorkid.Text = List[0].WorkOrderID;
                txtPlanid.Text = List[0].PlanID;
                txtItemCode.Text = List[0].Item_code;
                txtEName.Text = List[0].EquipmentName;
                txtStart.Text = List[0].pd_stime;
                txtEnd.Text = List[0].pd_etim;
                txtOrderQty.Text = List[0].OrderQuantity.ToString();
                txtWorkQty.Text = (List[0].ok_cnt + List[0].ng_cnt).ToString();
                txtOKQty.Text = List[0].ok_cnt.ToString();
                txtNGQTy.Text = List[0].ng_cnt.ToString();
                txtRemain.Text = (List[0].OrderQuantity - (List[0].ok_cnt + List[0].ng_cnt)).ToString();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            POPService service = new POPService();
            string searchDate = dtpWorkDate.Value.ToString("yyyy-MM-dd");
            List<POPUserVO> list = service.GetWOSearch(User.user_id, searchDate ,
                Convert.ToInt32(cboItem.SelectedValue), Convert.ToInt32(cboProcess.SelectedValue));
            dgv_WorkList.DataSource = list;
            dgv_WorkList.ClearSelection();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           if(txtWorkid.Text == "")
           {              
               MessageBox.Show("작업을 선택하여 주십시오.");
               return;
           }
           
           
           //1. POPFactoryInfo에 필드Order 넘기기
           //2. Main에 Order 넘기기


        }
    }
}
