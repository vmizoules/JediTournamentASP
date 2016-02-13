using System.Collections.Generic;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe Stade.
    /// </summary>
    public class Stade : EntityObject
    {
        /// <summary>
        /// Nom du Stade.
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Nombre de places du Stade.
        /// </summary>
        public int NbPlaces { get; set; }
        /// <summary>
        /// Planète sur laquelle se trouve le Stade.
        /// </summary>
        public string Planete { get; set; }
        /// <summary>
        /// Liste des caractéristiques.
        /// </summary>
        public List<Caracteristique> Caracteristiques { get; set; }
        /// <summary>
        /// Image resource pour le Stade.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Stade()
            : this(0, "Default Name", 100, "Default Planete", null, "")
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">Id du stade.</param>
        /// <param name="nbPlaces">Nombre de places du stade.</param>
        /// <param name="planete">Nom de la planète sur laquelle se situe le stade.</param>
        /// <param name="carac">Caractéritiques associées au stade.</param>
        /// <param name="imagePath">Chemin vers l'image du stade.</param>
        public Stade(int id, string nom, int nbPlaces, string planete, List<Caracteristique> carac, string imagePath) 
            : base(id)
        {
            Nom = nom;
            NbPlaces = nbPlaces;
            Planete = planete;
            Caracteristiques = carac;
            Image = imagePath;
        }

        public override string ToString()
        {
            return Nom + " (" + Planete + ")";
        }
    }
}
