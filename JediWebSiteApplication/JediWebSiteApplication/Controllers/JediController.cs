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
    public class JediController : Controller
    {
        private JediWebServiceClient m_webService;
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
        {
            // Instancie le web service 
            m_webService = new JediWebServiceClient();

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
                // get name from form
                String s_name = collection.Get(1);
                // get sith from form
                String s_sith = collection.Get(2);
                Boolean b_sith = true;
                if (s_sith == "false") {
                    b_sith = false;
                }

                // new Jedi
                JediModel new_j = new JediModel();
                new_j.IsSith = b_sith;
                new_j.Nom = s_name;
                new_j.Caracteristiques = new List<CaracteristiqueModel>();

                // convert into JediContract
                JediContract new_jc = JediAdapter.fromJediModel(new_j);

                // call web service with this jc
                m_webService.CreateJedi(new_jc);

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
                // TODO: Add delete logic here
                //m_webService.DeleteJedi(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
