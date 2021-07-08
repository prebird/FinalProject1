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
            txt_Category.Text = Category;
            txt_ItemCode.Text = OneItem.Item_Code;
            txt_ItemName.Text = OneItem.Item_Name;
            txt_UnitQTY.Text = OneItem.Item_UnitQTY.ToString();
     
            #region 자품목 조회
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

            #region 자품목 내역
            CommonUtil.SetInitGridView(dgv_JaItemMine);
            CommonUtil.AddGridTextColumn(dgv_JaItemMine, "상위품목 번호", "BOM_MoItemID", DataGridViewContentAlignment.MiddleCenter, colWidth: 110);
            CommonUtil.AddGridTextColumn(dgv_JaItemMine, "자품목 번호", "BOM_JaItemID", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_JaItemMine, "품목유형", "Item_Category", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_JaItemMine, "품목명", "Item_Name", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_JaItemMine, "단위수량", "Item_UnitQTY", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            #endregion

            // 전체 목록도 전역 List에 추가.
            AllList = service.GetAllItem();

            SelectJaItem(dgv_JaItemAll, Category); // 자품목 전체

            SelectMyJaItem(itemID); // 이 모품목에 있는 자품목만
        }

        // '완제품'이라면 반제품과 원자재, '반제품'이라면 원자재만 자품목으로 조회할 수 있음.
        private void SelectJaItem(DataGridView dgv, string category)
        {
            if (category == "완제품")
            {
                var ItemList = (from item in AllList
                                where item.Item_Category == "반제품"
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
        // 선택한 모품의 기존에 등록된 자품목 조회
        private void SelectMyJaItem(int itemID)
        {
            BOMService service = new BOMService();
            List<BomVO> bom = service.SearchJaItem(itemID);
            dgv_JaItemMine.DataSource = bom;
        }

        //BOM 등록
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // 유효성 체크


            if (MessageBox.Show("등록 하시겠습니까?", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BomVO bom = new BomVO()
                {
                    BOM_MoItemID = Convert.ToInt32(lblItemID.Text),
                    BOM_JaItemID = Convert.ToInt32(dgv_JaItemAll.SelectedRows[0].Cells[0].Value),
                    BOM_UseQTY = Convert.ToInt32(txt_UseQTY.Text),
                    BOM_YN = cbo_YN.Text,
                    BOM_DemandYN = cbo_DemandYN.Text,
                    BOM_Content = txt_Content.Text
                };

                BOMService service = new BOMService();
                bool result = service.InsertBOM(bom);

                if (result)
                {
                    MessageBox.Show("정보가 입력 되었습니다.");
                    SelectMyJaItem(Convert.ToInt32(lblItemID.Text));
                }
                else
                    MessageBox.Show("처리중 오류가 발생 했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // 등록 후 입력 내용 초기화
            txt_UseQTY.Text = cbo_YN.Text = cbo_DemandYN.Text = txt_Content.Text = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv_JaItemMine.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 행을 선택해 주십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int JaID = Convert.ToInt32(dgv_JaItemMine.SelectedRows[0].Cells[1].Value);

            if (MessageBox.Show("삭제 하시겠습니까", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                BOMService service = new BOMService();
                bool result = service.DeleteJaItem(JaID);

                if (result)
                {
                    MessageBox.Show("삭제 되었습니다.");
                    SelectMyJaItem(Convert.ToInt32(lblItemID.Text));
                }
                else
                    MessageBox.Show("처리중 오류가 발생했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        // 선택 초기화
        private void frmBOMInsert_Shown(object sender, EventArgs e)
        {
            dgv_JaItemAll.ClearSelection();
            dgv_JaItemMine.ClearSelection();
        }
    }
}
