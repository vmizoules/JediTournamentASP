using JediWebSiteApplication.Models;
using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Adapters
{
    /// <summary>
    /// Classe d'adaptation des Tournois.
    /// </summary>
    public class TournoiAdapter
    {
        /// <summary>
        /// Adapte un Tournoi Contract en Tournoi Model.
        /// </summary>
        /// <param name="tournoiC">Tournoi à adapter.</param>
        /// <returns>Tournoi Model.</returns>
        public static TournoiModel fromTournoiContract(TournoiContract tournoiC)
        {
            TournoiModel t = new TournoiModel();
            t.ID = tournoiC.ID;
            t.ID = -1;
            t.Nom = tournoiC.Nom;
            t.Matchs = MatchAdapter.fromMatchContractList(tournoiC.Matchs.ToList());

            return t;
        }

        /// <summary>
        /// Adapte un Tournoi Model en Tournoi Contract.
        /// </summary>
        /// <param name="tournoi">Tournoi à adapter.</param>
        /// <returns>Tournoi contract.</returns>
        public static TournoiContract fromTournoi(TournoiModel tournoi)
        {
            TournoiContract tc = new TournoiContract();
            tc.ID = tournoi.ID;
            tc.Nom = tournoi.Nom;
            tc.Matchs = MatchAdapter.fromMatchModelList(tournoi.Matchs).ToArray();

            return tc;
        }
    }
}