using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using JediService.Models;

namespace JediService
{
    [ServiceContract]
    public interface IJediService
    {
        // Liste des opérations disponibles dans le Web Service
        
        /// <summary>
        /// Récupère la liste des jedis.
        /// </summary>
        /// <returns>Liste des jedis.</returns>
        [OperationContract]
        List<JediContract> GetJedis();

        /// <summary>
        /// Création d'un jedi.
        /// </summary>
        /// <param name="jedi">Jedi à créer.</param>
        [OperationContract]
        void CreateJedi(JediContract jedi);

        /// <summary>
        /// Récupère la liste des stades.
        /// </summary>
        /// <returns>Liste des stades.</returns>
        [OperationContract]
        List<StadeContract> GetStades();

        /// <summary>
        /// Récupère la liste des matchs.
        /// </summary>
        /// <returns>Liste des matchs.</returns>
        [OperationContract]
        List<MatchContract> GetMatchs();

        /// <summary>
        /// Récupère la liste des tournois.
        /// </summary>
        /// <returns>Liste des tournois.</returns>
        [OperationContract]
        List<TournoiContract> GetTournois();

        /// <summary>
        /// Récupère la liste des catégories associées à un jedi.
        /// </summary>
        /// <param name="jedi">Jedi pour lequel on demande les catégories.</param>
        /// <returns>Liste des catégories associées.</returns>
        [OperationContract]
        List<CategorieContract> GetCategories(JediContract jedi);
    }


    // TODO maybe remove !
    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
