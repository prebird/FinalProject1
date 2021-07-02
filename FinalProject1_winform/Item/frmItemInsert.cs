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
        public frmItemInsert()
        {
            InitializeComponent();
        }

        public frmItemInsert(ItemVO item)
        {
            InitializeComponent();
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

        }
    }
}
