using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject1_Web.Controllers
{
    [Route("account")]
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }
    }
}