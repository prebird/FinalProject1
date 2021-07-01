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

namespace FinalProject1_winform
{
    public partial class frmMain : Form
    {
        List<MenuVO> Menus;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CommonService service = new CommonService();
            Menus = service.GetAllMenu();
            DrawDynamicMenu();
            HideSideMenu();
        }

        private void DrawDynamicMenu()
        {
            List<MenuVO> bigMenus = Menus.FindAll((x) => x.MenuLevel == 0);

            int startYpoint = 0;
            Panel prePanel = null;
            for (int i = 0; i < bigMenus.Count; i++)
            {
                Button btnBigMenu = new Button();
                btnBigMenu.Name = "btnBig" + bigMenus[i].MenuID.ToString();
                btnBigMenu.Size = new Size(196, 55);
                btnBigMenu.Text = "  " + bigMenus[i].MenuName;
                btnBigMenu.Location = new Point(0, startYpoint);
                btnBigMenu.Font = new Font("AppleSDGothicNeoB00", 12);
                btnBigMenu.ForeColor = Color.Black;
                btnBigMenu.TextAlign = ContentAlignment.MiddleLeft;
                btnBigMenu.BackColor = Color.White;
                btnBigMenu.FlatStyle = FlatStyle.Flat;
                btnBigMenu.Dock = DockStyle.Top;
                btnBigMenu.Tag = prePanel;
                startYpoint += 55;
                pnlSideBar.Controls.Add(btnBigMenu);

                List<MenuVO> smallMenus = Menus.FindAll((x) => x.refMenuID == bigMenus[i].MenuID);
                Panel pnlSmallMenus = new Panel();
                pnlSmallMenus.Name = "pnl" + bigMenus[i].MenuID;
                pnlSmallMenus.Size = new Size(196, 55 * smallMenus.Count);
                pnlSmallMenus.Location = new Point(0, startYpoint);
                //pnlSmallMenus.Dock = DockStyle.Top;
                startYpoint += 55 * smallMenus.Count;
                pnlSideBar.Controls.Add(pnlSmallMenus);

                prePanel = pnlSmallMenus;


                for (int j = 0; j < smallMenus.Count; j++)
                {
                    Button btnSmallMenu = new Button();
                    btnSmallMenu.Name = "btnSmall" + smallMenus[j].MenuID.ToString();
                    btnSmallMenu.Size = new Size(196, 55);
                    btnSmallMenu.Text = "      "+ smallMenus[j].MenuName;
                    btnSmallMenu.Font = new Font("AppleSDGothicNeoB00", 12);
                    btnSmallMenu.ForeColor = Color.DimGray;
                    btnSmallMenu.BackColor = Color.White;
                    btnSmallMenu.FlatStyle = FlatStyle.Flat;
                    btnSmallMenu.TextAlign = ContentAlignment.MiddleLeft;
                    btnSmallMenu.Location = new Point(0, 55*j);
                    btnSmallMenu.Dock = DockStyle.Top;
                    pnlSmallMenus.Controls.Add(btnSmallMenu);
                }
                
                
            }
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

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSideMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
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
    }
}
