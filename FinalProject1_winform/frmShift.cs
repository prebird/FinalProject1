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
    public partial class frmShift : FinalProject1_winform.Basic3
    {
        public frmShift()
        {
            InitializeComponent();
        }

        private void frmShift_Load(object sender, EventArgs e)
        {
            ShiftService service = new ShiftService();
            List<ShiftVO> list = service.GetAllShifts();

            CommonService service1 = new CommonService();
            List<CommonCodeVO> CCList = service1.GetCommonCode("shift_type");

            // 콤보박스바인딩 - 커먼코드
            CommonCodeVO item = new CommonCodeVO
            {
                common_name = "선택",
                common_value = "0"
            };
            CCList.Insert(0, item);
            CommonUtil.ComboBinding<CommonCodeVO>(cbShift, CCList, "common_value", "common_name");



        }


    }
}
