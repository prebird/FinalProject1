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
    public partial class frmBOMInsert : Form
    {
        List<ItemVO> AllList;

        public frmBOMInsert(int itemID, string Category) // Category는 자품목 등록 조회시 사용.
        {
            InitializeComponent();
            lblItemID.Text = itemID.ToString();

            // BomList에서 받아온 번호로 해당 아이템 조회 후 컨트롤에 정보 바인딩
            ItemService service = new ItemService();
            ItemVO OneItem = service.GetOneItem(itemID);
            Txt_Category.Text = Category;
            Txt_ItemCode.Text = OneItem.Item_Code;
            Txt_ItemName.Text = OneItem.Item_Name;
            Txt_UnitQTY.Text = OneItem.Item_UnitQTY.ToString();
     
            #region 자품목 그리드뷰 셋팅
            CommonUtil.SetInitGridView(dgv_JaItemAll);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "품목번호", "Item_ID", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "품목유형", "Item_Category", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "품목코드", "Item_Code", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "품목명", "Item_Name", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "단위수량", "Item_UnitQTY", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "측정방식", "Item_CheckType", DataGridViewContentAlignment.MiddleCenter, colWidth: 85, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "발주방식", "Item_OrderType", DataGridViewContentAlignment.MiddleCenter, colWidth: 85, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "안전재고량", "Item_SafetyQTY", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "입고창고", "Item_InHouse", DataGridViewContentAlignment.MiddleCenter, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "출고창고", "Item_OutHouse", DataGridViewContentAlignment.MiddleCenter, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "바코드", "Item_Barcode", DataGridViewContentAlignment.MiddleCenter, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "사용여부", "Item_YN", DataGridViewContentAlignment.MiddleCenter, colWidth: 85, visibility: false);
            CommonUtil.AddGridTextColumn(dgv_JaItemAll, "비고", "Item_Content", visibility: false);
            #endregion

            // 전체 목록도 전역 List에 추가.
            AllList = service.GetAllItem();
            SelectJaItem(dgv_JaItemAll, Category);
        }

        // '완제품'이라면 반제품과 원자재, '반제품'이라면 원자재만 자품목으로 조회할 수 있음.
        private void SelectJaItem(DataGridView dgv, string category)
        {
            if (category == "완제품")
            {
                var ItemList = (from item in AllList
                                where item.Item_Category == "반제품" || item.Item_Category == "원자재"
                                select item).ToList();
                dgv_JaItemAll.DataSource = ItemList;
            }
            else // 반제품
            {
                var ItemList = (from item in AllList
                                where item.Item_Category == "원자재"
                                select item).ToList();
                dgv_JaItemAll.DataSource = ItemList;
            }
        }
    }
}
