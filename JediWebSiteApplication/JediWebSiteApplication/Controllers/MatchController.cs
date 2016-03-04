using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediWebSiteApplication.Controllers
{
    public class MatchController : Controller
    {
        //
        // GET: /Match/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Match/Details/id
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Match/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Match/Create
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

        //
        // GET: /Match/Edit/id
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Match/Edit/id
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

        //
        // GET: /Match/Delete/id
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Match/Delete/id
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
