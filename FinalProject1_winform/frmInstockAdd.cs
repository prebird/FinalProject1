using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_DAC;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public partial class frmInstockAdd : Form
    {
        RestockOrderVO throwedVO;
        UserInfoVO user;
        public frmInstockAdd(RestockOrderVO throwedvo, UserInfoVO user)
        {
            InitializeComponent();
            this.throwedVO = throwedvo;
            this.user = user;
        }

        private void frmInstockAdd_Load(object sender, EventArgs e)
        {
            //바인딩
            CommonUtil.ComboBindingWHid(cbofactory);
            CommonUtil.ComboBindingItemID(cboItem);
            cbofactory.SelectedIndex = 0;

            txtTime.Text = DateTime.Now.ToString();

            txtROID.Text = throwedVO.RO_ID.ToString();
            txtUser.Text = user.user_name;
            txtCnt.Text = throwedVO.ins_cnt.ToString();

            // cbo품목 바인딩
            cboItem.SelectedIndex = cboItem.FindString(throwedVO.Item_Name);


        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.Text == "입고")
            {
                
                    btnSave.Text = "입고등록"; 

                
            }
            else if (cboType.Text == "출고")
            {
                
                     btnSave.Text = "출고등록";
               
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 유효성검사
            if (!cboType.CheckCboValidateValue("입출고타입")) return;
            if (!cbofactory.CheckCboValidateValue("입출고창고")) return;
            if (!cboItem.CheckCboValidateValue("품목")) return;
            if (txtCnt.CheckNullOrEmptyOk("입출고 갯수")) return;


            
            
            InventoryHistVO hist = new InventoryHistVO
            {

                factory_id = Convert.ToInt32(cbofactory.SelectedValue),
                Item_id = Convert.ToInt32(cboItem.SelectedValue),
                PO_ID = txtPOID.Text,
                RO_ID = Convert.ToInt32(txtROID.Text),
                ih_product_count = Convert.ToInt32(txtCnt.Text),
                ih_category = cboType.Text,
                ih_uadmin = txtUser.Text,
                ih_udate = txtTime.Text,
                ih_comment = txtNote.Text
            };

            // dac
            if (btnSave.Text == "입고등록")
            {
                RestockOrderDAC dac = new RestockOrderDAC();
                if (dac.insertInventoryIN(hist))
                {
                    MessageBox.Show("입고가 성공적으로 이루어 졌습니다.");
                }
                else
                {
                    MessageBox.Show("다시 시도해 주세요");
                }
            }
            
            else if (btnSave.Text == "출고등록")
            {
                RestockOrderDAC dac = new RestockOrderDAC();
                if (dac.insertInventoryOUT(hist))
                {
                    MessageBox.Show("출고가 성공적으로 이루어 졌습니다.");
                }
                else
                {
                    MessageBox.Show("다시 시도해 주세요");
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_gudi8_Click(object sender, EventArgs e)
        {

        }
    }
}
