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
    public partial class frmBOMList : FinalProject1_winform.Basic3
    {
        List<ItemVO> list;
        public frmBOMList()
        {
            InitializeComponent();
        }

        private void frmBOM_Load(object sender, EventArgs e)
        {
            #region dgv_Item 셋팅
            CommonUtil.SetInitGridView(dgv_Item);
            CommonUtil.AddGridTextColumn(dgv_Item, "품목번호", "Item_ID", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_Item, "품목유형", "Item_Category", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_Item, "품목코드", "Item_Code", DataGridViewContentAlignment.MiddleCenter, colWidth: 150);
            CommonUtil.AddGridTextColumn(dgv_Item, "품목명", "Item_Name", DataGridViewContentAlignment.MiddleCenter, colWidth: 150);
            CommonUtil.AddGridTextColumn(dgv_Item, "단위수량", "Item_UnitQTY", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_Item, "측정방식", "Item_CheckType", DataGridViewContentAlignment.MiddleCenter, colWidth: 85, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Item, "발주방식", "Item_OrderType", DataGridViewContentAlignment.MiddleCenter, colWidth: 85, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Item, "안전재고량", "Item_SafetyQTY", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_Item, "입고창고", "Item_InHouse", DataGridViewContentAlignment.MiddleCenter, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Item, "출고창고", "Item_OutHouse", DataGridViewContentAlignment.MiddleCenter, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Item, "바코드", "Item_Barcode", DataGridViewContentAlignment.MiddleCenter, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Item, "사용여부", "Item_YN", DataGridViewContentAlignment.MiddleCenter, colWidth: 85, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_Item, "비고", "Item_Content", visibility:false);
            #endregion
            LoadData();

            // 정전개 바인딩
            CommonUtil.SetInitGridView(dgv_Forward);
            CommonUtil.AddGridTextColumn(dgv_Forward, "level", "level", DataGridViewContentAlignment.MiddleCenter, colWidth: 50);
            CommonUtil.AddGridTextColumn(dgv_Forward, "INFO", "INFO", colWidth: 200);
            CommonUtil.AddGridTextColumn(dgv_Forward, "자품목ID", "BOM_JaItemID", DataGridViewContentAlignment.MiddleCenter, colWidth: 80);
            CommonUtil.AddGridTextColumn(dgv_Forward, "소요량", "BOM_UseQTY", DataGridViewContentAlignment.MiddleCenter, colWidth: 70);
            CommonUtil.AddGridTextColumn(dgv_Forward, "모품목ID", "BOM_MoItemID", DataGridViewContentAlignment.MiddleCenter, colWidth: 80,visibility:false);
            //CommonUtil.AddGridTextColumn(dgv_Forward, "소요계획여부", "BOM_DemandYN", colWidth: 80);
            //CommonUtil.AddGridTextColumn(dgv_Forward, "사용여부", "BOM_YN", colWidth: 80);
            //CommonUtil.AddGridTextColumn(dgv_Forward, "비고", "BOM_Content", colWidth: 80);

            // 역전개 바인딩
            CommonUtil.SetInitGridView(dgv_Reverse);
            CommonUtil.AddGridTextColumn(dgv_Reverse, "level", "level", colWidth: 50);
            CommonUtil.AddGridTextColumn(dgv_Reverse, "모품목명", "Item_Name", colWidth: 200);
            CommonUtil.AddGridTextColumn(dgv_Reverse, "모품목ID", "BOM_MoItemID", colWidth: 90);
            CommonUtil.AddGridTextColumn(dgv_Reverse, "소요량", "BOM_UseQTY", colWidth: 70);
            CommonUtil.AddGridTextColumn(dgv_Reverse, "자품목ID", "BOM_JaItemID", colWidth: 90);
            //CommonUtil.AddGridTextColumn(dgv_Reverse, "소요계획여부", "BOM_DemandYN", colWidth: 80);
            //CommonUtil.AddGridTextColumn(dgv_Reverse, "사용여부", "BOM_YN", colWidth: 80);
            //CommonUtil.AddGridTextColumn(dgv_Reverse, "비고", "BOM_Content", colWidth: 80);
        }

        public void LoadData()
        {
            ItemService service = new ItemService();
            list = service.GetAllItem();
            dgv_Item.DataSource = list;
        }

        private void dgv_Item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int itemID = Convert.ToInt32(dgv_Item.SelectedRows[0].Cells[0].Value);

            BOMService service1 = new BOMService();
            dgv_Forward.DataSource = null;
            dgv_Forward.DataSource = service1.BOMForward(itemID);

            BOMService service2 = new BOMService();
            dgv_Reverse.DataSource = null;
            dgv_Reverse.DataSource = service2.BOMReverse(itemID);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // 유효성 체크 (원자재는 BOM 등록할 수 없음)
            string Category = dgv_Item.SelectedRows[0].Cells[1].Value.ToString();

            if (Category == "원자재")
            {
                MessageBox.Show("원자재는 등록할 수 없습니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               
            int ItemID = Convert.ToInt32(dgv_Item.SelectedRows[0].Cells[0].Value);

            frmBOMInsert frm = new frmBOMInsert(ItemID, Category);
            frm.ShowDialog();
        }

        // 부분 조회 패널
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string itemCategory = cbo_ItemCategory.Text;
            string itemName = txt_ItemName.Text;
            string itemYN = cbo_YN.Text;

            ItemService service = new ItemService();
            list = service.GetPartialItem(itemCategory, itemName, itemYN);
            dgv_Item.DataSource = list;

            // 입력후 컨트롤 초기화
            cbo_ItemCategory.Text = txt_ItemName.Text = cbo_YN.Text = null;
        }
    }
}
