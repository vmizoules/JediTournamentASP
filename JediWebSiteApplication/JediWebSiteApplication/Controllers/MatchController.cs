using JediWebSiteApplication.Adapters;
using JediWebSiteApplication.Models;
using JediWebSiteApplication.Models.SubModels;
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
        private MatchModel GetMatchByID(int id)
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

            // Adaptation
            m_matchs = MatchAdapter.fromMatchContractList(mcs.ToList());
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
            MatchModel m = this.GetMatchByID(id);

            return View(m);
        }

        //
        // GET: /Match/Create
        public ActionResult Create()
        {
            // Construit le modèle du contenu nécessaire pour créer un match
            MatchAvailableContentModel content = new MatchAvailableContentModel(JediAdapter.fromJediContractList(m_webService.GetJedis().ToList()),
                                                                                StadeAdapter.fromStadeContractList(m_webService.GetStades().ToList()));
            return View(content);
        }

        //
        // POST: /Match/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // Récupère les valeurs du formulaire soumis
                int idJedi1 = -1;
                int.TryParse(collection["SelectedJedi1"], out idJedi1);
                int idJedi2 = -1;
                int.TryParse(collection["SelectedJedi2"], out idJedi2);
                int idStade = -1;
                int.TryParse(collection["SelectedStade"], out idStade);

                // Saisie invalide
                if (idJedi1 == -1 || idJedi2 == -1 || idStade == -1)
                    return View();

                // Récupères les objets nécessaires via la web service
                JediModel jediM1 = JediAdapter.fromJediContract(m_webService.GetJediById(idJedi1));
                JediModel jediM2 = JediAdapter.fromJediContract(m_webService.GetJediById(idJedi2));
                StadeModel stadeM = StadeAdapter.fromStadeContract(m_webService.GetStadeById(idStade));

                // Nouveau Match
                MatchModel newMatch = new MatchModel();
                newMatch.ID = -1;   // En cours de création
                newMatch.Jedi1 = jediM1;
                newMatch.Jedi2 = jediM2;
                newMatch.Stade = stadeM;
                newMatch.IdVainqueur = -1;  // Non joué
                newMatch.PhaseTournoi = EPhaseTournoiModel.QuartFinale; // Match à la base d'un tournoi

                // Appèle le Web Service pour l'enregistrement
                m_webService.CreateMatch(MatchAdapter.fromMatchModel(newMatch));

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
            MatchModel m = this.GetMatchByID(id);

            return View(m);
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
            MatchModel m = this.GetMatchByID(id);

            return View(m);
        }

        //
        // POST: /Match/Delete/id
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                MatchModel m = this.GetMatchByID(id);
                MatchContract mc = MatchAdapter.fromMatchModel(m);

                // TODO : check it
                // call webservice
                //m_webService.DeleteMatch(mc);

                return new RedirectResult(Url.Action("Index") + "#content");
            }
            catch
            {
                return View();
            }
        }
    }
}
