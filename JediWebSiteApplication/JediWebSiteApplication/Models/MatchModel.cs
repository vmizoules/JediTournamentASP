using JediWebSiteApplication.Adapters;
using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Models
{
    /// <summary>
    /// Énumération des différentes phases possible lors d'un tournoi.
    /// </summary>
    public enum EPhaseTournoiModel
    {
        QuartFinale,
        DemiFinale,
        Finale
    }

    public class MatchModel : EntityModel
    {
        /// <summary>
        /// Donne accès à la description du match (jedi 1 - Jedi 2).
        /// </summary>
        [Display(Name = "Affrontement")]
        public String Description
        {
            get
            {
                return Jedi1.Nom + " - " + Jedi2.Nom;
            }
            private set { }
        }

        /// <summary>
        /// Id du jedi vainqueur. Si égale à -1 alors le match n'as pa été joué.
        /// </summary>
        [Display(Name = "ID Vainqueur")]
        public int IdVainqueur { get; set; }

        /// <summary>
        /// Id du jedi vainqueur. Si égale à -1 alors le match n'as pa été joué.
        /// </summary>
        [Display(Name = "Vainqueur")]
        public string Vainqueur
        {
            get
            {
                return IdVainqueur < 0 ? "Non joué" : (IdVainqueur == Jedi1.ID ? Jedi1.Nom : Jedi2.Nom);
            }
            private set { }
        }

        /// <summary>
        /// Premier combattant Jedi.
        /// </summary>
        [Required]
        [Display(Name = "Premier Jedi")]
        public JediModel Jedi1 { get; set; }

        /// <summary>
        /// Second combattant Jedi.
        /// </summary>
        [Required]
        [Display(Name = "Second Jedi")]
        public JediModel Jedi2 { get; set; }

        /// <summary>
        /// Phase du tournoi associé au match.
        /// </summary>
        [Required]
        [Display(Name = "Phase du tournoi")]
        public EPhaseTournoiModel PhaseTournoi { get; set; }

        /// <summary>
        /// Stade dans lequel à lieu le match.
        /// </summary>
        [Required]
        [Display(Name = "Stade")]
        public StadeModel Stade { get; set; }
    }
}