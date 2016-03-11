using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using JediWebSiteApplication.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace JediWebSiteApplication.Manager
{
    public class CustomUserManager : UserManager<CustomApplicationUser>
    {
        public CustomUserManager()
            : base(new UserStore<CustomApplicationUser>(new ApplicationDbContext()))
        {

        }

        public CustomApplicationUser checkLoginPassword(string login, string pwd)
        {
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