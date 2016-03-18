using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using JediWebSiteApplication.Manager;
using JediWebSiteApplication.WebServiceReference;

namespace JediWebSiteApplication.Models.SubModels.Pari
{
    public class PreparedBetTournoiModel : PreparedTournoiModel
    {

        public PreparedBetTournoiModel(TournoiModel tournoi, string username, int mise, int idBetJedi)
            : base(tournoi)
        {
            JediWebServiceClient webService = new JediWebServiceClient();
            CustomUserManager manager = new CustomUserManager(webService);

            // L'utilisateur gagne son pari
            if (m_matchs[6].IdVainqueur == idBetJedi)
            {
                manager.UpdateUserPointsByAmount(username, 2 * mise);   // Double sa mise
            }
            // L'utilisateur perd son pari
            else
            {
                manager.UpdateUserPointsByAmount(username, -mise);
            }

            webService.Close();
        }
    }
}