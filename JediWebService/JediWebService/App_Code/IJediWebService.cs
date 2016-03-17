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
    /// <summary>
    /// Classe du service du Web Service.
    /// </summary>
    [ServiceContract]
    public interface IJediWebService
    {
        // Liste des opérations disponibles dans le Web Service

        #region "Opérations liées aux jedis"
        /// <summary>
        /// Récupère la liste des jedis.
        /// </summary>
        /// <returns>Liste des jedis.</returns>
        [OperationContract]
        List<JediContract> GetJedis();

        /// <summary>
        /// Récupère le jedi associé à l'id en paramètre.
        /// </summary>
        /// <param name="jediID">Id d'un jedi.</param>
        /// <returns>Jedi correspondant à l'id.</returns>
        [OperationContract]
        JediContract GetJediById(int jediID);

        /// <summary>
        /// Création d'un jedi.
        /// </summary>
        /// <param name="jedi">Jedi à créer.</param>
        [OperationContract]
        void CreateJedi(JediContract jedi);

        /// <summary>
        /// Mise à jour d'un jedi.
        /// </summary>
        /// <param name="jedi">Jedi à mettre à jour.</param>
        [OperationContract]
        void UpdateJedi(JediContract jedi);

        /// <summary>
        /// Suppression d'un jedi.
        /// </summary>
        /// <param name="jedi">Jedi à supprimer.</param>
        [OperationContract]
        void DeleteJedi(JediContract jedi);

        /// <summary>
        /// Récupère la liste des caractéristiques associées à l'id de jedi.
        /// </summary>
        /// <param name="jediID">ID du Jedi pour lequel on demande les caractéristiques.</param>
        /// <returns>Liste des caractéristiques associées.</returns>
        [OperationContract]
        List<CaracteristiqueContract> GetCaracteristiques(int jediID);

        #endregion
        #region "Opérations liées aux stades"

        /// <summary>
        /// Création d'un stade.
        /// </summary>
        /// <param name="stade">Stade à créer.</param>
        [OperationContract]
        void CreateStade(StadeContract stade);

        /// <summary>
        /// Mise à jour d'un stade.
        /// </summary>
        /// <param name="stade">Stade à mettre à jour.</param>
        [OperationContract]
        void UpdateStade(StadeContract stade);

        /// <summary>
        /// Suppression d'un stade.
        /// </summary>
        /// <param name="stade">Stade à supprimer.</param>
        [OperationContract]
        void DeleteStade(StadeContract stade);

        /// <summary>
        /// Récupère le stade associé à l'id en paramètre.
        /// </summary>
        /// <param name="stadeID">Id d'un stade.</param>
        /// <returns>Stade correspondant à l'id.</returns>
        [OperationContract]
        StadeContract GetStadeById(int stadeID);

        /// <summary>
        /// Récupère la liste des stades.
        /// </summary>
        /// <returns>Liste des stades.</returns>
        [OperationContract]
        List<StadeContract> GetStades();

        #endregion
        #region "Opérations liées aux matchs"

        /// <summary>
        /// Création d'un match.
        /// </summary>
        /// <param name="match">Match à créer.</param>
        [OperationContract]
        void CreateMatch(MatchContract match);

        /// <summary>
        /// Mise à jour d'un match.
        /// </summary>
        /// <param name="match">Match à mettre à jour.</param>
        [OperationContract]
        void UpdateMatch(MatchContract match);

        /// <summary>
        /// Suppression d'un match.
        /// </summary>
        /// <param name="match">Match à supprimer.</param>
        [OperationContract]
        void DeleteMatch(MatchContract match);

        /// <summary>
        /// Récupère le match associé à l'id en paramètre.
        /// </summary>
        /// <param name="matchID">Id d'un match.</param>
        /// <returns>Match correspondant à l'id.</returns>
        [OperationContract]
        MatchContract GetMatchById(int matchID);

        /// <summary>
        /// Récupère la liste des matchs.
        /// </summary>
        /// <returns>Liste des matchs.</returns>
        [OperationContract]
        List<MatchContract> GetMatchs();

        /// <summary>
        /// Calcul le résultat du match passé en paramètre.
        /// </summary>
        /// <param name="match">Match à jouer.</param>
        /// <returns>Id du jedi vainqueur du match.</returns>
        [OperationContract]
        int ComputeMatchResult(MatchContract match);

        #endregion
        #region "Opérations liées aux tournois"

        /// <summary>
        /// Création d'un tournoi.
        /// </summary>
        /// <param name="tournoi">Tournoi à créer.</param>
        [OperationContract]
        void CreateTournoi(TournoiContract tournoi);

        /// <summary>
        /// Mise à jour d'un tournoi.
        /// </summary>
        /// <param name="tournoi">Tournoi à mettre à jour.</param>
        [OperationContract]
        void UpdateTournoi(TournoiContract tournoi);

        /// <summary>
        /// Suppression d'un tournoi.
        /// </summary>
        /// <param name="tournoi">Tournoi à supprimer.</param>
        [OperationContract]
        void DeleteTournoi(TournoiContract tournoi);

        /// <summary>
        /// Récupère le tournoi associé à l'id en paramètre.
        /// </summary>
        /// <param name="tournoiID">Id d'un tournoi.</param>
        /// <returns>Tournoi correspondant à l'id.</returns>
        [OperationContract]
        TournoiContract GetTournoiById(int tournoiID);

        /// <summary>
        /// Récupère la liste des tournois.
        /// </summary>
        /// <returns>Liste des tournois.</returns>
        [OperationContract]
        List<TournoiContract> GetTournois();

        #endregion
    }
}
