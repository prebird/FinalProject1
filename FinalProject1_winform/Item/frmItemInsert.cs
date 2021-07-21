using FinalProject1_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (item.Item_img != null)
            {
                pictureBox1.ImageLocation = ConfigurationManager.AppSettings["apiurl"] + "Uploads/" + item.Item_img;
            }
            else
            {
                pictureBox1.ImageLocation = null;
            }
        }

        private async void btn_InsUp_Click(object sender, EventArgs e)
        {
            // 유효성 체크 추가

            if (MessageBox.Show(btn_InsUp.Text + "하시겠습니까", "입력 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int itemID = (itemList != null) ? itemList.Item_ID : 0;

                ItemVO item = new ItemVO()
                {
                    Item_ID = itemID,
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


                // 이미지 있는경우
                string uploadFileName;
                string uploadfile = null;
                bool imgResult = false;

                if (btn_InsUp.Text == "저장") // 신규 등록인 경우
                {
                    if (pictureBox1.ImageLocation != null) // 사진이 있는경우
                    {
                        //이미지 이름
                        // 파일 이름 string 만들기
                        Random rnd = new Random();
                        uploadFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(9999).ToString().PadLeft(4, '0');
                        uploadfile = uploadFileName + new FileInfo(pictureBox1.ImageLocation).Extension;

                        item.Item_img = uploadfile;

                        // 이미지 업로드
                        //파일업로드 API서비스를 호출
                        CallService callservice = new CallService();
                        imgResult = await callservice.ServerUploadForDBInsert(pictureBox1.ImageLocation, uploadfile);
                    }
                    else // 사진이 없는 경우
                    {
                        imgResult = true; // 그냥 true반환
                    }
                }
                else // 수정인 경우
                {
                    if (itemList.Item_img != null) // 이미지가 있었던 경우
                    {
                        item.Item_img = itemList.Item_img;
                        imgResult = true;
                    }
                    else // 이미지가 없었던경우
                    {
                        //이미지 이름
                        // 파일 이름 string 만들기
                        Random rnd = new Random();
                        uploadFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(9999).ToString().PadLeft(4, '0');
                        uploadfile = uploadFileName + new FileInfo(pictureBox1.ImageLocation).Extension;

                        item.Item_img = uploadfile;

                        // 이미지 업로드
                        //파일업로드 API서비스를 호출
                        CallService callservice = new CallService();
                        imgResult = await callservice.ServerUploadForDBInsert(pictureBox1.ImageLocation, uploadfile);
                    }
                }



                // DB 인서트
                ItemService service = new ItemService();
                bool result = service.InsertUpdateItem(item);

                if (imgResult == true) //이미지 업로드 성공시
                {
                    if (result)
                    {
                        MessageBox.Show("정보가 입력 되었습니다.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        MessageBox.Show("처리중 오류가 발생 했습니다.", "처리 오류", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                else //이미지 업로드 실패시
                {
                    MessageBox.Show("이미지 업로드 실패");
                }
            }
            
        }

        private void btnSearchPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dlg.FileName;
            }
        }
    }
}
