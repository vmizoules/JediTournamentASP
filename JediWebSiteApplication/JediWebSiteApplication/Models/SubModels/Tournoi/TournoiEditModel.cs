using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models.SubModels
{
    public class TournoiEditModel : TournoiAvailableContentModel
    {
        /// <summary>
        /// Tournoi concerné par l'édition.
        /// </summary>
        private TournoiModel m_tournoi;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="tournoi">Tournoi à éditer.</param>
        /// <param name="mModels">Liste des matchs disponibles.</param>
        public TournoiEditModel(TournoiModel tournoi, List<MatchModel> mModels)
            : base(mModels)
        {
            m_tournoi = tournoi;

            Nom = m_tournoi.Nom;

            // Affecte les sélections
            List<MatchModel> quartFinale = m_tournoi.Matchs.Where(m => m.PhaseTournoi == EPhaseTournoiModel.QuartFinale).ToList();
            if (quartFinale.Count >= 4)
            {
                SelectedMatch1 = quartFinale[0];
                SelectedMatch2 = quartFinale[1];
                SelectedMatch3 = quartFinale[2];
                SelectedMatch4 = quartFinale[3];
            }
        }
    }
}