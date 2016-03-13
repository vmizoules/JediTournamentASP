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
            // Recherche le tournoi correspondant
            TournoiModel t = GetTournoiByID(id);

            // Construit le modèle pour l'affichage des détails du tournoi
            TournoiDetailsModel content = new TournoiDetailsModel(t);

            return View(content);
        }

        //
        // GET: /Tournoi/Launch/id
        public ActionResult Launch(int id)
        {
            // Recherche le tournoi correspondant
            TournoiModel t = GetTournoiByID(id);

            // Construit le modèle pour le lancement nécessaire pour lancer un tournoi
            PreparedTournoiModel ptm = new PreparedTournoiModel(t);

            return View(ptm);
        }

        //
        // GET: /Tournoi/Create
        public ActionResult Create()
        {
            // Construit le modèle du contenu nécessaire pour créer un tournoi
            TournoiAvailableContentModel content = new TournoiAvailableContentModel(MatchAdapter.fromMatchContractList(m_webService.GetMatchs().ToList()));

            return View(content);
        }

        //
        // POST: /Tournoi/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // Récupère les valeurs du formulaire soumis
                List<MatchModel> matchs = new List<MatchModel>();
                for (int i = 1; i <= 4; i++)
                {
                    int tmp;
                    int.TryParse(collection["SelectedMatch" + i], out tmp);
                    
                    // Saisie invalide
                    if (tmp == -1)
                        return View();

                    // Récupères les objets nécessaires via la web service
                    matchs.Add(MatchAdapter.fromMatchContract(m_webService.GetMatchById(tmp)));
                }

                string name = collection["Nom"];

                // Nouveau Tournoi
                TournoiModel newTournoi = new TournoiModel();
                newTournoi.ID = -1; // En cours de création
                newTournoi.Nom = name;
                newTournoi.Matchs = matchs;

                // Crée le tournoi
                m_webService.CreateTournoi(TournoiAdapter.fromTournoiModel(newTournoi));

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
            // Recherche le tournoi correspondant
            TournoiModel t = GetTournoiByID(id);

            // Construit le modèle pour l'édition d'un tournoi
            TournoiEditModel content = new TournoiEditModel(t, MatchAdapter.fromMatchContractList(m_webService.GetMatchs().ToList()));

            return View(content);
        }

        //
        // POST: /Tournoi/Edit/id
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // Récupère les valeurs du formulaire soumis
                List<MatchModel> matchs = new List<MatchModel>();
                for (int i = 1; i <= 4; i++)
                {
                    int tmp;
                    int.TryParse(collection["SelectedMatch" + i], out tmp);

                    // Saisie invalide
                    if (tmp == -1)
                        return View();

                    // Récupères les objets nécessaires via la web service
                    matchs.Add(MatchAdapter.fromMatchContract(m_webService.GetMatchById(tmp)));
                }

                string name = collection["Nom"];

                // Recherche le tournoi correspondant
                TournoiModel tournoi = GetTournoiByID(id);
                tournoi.Nom = name;
                tournoi.Matchs = matchs;

                // Mise à jour du tournoi
                m_webService.UpdateTournoi(TournoiAdapter.fromTournoiModel(tournoi));

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
            // Recherche le tournoi correspondant
            TournoiModel t = GetTournoiByID(id);

            return View(t);
        }

        //
        // POST: /Tournoi/Delete/id
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // Recherche le tournoi correspondant
                TournoiModel t = GetTournoiByID(id);

                // Appelle le Web service pour la suppression
                m_webService.DeleteTournoi(TournoiAdapter.fromTournoiModel(t));

                return new RedirectResult(Url.Action("Index") + "#content");
            }
            catch
            {
                return View();
            }
        }
    }
}
