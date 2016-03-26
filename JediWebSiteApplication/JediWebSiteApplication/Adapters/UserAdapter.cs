using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JediWebSiteApplication.Models;
using JediWebSiteApplication.WebServiceReference;

namespace JediWebSiteApplication.Adapters
{
    public class UserAdapter
    {
        public static CustomApplicationUser fromUtilisateurContract(UtilisateurContract userC)
        {
            if (userC == null)
                return null;

            CustomApplicationUser u = new CustomApplicationUser();
            u.UserName = userC.Login;
            u.Id = userC.Login;
            u.Points = userC.Points;

            return u;
        }

        public static UtilisateurContract fromCustomApplicationUser(CustomApplicationUser customUser)
        {
            if (customUser == null)
                return null;

            UtilisateurContract u = new UtilisateurContract();
            u.Login = customUser.UserName;
            u.Password = customUser.PasswordHash;
            u.Prenom = customUser.UserName;
            u.Nom = customUser.UserName;
            u.Points = customUser.Points;
            
            return u;
        }


    }
}