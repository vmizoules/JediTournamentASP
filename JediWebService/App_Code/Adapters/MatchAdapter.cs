using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntitiesLayer;
using JediService.Models;

namespace JediService.Adapters
{
    /// <summary>
    /// Classe d'adaptation des Matchs.
    /// </summary>
    public class MatchAdapter
    {
        /// <summary>
        /// Adapte une EPhaseTournoi Contract en EPhaseTournoi.
        /// </summary>
        /// <param name="phaseC">EPhaseTournoi Contract à adapter.</param>
        /// <returns>EPhaseTournoi.</returns>
        public static EPhaseTournoi fromPhaseTournoiContract(EPhaseTournoiContract phaseC)
        {
            switch(phaseC)
            {
                case EPhaseTournoiContract.QuartFinale:
                    return EPhaseTournoi.QuartFinale;
                case EPhaseTournoiContract.DemiFinale:
                    return EPhaseTournoi.DemiFinale;
                case EPhaseTournoiContract.Finale:
                    return EPhaseTournoi.Finale;
                default:
                    return EPhaseTournoi.QuartFinale;
            }
        }

        /// <summary>
        /// Adapte un EPhaseTournoi en EPhaseTournoi Contract.
        /// </summary>
        /// <param name="phase">EPhaseTournoi à adapter.</param>
        /// <returns>EPhaseTournoi contract.</returns>
        public static EPhaseTournoiContract fromPhaseTournoi(EPhaseTournoi phase)
        {
            switch (phase)
            {
                case EPhaseTournoi.QuartFinale:
                    return EPhaseTournoiContract.QuartFinale;
                case EPhaseTournoi.DemiFinale:
                    return EPhaseTournoiContract.DemiFinale;
                case EPhaseTournoi.Finale:
                    return EPhaseTournoiContract.Finale;
                default:
                    return EPhaseTournoiContract.QuartFinale;
            }
        }

        /// <summary>
        /// Adapte un Match en Match Contract.
        /// </summary>
        /// <param name="matchC">Match à adapter.</param>
        /// <returns>Match.</returns>
        public static Match fromMatchContract(MatchContract matchC)
        {
            Match m = new Match();
            m.IdJediVainqueur = matchC.IdVainqueur;
            m.Jedi1 = JediAdapter.fromJediContract(matchC.Jedi1);
            m.Jedi2 = JediAdapter.fromJediContract(matchC.Jedi2);
            m.PhaseTournoi = MatchAdapter.fromPhaseTournoiContract(matchC.PhaseTournoi);
            m.Stade = StadeAdapter.fromStadeContract(matchC.Stade);

            return m;
        }

        /// <summary>
        /// Adapte une liste de Match Contract en une liste de Match.
        /// </summary>
        /// <param name="matchsC">Liste de Match Contract à adapter.</param>
        /// <returns>Liste de Match.</returns>
        public static List<Match> fromMatchContractList(List<MatchContract> matchsC)
        {
            List<Match> listM = new List<Match>();

            foreach (MatchContract mc in matchsC)
            {
                listM.Add(MatchAdapter.fromMatchContract(mc));
            }

            return listM;
        }

        /// <summary>
        /// Adapte un Match en Match Contract.
        /// </summary>
        /// <param name="match">Match à adapter.</param>
        /// <returns>Match contract.</returns>
        public static MatchContract fromMatch(Match match)
        {
            // Prépare les valeurs
            JediContract jc1 = JediAdapter.fromJedi(match.Jedi1);
            JediContract jc2 = JediAdapter.fromJedi(match.Jedi2);
            EPhaseTournoiContract pc = MatchAdapter.fromPhaseTournoi(match.PhaseTournoi);
            StadeContract sc = StadeAdapter.fromStade(match.Stade);

            // Crée le MatchContract
            MatchContract mc = new MatchContract(jc1, jc2, pc, sc);

            return mc;
        }

        /// <summary>
        /// Adapte une liste de Match en une liste de Match Contract.
        /// </summary>
        /// <param name="matchs">Liste de Match à adapter.</param>
        /// <returns>Liste de Match Contract.</returns>
        public static List<MatchContract> fromMatchList(List<Match> matchs)
        {
            List<MatchContract> listMC = new List<MatchContract>();

            foreach (Match m in matchs)
            {
                listMC.Add(MatchAdapter.fromMatch(m));
            }

            return listMC;
        }
    }
}