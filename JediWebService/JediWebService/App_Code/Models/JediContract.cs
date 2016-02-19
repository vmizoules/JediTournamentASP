using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JediService.Models
{
    /// <summary>
    /// Classe de contrat Jedi pour le Web Service.
    /// </summary>
    [DataContract]
    public class JediContract
    {
        private int m_ID;
        private bool m_isSith;
        private string m_nom;
        private List<CaracteristiqueContract> m_caracs;

        /// <summary>
        /// ID du jedi.
        /// </summary>
        [DataMember]
        public int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }

        /// <summary>
        /// Indique si le jedi est un sith ou non.
        /// </summary>
        [DataMember]
        public bool IsSith
        {
            get { return m_isSith; }
            set { m_isSith = value; }
        }

        /// <summary>
        /// Nom du Jedi.
        /// </summary>
        [DataMember]
        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }

        /// <summary>
        /// Liste des caractéristiques.
        /// </summary>
        [DataMember]
        public List<CaracteristiqueContract> Caracteristiques
        {
            get { return m_caracs; }
            set { m_caracs = value; }
        }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public JediContract()
            : this(-1, false, "Default Name", null)
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="nom">Nom du jedi.</param>
        /// <param name="isSith">Booléen indiquant si c'est un sith ou non.</param>
        public JediContract(int id, bool isSith, string nom, List<CaracteristiqueContract> caracs)
        {
            m_ID = id;
            m_isSith = isSith;
            m_nom = nom;
            m_caracs = caracs;
        }
    }
}