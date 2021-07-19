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
    public partial class POPLogin : Form
    {
        public POPLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //등록된 사원이 아닙니다.
            POPService service = new POPService();
            List<POPVO> userInfo = service.GetUserInfo(txtUserID.Text);

            if (userInfo.Count == 0)
            {
                MessageBox.Show("등록되지 않은 사원정보입니다. 확인 후 다시 인증하여주십시오.");
                return;
            }
            else
            {
                POPMain main = new POPMain(userInfo[0]);
                main.Show();
                this.Hide();
            }
            
        }
    }
}
