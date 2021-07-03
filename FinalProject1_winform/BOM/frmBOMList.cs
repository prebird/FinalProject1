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
            CommonUtil.AddGridTextColumn(dgv_Item, "바코드", "Item_Barcode", DataGridViewContentAlignment.MiddleCenter);
            CommonUtil.AddGridTextColumn(dgv_Item, "사용여부", "Item_Content", DataGridViewContentAlignment.MiddleCenter, colWidth: 85);
            CommonUtil.AddGridTextColumn(dgv_Item, "비고", "Item_ID");
        }

        public void LoadData()
        {
            ItemService service = new ItemService();
            list = service.GetAllItem();
            dgv_Item.DataSource = list;
        }



    }
}
