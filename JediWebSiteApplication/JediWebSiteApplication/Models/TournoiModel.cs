using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models
{
    /// <summary>
    /// Classe de model Tournoi pour le Web Service.
    /// </summary>
    public class TournoiModel : EntityModel
    {
        /// <summary>
        /// Nom du tournoi.
        /// </summary>
        [Required]
        [Display(Name = "Nom du tournoi")]
        public string Nom { get; set; }

        /// <summary>
        /// Liste des matchs composant le tournoi.
        /// </summary>
        [Required]
        [Display(Name = "Matchs")]
        public List<MatchModel> Matchs { get; set; }
    }
}