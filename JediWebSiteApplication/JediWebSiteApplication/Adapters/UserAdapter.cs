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
            u.Id = userC.Login + "#" + userC.Nom + "#" + userC.Prenom;
            // TODO add more information

            return u;
        }


    }
}