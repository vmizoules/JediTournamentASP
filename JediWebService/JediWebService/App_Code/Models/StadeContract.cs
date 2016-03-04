using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JediService.Models
{
    /// <summary>
    /// Classe de contrat Stade pour le Web Service.
    /// </summary>
    [DataContract]
    public class StadeContract : EntityContract
    {
        private string m_nom;
        private int m_nbPlaces;
        private string m_planete;
        private List<CaracteristiqueContract> m_caracs;

        /// <summary>
        /// Nom du Stade.
        /// </summary>
        [DataMember]
        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }

        /// <summary>
        /// Nombre de places du stade.
        /// </summary>
        [DataMember]
        public int NbPlaces
        {
            get { return m_nbPlaces; }
            set { m_nbPlaces = value; }
        }

        /// <summary>
        /// Nom de la planète sur laquelle se trouve le Stade.
        /// </summary>
        [DataMember]
        public string Planete
        {
            get { return m_planete; }
            set { m_planete = value; }
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
        public StadeContract()
            : this(-1, "Default Name", 100, "Default Planete", null)
        {
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="id">ID du stade</param>
        /// <param name="nom">Nom du stade</param>
        /// <param name="nbPlaces">Nombre de places du stade.</param>
        /// <param name="planete">Nom de la planète sur laquelle se situe le stade.</param>
        public StadeContract(int id, string nom, int nbPlaces, string planete, List<CaracteristiqueContract> caracs)
            : base(id)
        {
            m_nbPlaces = nbPlaces;
            m_nom = nom;
            m_planete = planete;
            m_caracs = caracs;
        }
    }
}