using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public partial class frmMain : Form
    {
        List<MenuVO> Menus;
        UserInfoVO user;
        bool bFlag = false;
        public UserInfoVO User 
        {
            get { return user; }
        
        }

        public frmMain(UserInfoVO user, Form loginform)
        {
            InitializeComponent();
            this.user = user;
            this.Tag = loginform;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CommonService service = new CommonService();
            Menus = service.GetAllMenu();
            DrawDynamicMenu();
            HideSideMenu();
            SetEvent();

            // 유저바인딩
            if (user.user_pic != null)
            {
                picUser.ImageLocation = ConfigurationManager.AppSettings["apiurl"] + "Uploads/" + user.user_pic;
            }
            else
            {
                picUser.ImageLocation = null;
            }

            lbluserName.Text = user.user_name + " 님";
            lbluserTitle.Text = "부서 : " + user.depart_name;

            // 노트
            

        }

        private void GetAuthByUserID()
        {

        }


        private void DrawDynamicMenu()
        {
            List<MenuVO> bigMenus = Menus.FindAll((x) => x.MenuLevel == 0);

            int startYpoint = 0;
            Panel prePanel = null;
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(40, 40);
            for (int i = 0; i < bigMenus.Count; i++)
            {
                Button btnBigMenu = new Button();
                btnBigMenu.Name = "btnBig" + bigMenus[i].MenuID.ToString();
                btnBigMenu.FlatAppearance.BorderSize = 1;
                btnBigMenu.Size = new Size(196, 55);
                btnBigMenu.Text = "  " + bigMenus[i].MenuName;
                btnBigMenu.Location = new Point(0, startYpoint);
                btnBigMenu.Font = new Font("AppleSDGothicNeoB00", 12);
                btnBigMenu.ForeColor = Color.Black;
                btnBigMenu.TextAlign = ContentAlignment.MiddleLeft;
                imageList.Images.Clear();

                if (bigMenus[i].menu_Img == null)
                {
                    imageList.Images.Add(Properties.Resources.gray_dot1);  // 이미지 동적으로 읽어올것
                }
                else
                {
                    //Image image = new Bitmap(ConfigurationManager.AppSettings["apiurl"] + "Uploads/" + bigMenus[i].menu_Img);
                    //Image image = System.Drawing.Image.FromFile(ConfigurationManager.AppSettings["apiurl"] + "Uploads/" + bigMenus[i].menu_Img);
                    System.Net.WebRequest request = System.Net.WebRequest.Create(ConfigurationManager.AppSettings["apiurl"] + "Uploads/" + bigMenus[i].menu_Img);
                    System.Net.WebResponse resp = request.GetResponse();
                    System.IO.Stream respStream = resp.GetResponseStream();
                    Bitmap bmp = new Bitmap(respStream);
                    respStream.Dispose();
                    imageList.Images.Add(bmp);  // 이미지 동적으로 읽어올것
                }

                btnBigMenu.Image = imageList.Images[0];
                btnBigMenu.ImageAlign = ContentAlignment.MiddleLeft;
                btnBigMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnBigMenu.BackColor = Color.White;
                btnBigMenu.FlatStyle = FlatStyle.Flat;
                btnBigMenu.Tag = prePanel;
                startYpoint += 55;
                pnlSideBar.Controls.Add(btnBigMenu);

                List<MenuVO> smallMenus = Menus.FindAll((x) => x.refMenuID == bigMenus[i].MenuID);
                Panel pnlSmallMenus = new Panel();
                pnlSmallMenus.Name = "pnl" + bigMenus[i].MenuID;
                pnlSmallMenus.Size = new Size(196, 55 * smallMenus.Count);
                pnlSmallMenus.Location = new Point(0, startYpoint);
                //pnlSmallMenus.Dock = DockStyle.Top;
                //startYpoint += 55 * smallMenus.Count;
                pnlSideBar.Controls.Add(pnlSmallMenus);

                prePanel = pnlSmallMenus;


                for (int j = 0; j < smallMenus.Count; j++)
                {
                    Button btnSmallMenu = new Button();
                    btnSmallMenu.Name = "btnSmall" + smallMenus[j].MenuID.ToString();
                    btnSmallMenu.FlatAppearance.BorderSize = 0;
                    btnSmallMenu.Size = new Size(196, 55);
                    btnSmallMenu.Text = "        "+ smallMenus[j].MenuName;
                    btnSmallMenu.Font = new Font("AppleSDGothicNeoB00", 12);
                    btnSmallMenu.ForeColor = Color.DimGray;
                    btnSmallMenu.BackColor = Color.White;
                    btnSmallMenu.FlatStyle = FlatStyle.Flat;
                    btnSmallMenu.TextAlign = ContentAlignment.MiddleLeft;
                    btnSmallMenu.Location = new Point(0, 55*j);
                    //btnSmallMenu.Image = Properties.Resources.gray_dot;
                    btnSmallMenu.ImageAlign = ContentAlignment.MiddleLeft;
                    btnSmallMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
                    btnSmallMenu.Tag = smallMenus[j].ProgramName;
                    pnlSmallMenus.Controls.Add(btnSmallMenu);

                }
            }
        }

        public void OpenCreateForm(string prgName)
        {
            //문자열로부터 클래스명을 얻고 싶을때 => Type
            string appName = Assembly.GetEntryAssembly().GetName().Name;
            Type frmType = Type.GetType($"{appName}.{prgName}");

            if (frmType == null)
            {
                MessageBox.Show("버튼에 등록된 폼을 찾을 수 없습니다. 메뉴관리 탭에서 수정해 주세요");
                return;
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == frmType)
                {
                    form.Activate();
                    form.BringToFront();
                    
                    return;
                }
            }

            Form frm = (Form)Activator.CreateInstance(frmType);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void HideSideMenu()
        {
            // 패널 숨기기
            foreach(Control ctrl in pnlSideBar.Controls)
            {
                if (ctrl is Button btn)
                {
                    if (btn.Tag != null)
                    {
                        btn.Location = ((Panel)btn.Tag).Location;
                    }
                }
                else if (ctrl is Panel pnl)
                {
                    pnl.Visible = false;
                }
            }
        }

        private void SetEvent()
        {
            foreach (Control ctrl in pnlSideBar.Controls)
            {
                if (ctrl is Button)
                {
                    ((Button)ctrl).MouseEnter += buttonColorChangeWhenMouseEnter;
                    ((Button)ctrl).MouseLeave += buttonColorChangeWhenMouseLeave;
                    ((Button)ctrl).Click += BigButtonClick;
                }

                if (ctrl is Panel)
                {
                    foreach (Control ctrl2 in ctrl.Controls)
                    {
                        ((Button)ctrl2).MouseEnter += buttonColorChangeWhenMouseEnter;
                        ((Button)ctrl2).MouseLeave += subButtonColorChangeWhenMouseLeave;
                        ((Button)ctrl2).Click += SmallButtonClick;
                    }
                }
            }
        }



        private void BigButtonClick(object sender, EventArgs e)
        {
            // 대메뉴 버튼 클릭시 패널 보이고 다른 버튼들 위치 수정
            Button thisButton = (Button)sender;
            // 버튼의 ID가 패널의 이름이 BigMenu 뒤의 ID에 해당하는 패널을 Visible = true하기
            int menuID = int.Parse(thisButton.Name.ToString().Replace("btnBig", ""));
            //int pnlIdx = 0;
            bool bFind = false;
            int pnlHeight = 0;

            // 대메뉴의 새끼 패널이 visible 인지
            bool childPanelVisible = false;
            foreach (Control ctrl in pnlSideBar.Controls)
            {
                if (ctrl is Panel && ctrl.Name == "pnl" + menuID )
                {
                    childPanelVisible = ctrl.Visible;
                }
            }

            if (!childPanelVisible)
            {
                foreach (Control ctrl in pnlSideBar.Controls)
                {

                    if (bFind) // 찾았으면 밑에 버튼들 위치 내리기
                    {
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + pnlHeight);
                    }
                    if (ctrl is Panel && ctrl.Name == "pnl" + menuID) //클릭된 버튼의 자식패널 찾기
                    {
                        ctrl.Visible = true;
                        childPanelVisible = true;
                        // 버튼 바로 밑에 위치시키기
                        ctrl.Location = new Point(0, thisButton.Location.Y + 55);
                        //pnlIdx = pnlSideBar.Controls.IndexOf(ctrl);
                        bFind = true;
                        pnlHeight = ctrl.Size.Height;
                    }
                } 
            }
            else
            {
                foreach (Control ctrl in pnlSideBar.Controls)
                {

                    if (bFind) // 찾았으면 밑에 버튼들 위치 내리기
                    {
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y - pnlHeight);
                    }
                    if (ctrl is Panel && ctrl.Name == "pnl" + menuID) //클릭된 버튼의 자식패널 찾기
                    {
                        ctrl.Visible = false;
                        childPanelVisible = false;

                        //pnlIdx = pnlSideBar.Controls.IndexOf(ctrl);
                        bFind = true;
                        pnlHeight = ctrl.Size.Height;
                    }
                }
            }
        }

        private void SmallButtonClick(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            if (thisButton.Tag == null)
            {
                MessageBox.Show("폼을 등록해 주세요");
                return;
            }
            OpenCreateForm(thisButton.Tag.ToString());
        }


        // method
        private void buttonColorChangeWhenMouseEnter(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;

            thisButton.ForeColor = Color.White;

        }

        private void buttonColorChangeWhenMouseLeave(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;

            thisButton.ForeColor = Color.Black;
        }

        private void subButtonColorChangeWhenMouseLeave(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;

            thisButton.ForeColor = Color.DimGray;
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                tabControl1.Visible = false;
            }
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;

                if (this.ActiveMdiChild.Tag == null)
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text + "   ");
                    tp.Parent = tabControl1;
                    tp.Tag = this.ActiveMdiChild;
                    tabControl1.SelectedTab = tp;

                    this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
                    this.ActiveMdiChild.Tag = tp;
                }
                else
                {
                    foreach(TabPage tp in tabControl1.TabPages)
                    {
                        if (tp.Tag == this.ActiveMdiChild)
                        {
                            tabControl1.SelectedTab = tp;
                            return;
                        }
                    }
                }

                if (!tabControl1.Visible)
                    tabControl1.Visible = true;
            }
        }
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((TabPage)((Form)sender).Tag).Dispose();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Tag != null)
            {
                Form frm = (Form)tabControl1.SelectedTab.Tag;
                frm.Select();
            }
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                var r = tabControl1.GetTabRect(i);
                var closeImage = Properties.Resources.close_grey;
                var closeRect = new Rectangle((r.Right - closeImage.Width), r.Top + (r.Height - closeImage.Height) / 2,
                    closeImage.Width, closeImage.Height);

                if (closeRect.Contains(e.Location))
                {
                    this.ActiveMdiChild.Close();
                    break;
                }
            }
        }

        private void label_gudi1_Click(object sender, EventArgs e)
        {
            // 로그아웃 버튼
            bFlag = true;
            this.Close();
            frmLogin frm = (frmLogin)this.Tag;
            frm.Show();

        }

        private void pictureBox_gudi2_Click(object sender, EventArgs e)
        {
            frmNotice frm = new frmNotice();
            frm.ShowDialog();
        }

        private void pictureBox_gudi3_Click(object sender, EventArgs e)
        {
            CommonService service = new CommonService();
            Menus = service.GetAllMenu();
            pnlSideBar.Controls.Clear();
            DrawDynamicMenu();
            HideSideMenu();
            SetEvent();
            this.Refresh();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(bFlag)
            {
                return;
            }
            Application.Exit();
        }
    }
}
