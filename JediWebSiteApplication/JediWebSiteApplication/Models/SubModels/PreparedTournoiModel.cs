using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models.SubModels
{
    public class PreparedTournoiModel
    {
        private TournoiModel m_tournoi;
        private List<MatchModel> m_matchs;

        public PreparedTournoiModel(TournoiModel tournoi)
        {
            m_tournoi = tournoi;
            m_matchs = new List<MatchModel>();
            
            // Ajoute et calcul les 4 premiers matchs (Quart de finale)
            m_matchs.AddRange(m_tournoi.Matchs.Where(m => m.PhaseTournoi == EPhaseTournoiModel.QuartFinale));
            foreach (MatchModel m in m_matchs)
            {
                computeMatch(m);
            }

            // Calcul des 2 matchs (Demi finale)
            for (int i = 0 ; i < 2; i++)
            {
                MatchModel mm = new MatchModel();
                mm.PhaseTournoi = EPhaseTournoiModel.DemiFinale;
                affectMatchMainData(mm, m_matchs[2 * i], m_matchs[2 * i + 1], null);
                // Fait jouer le match
                computeMatch(mm);

                m_matchs.Add(mm);
            }

            // Calcul du dernier match (Finale)
            MatchModel mFinale = new MatchModel();
            mFinale.PhaseTournoi = EPhaseTournoiModel.Finale;
            affectMatchMainData(mFinale, m_matchs[4], m_matchs[5], null);
            // Fait jouer le match
            computeMatch(mFinale);

            m_matchs.Add(mFinale);
        }

        private void affectMatchMainData(MatchModel m, MatchModel p1, MatchModel p2, StadeModel s)
        {
            // Affecte le jedi 1 gagant du précédent match
            int idWinner1 = p1.IdVainqueur;
            m.Jedi1 = idWinner1 == p1.Jedi1.ID ? p1.Jedi1 : p1.Jedi2;

            // Affecte le jedi 2 gagant du précédent match
            int idWinner2 = p2.IdVainqueur;
            m.Jedi2 = idWinner2 == p2.Jedi1.ID ? p2.Jedi1 : p2.Jedi2;

            // Stade
            m.Stade = s; // Non utile pour l'affichage donc non affecté

            m.ID = -2;
        }

        public void computeMatch(MatchModel match)
        {
            match.IdVainqueur = match.Jedi1.ID; // TODO real compute
        }

        public List<MatchModel> Matchs
        {
            get { return m_matchs; }
            private set { }
        }
    }
}