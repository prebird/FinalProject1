using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject1_winform
{
    public partial class frmMainMgt : FinalProject1_winform.Basic3
    {
        List<MenuVO> menus = new List<MenuVO>();
        public frmMainMgt()
        {
            InitializeComponent();

            // 상위메뉴DGV설정
            CommonUtil.SetInitGridView(dgvUpMenu);
            CommonUtil.AddGridTextColumn(dgvUpMenu, "메뉴ID", "MenuID", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvUpMenu, "메뉴명", "MenuName", colWidth:150);
            CommonUtil.AddGridTextColumn(dgvUpMenu, "수정자", "user_name", colWidth:100);
            CommonUtil.AddGridTextColumn(dgvUpMenu, "수정일", "menu_udate", colWidth:100);


            // 하위메뉴DGV설정
            CommonUtil.SetInitGridView(dgvDownMenu);
            CommonUtil.AddGridTextColumn(dgvDownMenu, "메뉴ID", "MenuID", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvDownMenu, "메뉴명", "MenuName", colWidth: 150);
            CommonUtil.AddGridTextColumn(dgvDownMenu, "폼이름", "ProgramName", colWidth: 200);
            CommonUtil.AddGridTextColumn(dgvDownMenu, "부모ID", "refMenuID", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgvDownMenu, "수정자", "user_name", colWidth: 100);
            CommonUtil.AddGridTextColumn(dgvDownMenu, "수정일", "menu_udate", colWidth: 100);

        }

        private void frmMainMgt_Load(object sender, EventArgs e)
        {
            CommonService service = new CommonService();
            menus = service.GetAllMenuMgt();

            UpMenuLoad();
        }

        

        private void dgvUpMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int parentID = Convert.ToInt32(dgvUpMenu.SelectedRows[0].Cells[0].Value);
            DownMenuLoad(parentID);

        }

        #region ButtonEvent
        //상위
        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmBigMenuIns frm = new frmBigMenuIns();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 폼 다시 로드 -> 
            }
        }

        private void btnBigUps_Click(object sender, EventArgs e)
        {
            // 클릭된 거 VO로만들기
            MenuVO throwMenu = menus.Find((x) => x.MenuID == Convert.ToInt32(dgvUpMenu.SelectedRows[0].Cells[0].Value));

            frmBigMenuIns frm = new frmBigMenuIns(throwMenu);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 폼 다시 로드 -> 
            }
        }

        private void btnBigDelete_Click(object sender, EventArgs e)
        {
            // 진짜 삭제하시겠습니까? 하위 메뉴까지 삭제됩니다.
        }

        // 하위

        private void btnSmallInsert_Click(object sender, EventArgs e)
        {
            frmSmallMenuIns frm = new frmSmallMenuIns(Convert.ToInt32(dgvUpMenu.SelectedRows[0].Cells[0].Value));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 폼 다시 로드 -> 
            }
        }

        private void btnSmallUps_Click(object sender, EventArgs e)
        {
            if (dgvDownMenu.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 메뉴를 선택해 주세요");
                return;
            }
            // 클릭된 거 VO로만들기
            MenuVO throwMenu = menus.Find((x) => x.MenuID == Convert.ToInt32(dgvDownMenu.SelectedRows[0].Cells[0].Value));

            frmSmallMenuIns frm = new frmSmallMenuIns(throwMenu, Convert.ToInt32(dgvUpMenu.SelectedRows[0].Cells[0].Value));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // 폼 다시 로드 -> 
            }
        }

        private void btnSmallDelete_Click(object sender, EventArgs e)
        {
            // 진짜 삭제하시겠습니까?
        }
        #endregion


        #region Method
        private void UpMenuLoad()
        {
            dgvUpMenu.DataSource = menus.FindAll((x) => x.MenuLevel == 0);
            dgvUpMenu.ClearSelection();
        }

        private void DownMenuLoad(int parentID)
        {
            dgvDownMenu.DataSource = menus.FindAll((x) => x.MenuLevel == 1 && x.refMenuID == parentID);
            dgvDownMenu.ClearSelection();
        }
        #endregion

        
    }
}
