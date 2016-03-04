using JediWebSiteApplication.Adapters;
using JediWebSiteApplication.Models;
using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediWebSiteApplication.Controllers
{
    public class MatchController : BaseController
    {
        private List<MatchModel> m_matchs;

        /// <summary>
        /// Retourne le jedi associé à l'id en paramètre.
        /// </summary>
        /// <param name="id">Id du jedi recherché.</param>
        /// <returns>Jedi Model correspondant.</returns>
        private MatchModel GetJediByID(int id)
        {
            return m_matchs.Find(j => j.ID == id);
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        public MatchController()
            : base()
        {
            // Récupère tous les matchs dans une liste
            MatchContract[] mcs = m_webService.GetMatchs(); // Appel au Web Service

            m_matchs = new List<MatchModel>(); // Adaptation
            foreach (MatchContract mc in mcs)
            {
                m_matchs.Add(MatchAdapter.fromMatchContract(mc));
            }
        }

        //
        // GET: /Match/
        public ActionResult Index()
        {
            return View(m_matchs);
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

                return new RedirectResult(Url.Action("Index") + "#content");
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

                return new RedirectResult(Url.Action("Index") + "#content");
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

                return new RedirectResult(Url.Action("Index") + "#content");
            }
            catch
            {
                return View();
            }
        }
    }
}
