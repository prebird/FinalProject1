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
    public partial class frmItem : FinalProject1_winform.Basic3
    {
        List<ItemVO> list;
        public frmItem()
        {
            InitializeComponent();
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgv_Item);
            CommonUtil.AddGridTextColumn(dgv_Item, "품목번호", "Item_ID", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_Item, "품목유형", "Item_Category", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_Item, "품목코드", "Item_Code", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_Item, "품목명", "Item_Name", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_Item, "단위수량", "Item_UnitQTY", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_Item, "측정방식", "Item_CheckType", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_Item, "발주방식", "Item_OrderType", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_Item, "안전재고량", "Item_SafetyQTY", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_Item, "입고창고", "Item_InHouse", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_Item, "출고창고", "Item_OutHouse", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_Item, "이미지", "Item_img", DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
            CommonUtil.AddGridTextColumn(dgv_Item, "사용여부", "Item_YN", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_Item, "비고", "Item_Content");

            LoadData();
        }


        public void LoadData()
        {
            ItemService service = new ItemService();
            list = service.GetAllItem();
            dgv_Item.DataSource = list;
        }

        public void ResetCtrl()
        {
            cbo_ItemCategory.Text = cbo_YN.Text = txt_ItemName.Text = null;
        }

        private void 입력초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetCtrl();
        }

        // 등록
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            frmItemInsert frm = new frmItemInsert();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        // 수정
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dgv_Item.SelectedRows.Count < 1)
            {
                MessageBox.Show("수정할 행을 선택해 주십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int itemID = Convert.ToInt32(dgv_Item.SelectedRows[0].Cells[0].Value);
            ItemVO item = list.Find((elem) => elem.Item_ID == itemID);

            frmItemInsert frm = new frmItemInsert(item);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        // 삭제
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Item.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 행을 선택해 주십시오.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int itemID = Convert.ToInt32(dgv_Item.SelectedRows[0].Cells[0].Value);

            if (MessageBox.Show("삭제 하시겠습니까", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ItemService service = new ItemService();
                bool result = service.Deleteitem(itemID);

                if (result)
                {
                    MessageBox.Show("삭제 되었습니다.");
                    LoadData();
                }
                else
                    MessageBox.Show("처리중 오류가 발생했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel Files(*.xls)|*.xls|Excel Files(*.xlsx)|*.xlsx";
            dlg.Title = "엑셀파일로 내보내기";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bool result = ExcelUtil.ExportExcelToList<ItemVO>(list, dlg.FileName, "deleted");

                if (result)
                {
                    MessageBox.Show("엑셀 다운로드 완료");
                }

            }
        }

        private void btn_Barcode_Click(object sender, EventArgs e)
        {
            frmBarcode frm = new frmBarcode();
            frm.ShowDialog();

        }
    }
}
