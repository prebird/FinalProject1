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
            
        }

        private void btnBigUps_Click(object sender, EventArgs e)
        {

        }

        private void btnBigDelete_Click(object sender, EventArgs e)
        {

        }

        // 하위

        private void btnSmallInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnSmallUps_Click(object sender, EventArgs e)
        {

        }

        private void btnSmallDelete_Click(object sender, EventArgs e)
        {

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
