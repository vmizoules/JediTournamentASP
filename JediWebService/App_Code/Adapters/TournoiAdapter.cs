using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntitiesLayer;
using JediService.Models;

namespace JediService.Adapters
{
    /// <summary>
    /// Classe d'adaptation des Tournois.
    /// </summary>
    public class TournoiAdapter
    {
        /// <summary>
        /// Adapte un Tournoi en Tournoi Contract.
        /// </summary>
        /// <param name="tournoiC">Tournoi à adapter.</param>
        /// <returns>Tournoi.</returns>
        public static Tournoi fromTournoiContract(TournoiContract tournoiC)
        {
            Tournoi t = new Tournoi();
            t.Nom = tournoiC.Nom;
            t.Matchs = MatchAdapter.fromMatchContractList(tournoiC.Matchs);

            return t;
        }

        /// <summary>
        /// Adapte un Tournoi en Tournoi Contract.
        /// </summary>
        /// <param name="tournoi">Tournoi à adapter.</param>
        /// <returns>Tournoi contract.</returns>
        public static TournoiContract fromTournoi(Tournoi tournoi)
        {
            TournoiContract tc = new TournoiContract(tournoi.Nom, MatchAdapter.fromMatchList(tournoi.Matchs));
            return tc;
        }
    }
}