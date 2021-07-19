using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using FinalProject1_VO;
using FinalProject1_DAC;
using FinalProject1_Web.Models;

namespace FinalProject1_Web.Controllers
{
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index(int page = 1)
        {
            int pageSize = Convert.ToInt32(WebConfigurationManager.AppSettings["pagesize"]);
            NoteDAC dac = new NoteDAC();

            NoteListViewModel model = new NoteListViewModel();
            model.Notes = dac.GetAllList(page, pageSize);
            model.PageInfo = new PagingInfo
            {
                TotalItems = dac.GetNoteTotalCount(),
                ItemsPerPage = pageSize,
                CurrentPage = page
            };
            

            return View(model);
        }

        // GET: Note/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Note/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Note/Create
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

        // GET: Note/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Note/Edit/5
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

        // GET: Note/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Note/Delete/5
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
