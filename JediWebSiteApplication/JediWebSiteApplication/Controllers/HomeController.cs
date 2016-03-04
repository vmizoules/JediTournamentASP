using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediWebSiteApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Site créé dans le cadre de la matière service réseau de l'enseignement F2 et F5 de l'ISIMA.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Nos coordonnées :";

            return View();
        }
    }
}