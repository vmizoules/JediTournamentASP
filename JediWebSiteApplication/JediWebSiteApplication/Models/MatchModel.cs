﻿using JediWebSiteApplication.Adapters;
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
        /// Id du jedi vainqueur. Si égale à -1 alors le match n'as pa été joué.
        /// </summary>
        [Required]
        [Display(Name = "Vainqueur")]
        public int IdVainqueur { get; set; }

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