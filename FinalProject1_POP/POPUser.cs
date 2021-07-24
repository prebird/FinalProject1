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
    public partial class POPUser : Form
    {
        POPVO User;
        public POPUser(POPVO user)
        {
            InitializeComponent();
            User = user;
        }

        private void POPUser_Load(object sender, EventArgs e)
        {
            lblUserId.Text = User.user_id;
            lblUserName.Text = User.user_name;
            lblUserBirthDay.Text = User.user_birthday;
            lblUserEmail.Text = User.user_email;
            lblComment.Text = $"{User.user_name}님 환영합니다.";
            lblUserDept.Text = User.user_depart_id;
            pictureBoxUser.ImageLocation = ConfigurationManager.AppSettings["apiurl"] + "Uploads/" + User.user_pic;

            CommonUtil.SetInitGridView(dgv_workList);

            CommonUtil.AddGridTextColumn(dgv_workList, "작업지시번호", "WorkOrderID", DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
            CommonUtil.AddGridTextColumn(dgv_workList, "품목", "Item_Code", DataGridViewContentAlignment.MiddleCenter, colWidth: 130);
            CommonUtil.AddGridTextColumn(dgv_workList, "계획수량", "OrderQuantity", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_workList, "작업지시상태", "Status", DataGridViewContentAlignment.MiddleCenter, colWidth: 120);

            LoadData();
        }

        private void LoadData()
        {
            POPService service = new POPService();
            List<POPUserVO> WList = service.GetUserWork(User.user_id, DateTime.Now.ToString("yyyy-MM-dd"));
            dgv_workList.DataSource = WList;
            dgv_workList.ClearSelection();
        }
    }
}
