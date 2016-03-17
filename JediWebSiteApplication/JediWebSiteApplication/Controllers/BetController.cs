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
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bet/idTournoi
        public ActionResult Bet(int idTournoi)
        {
            BetModel content = new BetModel(TournoiAdapter.fromTournoiContract(m_webService.GetTournoiById(idTournoi)));

            return View(content);
        }
    }
}