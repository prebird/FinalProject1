using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace FinalProject1_Web.Controllers
{
    
    public class UploadController : ApiController
    {
        //POST : https://localhost:44394/api/Upload
        public HttpResponseMessage Post()
        {
            HttpResponseMessage result = null;

            if (HttpContext.Current.Request.Files.Count > 0)
            {
                foreach (string file in HttpContext.Current.Request.Files)
                {
                    var postedFile = HttpContext.Current.Request.Files[file];
                    var orgFileName = postedFile.FileName;

                    //웹서버의 URL로부터 물리적인 서버의 경로를 알아낸다.
                    var filePath = HttpContext.Current.Server.MapPath("~/Uploads/");
                    postedFile.SaveAs(filePath + orgFileName);
                }

                result = Request.CreateResponse(HttpStatusCode.Created);
            }
            else
            {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            return result;
        }
    }
}
