using System.Collections.Generic;
using EntitiesLayer;

namespace DataAccessLayer
{
    /// <summary>
    /// Interface pont pour l'implémentation d'accès aux données.
    /// </summary>
    interface Bridge
    {
        #region "Liés aux Jedis"
        /// <summary>
        /// Permet d'obtenir la liste de tous les jedis connus.
        /// </summary>
        /// <returns>Liste des jedis.</returns>
        List<Jedi> GetAllJedis();
        /// <summary>
        /// Crée un nouveau jedi.
        /// </summary>
        /// <param name="jedi">Jedi à créer.</param>
        void CreateJedi(Jedi jedi);
        /// <summary>
        /// Met à jour le jedi en paramètre.
        /// </summary>
        /// <param name="jedi">Jedi à modifier.</param>
        void UpdateJedi(Jedi jedi);
        /// <summary>
        /// Supprime le jedi passé en paramètre.
        /// </summary>
        /// <param name="jedi">Jedi à supprimer.</param>
        void DeleteJedi(Jedi jedi);
        #endregion

        #region "Liés aux Stades"
        /// <summary>
        /// Permet d'obtenir la liste de tous les stades connus.
        /// </summary>
        /// <returns>Liste des stades.</returns>
        List<Stade> GetAllStades();
        /// <summary>
        /// Crée un nouveau stade.
        /// </summary>
        /// <param name="stade">Stade à créer.</param>
        void CreateStade(Stade stade);
        /// <summary>
        /// Met à jour le stade en paramètre.
        /// </summary>
        /// <param name="stade">Stade à modifier.</param>
        void UpdateStade(Stade stade);
        /// <summary>
        /// Supprime le stade passé en paramètre.
        /// </summary>
        /// <param name="stade">Stade à supprimer.</param>
        void DeleteStade(Stade stade);
        #endregion

        #region "Liés aux Matchs"
        /// <summary>
        /// Permet d'obtenir la liste de tous les matchs connus.
        /// </summary>
        /// <returns>Liste des matchs.</returns>
        List<Match> GetAllMatchs();
        /// <summary>
        /// Crée un nouveau match.
        /// </summary>
        /// <param name="match">Match à créer.</param>
        void CreateMatch(Match match);
        /// <summary>
        /// Met à jour le match en paramètre.
        /// </summary>
        /// <param name="match">Match à modifier.</param>
        void UpdateMatch(Match match);
        /// <summary>
        /// Supprime le match passé en paramètre.
        /// </summary>
        /// <param name="match">Match à supprimer.</param>
        void DeleteMatch(Match match);
        #endregion

        #region "Liés aux Caractéristiques"
        /// <summary>
        /// Permet d'obtenir la liste de toutes les caractéristiques enregistrées.
        /// </summary>
        /// <returns>Liste des caractéritiques.</returns>
        List<Caracteristique> GetAllCaracs();
        /// <summary>
        /// Permet d'obtenir la liste des caractéristiques de jedi enregistrées.
        /// </summary>
        /// <returns>Liste des caractéritiques.</returns>
        List<Caracteristique> GetAllJediCaracs();
        /// <summary>
        /// Permet d'obtenir la liste des caractéristiques de stade enregistrées.
        /// </summary>
        /// <returns>Liste des caractéritiques.</returns>
        List<Caracteristique> GetAllStadeCaracs();
        /// <summary>
        /// Crée une nouvelle caractéristique.
        /// </summary>
        /// <param name="carac">Caractéristique à créer.</param>
        void CreateCarac(Caracteristique carac);
        /// <summary>
        /// Met à jour la caractéristique en paramètre.
        /// </summary>
        /// <param name="carac">Caractéristique à modifier.</param>
        void UpdateCarac(Caracteristique carac);
        /// <summary>
        /// Supprime la caractéristique passé en paramètre.
        /// </summary>
        /// <param name="carac">Caractéristique à supprimer.</param>
        void DeleteCarac(Caracteristique carac);
        #endregion

        #region "Liés aux Tournois"
        /// Permet d'obtenir le tournoi avec l'id correspondant.
        /// </summary>
        /// <param name="id">Id du tournoi.</param>
        /// <returns>Tournoi correspondant.</returns>
        Tournoi GetTournoi(int id);
        /// <summary>
        /// Permet d'obtenir la liste de tous les tournois connus.
        /// </summary>
        /// <returns>Liste des tournois.</returns>
        List<Tournoi> GetAllTournois();
        /// <summary>
        /// Permet d'obtenir la liste de tous les tournois connus n'ayant pas étaient joués.
        /// </summary>
        /// <returns>Liste des tournois non joués.</returns>
        List<Tournoi> GetGoodTournois();
        /// <summary>
        /// Crée un nouveau tournoi.
        /// </summary>
        /// <param name="tournoi">Tournoi à créer.</param>
        void CreateTournoi(Tournoi tournoi);
        /// <summary>
        /// Met à jour le tournoi en paramètre.
        /// </summary>
        /// <param name="tournoi">Tournoi à modifier.</param>
        void UpdateTournoi(Tournoi tournoi);
        /// <summary>
        /// Supprime le tournoi passé en paramètre.
        /// </summary>
        /// <param name="tournoi">Tournoi à supprimer.</param>
        void DeleteTournoi(Tournoi tournoi);
        #endregion

        #region "Liés aux Users"
        /// <summary>
        /// Permet de récupérer un utilisateur par login.
        /// </summary>
        /// <param name="login">Login de l'utilisateur à récupérer.</param>
        /// <returns>Utilisateur correspondant.</returns>
        Utilisateur GetUtilisateurByLogin(string login);
        /// <summary>
        /// Crée un nouvel utilisateur.
        /// </summary>
        /// <param name="user">Utilisateur à créer.</param>
        void CreateUser(Utilisateur user);
        /// <summary>
        /// Met à jour l'utilisateur en paramètre.
        /// </summary>
        /// <param name="user">Utilisateur à modifier.</param>
        void UpdateUser(Utilisateur user);
        /// <summary>
        /// Supprime l'utilisateur passé en paramètre.
        /// </summary>
        /// <param name="user">Utilisateur à supprimer.</param>
        void DeleteUser(Utilisateur user);
        #endregion
    }
}
