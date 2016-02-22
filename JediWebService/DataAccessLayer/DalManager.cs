using System.Collections.Generic;
using EntitiesLayer;
using DataAccessLayer.Implementations;

namespace DataAccessLayer
{
    /// <summary>
    /// Classe Singleton.
    /// </summary>
    public class DalManager
    {
        /// <summary>
        /// Bridge vers le SGBD utilisé.
        /// </summary>
        private Bridge m_bridge;

        /// <summary>
        /// Instance unique.
        /// </summary>
        private static DalManager _instance;

        /// <summary>
        /// Mutex.
        /// </summary>
        private static readonly object _padlock = new object();

        /// <summary>
        /// Constructeur.
        /// </summary>
        private DalManager()
        {
            //m_bridge = new ImplementationStub();
            m_bridge = new ImplementationAzure();
        }

        /// <summary>
        /// Récupération de l'instance.
        /// </summary>
        public static DalManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DalManager();
                        }
                    }
                }
                return _instance;
            }

            private set { _instance = value; }
        }

        #region "Liés aux Jedis"

        /// <summary>
        /// Permet d'obtenir la liste de tous les jedis connus.
        /// </summary>
        /// <returns>Liste des jedis.</returns>
        public List<Jedi> GetAllJedis()
        {
            return m_bridge.GetAllJedis();
        }

        /// <summary>
        /// Crée un nouveau jedi.
        /// </summary>
        /// <param name="jedi">Jedi à créer.</param>
        public void CreateJedi(Jedi jedi)
        {
            m_bridge.CreateJedi(jedi);
        }

        /// <summary>
        /// Met à jour le jedi en paramètre.
        /// </summary>
        /// <param name="jedi">Jedi à modifier.</param>
        public void UpdateJedi(Jedi jedi)
        {
            m_bridge.UpdateJedi(jedi);
        }

        /// <summary>
        /// Supprime le jedi passé en paramètre.
        /// </summary>
        /// <param name="jedi">Jedi à supprimer.</param>
        public void DeleteJedi(Jedi jedi)
        {
            m_bridge.DeleteJedi(jedi);
        }

        #endregion

        #region "Liés aux Stades"

        /// <summary>
        /// Permet d'obtenir la liste de tous les stades connus.
        /// </summary>
        /// <returns>Liste des stades.</returns>
        public List<Stade> GetAllStades()
        {
            return m_bridge.GetAllStades();
        }

        /// <summary>
        /// Crée un nouveau stade.
        /// </summary>
        /// <param name="stade">Stade à créer.</param>
        public void CreateStade(Stade stade)
        {
            m_bridge.CreateStade(stade);
        }

        /// <summary>
        /// Met à jour le stade en paramètre.
        /// </summary>
        /// <param name="stade">Stade à modifier.</param>
        public void UpdateStade(Stade stade)
        {
            m_bridge.UpdateStade(stade);
        }

        /// <summary>
        /// Supprime le stade passé en paramètre.
        /// </summary>
        /// <param name="stade">Stade à supprimer.</param>
        public void DeleteStade(Stade stade)
        {
            m_bridge.DeleteStade(stade);
        }

        #endregion

        #region "Liés aux Matchs"

        /// <summary>
        /// Permet d'obtenir la liste de tous les matchs connus.
        /// </summary>
        /// <returns>Liste des matchs.</returns>
        public List<Match> GetAllMatchs()
        {
            return m_bridge.GetAllMatchs();
        }

        /// <summary>
        /// Crée un nouveau match.
        /// </summary>
        /// <param name="match">Match à créer.</param>
        public void CreateMatch(Match match)
        {
            m_bridge.CreateMatch(match);
        }

        /// <summary>
        /// Met à jour le match en paramètre.
        /// </summary>
        /// <param name="match">Match à modifier.</param>
        public void UpdateMatch(Match match)
        {
            m_bridge.UpdateMatch(match);
        }

        /// <summary>
        /// Supprime le match passé en paramètre.
        /// </summary>
        /// <param name="match">Match à supprimer.</param>
        public void DeleteMatch(Match match)
        {
            m_bridge.DeleteMatch(match);
        }

        #endregion

        #region "Liés aux Caractéristiques"

        /// <summary>
        /// Permet d'obtenir la liste de toutes les caractéristiques enregistrées.
        /// </summary>
        /// <returns>Liste des caractéritiques.</returns>
        public List<Caracteristique> GetAllCaracs()
        {
            return m_bridge.GetAllCaracs();
        }

        /// <summary>
        /// Permet d'obtenir la liste des caractéristiques de jedi enregistrées.
        /// </summary>
        /// <returns>Liste des caractéritiques.</returns>
        public List<Caracteristique> GetAllJediCaracs()
        {
            return m_bridge.GetAllJediCaracs();
        }

        /// <summary>
        /// Permet d'obtenir la liste des caractéristiques de stade enregistrées.
        /// </summary>
        /// <returns>Liste des caractéritiques.</returns>
        public List<Caracteristique> GetAllStadeCaracs()
        {
            return m_bridge.GetAllStadeCaracs();
        }

        /// <summary>
        /// Crée une nouvelle caractéristique.
        /// </summary>
        /// <param name="carac">Caractéristique à créer.</param>
        public void CreateCarac(Caracteristique carac)
        {
            m_bridge.CreateCarac(carac);
        }

        /// <summary>
        /// Met à jour la caractéristique en paramètre.
        /// </summary>
        /// <param name="carac">Caractéristique à modifier.</param>
        public void UpdateCarac(Caracteristique carac)
        {
            m_bridge.UpdateCarac(carac);
        }

        /// <summary>
        /// Supprime la caractéristique passé en paramètre.
        /// </summary>
        /// <param name="carac">Caractéristique à supprimer.</param>
        public void DeleteCarac(Caracteristique carac)
        {
            m_bridge.DeleteCarac(carac);
        }

        #endregion

        #region "Liés aux Tournois"

        /// Permet d'obtenir le tournoi avec l'id correspondant.
        /// </summary>
        /// <param name="id">Id du tournoi.</param>
        /// <returns>Tournoi correspondant.</returns>
        public Tournoi GetTournoi(int id)
        {
            return m_bridge.GetTournoi(id);
        }

        /// <summary>
        /// Permet d'obtenir la liste de tous les tournois connus n'ayant pas étaient joués.
        /// </summary>
        /// <returns>Liste des tournois non joués.</returns>
        public List<Tournoi> GetGoodTournois()
        {
            return m_bridge.GetGoodTournois();
        }

        /// <summary>
        /// Permet d'obtenir la liste de tous les tournois connus.
        /// </summary>
        /// <returns>Liste des tournois.</returns>
        public List<Tournoi> GetAllTournois()
        {
            return m_bridge.GetAllTournois();
        }

        /// <summary>
        /// Crée un nouveau tournoi.
        /// </summary>
        /// <param name="tournoi">Tournoi à créer.</param>
        public void CreateTournoi(Tournoi tournoi)
        {
            m_bridge.CreateTournoi(tournoi);
        }

        /// <summary>
        /// Met à jour le tournoi en paramètre.
        /// </summary>
        /// <param name="tournoi">Tournoi à modifier.</param>
        public void UpdateTournoi(Tournoi tournoi)
        {
            m_bridge.UpdateTournoi(tournoi);
        }

        /// <summary>
        /// Supprime le tournoi passé en paramètre.
        /// </summary>
        /// <param name="tournoi">Tournoi à supprimer.</param>
        public void DeleteTournoi(Tournoi tournoi)
        {
            m_bridge.DeleteTournoi(tournoi);
        }

        #endregion

        #region "Liés aux Users"

        /// <summary>
        /// Permet de récupérer un utilisateur par login.
        /// </summary>
        /// <param name="login">Login de l'utilisateur à récupérer.</param>
        /// <returns>Utilisateur correspondant.</returns>
        public Utilisateur GetUtilisateurByLogin(string login)
        {
            return m_bridge.GetUtilisateurByLogin(login);
        }

        /// <summary>
        /// Crée un nouvel utilisateur.
        /// </summary>
        /// <param name="user">Utilisateur à créer.</param>
        public void CreateUtilisateur(Utilisateur user)
        {
            m_bridge.CreateUser(user);
        }

        /// <summary>
        /// Met à jour l'utilisateur en paramètre.
        /// </summary>
        /// <param name="user">Utilisateur à modifier.</param>
        public void UpdateUtilisateur(Utilisateur user)
        {
            m_bridge.UpdateUser(user);
        }

        /// <summary>
        /// Supprime l'utilisateur passé en paramètre.
        /// </summary>
        /// <param name="user">Utilisateur à supprimer.</param>
        public void DeleteUtilisateur(Utilisateur user)
        {
            m_bridge.DeleteUser(user);
        }

        #endregion
    }
}
