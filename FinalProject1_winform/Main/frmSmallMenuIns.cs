using FinalProject1_DAC;
using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmSmallMenuIns : Form
    {
        MenuVO throwedMenu;
        int BigMenuID;
        public frmSmallMenuIns(int throwedBigMenuID)
        {
            InitializeComponent();
            btnSave.Text = "등록";
            this.BigMenuID = throwedBigMenuID;
        }

        public frmSmallMenuIns(MenuVO throwedMenu, int throwedBigMenuID)
        {
            InitializeComponent();
            this.throwedMenu = throwedMenu;
            btnSave.Text = "수정";
            this.BigMenuID = throwedBigMenuID;
        }

        private void frmSmallMenuIns_Load(object sender, EventArgs e)
        {
            // 유저정보

            // DGV
            CommonUtil.SetInitGridView(dgvBig);
            CommonUtil.AddGridTextColumn(dgvBig, "메뉴아이디", "MenuID", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvBig, "상위메뉴명", "MenuName", colWidth: 180);

            //날짜
            dtpDate.Text = DateTime.Now.ToShortDateString();

            // DGV
            CommonDAC DAC = new CommonDAC();
            List<MenuVO> menu = DAC.GetAllMenuMgt().FindAll((x) => x.MenuLevel == 0);
            dgvBig.DataSource = menu;
            int idx = menu.FindIndex((x) => x.MenuID == BigMenuID);
            // 넘어온 상위id로 바인딩하기
            dgvBig.CurrentCell = dgvBig.Rows[idx].Cells[0];
            

            // CBO
            //Form을 상속받은 모든폼들 가져오기
            List<string> formList = new List<string>();
            Type formType = typeof(Form);
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (formType.IsAssignableFrom(type))
                {
                    formList.Add(type.Name);
                }
            }
            formList.Insert(0, "선택");
            cboForm.DataSource = formList;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 유효성체크
            if (CommonUtil.CheckNullOrEmptyOk(txtMenuName, "메뉴이름") == false) return;
            if (CommonUtil.CheckCboValidateValue(cboForm, "메뉴 클릭시 열릴 폼") == false) return;
            if (dgvBig.SelectedRows.Count < 1)
            {
                MessageBox.Show("상위메뉴를 선택해 주세요");
                return;
            }

            // VO
            MenuVO menu = new MenuVO();
            menu.MenuName = txtMenuName.Text;
            menu.refMenuID = Convert.ToInt32(dgvBig.SelectedRows[0].Cells[0].Value);
            menu.ProgramName = cboForm.Text;
            menu.menu_uadmin = txtUserName.Text;
            menu.menu_udate = dtpDate.Text;

            if (btnSave.Text == "등록")
            {
                // insert
                MenuService service = new MenuService();
                if (service.insertSmallMenu(menu))
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
                if (service.updateSmallMenu(menu))
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

        private void dgvBig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
