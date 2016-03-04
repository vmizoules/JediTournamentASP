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
    public class JediController : BaseController
    {
        private List<JediModel> m_jedis;

        /// <summary>
        /// Retourne le jedi associé à l'id en paramètre.
        /// </summary>
        /// <param name="id">Id du jedi recherché.</param>
        /// <returns>Jedi Model correspondant.</returns>
        private JediModel GetJediByID(int id)
        {
            return m_jedis.Find(j => j.ID == id);
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        public JediController()
            : base()
        {
            // Récupère tous les stades dans une liste
            JediContract[] jcs = m_webService.GetJedis(); // Appel au Web Service

            m_jedis = new List<JediModel>(); // Adaptation
            foreach (JediContract jc in jcs)
            {
                m_jedis.Add(JediAdapter.fromJediContract(jc));
            }
        }

        //
        // GET: /Jedi/
        public ActionResult Index()
        {
            // Utilise la liste des jedis
            return View(m_jedis);
        }

        //
        // GET: /Jedi/Details/id
        public ActionResult Details(int id)
        {
            // Recherche le jedi correspondant
            JediModel selectedJedi = GetJediByID(id);

            return View(selectedJedi);
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
                // Récupère les valeurs du formulaire soumis
                string name = collection["Nom"];
                bool isSith = false;
                bool.TryParse(collection["IsSith"], out isSith);

                // Nouveau Jedi
                JediModel newJedi = new JediModel();
                newJedi.Nom = name;
                newJedi.IsSith = isSith;

                // Appèle le Web Service pour l'enregistrement
                m_webService.CreateJedi(JediAdapter.fromJediModel(newJedi));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Jedi/Edit/id
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Jedi/Edit/id
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
        // GET: /Jedi/Delete/id
        public ActionResult Delete(int id)
        {
            // Recherche le jedi correspondant
            JediModel selectedJedi = GetJediByID(id);

            return View(selectedJedi);
        }

        //
        // POST: /Jedi/Delete/id
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // Recherche le jedi correspondant
                JediModel selectedJedi = GetJediByID(id);

                // Supprime le jedi
                m_webService.DeleteJedi(JediAdapter.fromJediModel(selectedJedi));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
