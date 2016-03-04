using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JediService.Models
{
    /// <summary>
    /// Classe de contrat Entity pour le Web Service.
    /// </summary>
    [DataContract]
    public abstract class EntityContract
    {
        private int m_ID;

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
        /// Constructeur par défaut.
        /// </summary>
        public EntityContract()
            : this(-1)
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">Id de l'entité.</param>
        public EntityContract(int id)
        {
            m_ID = id;
        }
    }
}