using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models
{
    public class JediModel : EntityModel
    {
        /// <summary>
        /// Nom du jedi.
        /// </summary>
        [Required]
        [Display(Name = "Nom du jedi")]
        public string Nom { get; set; }

        /// <summary>
        /// Indique si le jedi est un sith ou non.
        /// </summary>
        [Required]
        [Display(Name = "Status jedi")]
        public bool IsSith { get; set; }

        /// <summary>
        /// Liste des caractéristiques.
        /// </summary>
        [Display(Name = "Caractéristiques du jedi")]
        public List<CaracteristiqueModel> Caracteristiques { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}