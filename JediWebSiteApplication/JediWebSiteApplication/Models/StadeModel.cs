using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models
{
    public class StadeModel : EntityModel
    {
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
    }
}