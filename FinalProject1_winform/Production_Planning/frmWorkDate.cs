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
    public partial class frmWorkDate : Form
    {
        public string WorkDate { get; set; }
        public string user_id { get; set; }
        public int OrderQuantity { get; set; }

        public frmWorkDate()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cboUser.SelectedIndex == 0)
            {
                MessageBox.Show("유저를 먼저 선택해주세요");
                return;
            }

            //if(dtpDate.Text == DateTime.Today.ToString("yyyy-MM-dd"))
            //{
            //    MessageBox.Show("작업 지시 날짜는 오늘로 할 수 없습니다.");
            //    return;
            //}

            WorkDate = dtpDate.Value.ToString("yyyy-MM-dd");
            user_id = cboUser.SelectedValue.ToString();
            OrderQuantity = Convert.ToInt32(textBox_gudi1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmWorkDate_Load(object sender, EventArgs e)
        {
            ProductionPlanService service = new ProductionPlanService();
            UserInfoVO item = new UserInfoVO();
            item.user_id = "";
            item.user_name = "선택";
            List<UserInfoVO> list = service.GetAllUser();
            list.Insert(0, item);

            CommonUtil.ComboBinding<UserInfoVO>(cboUser, list, "user_name", "user_id");
        }

        private void textBox_gudi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
