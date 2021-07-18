using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject1_VO;
using FinalProject1_DAC;

namespace FinalProject1_Web.Controllers
{
    public class UserJoinController : Controller
    {
        public ActionResult Create()
        {
            UserInfoVO user = new UserInfoVO();
            return View(user);
        }


        [HttpPost]
        public ActionResult Create(UserInfoVO user)
        {
            user.user_Category = "user002";
            try
            {
                UserInfoDAC dac = new UserInfoDAC();
                if (dac.InsertData(user))
                {
                    return RedirectToAction("Index", "Main");
                }
                else
                {
                    return View(user);
                }
            }
            catch (Exception err)
            {
                string str = err.Message;
                return View(user);
            }
            
        }
    }
}