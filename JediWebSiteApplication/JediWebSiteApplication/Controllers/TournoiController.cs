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
    public class TournoiController : BaseController
    {
        private List<TournoiModel> m_tournois;

        /// <summary>
        /// Retourne le tournoi associé à l'id en paramètre.
        /// </summary>
        /// <param name="id">Id du tournoi recherché.</param>
        /// <returns>Tournoi Model correspondant.</returns>
        private TournoiModel GetTournoiByID(int id)
        {
            return m_tournois.Find(t => t.ID == id);
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        public TournoiController()
            : base()
        {
            // Récupère tous les tournois dans une liste
            TournoiContract[] tcs = m_webService.GetTournois(); // Appel au Web Service

            // Adaptation
            m_tournois = TournoiAdapter.fromTournoiContractList(tcs.ToList());
        }

        //
        // GET: /Tournoi/
        public ActionResult Index()
        {
            return View(m_tournois);
        }

        //
        // GET: /Tournoi/Details/id
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Tournoi/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tournoi/Create
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
        // GET: /Tournoi/Edit/id
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Tournoi/Edit/id
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
        // GET: /Tournoi/Delete/id
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Tournoi/Delete/id
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
