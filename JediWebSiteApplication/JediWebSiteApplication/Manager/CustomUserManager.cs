﻿using System;
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
        
        // Check credential by calling webservice
        public CustomApplicationUser checkLoginPassword(string login, string pwd)
        {
            UtilisateurContract userC = m_webService.CheckLoginPassword(login, pwd);
            
            CustomApplicationUser user = UserAdapter.fromUtilisateurContract(userC);

            return user;
        }

        // Create user and call webservice
        public Boolean Create(CustomApplicationUser customUser, string pwd)
        {
            bool success = true;

            // add password in user
            customUser.PasswordHash = pwd;

            // convert into Contract
            UtilisateurContract user = UserAdapter.fromCustomApplicationUser(customUser);

            // call webservice 
            try
            {
                m_webService.CreateUtilisateur(user);
            }
            catch (Exception)
            {
                success = false;
            }
            
            // well created
            return success;
        }

        public int GetUserPoints(string username)
        {
            return m_webService.GetUserPoints(username);
        }

        public void SetPoints(string username, int points)
        {
            m_webService.UpdateUserPoint(username, points);
        }

        public void ResetUserPoint(string username)
        {
            m_webService.ResetUserPoint(username);
        }

        // Create identity (and add in cookie)
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