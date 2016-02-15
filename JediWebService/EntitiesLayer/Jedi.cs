using System;
using System.Collections.Generic;

namespace EntitiesLayer
{
    /// <summary>
    /// Classe Jedi.
    /// </summary>
    [Serializable]
    public class Jedi : EntityObject
    {
        /// <summary>
        /// Nom du Jedi.
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Indique si le jedi est un sith ou non.
        /// </summary>
        public bool IsSith { get; set; }
        /// <summary>
        /// Propriété transformant le booléen IsSith en texte.
        /// </summary>
        public string JediState
        {
            get { return (IsSith ? "Sith" : "Jedi");  }
            set { JediState = value; }
        }
        /// <summary>
        /// Liste des caractéristiques.
        /// </summary>
        public List<Caracteristique> Caracteristiques { get; set; }
        /// <summary>
        /// Image resource pour le Jedi.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Jedi()
            : this(-1, "Default Name", false, null, "")
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">ID du Jedi.</param>
        /// <param name="nom">Nom du jedi.</param>
        /// <param name="isSith">Booléen indiquant si c'est un sith ou non.</param>
        /// <param name="carac">Caractéristiques du jedi.</param>
        /// <param name="imagePath">Chemin vers l'image du jedi.</param>
        public Jedi(int id, string nom, bool isSith, List<Caracteristique> carac, string imagePath) 
            : base(id)
        {
            Nom = nom;
            IsSith = isSith;
            Caracteristiques = carac;
            Image = imagePath;
        }

        public override string ToString()
        {
            return Nom + " (" + JediState + ")";
        }
    }
}
