using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models.SubModels
{
    public class PreparedTournoiModel
    {
        /// <summary>
        /// Tournoi à exécuter.
        /// </summary>
        private TournoiModel m_tournoi;
        /// <summary>
        /// Match calculés pour le tournoi.
        /// </summary>
        private List<MatchModel> m_matchs;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="tournoi">Tournoi à traiter.</param>
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
                MatchModel mm = affectMatchMainData(m_matchs[2 * i], m_matchs[2 * i + 1], null);
                mm.PhaseTournoi = EPhaseTournoiModel.DemiFinale;
                // Fait jouer le match
                computeMatch(mm);

                m_matchs.Add(mm);
            }

            // Calcul du dernier match (Finale)
            MatchModel mFinale = affectMatchMainData(m_matchs[4], m_matchs[5], null);
            mFinale.PhaseTournoi = EPhaseTournoiModel.Finale;
            // Fait jouer le match
            computeMatch(mFinale);

            m_matchs.Add(mFinale);
        }

        /// <summary>
        /// Affecte les valeurs principales pour remplir les données d'un match à partir de ses précédents.
        /// </summary>
        /// <param name="p1">Premier match précédent.</param>
        /// <param name="p2">Second match précédent.</param>
        /// <param name="s">Stade dans lequel se déroule le match.</param>
        /// <returns>Match créer à partir des paramètres.</returns>
        private MatchModel affectMatchMainData(MatchModel p1, MatchModel p2, StadeModel s)
        {
            MatchModel m = new MatchModel();

            // Affecte le jedi 1 gagant du précédent match
            int idWinner1 = p1.IdVainqueur;
            m.Jedi1 = idWinner1 == p1.Jedi1.ID ? p1.Jedi1 : p1.Jedi2;

            // Affecte le jedi 2 gagant du précédent match
            int idWinner2 = p2.IdVainqueur;
            m.Jedi2 = idWinner2 == p2.Jedi1.ID ? p2.Jedi1 : p2.Jedi2;

            // Stade
            m.Stade = s; // Non utile pour l'affichage donc non affecté

            m.ID = -2;

            return m;
        }

        /// <summary>
        /// Calcul le résultat d'un match.
        /// </summary>
        /// <param name="match">Match à calculer.</param>
        public void computeMatch(MatchModel match)
        {
            Random r = new Random();

            // Affecte le vainqueur
            if (/* Jedi 1*/ r.Next(100) > r.Next(100) /* Jedi 2 */) 
                match.IdVainqueur = match.Jedi1.ID;
            else
                match.IdVainqueur = match.Jedi2.ID;
        }

        /// <summary>
        /// Propriété d'accès aux matchs calculés par le gestionnaire du tournoi.
        /// </summary>
        public List<MatchModel> Matchs
        {
            get { return m_matchs; }
            private set { }
        }
    }
}