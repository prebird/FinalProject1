using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Configuration;
using System.Net.Http.Headers;
using System.IO;

namespace FinalProject1_winform
{
    class CallService
    {
        HttpClient client = new HttpClient();

        public CallService()
        {
            string serverUrl = ConfigurationManager.AppSettings["apiurl"];
            client.BaseAddress = new Uri($"{serverUrl}api/Upload/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<bool> ServerUpload(string localFileName)
        {
            Random rnd = new Random();
            var fileStream = File.Open(localFileName, FileMode.Open);
            string uploadFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + rnd.Next(9999).ToString().PadLeft(4, '0');
            var uploadfile = uploadFileName + new FileInfo(localFileName).Extension;

            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(new StreamContent(fileStream), "file1", uploadfile);

            using (HttpResponseMessage res = await client.PostAsync("", content))
            {
                if(res.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // 사용 하는쪽 코드 예시
        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    if (dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        textBox1.Text = dlg.FileName;
        //        //파일업로드 API서비스를 호출
        //        CallService service = new CallService();
        //        bool result = await service.ServerUpload(dlg.FileName);

        //        if (result)
        //            MessageBox.Show("업로드 완료");
        //        else
        //            MessageBox.Show("업로드 실패");
        //    }
        //}

        // db 인서트용 
        public async Task<bool> ServerUploadForDBInsert(string localFileName, string uploadfile)
        {
            
            var fileStream = File.Open(localFileName, FileMode.Open);
            

            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(new StreamContent(fileStream), "file1", uploadfile);

            using (HttpResponseMessage res = await client.PostAsync("", content))
            {
                if (res.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        
    }
}
