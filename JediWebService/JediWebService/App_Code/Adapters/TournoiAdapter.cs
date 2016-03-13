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
        /// Adapte un Tournoi Contract en Tournoi.
        /// </summary>
        /// <param name="tournoiC">Tournoi à adapter.</param>
        /// <returns>Tournoi.</returns>
        public static Tournoi fromTournoiContract(TournoiContract tournoiC)
        {
            if (tournoiC == null)
                return null;

            Tournoi t = new Tournoi();
            t.ID = tournoiC.ID;
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
            if (tournoi == null)
                return null;

            TournoiContract tc = new TournoiContract(tournoi.ID, tournoi.Nom, MatchAdapter.fromMatchList(tournoi.Matchs));
            return tc;
        }
    }
}