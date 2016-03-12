using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediWebSiteApplication.Models.SubModels
{
    public class TournoiAvailableContentModel
    {
        /// <summary>
        /// Liste des matchs disponibles.
        /// </summary>
        private readonly List<MatchModel> m_availableMatchs;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="mModels">Liste des matchs disponibles.</param>
        public TournoiAvailableContentModel(List<MatchModel> mModels)
        {
            m_availableMatchs = mModels;
        }

        /// <summary>
        /// Nom du tournoi.
        /// </summary>
        [Required]
        [Display(Name = "Nom du tournoi")]
        public string Nom { get; set; }

        /// <summary>
        /// Premier Quart de Finale.
        /// </summary>
        [Required]
        [Display(Name = "Premier Quart de Finale")]
        public MatchModel SelectedMatch1 { get; set; }

        /// <summary>
        /// Premier Quart de Finale.
        /// </summary>
        [Required]
        [Display(Name = "Second Quart de Finale")]
        public MatchModel SelectedMatch2 { get; set; }

        /// <summary>
        /// Premier Quart de Finale.
        /// </summary>
        [Required]
        [Display(Name = "Troisième Quart de Finale")]
        public MatchModel SelectedMatch3{ get; set; }

        /// <summary>
        /// Premier Quart de Finale.
        /// </summary>
        [Required]
        [Display(Name = "Quatrième Quart de Finale")]
        public MatchModel SelectedMatch4 { get; set; }

        /// <summary>
        /// Liste des matchs disponibles.
        /// </summary>
        public IEnumerable<SelectListItem> Matchs
        {
            get
            {
                IEnumerable<SelectListItem> allMatchs = m_availableMatchs.Select(m => new SelectListItem
                                                                                {
                                                                                    Value = m.ID.ToString(),
                                                                                    Text = m.Description
                                                                                });

                return allMatchs;
            }
        }

        /// <summary>
        /// Gère la valeur par défaut du champ du formulaire pour la liste des matchs.
        /// </summary>
        public string DefaultMatch
        {
            get { return "Choisir un match"; }
        }
    }
}