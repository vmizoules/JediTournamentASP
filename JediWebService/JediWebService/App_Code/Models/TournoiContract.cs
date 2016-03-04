using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JediService.Models
{
    /// <summary>
    /// Classe de contrat Tournoi pour le Web Service.
    /// </summary>
    [DataContract]
    public class TournoiContract : EntityContract
    {
        private string m_nom;
        private List<MatchContract> m_matchs;

        /// <summary>
        /// Nom du tournoi.
        /// </summary>
        [DataMember]
        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }
        /// <summary>
        /// Liste des matchs composant le tournoi.
        /// </summary>
        [DataMember]
        public List<MatchContract> Matchs
        {
            get { return m_matchs; }
            set { m_matchs = value; }
        }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public TournoiContract()
            : this("Default Name", null)
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="nom">Nom du tournoi.</param>
        /// <param name="matchs">Match qui ont eu ou auront lieu pendant le tournoi.</param>
        public TournoiContract(string nom, List<MatchContract> matchs) 
        {
            m_nom = nom;
            m_matchs = matchs;
        }
    }
}