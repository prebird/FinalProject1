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
    public partial class frmMasterInsert : Form
    {
        int _SalesMasterID;
        public frmMasterInsert(int SalesMasterID)
        {
            InitializeComponent();
            _SalesMasterID = SalesMasterID;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // 유효성 체크
            if (MessageBox.Show("입력 하시겠습니까?", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {     
                SalesMasterVO SMVO = new SalesMasterVO()
                {
                    PO_ID = _SalesMasterID,
                    PO_Destination = txt_Destination.Text,
                    PO_OutCnt = Convert.ToInt32(txt_OutCnt.Text),
                    PO_CancelCnt = Convert.ToInt32(txt_CancelCnt.Text),
                    PO_Content = txt_Content.Text,
                    PO_EditManager = txt_EditManger.Text,
                    PO_EditDate = dtp_EditDate.Text,
                };

                SalesMasterService service = new SalesMasterService();
                bool result =  service.UpdateSM(SMVO);

                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                //else
                //    this.DialogResult = DialogResult.No;
            }
       }
    }
}
