using FinalProject1_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject1_DAC;
using FinalProject1_VO;

namespace FinalProject1_Web.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }

        [HttpPost]
        public ActionResult AddToCart(int productID, string returnUrl)
        {
            ItemDAC db = new ItemDAC();
            ItemVO prd = db.GetOneItem(productID);

            ItemDAC db1 = new ItemDAC();
            if (prd != null)
            {
                Cart cart = GetCart();
                cart.AddItem(prd, 1);
            }

            return RedirectToAction("Index");
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];

            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart; 
            }
            return cart;
        }

        public ActionResult Buy()
        {
            return View((Cart)Session["Cart"]);
        }


    }
}