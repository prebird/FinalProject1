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
using System.IO;
using System.Configuration;

namespace FinalProject1_winform
{
    
    public partial class frmUserJoin : Form
    {
        bool isVaildId = false;
        UserInfoVO user;

        public frmUserJoin()
        {
            InitializeComponent();
        }

        public frmUserJoin(UserInfoVO user)
        {
            InitializeComponent();

            this.user = user;
            btnSave.Text = "수정";

            
           

        }

        private void frmUserJoin_Load(object sender, EventArgs e)
        {
            // 바인딩
            CommonUtil.ComboBindingCommonCode(cboDept, "Dept_type");
            CommonUtil.ComboBindingCommonCode(cboCategory, "User_type");


            if (btnSave.Text == "수정")
            {
                // 중복체크 하지 않게
                isVaildId = true;
                // 바인딩
                txtID.Text = user.user_id;
                txtPwd.Text = user.user_pwd;
                txtEmail.Text = user.user_email;
                txtName.Text = user.user_name;
                cboCategory.SelectedIndex = cboCategory.FindString(user.category_name);
                cboDept.SelectedIndex = cboDept.FindString(user.depart_name);
                if (user.user_pic != null)
                {
                    pic.ImageLocation = ConfigurationManager.AppSettings["apiurl"] + "Uploads/" + user.user_pic;
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!txtID.CheckNullOrEmptyOk("아이디")) return;
            UserInfoDAC dac = new UserInfoDAC();
            if (dac.IsValidID(txtID.Text))
            {
                isVaildId = true;
                MessageBox.Show("사용할 수 있는 아이디 입니다.");
            }
            else
            {
                MessageBox.Show("중복된 아이디입니다. 다른 아이디를 입력해 주세요");
                isVaildId = false;
            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pic.ImageLocation = dlg.FileName;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // 유효성체크
            if (!txtID.CheckNullOrEmptyOk("아이디")) return;
            if (isVaildId == false)
            {
                MessageBox.Show("아이디 중복체크를 해주세요"); return;
            }
            if (!txtPwd.CheckNullOrEmptyOk("비밀번호")) return;
            if (!txtName.CheckNullOrEmptyOk("이름")) return;
            if (!CommonUtil.CheckCboValidateValue(cboCategory, "분류")) return;

            // VO
            UserInfoVO thisUser = new UserInfoVO();
            thisUser.user_id = txtID.Text;
            thisUser.user_pwd = txtPwd.Text;
            thisUser.user_name = txtName.Text;
            thisUser.user_Category = cboCategory.SelectedValue.ToString();
            thisUser.user_depart_id = cboDept.SelectedValue.ToString();
            thisUser.user_email = txtEmail.Text;

            // 이미지 있는경우
            string uploadFileName;
            string uploadfile = null;
            bool result = false;

            if (pic.ImageLocation != null)
            {
                //이미지 이름
                // 파일 이름 string 만들기
                Random rnd = new Random();
                uploadFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(9999).ToString().PadLeft(4, '0');
                uploadfile = uploadFileName + new FileInfo(pic.ImageLocation).Extension;

                thisUser.user_pic = uploadfile;

                // 이미지 업로드
                //파일업로드 API서비스를 호출
                CallService callservice = new CallService();
                result = await callservice.ServerUploadForDBInsert(pic.ImageLocation, uploadfile);
            }
            else
            {
                result = true;
            }

            if (btnSave.Text == "등록")
            {

                // insert
                UserInfoDAC dac = new UserInfoDAC();
                if (result)
                {
                    if (dac.InsertData(thisUser))
                    {
                        MessageBox.Show("성공적으로 등록되었습니다.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("DB 인서트 실패");
                    }
                }
                else
                {
                    MessageBox.Show("사진 업로드 실패");
                }
            }
            else if (btnSave.Text == "수정")
            {

                thisUser.user_id = user.user_id;
                // update
                UserInfoDAC dac = new UserInfoDAC();
                if (result)
                {
                    if (dac.UpdateData(thisUser))
                    {
                        MessageBox.Show("성공적으로 수정되었습니다.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("DB 인서트 실패");
                    }
                }
                else
                {
                    MessageBox.Show("사진 업로드 실패");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
