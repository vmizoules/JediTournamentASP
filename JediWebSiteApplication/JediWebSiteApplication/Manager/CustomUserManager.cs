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
using System.Threading.Tasks;

namespace JediWebSiteApplication.Manager
{
    public class CustomUserManager : UserManager<CustomApplicationUser>
    {
        /// <summary>
        /// Web service.
        /// </summary>
        JediWebServiceClient m_webService;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="webService">Jedi Web Service.</param>
        public CustomUserManager(JediWebServiceClient webService)
            : base(new UserStore<CustomApplicationUser>(new ApplicationDbContext()))
        {
            m_webService = webService;
        }
        
        // Vérifie les credentials en appelant le web service
        public CustomApplicationUser checkLoginPassword(string login, string pwd)
        {
            UtilisateurContract userC = m_webService.CheckLoginPassword(login, pwd);
            
            CustomApplicationUser user = UserAdapter.fromUtilisateurContract(userC);

            return user;
        }

        // Création d'un utilisateur et appel au web service
        public Boolean Create(CustomApplicationUser customUser, string pwd)
        {
            bool success = true;

            // Ajoute le mot de passe de l'utilisateur
            customUser.PasswordHash = pwd;
            // Défini les points par défaults
            customUser.Points = 100;

            // Convertion en Contract
            UtilisateurContract user = UserAdapter.fromCustomApplicationUser(customUser);

            // Appelle au web service 
            try
            {
                m_webService.CreateUtilisateur(user);
            }
            catch (Exception)
            {
                success = false;
            }
            
            // Création réussie
            return success;
        }

        public int GetUserPoints(string username)
        {
            return m_webService.GetUserPoints(username);
        }

        public void UpdateUserPointsByAmount(string username, int amount)
        {
            m_webService.UpdateUserPointWithAmount(username, amount);
        }

        public void SetUserPoints(string username, int points)
        {
            m_webService.UpdateUserPoint(username, points);
        }

        public void ResetUserPoint(string username)
        {
            m_webService.ResetUserPoint(username);
        }

        // Crée l'identité de l'utilisateur (Et l'ajoute dans un cookie)
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

        // Crée l'identité de l'utilisateur (Et l'ajoute dans un cookie) de manière asynchrone
        public new Task<CustomIdentity> CreateIdentityAsync(CustomApplicationUser user, string authenticationType)
        {
            return Task.Factory.StartNew<CustomIdentity>(() => { return CreateIdentity(user, authenticationType); });
        }
    }
}