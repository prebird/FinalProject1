using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using FinalProject1_VO;
using FinalProject1_DAC;
using FinalProject1_Web.Models;
using Newtonsoft.Json;

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
            model.Notes = dac.GetAllListInPage(page, pageSize);
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
            NoteDAC dac = new NoteDAC();
            NoteVO model = dac.GetNoteInfo(id);
            return View(model);
        }

        // GET: Note/Create
        public ActionResult Create()
        {
            string userid = "";
            if (Session["User"] == null)
            {
                userid = "";
            }
            else
            {
                userid = ((UserInfoVO)Session["User"]).user_id;
            }
            NoteVO model = new NoteVO
            {
                
                note_userid = userid,
                note_subject = "",
                note_contents = ""
            };

            return View(model);
        }

        // POST: Note/Create
        [HttpPost]
        public ActionResult Create(NoteVO post)
        {
            try
            {
                NoteDAC dac = new NoteDAC();
                if (dac.SaveBoard(post))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(post);
                }
                
            }
            catch(Exception err)
            {
                string str = err.Message;
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
