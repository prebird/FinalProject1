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
        }

        private void DrawDynamicMenu()
        {

        }
    }
}
