using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediWebSiteApplication.Models.SubModels
{
    public class MatchAvailableContentModel
    {
        /// <summary>
        /// Liste des jedis disponibles.
        /// </summary>
        private readonly List<JediModel> m_availableJedis;
        /// <summary>
        /// Liste des stades disponibles.
        /// </summary>
        private readonly List<StadeModel> m_availableStades;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="jModels">Liste des jedis disponibles.</param>
        /// <param name="sModels">Liste des stades disponibles.</param>
        public MatchAvailableContentModel(List<JediModel> jModels, List<StadeModel> sModels)
        {
            m_availableJedis = jModels;
            m_availableStades = sModels;
        }

        /// <summary>
        /// Premier combattant jedi.
        /// </summary>
        [Required]
        [Display(Name = "Premier Combattant")]
        public JediModel SelectedJedi1 { get; set; }

        /// <summary>
        /// Second combattant jedi.
        /// </summary>
        [Required]
        [Display(Name = "Second Combattant")]
        public JediModel SelectedJedi2 { get; set; }

        /// <summary>
        /// Liste de jedis disponibles.
        /// </summary>
        public IEnumerable<SelectListItem> Jedis
        {
            get
            {
                IEnumerable<SelectListItem> allJedis = m_availableJedis.Select(j => new SelectListItem
                                                                                {
                                                                                    Value = j.ID.ToString(),
                                                                                    Text = j.Nom
                                                                                });
                return allJedis;
            }
        }

        /// <summary>
        /// Gère la valeur par défaut du champ du formulaire pour la liste des jedis.
        /// </summary>
        public string DefaultJedi
        {
            get { return "Choisir un jedi"; }
        }

        /// <summary>
        /// Stade de déroulement du match.
        /// </summary>
        [Required]
        [Display(Name = "Stade")]
        public StadeModel SelectedStade { get; set; }

        /// <summary>
        /// Liste de stades disponibles pour le match.
        /// </summary>
        public IEnumerable<SelectListItem> Stades
        {
            get
            {
                IEnumerable<SelectListItem> allStades = m_availableStades.Select(s => new SelectListItem
                                                                                    {
                                                                                        Value = s.ID.ToString(),
                                                                                        Text = s.Place
                                                                                    });
                return allStades;
            }
        }

        /// <summary>
        /// Gère la valeur par défaut du champ du formulaire pour la liste des stades.
        /// </summary>
        public string DefaultStade
        {
            get { return "Choisir un stade"; }
        }
    }
}