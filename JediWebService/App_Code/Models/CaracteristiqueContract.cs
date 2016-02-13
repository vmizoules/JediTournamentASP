using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JediService.Models
{
    /// <summary>
    /// Énumération des différentes caractéristiques possibles.
    /// </summary>
    [DataContract(Name = "EDefCaracteristiqueContract")]
    public enum EDefCaracteristiqueContract
    {
        [EnumMember]
        Force,
        [EnumMember]
        Defense,
        [EnumMember]
        Sante,
        [EnumMember]
        Chance
    }

    /// <summary>
    /// Énumération des différents types de caractéristiques possibles.
    /// </summary>
    [DataContract(Name = "ETypeCaracteristiqueContract")]
    public enum ETypeCaracteristiqueContract
    {
        [EnumMember]
        Jedi,
        [EnumMember]
        Stade
    }

    /// <summary>
    /// Classe de contrat caractéristique pour le Web Service.
    /// </summary>
    [DataContract]
    public class CaracteristiqueContract
    {
        private string m_nom;
        private EDefCaracteristiqueContract m_definition;
        private ETypeCaracteristiqueContract m_type;
        private int m_valeur;

        /// <summary>
        /// Nom de la caractéristique.
        /// </summary>
        [DataMember]
        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }

        /// <summary>
        /// Caractéristique concernée (type d'atout).
        /// </summary>
        [DataMember]
        public EDefCaracteristiqueContract Definition
        {
            get { return m_definition; }
            set { m_definition = value; }
        }

        /// <summary>
        /// Type de la caractéristique (Entité concernée).
        /// </summary>
        [DataMember]
        public ETypeCaracteristiqueContract Type
        {
            get { return m_type; }
            set { m_type = value; }
        }

        /// <summary>
        /// Valeur de la caractéristique.
        /// </summary>
        [DataMember]
        public int Valeur
        {
            get { return m_valeur; }
            set { m_valeur = value; }
        }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public CaracteristiqueContract()
            : this("Default Name", EDefCaracteristiqueContract.Chance, ETypeCaracteristiqueContract.Jedi, 0)
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="nom">Nom du jedi.</param>
        /// <param name="isSith">Booléen indiquant si c'est un sith ou non.</param>
        public CaracteristiqueContract(string nom, EDefCaracteristiqueContract def, ETypeCaracteristiqueContract type, int val)
        {
            m_nom = nom;
            m_definition = def;
            m_type = type;
            m_valeur = val;
        }
    }
}