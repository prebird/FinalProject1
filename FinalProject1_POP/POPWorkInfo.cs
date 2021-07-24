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
        public POPWorkInfo(POPVO user)
        {
            InitializeComponent();
            User = user;
        }

        private void POPWorkInfo_Load(object sender, EventArgs e)
        {

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
            List<POPUserVO> WList = service.GetUserWork(User.user_id);
            dgv_WorkList.DataSource = WList;
            dgv_WorkList.ClearSelection();
            dgv_WorkList.Font = new Font("AppleSDGothicNeoB00", 18, FontStyle.Regular);
            dgv_WorkList.DefaultCellStyle.Font = new Font("AppleSDGothicNeoB00", 15, FontStyle.Regular);


        }
    }
}
