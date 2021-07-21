using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmBigMenuIns : Form
    {
        MenuVO throwedMenu;
        public frmBigMenuIns()
        {
            InitializeComponent();
            btnSave.Text = "등록";
        }

        public frmBigMenuIns(MenuVO throwedMenu)
        {
            InitializeComponent();
            this.throwedMenu = throwedMenu;
            btnSave.Text = "수정";
            txtMenuName.Text = throwedMenu.MenuName;
        }

        private void frmMainMgtInsert_Load(object sender, EventArgs e)
        {
            // 유저정보

            //날짜
            dtpDate.Text = DateTime.Now.ToShortDateString();


            if (btnSave.Text == "수정")
            {
                pictureBox1.ImageLocation = (throwedMenu.menu_Img == null)? null : ConfigurationManager.AppSettings["apiurl"] + "Uploads/" + throwedMenu.menu_Img; 
            }
        }

        private void btnSearchPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dlg.FileName;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // 유효성체크
            if(!CommonUtil.CheckNullOrEmptyOk(txtMenuName, "메뉴이름")) return ;

            // VO에 담기
            MenuVO menu = new MenuVO();
            menu.MenuName = txtMenuName.Text;
            
            menu.menu_uadmin = txtUserName.Text;
            menu.menu_udate = dtpDate.Text;


            // 이미지 있는경우
            string uploadFileName;
            string uploadfile = null;
            bool result = false; 

            if (pictureBox1.ImageLocation != null)
            {
                //이미지 이름
                // 파일 이름 string 만들기
                Random rnd = new Random();
                uploadFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(9999).ToString().PadLeft(4, '0');
                uploadfile = uploadFileName + new FileInfo(pictureBox1.ImageLocation).Extension;

                menu.menu_Img = uploadfile;

                // 이미지 업로드
                //파일업로드 API서비스를 호출
                CallService callservice = new CallService();
                result = await callservice.ServerUploadForDBInsert(pictureBox1.ImageLocation, uploadfile);
            }
            else
            {
                result = true;
            }


            if (btnSave.Text == "등록")
            {

                // insert
                MenuService service = new MenuService();
                if (result)
                {
                    if (service.insertBigMenu(menu))
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

                menu.MenuID = throwedMenu.MenuID;
                // update
                MenuService service = new MenuService();
                if (result)
                {
                    if (service.updateBigMenu(menu))
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
