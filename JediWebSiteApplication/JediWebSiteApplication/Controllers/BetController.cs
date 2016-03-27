using JediWebSiteApplication.Adapters;
using JediWebSiteApplication.Models.SubModels.Pari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediWebSiteApplication.Controllers
{
    public class BetController : BaseController
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        public BetController()
            : base()
        {
        }

        // GET: Bet/
        public ActionResult Index(int idTournoi)
        {
            ViewBag.TournoiID = idTournoi;
            return View();
        }

        // GET: Bet/Bet/idTournoi
        public ActionResult Bet(int idTournoi)
        {
            // Contenu nécessaire à la gestion des paris
            BetModel content = new BetModel(TournoiAdapter.fromTournoiContract(m_webService.GetTournoiById(idTournoi)));

            return View(content);
        }

        //
        // POST: Bet/Bet
        [HttpPost]
        public ActionResult Bet(FormCollection collection)
        {
            try
            {
                // Récupère la mise
                int idTournoi = -1;
                int.TryParse(collection["IDTournoi"], out idTournoi);
                int mise = 0;
                int.TryParse(collection["Mise"], out mise);
                // Corrige la mise si supérieure aux moyens de l'utilisateur
                int userPoints = m_webService.GetUserPoints(User.Identity.Name);
                mise = mise > userPoints ? userPoints : mise;

                int idBetJedi = -1;
                int.TryParse(collection["BetJedi"], out idBetJedi);

                if (idTournoi == -1 || idBetJedi == -1)
                    return new RedirectResult(Url.Action("Index", "Tournoi") + "#content");

                return new RedirectResult(Url.Action("BetLaunch", "Tournoi", new { id = idTournoi, m = mise, bet = idBetJedi }) + "#content");
            }
            catch
            {
                return View();
            }
        }
    }
}