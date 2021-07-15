using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1_VO;

namespace FinalProject1_winform
{
    public static class CommonUtil
    {


        #region DataGridView 설정
        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false; //=>컬럼을 수동으로 정의하겠다.
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public static void AddGridTextColumn(DataGridView dgv,
                                        string headerText,
                                        string propertyName,
                                        DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft,
                                        int colWidth = 100,
                                        bool visibility = true)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = propertyName;
            col.HeaderText = headerText;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.DataPropertyName = propertyName;
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = align;
            col.Visible = visibility;
            col.ReadOnly = true;

            dgv.Columns.Add(col);
        }
        #endregion

        // 데이터 그리드뷰에 버튼 바인딩
        public static void ButtonInDGV(DataGridView dgv, string headerText ,string buttonText, int width = 80)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = headerText;
            btn.Text = buttonText;
            btn.Width = width;
            btn.DefaultCellStyle.Padding = new Padding(5, 1, 5, 1);
            btn.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(btn);
        }


        // 텍스트박스 유효성체크
        public static bool CheckNullOrEmptyOk(this TextBox txtInput, string Title)
        {
            if (string.IsNullOrEmpty(txtInput.Text.Trim()))
            {
                MessageBox.Show(string.Format("{0}이(가) 입력되지 않았습니다. {0}을(를) 입력해 주십시오.", Title), "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        // int? 타입일때 텍스트가 비어있으면 null을 리턴, 아니면 숫자로 바꿔서 리턴
        public static int ZeroOrNum(this string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(inputText);
            }
        }

        // 
        public static int? ZeroOrInt(this int? inputValue)
        {
            if (inputValue == null)
            {
                return 0;
            }
            else
            {
                return inputValue;
            }
        }

        public static int ZeroOrInt(this string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(inputText);
            }
        }

        // 콤보박스 유효성체크
        public static bool CheckCboValidateValue(this ComboBox cbo, string Title)
        {
            if (cbo.SelectedIndex == 0)
            {
                MessageBox.Show(string.Format("{0}를 선택해 주세요", Title), "입력오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        // 이미지 <-> 바이트배열
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter ic = new ImageConverter();
            return (byte[])ic.ConvertTo(img, typeof(byte[]));
        }

        public static Image ByteToImage(byte[] data)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            return (Bitmap)tc.ConvertFrom(data);
        }

        // 콤보박스바인딩
        public static void ComboBinding<T>(ComboBox cbo, List<T> list, string displayMember, string valueMember)
        {
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
            cbo.DataSource = list;
        }
        // 사용케이스
        //CommonService service1 = new CommonService();
        //List<CommonCodeVO> CCList = service1.GetCommonCode("shift_type");
        //CommonCodeVO item = new CommonCodeVO
        //{
        //    common_name = "선택",
        //    common_value = "0"
        //};

        //CommonUtil.ComboBinding<CommonCodeVO>(cbShift, CClist, "common_value", "common_name");



        // DemandPlan의 PlanID 바인딩
        public static void ComboBindingPlanID(ComboBox cbo)
        {
            CommonService service = new CommonService();
            List<DemandPlanVO> list = service.GetCommboDemandPlan();
            DemandPlanVO item = new DemandPlanVO
            {
                PlanID = "선택"
            };
            list.Insert(0, item);

            ComboBinding<DemandPlanVO>(cbo, list, "PlanID", "");
        }

        public static void ComboBindingProductID(ComboBox cbo)
        {
            CommonService service = new CommonService();
            List<ItemVO> list = service.GetCommboProductName();
            ItemVO item = new ItemVO
            {
                Item_ID = 0,
                Item_Name = "선택"
            };
            list.Insert(0, item);

            ComboBinding<ItemVO>(cbo, list, "Item_Name", "Item_ID");
        }



        #region 옛날 유틸
        //public static void ColorChange(object sender, Panel panel)
        //{
        //    foreach (gudi2Button buttons in panel.Controls)
        //    {
        //        buttons.ButtonType = ButtonStyle.Normal;
        //    }
        //    gudi2Button me = (gudi2Button)sender;
        //    me.ButtonType = ButtonStyle.Highlight;
        //}

        //public static void PanelShowAndHide(Panel panel)
        //{
        //    if (panel.Visible == false)
        //    {
        //        panel.Visible = true;
        //    }
        //    else
        //        panel.Visible = false;
        //}

        //#region 입력값 체크
        ///*
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="pnl"></param>
        ///// <returns></returns>
        //public static string InputYNCheck(Panel pnl)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    //패널안의 텍스트박스 컨트롤들의 입력여부를 체크
        //    foreach (Control ctrl in pnl.Controls)
        //    {
        //        if (ctrl is GudiTextBox txt)
        //        {
        //            if (txt.InputType == validType.Required || txt.InputType == validType.RequiredNumeric)
        //            {
        //                if (string.IsNullOrWhiteSpace(txt.Text.Trim()))
        //                {
        //                    sb.Append($"- {txt.Tag}을 입력해 주세요.\n");
        //                }
        //            }
        //        }
        //    }

        //    return sb.ToString();
        //}
        //*/

        //public static string IsPhoneNumber(string input)
        //{
        //    string phonePattern = @"^\d{3}-\d{3,4}-\d{4}$";
        //    if (!Regex.IsMatch(input, phonePattern))
        //    {
        //        return $"- 전화번호 형식이 아닙니다.\n";
        //    }
        //    else
        //    {
        //        return string.Empty;
        //    }
        //}
        //#endregion

        //public static void ComboBinding(ComboBox cbo, List<ComboItemVO> list, string gubun, bool blankItem = true, string blankText = "")
        //{
        //    //var codeList = (from item in list
        //    //                where item.Gubun.Equals(gubun)
        //    //                select item).ToList();

        //    var codeList = list.Where<ComboItemVO>((item) => item.Gubun.Equals(gubun)).ToList();

        //    if (blankItem)
        //    {
        //        ComboItemVO blank = new ComboItemVO
        //        { Code = "", Name = blankText };
        //        codeList.Insert(0, blank);
        //    }

        //    cbo.DisplayMember = "Name";
        //    cbo.ValueMember = "Code";
        //    cbo.DataSource = codeList;       
        //}       

        //// Order 전용 메서드
        //public static void ComboBindingOrder(ComboBox cbo, List<CompanyVO> list, string Category, bool blankItem = true, string blankText = "")
        //{
        //    var CustomerList = list.Where<CompanyVO>((item) => item.CompanyCategory.Equals(Category)).ToList();

        //    if (blankItem)
        //    {
        //        CompanyVO blank = new CompanyVO
        //        { CompanyID = 0, 
        //          CompanyName = blankText };
        //          CustomerList.Insert(0, blank);
        //    }
        //    cbo.DisplayMember = "CompanyName";
        //    cbo.ValueMember = "CompanyID";
        //    cbo.DataSource = CustomerList;
        //}

        //// OutProduct 전용 메서드
        //public static void ComboBindingUser(ComboBox cbo, List<UserVO> Userlist, bool blankItem = true, string blankText = "")
        //{
        //    if (blankItem)
        //    {
        //        UserVO blank = new UserVO
        //        {
        //            UserID = null,
        //            UserName = blankText
        //        };
        //        Userlist.Insert(0, blank);
        //    }
        //    cbo.DisplayMember = "UserName";
        //    cbo.ValueMember = "UserID";
        //    cbo.DataSource = Userlist;
        //}

        //// OutProduct WareHouse 전용 메서드
        //public static void ComboBindingPossibleHouse(ComboBox cbo, List<OutProductDetailVO> PossibleHouseList, bool blankItem = true, string blankText = "")
        //{
        //    if (blankItem)
        //    {
        //        OutProductDetailVO blank = new OutProductDetailVO
        //        {
        //            LocationID = blankText,
        //        };
        //        PossibleHouseList.Insert(0, blank);
        //    }
        //    cbo.DisplayMember = "Locationid";
        //    cbo.DataSource = PossibleHouseList;
        //}
        #endregion

    }
}

