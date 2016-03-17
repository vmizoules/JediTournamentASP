using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JediWebSiteApplication.Models.SubModels.Pari
{
    public class BetModel
    {
        /// <summary>
        /// Liste des jedis concourrant dans le tournoi (Les occurrences sont uniques).
        /// </summary>
        private List<JediModel> m_availableJedis;

        public BetModel(/* TODO User data */ TournoiModel tournoi)
        {
            IDTournoi = tournoi.ID;
            List<JediModel> tmp = new List<JediModel>();

            // Liste des jedis concourrants
            foreach (MatchModel m in tournoi.Matchs)
            {
                tmp.Add(m.Jedi1);
                tmp.Add(m.Jedi2);
            }

            // Unique occurrence de chacun d'eux
            m_availableJedis = tmp.DistinctBy(j => j.ID).ToList();
        }

        /// <summary>
        /// Id du tournoi sur lequel on pari.
        /// </summary>
        public int IDTournoi { get; set; }

        /// <summary>
        /// Mise de l'utilisateur.
        /// </summary>
        [Required]
        [Display(Name = "Mise ")]
        [Range(0, int.MaxValue)]
        public int Mise { get; set; }

        /// <summary>
        /// Jedi sur lequel on mise.
        /// </summary>
        [Required]
        [Display(Name = "Miser sur ")]
        public JediModel BetJedi { get; set; }

        /// <summary>
        /// Liste de jedis disponibles pour la mise dans le tournoi sélectionné.
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
    }
}