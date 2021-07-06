using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject1_Web.Controllers
{
    public class CustomerServiceController : Controller
    {
        // GET: CustomerService
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerService/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerService/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerService/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
