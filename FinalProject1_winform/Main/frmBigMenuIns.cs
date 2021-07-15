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
        }

        private void frmMainMgtInsert_Load(object sender, EventArgs e)
        {
            // 유저정보

            //날짜
            dtpDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSearchPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dlg.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 유효성체크
            if(!CommonUtil.CheckNullOrEmptyOk(txtMenuName, "메뉴이름")) return ;

            // VO에 담기
            MenuVO menu = new MenuVO();
            menu.MenuName = txtMenuName.Text;
            // 웹이 등록하야하나?
            if (pictureBox1.ImageLocation != null)
            {
                menu.menu_Img = pictureBox1.ImageLocation;
            }
            menu.menu_uadmin = txtUserName.Text;
            menu.menu_udate = dtpDate.Text;

            if (btnSave.Text == "등록")
            {
                // insert
                MenuService service = new MenuService();
                if (service.insertBigMenu(menu))
                {
                    MessageBox.Show("성공적으로 등록되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("다시 시도해 주세요.");
                } 
            }
            else if (btnSave.Text == "수정")
            {
                // update
                MenuService service = new MenuService();
                if (service.updateBigMenu(menu))
                {
                    MessageBox.Show("성공적으로 등록되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("다시 시도해 주세요.");
                }
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
