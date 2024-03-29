﻿using JediWebSiteApplication.Adapters;
using JediWebSiteApplication.Models;
using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediWebSiteApplication.Controllers
{
    public class StadeController : BaseController
    {
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
            : base()
        {
            // Récupère tous les stades dans une liste
            StadeContract[] scs = m_webService.GetStades(); // Appel au Web Service

            // Adaptation
            m_stades = StadeAdapter.fromStadeContractList(scs.ToList());
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

                return new RedirectResult(Url.Action("Index") + "#content");
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
            // Recherche le stade correspondant
            StadeModel selectedStade = GetStadeByID(id);
            return View(selectedStade);
        }

        //
        // POST: /Stade/Edit/id
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // Récupère les valeurs du formulaire soumis
                string name = collection["Nom"];
                int nbPlace = 0;
                int.TryParse(collection["NbPlaces"], out nbPlace);
                string planete = collection["Planete"];

                // Recherche le stade correspondant
                StadeModel selectedStade = GetStadeByID(id);
                selectedStade.Nom = name;
                selectedStade.NbPlaces = nbPlace;
                selectedStade.Planete = planete;

                // Mise à jour du stade
                m_webService.UpdateStade(StadeAdapter.fromStadeModel(selectedStade));

                return new RedirectResult(Url.Action("Index") + "#content");
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
            // Recherche le stade correspondant
            StadeModel selectedStade = GetStadeByID(id);

            return View(selectedStade);
        }

        //
        // POST: /Stade/Delete/id
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // Recherche le stade correspondant
                StadeModel selectedStade = GetStadeByID(id);

                // Supprime le stade
                m_webService.DeleteStade(StadeAdapter.fromStadeModel(selectedStade));

                return new RedirectResult(Url.Action("Index") + "#content");
            }
            catch
            {
                return View();
            }
        }
    }
}
