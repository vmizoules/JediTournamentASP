using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JediService.Models
{
    /// <summary>
    /// Énumération des différentes phases possible lors d'un tournoi.
    /// </summary>
    [DataContract(Name = "EPhaseTournoiContract")]
    public enum EPhaseTournoiContract
    {
        [EnumMember]
        QuartFinale,
        [EnumMember]
        DemiFinale,
        [EnumMember]
        Finale
    }

    /// <summary>
    /// Classe de contrat Match pour le Web Service.
    /// </summary>
    [DataContract]
    public class MatchContract : EntityContract
    {
        private int m_idVainqueur;
        private JediContract m_jedi1;
        private JediContract m_jedi2;
        private EPhaseTournoiContract m_phase;
        private StadeContract m_stade;

        /// <summary>
        /// Id du jedi vainqueur. Si égale à -1 alors le match n'as pa été joué.
        /// </summary>
        [DataMember]
        public int IdVainqueur
        {
            get { return m_idVainqueur; }
            set { m_idVainqueur = value; }
        }
        /// <summary>
        /// Premier combattant Jedi.
        /// </summary>
        [DataMember]
        public JediContract Jedi1
        {
            get { return m_jedi1; }
            set { m_jedi1 = value; }
        }
        /// <summary>
        /// Second combattant Jedi.
        /// </summary>
        [DataMember]
        public JediContract Jedi2
        {
            get { return m_jedi2; }
            set { m_jedi2 = value; }
        }
        /// <summary>
        /// Phase du tournoi associé au match.
        /// </summary>
        [DataMember]
        public EPhaseTournoiContract PhaseTournoi
        {
            get { return m_phase; }
            set { m_phase = value; }
        }
        /// <summary>
        /// Stade dans lequel à lieu le match.
        /// </summary>
        [DataMember]
        public StadeContract Stade
        {
            get { return m_stade; }
            set { m_stade = value; }
        }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public MatchContract()
            : this(-1, null, null, EPhaseTournoiContract.QuartFinale, null)
        {

        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">identifiant du match.</param>
        /// <param name="jedi1">Premier jedi concurrent.</param>
        /// <param name="jedi2">Second jedi concurrent.</param>
        /// <param name="phase">Phase lors de laquelle se déroule le match.</param>
        /// <param name="stade">Stade dans lequel se déroule le match.</param>
        public MatchContract(int id, JediContract jedi1, JediContract jedi2, EPhaseTournoiContract phase, StadeContract stade)
        {
            m_jedi1 = jedi1;
            m_jedi2 = jedi2;
            m_phase = phase;
            m_stade = stade;
            m_idVainqueur = -1;   // Initialisation de l'ID à -1 => vainqueur non déterminé
        }
    }
}