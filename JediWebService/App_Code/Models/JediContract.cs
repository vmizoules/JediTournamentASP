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
        private bool m_isSith;
        private string m_nom;

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
        /// Constructeur par défaut.
        /// </summary>
        public JediContract()
            : this(false, "Default")
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        public JediContract(bool isSith, string nom)
        {
            m_isSith = isSith;
            m_nom = nom;
        }
    }
}