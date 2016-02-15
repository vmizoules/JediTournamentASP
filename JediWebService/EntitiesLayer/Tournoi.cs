using System.Collections.Generic;

namespace EntitiesLayer
{
    public class Tournoi : EntityObject
    {
        /// <summary>
        /// Nom du tournoi.
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Liste des matchs composant le tournoi.
        /// </summary>
        public List<Match> Matchs { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Tournoi()
            : this(-1, "Default Name", null)
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">Id du tournoi.</param>
        /// <param name="nom">Nom du tournoi.</param>
        /// <param name="matchs">Match qui ont eu ou auront lieu pendant le tournoi.</param>
        public Tournoi(int id, string nom, List<Match> matchs) 
            : base(id)
        {
            Nom = nom;
            Matchs = matchs;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
