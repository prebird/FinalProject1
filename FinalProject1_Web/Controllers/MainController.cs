using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject1_Web.Controllers
{
    public class MainController : Controller
    {

        // GET: Main
        public ActionResult Index1()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }

        // 로그인 성공시  
        public ActionResult LoginSuccess()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}