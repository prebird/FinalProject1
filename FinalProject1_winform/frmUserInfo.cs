using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_VO;
using FinalProject1_DAC;
using System.Configuration;

namespace FinalProject1_winform
{
    public partial class frmUserInfo : Form
    {
        List<UserInfoVO> users;

        public frmUserInfo()
        {
            InitializeComponent();


            CommonUtil.ComboBindingCommonCode(cbo_searchDepart, "Dept_type");
            CommonUtil.ComboBindingCommonCode(cbo_searchUserCategory, "User_type");

            // dgv 바인딩
            CommonUtil.SetInitGridView(dgvUser);
            CommonUtil.AddGridTextColumn(dgvUser, "아이디", "user_id", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvUser, "비밀번호", "user_pwd", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvUser, "이름", "user_name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvUser, "분류", "depart_name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvUser, "부서명", "category_name", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvUser, "이메일", "user_email", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvUser, "사진", "user_pic", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvUser, "권한ID", "authID", colWidth: 90);

            // 권한

        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            SearchUserInfo();
        }

        private void SearchUserInfo()
        {
            UserInfoDAC dac = new UserInfoDAC();
            users = dac.SearchUserInfo(cbo_searchDepart.SelectedValue.ToString(), cbo_searchUserCategory.SelectedValue.ToString(), txtSearchName.Text);
            dgvUser.DataSource = users;
            dgvUser.ClearSelection();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchUserInfo();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
            {
                return;
            }
            string userid = dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            UserInfoVO thisUser = users.Find((x) => x.user_id.Equals(userid));
            txtUserId.Text = thisUser.user_id;
            txtPwd.Text = thisUser.user_pwd;
            txtName.Text = thisUser.user_name;
            txtCategory.Text = thisUser.category_name;
            txtDepart.Text = thisUser.depart_name;
            txtEmail.Text = thisUser.user_email;
            if (thisUser.user_pic != null)
            {
                Pic1.ImageLocation = ConfigurationManager.AppSettings["apiurl"] + "Uploads/" + thisUser.user_pic; 
            }



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUserJoin frm = new frmUserJoin();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                // 로드
                SearchUserInfo();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userid = dgvUser.SelectedRows[0].Cells[0].Value.ToString();
            UserInfoVO thisUser = users.Find((x) => x.user_id.Equals(userid));
            frmUserJoin frm = new frmUserJoin(thisUser);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //로드
                SearchUserInfo();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
