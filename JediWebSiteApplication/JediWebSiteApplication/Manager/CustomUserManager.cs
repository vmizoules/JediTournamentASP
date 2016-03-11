using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using JediWebSiteApplication.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using JediWebSiteApplication.WebServiceReference;

namespace JediWebSiteApplication.Manager
{
    public class CustomUserManager : UserManager<CustomApplicationUser>
    {
        JediWebServiceClient m_webService;

        public CustomUserManager(JediWebServiceClient webService)
            : base(new UserStore<CustomApplicationUser>(new ApplicationDbContext()))
        {
            m_webService = webService;
        }

        public CustomApplicationUser checkLoginPassword(string login, string pwd)
        {
            UtilisateurContract userC = m_webService.CheckLoginPassword(login, pwd);

            // TODO MAKE IT

            return new CustomApplicationUser();
        }

        public Boolean Create(CustomApplicationUser user, string pwd)
        {

            // TODO MAKE IT

            return true;
        }
    }
}