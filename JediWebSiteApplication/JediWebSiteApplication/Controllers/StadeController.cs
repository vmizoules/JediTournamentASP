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
    public class StadeController : Controller
    {
        private JediWebServiceClient m_webService;
        private List<StadeModel> m_stades;

        /// <summary>
        /// Retourne le stade associé à l'id en paramètre.
        /// </summary>
        /// <param name="id">Id du stade recherché.</param>
        /// <returns>Stade Model correspondant.</returns>
        private StadeModel GetStadeByID(int id)
        {
            return m_stades.Find(s => s.ID == id);
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        public StadeController()
        {
            // Instancie le web service 
            m_webService = new JediWebServiceClient();

            // Récupère tous les stades dans une liste
            StadeContract[] scs = m_webService.GetStades(); // Appel au Web Service

            m_stades = new List<StadeModel>(); // Adaptation
            foreach (StadeContract sc in scs)
            {
                m_stades.Add(StadeAdapter.fromStadeContract(sc));
            }
        }

        //
        // GET: /Stade/
        public ActionResult Index()
        {
            // Utilise la liste des stades
            return View(m_stades);
        }

        //
        // GET: /Stade/Details/id
        public ActionResult Details(int id)
        {
            // Recherche le stade correspondant
            StadeModel selectedStade = GetStadeByID(id);
            return View(selectedStade);
        }

        //
        // GET: /Stade/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Stade/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // Récupère les valeurs du formulaire soumis
                string name = collection["Nom"];
                int nbPlace = 0;
                int.TryParse(collection["NbPlaces"], out nbPlace);
                string planete = collection["Planete"];

                // Nouveau Stade
                StadeModel newStade = new StadeModel();
                newStade.Nom = name;
                newStade.NbPlaces = nbPlace;
                newStade.Planete = planete;

                // Appèle le Web Service pour l'enregistrement
                m_webService.CreateStade(StadeAdapter.fromStadeModel(newStade));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Stade/Edit/id
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Stade/Edit/id
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
        // GET: /Stade/Delete/id
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Stade/Delete/id
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
