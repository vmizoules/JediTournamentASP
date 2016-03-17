using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models.SubModels
{
    public class MatchEditModel : MatchAvailableContentModel
    {
        /// <summary>
        /// Match concerné par l'édition.
        /// </summary>
        private MatchModel m_match;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="match">Match à éditer.</param>
        /// <param name="jModels">Liste des jedis disponibles.</param>
        /// <param name="sModels">Liste des stades disponibles.</param>
        public MatchEditModel(MatchModel match, List<JediModel> jModels, List<StadeModel> sModels)
            : base(jModels, sModels)
        {
            m_match = match;
            SelectedJedi1 = m_match.Jedi1;
            SelectedJedi2 = m_match.Jedi2;
            SelectedStade = m_match.Stade;
        }
    }
}