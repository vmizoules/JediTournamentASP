using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediWebSiteApplication.Controllers
{
    public class BaseController : Controller
    {
        protected JediWebServiceClient m_webService;

        public BaseController()
        {
            // Instancie le web service
            m_webService = new JediWebServiceClient();
        }
    }
}