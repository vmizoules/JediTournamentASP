using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JediService.Models
{
    /// <summary>
    /// Classe de contrat Stade pour le Web Service.
    /// </summary>
    [DataContract]
    public class StadeContract
    {
        public string Nom { get; set; }
        public int NbPlaces { get; set; }
        // TODO, add it ?
        //public List<CaracteristiquesContract> Caracteristiques { get; set; }
        public string Planete { get; set; }
        public string Image { get; set; }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="nom">Nom du stade</param>
        /// <param name="nbPlaces">Nombre de places du stade.</param>
        /// <param name="planete">Nom de la planète sur laquelle se situe le stade.</param>
        /// <param name="imagePath">Chemin vers l'image du stade.</param>
        public StadeContract(string nom, int nbPlaces, string planete, string imagePath)
        {
            Nom = nom;
            NbPlaces = nbPlaces;
            Planete = planete;
            Image = imagePath;

            // TODO : add caracteristiques ?
            //Caracteristiques = carac;

            // TODO : id ?
        }
    }
}