using JediWebSiteApplication.Models;
using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Adapters
{
    /// <summary>
    /// Classe d'adaptation des Matchs.
    /// </summary>
    public class MatchAdapter
    {
        /// <summary>
        /// Adapte une EPhaseTournoi Contract en EPhaseTournoi Model.
        /// </summary>
        /// <param name="phaseC">EPhaseTournoi Contract à adapter.</param>
        /// <returns>EPhaseTournoi Model.</returns>
        public static EPhaseTournoiModel fromPhaseTournoiContract(EPhaseTournoiContract phaseC)
        {
            switch (phaseC)
            {
                case EPhaseTournoiContract.QuartFinale:
                    return EPhaseTournoiModel.QuartFinale;
                case EPhaseTournoiContract.DemiFinale:
                    return EPhaseTournoiModel.DemiFinale;
                case EPhaseTournoiContract.Finale:
                    return EPhaseTournoiModel.Finale;
                default:
                    return EPhaseTournoiModel.QuartFinale;
            }
        }

        /// <summary>
        /// Adapte un EPhaseTournoi Model en EPhaseTournoi Contract.
        /// </summary>
        /// <param name="phase">EPhaseTournoi Model à adapter.</param>
        /// <returns>EPhaseTournoi contract.</returns>
        public static EPhaseTournoiContract fromPhaseTournoiModel(EPhaseTournoiModel phase)
        {
            switch (phase)
            {
                case EPhaseTournoiModel.QuartFinale:
                    return EPhaseTournoiContract.QuartFinale;
                case EPhaseTournoiModel.DemiFinale:
                    return EPhaseTournoiContract.DemiFinale;
                case EPhaseTournoiModel.Finale:
                    return EPhaseTournoiContract.Finale;
                default:
                    return EPhaseTournoiContract.QuartFinale;
            }
        }

        /// <summary>
        /// Adapte un Match Model en Match Contract.
        /// </summary>
        /// <param name="matchC">Match à adapter.</param>
        /// <returns>Match Model.</returns>
        public static MatchModel fromMatchContract(MatchContract matchC)
        {
            MatchModel m = new MatchModel();
            m.ID = matchC.ID;
            m.IdVainqueur = matchC.IdVainqueur;
            m.Jedi1 = JediAdapter.fromJediContract(matchC.Jedi1);
            m.Jedi2 = JediAdapter.fromJediContract(matchC.Jedi2);
            m.PhaseTournoi = MatchAdapter.fromPhaseTournoiContract(matchC.PhaseTournoi);
            m.Stade = StadeAdapter.fromStadeContract(matchC.Stade);

            return m;
        }

        /// <summary>
        /// Adapte une liste de Match Contract en une liste de Match Model.
        /// </summary>
        /// <param name="matchsC">Liste de Match Contract à adapter.</param>
        /// <returns>Liste de Match Model.</returns>
        public static List<MatchModel> fromMatchContractList(List<MatchContract> matchsC)
        {
            List<MatchModel> listM = new List<MatchModel>();

            foreach (MatchContract mc in matchsC)
            {
                listM.Add(MatchAdapter.fromMatchContract(mc));
            }

            return listM;
        }

        /// <summary>
        /// Adapte un Match Model en Match Contract.
        /// </summary>
        /// <param name="match">Match à adapter.</param>
        /// <returns>Match contract.</returns>
        public static MatchContract fromMatchModel(MatchModel match)
        {
            // Prépare les valeurs
            JediContract jc1 = JediAdapter.fromJediModel(match.Jedi1);
            JediContract jc2 = JediAdapter.fromJediModel(match.Jedi2);
            EPhaseTournoiContract pc = MatchAdapter.fromPhaseTournoiModel(match.PhaseTournoi);
            StadeContract sc = StadeAdapter.fromStadeModel(match.Stade);

            // Crée le MatchContract
            MatchContract mc = new MatchContract();
            mc.ID = match.ID;
            mc.IdVainqueur = match.IdVainqueur;
            mc.Jedi1 = jc1;
            mc.Jedi2 = jc2;
            mc.PhaseTournoi = pc;
            mc.Stade = sc;

            return mc;
        }

        /// <summary>
        /// Adapte une liste de Match Model en une liste de Match Contract.
        /// </summary>
        /// <param name="matchs">Liste de Match à adapter.</param>
        /// <returns>Liste de Match Contract.</returns>
        public static List<MatchContract> fromMatchModelList(List<MatchModel> matchs)
        {
            List<MatchContract> listMC = new List<MatchContract>();

            foreach (MatchModel m in matchs)
            {
                listMC.Add(MatchAdapter.fromMatchModel(m));
            }

            return listMC;
        }
    }
}