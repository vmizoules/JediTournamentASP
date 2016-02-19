using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models
{
    public class StadeModel
    {
        /// <summary>
        /// ID du stade.
        /// </summary>
        [Display(Name = "ID du stade")]
        public int ID { get; set; }

        /// <summary>
        /// Nom du stade.
        /// </summary>
        [Required]
        [Display(Name = "Nom du stade")]
        public string Nom { get; set; }

        /// <summary>
        /// Nombre de places du stade.
        /// </summary>
        [Required]
        [Display(Name = "Nombre de places")]
        public int NbPlaces { get; set; }

        /// <summary>
        /// Nom de la planète sur laquelle se trouve le Stade.
        /// </summary>
        [Required]
        [Display(Name = "Planète")]
        public string Planete { get; set; }

        /// <summary>
        /// Liste des caractéristiques.
        /// </summary>
        [Display(Name = "Caractéristiques du stade")]
        public List<CaracteristiqueModel> Caracteristiques { get; set; }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="stadeC">Stade contract.</param>
        public StadeModel(StadeContract stadeC)
        {
            //ID = stadeC.ID;
            ID = -1;
            Nom = stadeC.Nom;
            NbPlaces = stadeC.NbPlaces;
            Planete = stadeC.Planete;

            List<CaracteristiqueModel> listCaracs = new List<CaracteristiqueModel>();
            foreach (CaracteristiqueContract cc in stadeC.Caracteristiques)
            {
                listCaracs.Add(new CaracteristiqueModel(cc));
            }

            Caracteristiques = listCaracs;
        }
    }
}