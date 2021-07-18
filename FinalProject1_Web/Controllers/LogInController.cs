using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_Web.Controllers
{

    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }

        // post (회원가입)
        //public ActionResult Register(UserInfoVO userModel)
        //{
        //    UserInfoDAC dac = new UserInfoDAC();
            
        //}
    }
}