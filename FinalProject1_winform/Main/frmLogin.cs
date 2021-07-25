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

namespace FinalProject1_winform
{
    public partial class frmLogin : Form
    {
        public UserInfoVO User { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // 유효성체크
            if (!txtID.CheckNullOrEmptyOk("아이디")) return;
            if (!txtPwd.CheckNullOrEmptyOk("비밀번호")) return;

            // 아이디와 비밀번호가 맞으면 DB에서 UserVO를 가지고 온다.

            UserInfoDAC dac = new UserInfoDAC();
            if (dac.IsValidID(txtID.Text))
            {
                MessageBox.Show("없는 아이디 입니다."); return;
            }

            if (dac.IsUserValid(txtID.Text, txtPwd.Text) > 0)
            {
                User = dac.GetUserInfo(txtID.Text, txtPwd.Text);
            }
            else
            {
                MessageBox.Show("비밀번호가 맞지 않습니다."); return;
            }

            if (User != null)
            {
                frmMain frm = new frmMain(User, this);
                frm.Show();
                txtID.Text = txtPwd.Text = null;
                this.Hide();
            }
            else
            {
                MessageBox.Show("로그인을 해주세요");
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogIn.PerformClick();
            }
        }
    }
}
