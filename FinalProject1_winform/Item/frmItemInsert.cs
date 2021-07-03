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
    public partial class frmItemInsert : Form
    {
        ItemVO itemList;
        public frmItemInsert()
        {
            InitializeComponent();
        }

        public frmItemInsert(ItemVO item)
        {
            InitializeComponent();
            itemList = item;
            
            lbl_Title.Text = "품목 정보 수정";
            btn_InsUp.Text = "수정";

            txt_Code.Text = item.Item_Code;
            txt_Name.Text = item.Item_Name;
            cbo_Category.Text = item.Item_Category;
            txt_UnitQTY.Text = item.Item_UnitQTY.ToString();
            cbo_CheckType.Text = item.Item_CheckType;
            cbo_OrderType.Text =item.Item_OrderType;
            txt_SafetyQTY.Text = item.Item_SafetyQTY.ToString();
            cbo_InHouse.Text = item.Item_InHouse;
            cbo_OutHouse.Text = item.Item_OutHouse;
            txt_BarCode.Text = item.Item_Barcode;
            cbo_YN.Text = item.Item_YN;
            txt_Content.Text =item.Item_Content;
        }

        private void btn_InsUp_Click(object sender, EventArgs e)
        {
            // 유효성 체크 추가

            if (MessageBox.Show(btn_InsUp.Text + "하시겠습니까", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int itemID = (itemList != null) ? itemList.Item_ID : 0;

                ItemVO item = new ItemVO()
                {
                    Item_Code = txt_Code.Text,
                    Item_Name = txt_Name.Text,
                    Item_Category = cbo_Category.Text,
                    Item_UnitQTY = Convert.ToInt32(txt_UnitQTY.Text),
                    Item_CheckType = cbo_CheckType.Text,
                    Item_OrderType = cbo_OrderType.Text,
                    Item_SafetyQTY = Convert.ToInt32(txt_SafetyQTY.Text),
                    Item_InHouse = cbo_InHouse.Text,
                    Item_OutHouse = cbo_OutHouse.Text,
                    Item_Barcode = txt_BarCode.Text,
                    Item_YN = cbo_YN.Text,
                    Item_Content = txt_Content.Text,
                };

                ItemService service = new ItemService();
                bool result = service.InsertUpdateItem(itemList);

                if (result)
                    MessageBox.Show("정보가 입력 되었습니다.");
                else
                    MessageBox.Show("처리중 오류가 발생 했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
