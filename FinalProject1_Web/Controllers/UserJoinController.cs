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
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login()
        {
            UserInfoVO model = new UserInfoVO();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(UserInfoVO model)
        {
            if (ModelState.IsValid)
            {
                UserInfoDAC dac = new UserInfoDAC();
                if (dac.IsUserValid(model.user_id, model.user_pwd) > 0) //로그인 성공
                {
                    UserInfoVO user = dac.GetUserInfo(model.user_id, model.user_pwd);
                    Session["User"] = user;
                    return RedirectToAction("LoginSuccess", "Main");
                }
                else //로그인 실패
                {
                    // 없는 아이디 입니다.
                    // 
                    ModelState.AddModelError(string.Empty, "아이디 혹은 비밀번호가 올바르지 않습니다.");
                }
            }
            
            return View(model);
        }

        public ActionResult LogOut()
        {
            Session.Remove("User");
            return RedirectToAction("LoginSuccess", "Main");
        }

        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            UserInfoVO user = new UserInfoVO();
            return View(user);
        }

        /// <summary>
        /// 회원가입
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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