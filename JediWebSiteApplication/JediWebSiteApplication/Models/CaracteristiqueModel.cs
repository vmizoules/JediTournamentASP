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
    /// Énumération des différentes caractéristiques possibles.
    /// </summary>
    public enum EDefCaracteristiqueModel
    {
        Force,
        Defense,
        Sante,
        Chance
    }

    /// <summary>
    /// Énumération des différents types de caractéristiques possibles.
    /// </summary>
    public enum ETypeCaracteristiqueModel
    {
        Jedi,
        Stade
    }

    /// <summary>
    /// Classe de Model caractéristique.
    /// </summary>
    public class CaracteristiqueModel
    {
        /// <summary>
        /// ID de la caractéristique.
        /// </summary>
        [Display(Name = "ID de la caractéristique")]
        public int ID { get; set; }

        /// <summary>
        /// Nom de la caractéristique.
        /// </summary>
        [Required]
        [Display(Name = "Nom de la caractéristique")]
        public string Nom {  get; set; }

        /// <summary>
        /// Caractéristique concernée (type d'atout).
        /// </summary>
        [Required]
        [Display(Name = "Définition de la caractéristique")]
        public EDefCaracteristiqueModel Definition { get; set; }

        /// <summary>
        /// Type de la caractéristique (Entité concernée).
        /// </summary>
        [Required]
        [Display(Name = "Type de la caractéristique")]
        public ETypeCaracteristiqueModel Type { get; set; }

        /// <summary>
        /// Valeur de la caractéristique.
        /// </summary>
        [Required]
        [Display(Name = "Valeur de la caractéristique")]
        public int Valeur { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public CaracteristiqueModel()
            : this(-1, "Default Name", EDefCaracteristiqueContract.Chance, ETypeCaracteristiqueContract.Jedi, 0)
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="nom">Nom de la caractéristique.</param>
        /// <param name="definition">Caractéristique concernée.</param>
        /// <param name="type">Type de la caractéristique.</param>
        /// <param name="valeur">Valeur affectée à la caractéristique.</param>
        public CaracteristiqueModel(int id, string nom, EDefCaracteristiqueContract def, ETypeCaracteristiqueContract type, int val)
        {
            ID = id;
            Nom = nom;
            Definition = CaracteristiqueAdapter.fromDefCaracteristiqueContract(def);
            Type = CaracteristiqueAdapter.fromTypeCaracteristiqueContract(type);
            Valeur = val;
        }
    }
}