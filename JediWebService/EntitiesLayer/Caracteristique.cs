using System;
using EntitiesLayer.Tools;
using System.ComponentModel;

namespace EntitiesLayer
{
    /// <summary>
    /// Énumération des différentes caractéristiques possibles.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum EDefCaracteristique
    {
        [Description("Force")]
        Force,
        [Description("Défense")]
        Defense,
        [Description("Santé")]
        Sante,
        [Description("Chance")]
        Chance
    }

    /// <summary>
    /// Énumération des différents types de caractéristiques possibles.
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ETypeCaracteristique
    {
        [Description("Jedi")]
        Jedi,
        [Description("Stade")]
        Stade
    }

    /// <summary>
    /// Classe Caractéristique.
    /// </summary>
    [Serializable]
    public class Caracteristique : EntityObject
    {
        /// <summary>
        /// Nom de la caractéristique.
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Caractéristique concernée (type d'atout).
        /// </summary>
        public EDefCaracteristique Definition { get; set; }
        /// <summary>
        /// Type de la caractéristique (Entité concernée).
        /// </summary>
        public ETypeCaracteristique Type { get; set; }
        /// <summary>
        /// Valeur de la caractéristique.
        /// </summary>
        public int Valeur { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Caracteristique()
            : this(-1, "Default Name", EDefCaracteristique.Chance, ETypeCaracteristique.Jedi, 0)
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">Id de la caractéristique.</param>
        /// <param name="nom">Nom de la caractéristique.</param>
        /// <param name="definition">Caractéristique concernée.</param>
        /// <param name="type">Type de la caractéristique.</param>
        /// <param name="valeur">Valeur affectée à la caractéristique.</param>
        public Caracteristique(int id, string nom, EDefCaracteristique definition, ETypeCaracteristique type, int valeur) 
            : base(id)
        {
            Nom = nom;
            Definition = definition;
            Type = type;
            Valeur = valeur;
        }

        /// <summary>
        /// Méthode d'affichage.
        /// </summary>
        /// <returns>Affichage d'une caractéristique : Nom Valeur (Definition).</returns>
        public override string ToString()
        {
            return Nom + " " + Valeur + " (" + Definition + ")";
        }
    }
}
