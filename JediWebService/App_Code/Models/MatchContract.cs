using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JediService.Models
{
    /// <summary>
    /// Classe de contrat Match pour le Web Service.
    /// </summary>
    [DataContract]
    public class MatchContract
    {
        public int IdJediVainqueur { get; set; }
        public JediContract Jedi1 { get; set; }
        public JediContract Jedi2 { get; set; }
        // TODO : add it ? -> PhaseTournoi
        public StadeContract Stade { get; set; }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">Id du match.</param>
        /// <param name="jedi1">Premier jedi concurrent.</param>
        /// <param name="jedi2">Second jedi concurrent.</param>
        /// <param name="phase">Phase lors de laquelle se déroule le match.</param>
        /// <param name="stade">Stade dans lequel se déroule le match.</param>
        public MatchContract(JediContract jedi1, JediContract jedi2, StadeContract stade)
        {
            Jedi1 = jedi1;
            Jedi2 = jedi2;
            Stade = stade;
            IdJediVainqueur = -1;   // Initialisation de l'ID à -1 => vainqueur non déterminé
            
            // TODO : add it ?
            //PhaseTournoi = phase;

            // TODO : id ?
        }

    }
}