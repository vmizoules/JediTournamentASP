using JediWebSiteApplication.Models;
using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediWebSiteApplication.Controllers
{
    public class JediController : Controller
    {
        private JediWebServiceClient m_webService;

        // Constructor
        public JediController()
        {
            // instanciate web service 
            m_webService = new JediWebServiceClient();
        }

        //
        // GET: /Jedi/
        public ActionResult Index()
        {


            // call to web service
            JediContract[] jedis = m_webService.GetJedis();

            List<JediModel> list = new List<JediModel>();

            foreach (JediContract oneJedi in jedis) {
                list.Add(new JediModel(oneJedi));
            }


            return View(list);
        }

        //
        // GET: /Jedi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Jedi/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Jedi/Create
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
        // GET: /Jedi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Jedi/Edit/5
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
        // GET: /Jedi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Jedi/Delete/5
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
