using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models.SubModels
{
    public class TournoiDetailsModel
    {
        /// <summary>
        /// Tournoi sur lequel on obtient les détails.
        /// </summary>
        private TournoiModel m_tournoi;
        /// <summary>
        /// Ensemble des matchs de quart de finales.
        /// </summary>
        private List<MatchModel> m_quartFinales;
        /// <summary>
        /// Ensemble des matchs de demi finales.
        /// </summary>
        private List<MatchModel> m_demiFinales;
        /// <summary>
        /// Match de finale.
        /// </summary>
        private MatchModel m_finale;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="tm">Tournoi concerné</param>
        public TournoiDetailsModel(TournoiModel tm)
        {
            m_tournoi = tm;

            m_quartFinales = m_tournoi.Matchs.Where(m => m.PhaseTournoi == EPhaseTournoiModel.QuartFinale).ToList();
            m_demiFinales = m_tournoi.Matchs.Where(m => m.PhaseTournoi == EPhaseTournoiModel.DemiFinale).ToList();
            if (m_demiFinales.Count <= 0)
                m_demiFinales = null;
            m_finale = m_tournoi.Matchs.Where(m => m.PhaseTournoi == EPhaseTournoiModel.Finale).SingleOrDefault();
        }

        /// <summary>
        /// Propriété d'accès au tournoi.
        /// </summary>
        public TournoiModel Tournoi
        {
            get { return m_tournoi; }
            private set { }
        }

        /// <summary>
        /// Propriété d'accès aux matchs de quart de finale.
        /// </summary>
        public List<MatchModel> QuartFinales
        {
            get { return m_quartFinales; }
            private set { }
        }

        /// <summary>
        /// Propriété d'accès aux matchs de demi de finale.
        /// </summary>
        public List<MatchModel> DemiFinales
        {
            get { return m_demiFinales; }
            private set { }
        }

        /// <summary>
        /// Propriété d'accès au match de la finale.
        /// </summary>
        public MatchModel Finale
        {
            get { return m_finale; }
            private set { }
        }
    }
}