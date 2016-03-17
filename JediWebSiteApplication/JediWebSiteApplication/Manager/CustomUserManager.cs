using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using JediWebSiteApplication.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using JediWebSiteApplication.WebServiceReference;
using JediWebSiteApplication.Adapters;
using System.Security.Claims;

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

            CustomApplicationUser user = UserAdapter.fromUtilisateurContract(userC);

            return user;
        }

        public Boolean Create(CustomApplicationUser user, string pwd)
        {

            // TODO MAKE IT

            return true;
        }

        public CustomIdentity CreateIdentity(CustomApplicationUser user, string authenticationType)
        {
            IList<Claim> claimCollection = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.UserName + "@jediservice.zz2")
            };

            CustomIdentity id = new CustomIdentity(claimCollection, authenticationType);

            return id;
        }
    }
}