using System.Collections.Generic;
using System.Linq;
using EntitiesLayer;
using System.IO;
using System.Xml.Serialization;
using DataAccessLayer;
using System.Security.Cryptography;
using System.Text;
using System;

namespace BusinessLayer
{
    public class JediBusinessManager
    {
        /// <summary>
        /// Gestionnaire d'interactions avec la couche d'accès aux données.
        /// </summary>
        private DalManager m_data;

        /// <summary>
        /// Générateur de nombres pseudo aléatoires.
        /// </summary>
        private Random m_generator;

        /// <summary>
        /// Constructeur.
        /// </summary>
        public JediBusinessManager()
        {
            m_data = DalManager.Instance;
            m_generator = new Random();
        }

        #region "Liés aux Jedis"

        /// <summary>
        /// Donne la liste des noms des jedis siths.
        /// </summary>
        /// <returns>Liste des noms des jedis siths.</returns>
        public List<string> GetSithsNames()
        {
            return m_data.GetAllJedis().Where(j => j.IsSith).Select(j => j.Nom).ToList();
        }

        /// <summary>
        /// Donne la liste des jedis ayant plus de 3 points de Force et 50 points de vie.
        /// </summary>
        /// <returns>Liste des noms des jedis avec plus de 3 points de Force et 50 points de vie.</returns>
        public List<string> GetJedis3F50PV()
        {
            return m_data.GetAllJedis().Where(j => j.Caracteristiques != null
                                                && j.Caracteristiques.Any(c => c.Type == ETypeCaracteristique.Jedi && c.Definition == EDefCaracteristique.Force && c.Valeur > 3)
                                                && j.Caracteristiques.Any(c => c.Type == ETypeCaracteristique.Jedi && c.Definition == EDefCaracteristique.Sante && c.Valeur > 50)
                                              ).Select(j => j.Nom).ToList();
        }

        /// <summary>
        /// Donne la liste de tous les jedis.
        /// </summary>
        /// <returns>Liste de tous les jedis.</returns>
        public List<Jedi> GetAllJedis()
        {
            return m_data.GetAllJedis();
        }

        /// <summary>
        /// Donne le jedi correspondant à l'id.
        /// </summary>
        /// <returns>Jedi correspondant si existant, sinon null.</returns>
        public Jedi GetJediByID(int id)
        {
            return m_data.GetAllJedis().Where(j => j.ID == id).SingleOrDefault();
        }

        /// <summary>
        /// Crée un nouveau jedi.
        /// </summary>
        /// <param name="jedi">Jedi à créer.</param>
        public void CreateJedi(Jedi jedi)
        {
            m_data.CreateJedi(jedi);
        }

        /// <summary>
        /// Met à jour le jedi en paramètre.
        /// </summary>
        /// <param name="jedi">Jedi à modifier.</param>
        public void UpdateJedi(Jedi jedi)
        {
            m_data.UpdateJedi(jedi);
        }

        /// <summary>
        /// Supprime le jedi passé en paramètre.
        /// </summary>
        /// <param name="jedi">Jedi à supprimer.</param>
        public void DeleteJedi(Jedi jedi)
        {
            m_data.DeleteJedi(jedi);
        }

        #endregion
        #region "Liés aux Stades"

        /// <summary>
        /// Donne la liste des noms des stades disponibles.
        /// </summary>
        /// <returns>Liste des noms des stades.</returns>
        public List<string> GetStades()
        {
            return m_data.GetAllStades().Select(s => s.Planete).ToList();
        }

        /// <summary>
        /// Donne le stade correspondant à l'id.
        /// </summary>
        /// <returns>Stade correspondant si existant, sinon null.</returns>
        public Stade GetStadeByID(int id)
        {
            return m_data.GetAllStades().Where(s => s.ID == id).SingleOrDefault();
        }

        /// <summary>
        /// Donne la liste de tous les stades.
        /// </summary>
        /// <returns>Liste de tous les stades.</returns>
        public List<Stade> GetAllStades()
        {
            return m_data.GetAllStades();
        }

        /// <summary>
        /// Crée un nouveau stade.
        /// </summary>
        /// <param name="stade">Stade à créer.</param>
        public void CreateStade(Stade stade)
        {
            m_data.CreateStade(stade);
        }

        /// <summary>
        /// Met à jour le stade en paramètre.
        /// </summary>
        /// <param name="stade">Stade à modifier.</param>
        public void UpdateStade(Stade stade)
        {
            m_data.UpdateStade(stade);
        }

        /// <summary>
        /// Supprime le stade passé en paramètre.
        /// </summary>
        /// <param name="stade">Stade à supprimer.</param>
        public void DeleteStade(Stade stade)
        {
            m_data.DeleteStade(stade);
        }

        #endregion

        #region "Liés aux Matchs"

        /// <summary>
        /// Donne la liste des matchs qui ont eu lieu dans un stade de plus de 200 places et ou deux Siths se sont affrontés.
        /// </summary>
        /// <returns>Liste des matchs qui ont eu lieu dans un stade de plus de 200 places et ou deux Siths se sont affrontés.</returns>
        public List<Match> GetMatch200P2S()
        {
            List<Match> list = m_data.GetAllMatchs().Where(m => m.Stade.NbPlaces > 200 && m.Jedi1.IsSith && m.Jedi2.IsSith).ToList();
            return new HashSet<Match>(list).ToList();   // Rend unique
        }

        /// <summary>
        /// Donne la liste de l'ensemble des objets matchs.
        /// </summary>
        /// <returns>Liste des objets matchs.</returns>
        public List<Match> GetAllMatchs()
        {
            return m_data.GetAllMatchs();
        }

        /// <summary>
        /// Donne la liste de l'ensemble des objets matchs de quart de finale.
        /// </summary>
        /// <returns>Liste des objets matchs quart de finale.</returns>
        public List<Match> GetAllQuartFinaleMatch()
        {
            return m_data.GetAllMatchs().Where(m => m.PhaseTournoi == EPhaseTournoi.QuartFinale).ToList();
        }

        /// <summary>
        /// Crée un nouveau match.
        /// </summary>
        /// <param name="match">Match à créer.</param>
        public void CreateMatch(Match match)
        {
            m_data.CreateMatch(match);
        }

        /// <summary>
        /// Met à jour le match en paramètre.
        /// </summary>
        /// <param name="match">Match à modifier.</param>
        public void UpdateMatch(Match match)
        {
            m_data.UpdateMatch(match);
        }

        /// <summary>
        /// Supprime le match passé en paramètre.
        /// </summary>
        /// <param name="match">Match à supprimer.</param>
        public void DeleteMatch(Match match)
        {
            m_data.DeleteMatch(match);
        }

        /// <summary>
        /// Donne le match correspondant à l'id.
        /// </summary>
        /// <returns>Match correspondant si existant, sinon null.</returns>
        public Match GetMatchByID(int id)
        {
            return m_data.GetAllMatchs().Where(m => m.ID == id).SingleOrDefault();
        }

        /// <summary>
        /// Calcul le résultat du match passé en paramètre.
        /// </summary>
        /// <param name="match">Match à jouer.</param>
        /// <returns>Id du jedi vainqueur du match.</returns>
        public int ComputeMatchResult(Match match)
        {
            int ret = -1;
            // Affecte le vainqueur
            if (/* Jedi 1*/ m_generator.Next(100) > m_generator.Next(100) /* Jedi 2 */)
                ret = match.Jedi1.ID;
            else
                ret = match.Jedi2.ID;

            return ret;
        }

        #endregion

        #region "Liés aux Caractéristiques"

        /// <summary>
        /// Donne la liste des caractéristiques liées aux jedis.
        /// </summary>
        /// <returns>Liste des caractéristiques liées aux jedis.</returns>
        public List<Caracteristique> GetAllJediCaracs()
        {
            return m_data.GetAllJediCaracs();
        }

        /// <summary>
        /// Donne la liste des caractéristiques liées aux stades.
        /// </summary>
        /// <returns>Liste des caractéristiques liées aux stades.</returns>
        public List<Caracteristique> GetAllStadeCaracs()
        {
            return m_data.GetAllStadeCaracs();
        }

        /// <summary>
        /// Crée une nouvelle caractéristique.
        /// </summary>
        /// <param name="carac">Caractéristique à créer.</param>
        public void CreateCarac(Caracteristique carac)
        {
            m_data.CreateCarac(carac);
        }

        /// <summary>
        /// Met à jour la caractéristique en paramètre.
        /// </summary>
        /// <param name="carac">Caractéristique à modifier.</param>
        public void UpdateCarac(Caracteristique carac)
        {
            m_data.UpdateCarac(carac);
        }

        /// <summary>
        /// Supprime la caractéristique passé en paramètre.
        /// </summary>
        /// <param name="carac">Caractéristique à supprimer.</param>
        public void DeleteCarac(Caracteristique carac)
        {
            m_data.DeleteCarac(carac);
        }

        #endregion

        #region "Liés aux Tournois"

        /// <summary>
        /// Récupère le tournoi correspondant à l'id.
        /// </summary>
        /// <returns>Tournoi correspondant.</returns>
        public Tournoi GetTournoi(int id)
        {
            return m_data.GetTournoi(id);
        }

        /// <summary>
        /// Permet d'obtenir la liste de tous les tournois connus.
        /// </summary>
        /// <returns>Liste des tournois.</returns>
        public List<Tournoi> GetAllTournois()
        {
            return m_data.GetAllTournois();
        }

        /// <summary>
        /// Permet d'obtenir la liste de tous les tournois connus n'ayant pas étaient joués.
        /// </summary>
        /// <returns>Liste des tournois non joués.</returns>
        public List<Tournoi> GetGoodTournois()
        {
            return m_data.GetGoodTournois();
        }

        /// <summary>
        /// Crée un nouveau tournoi.
        /// </summary>
        /// <param name="tournoi">Tournoi à créer.</param>
        public void CreateTournoi(Tournoi tournoi)
        {
            m_data.CreateTournoi(tournoi);
        }

        /// <summary>
        /// Met à jour le tournoi en paramètre.
        /// </summary>
        /// <param name="tournoi">Tournoi à modifier.</param>
        public void UpdateTournoi(Tournoi tournoi)
        {
            m_data.UpdateTournoi(tournoi);
        }

        /// <summary>
        /// Supprime le tournoi passé en paramètre.
        /// </summary>
        /// <param name="tournoi">Tournoi à supprimer.</param>
        public void DeleteTournoi(Tournoi tournoi)
        {
            m_data.DeleteTournoi(tournoi);
        }

        #endregion

        #region "Liés aux Users"

        /// <summary>
        /// Vérifie que le mot de passe correspond au login entré.
        /// </summary>
        /// <param name="login">Login de l'utilisateur.</param>
        /// <param name="passwd">Mot de passe à vérifier.</param>
        /// <returns>Vrai si le mot de passe correspond, sinon faux.</returns>
        public bool CheckConnexionUser(string login, string passwd)
        {
            passwd = GetSHA256Hash(passwd);

            Utilisateur user = m_data.GetUtilisateurByLogin(login);
            return user != null && user.Password == passwd;
        }

        /// <summary>
        /// Vérifie que le mot de passe correspond au login entré.
        /// </summary>
        /// <param name="login">Login de l'utilisateur.</param>
        /// <param name="passwd">Mot de passe à vérifier.</param>
        /// <returns>Utilisateur si le mot de passe correspond, sinon null.</returns>
        public Utilisateur CheckLoginPassword(string login, string passwd)
        {
            passwd = GetSHA256Hash(passwd);

            Utilisateur user = m_data.GetUtilisateurByLogin(login);
            if (user == null || user.Password != passwd)
            {
                user = null;
            }

            return user;
        }

        /// <summary>
        /// Crée un nouvel utilisateur.
        /// </summary>
        /// <param name="user">Utilisateur à créer.</param>
        public void CreateUser(Utilisateur user)
        {
            user.Password = GetSHA256Hash(user.Password);
            m_data.CreateUtilisateur(user);
        }

        /// <summary>
        /// Met à jour l'utilisateur en paramètre.
        /// </summary>
        /// <param name="user">Utilisateur à modifier.</param>
        public void UpdateUser(Utilisateur user)
        {
            m_data.UpdateUtilisateur(user);
        }

        /// <summary>
        /// Supprime l'utilisateur passé en paramètre.
        /// </summary>
        /// <param name="user">Utilisateur à supprimer.</param>
        public void DeleteUser(Utilisateur user)
        {
            m_data.DeleteUtilisateur(user);
        }

        #endregion

        #region "Autres"

        /// <summary>
        /// Création de la base de données.
        /// </summary>
        public void CreateDataBase()
        {

            /*********** SCRIPT DE CREATION DE LA BDD (ET RESET) **********************/


            /* Avant de reset il peut être utile d'exécuter la commande "DBCC CHECKIDENT (table, RESEED, 0);" sur chaque table pour reset les IDs */


            /* Supression */

            //addUtilisateur(new Utilisateur("admin", "admin", "admin", "admin"));

            int i;

            List<Caracteristique> listCaracteristiques = m_data.GetAllCaracs();
            for (i = 0; i < listCaracteristiques.Count; i++)
            {
                m_data.DeleteCarac(listCaracteristiques.ElementAt(i));
            }

            List<Stade> listStade = m_data.GetAllStades();
            for (i = 0; i < listStade.Count; i++)
            {
                m_data.DeleteStade(listStade.ElementAt(i));
            }

            List<Match> listMatch = m_data.GetAllMatchs();
            for (i = 0; i < listMatch.Count; i++)
            {
                m_data.DeleteMatch(listMatch.ElementAt(i));
            }

            List<Jedi> listJedi = m_data.GetAllJedis();
            for (i = 0; i < listJedi.Count; i++)
            {
                m_data.DeleteJedi(listJedi.ElementAt(i));
            }

            List<Tournoi> listTournoi = m_data.GetAllTournois();
            for (i = 0; i < listTournoi.Count; i++)
            {
                m_data.DeleteTournoi(listTournoi.ElementAt(i));
            }

            /* Création */

            List<Caracteristique> listCarac = new List<Caracteristique>();

            // Caracs de Jedis
            listCarac.Add(new Caracteristique(1, "Force", EDefCaracteristique.Force, ETypeCaracteristique.Jedi, 2));
            listCarac.Add(new Caracteristique(2, "Force Supérieure", EDefCaracteristique.Force, ETypeCaracteristique.Jedi, 4));
            listCarac.Add(new Caracteristique(3, "Force Herculéenne", EDefCaracteristique.Force, ETypeCaracteristique.Jedi, 6));
            listCarac.Add(new Caracteristique(4, "Defense Mineure", EDefCaracteristique.Defense, ETypeCaracteristique.Jedi, 2));
            listCarac.Add(new Caracteristique(5, "Defense Supérieure", EDefCaracteristique.Defense, ETypeCaracteristique.Jedi, 4));
            listCarac.Add(new Caracteristique(6, "Le Mur", EDefCaracteristique.Defense, ETypeCaracteristique.Jedi, 6));
            listCarac.Add(new Caracteristique(7, "Vie", EDefCaracteristique.Sante, ETypeCaracteristique.Jedi, 40));
            listCarac.Add(new Caracteristique(8, "Vie Supérieure", EDefCaracteristique.Sante, ETypeCaracteristique.Jedi, 51));
            listCarac.Add(new Caracteristique(9, "Sac à PV", EDefCaracteristique.Sante, ETypeCaracteristique.Jedi, 60));
            listCarac.Add(new Caracteristique(10, "Unlucky Boy", EDefCaracteristique.Chance, ETypeCaracteristique.Jedi, -7));
            listCarac.Add(new Caracteristique(11, "Lucky Boy", EDefCaracteristique.Chance, ETypeCaracteristique.Jedi, 7));

            // Caracs de stades
            listCarac.Add(new Caracteristique(12, "Froid Glaciale", EDefCaracteristique.Defense, ETypeCaracteristique.Stade, -2));
            listCarac.Add(new Caracteristique(13, "Désert", EDefCaracteristique.Force, ETypeCaracteristique.Stade, -2));
            listCarac.Add(new Caracteristique(14, "Ovation", EDefCaracteristique.Force, ETypeCaracteristique.Stade, 3));

            foreach (Caracteristique c in listCarac)
            {
                m_data.CreateCarac(c);
            }

            List<Jedi> listJedis = new List<Jedi>();

            // Caractéristiques éventuelles des jedis
            List<Caracteristique> caracsDarthVador = listCarac.Where(c => c.Type == ETypeCaracteristique.Jedi && (c.ID == 2 || c.ID == 7 || c.ID == 11)).ToList();
            List<Caracteristique> caracsDarthMaul = listCarac.Where(c => c.Type == ETypeCaracteristique.Jedi && (c.ID == 3 || c.ID == 10)).ToList();
            List<Caracteristique> caracsLukeS = listCarac.Where(c => c.Type == ETypeCaracteristique.Jedi && (c.ID == 2 || c.ID == 4 || c.ID == 8)).ToList();
            List<Caracteristique> caracsYoda = listCarac.Where(c => c.Type == ETypeCaracteristique.Jedi && (c.ID == 6 || c.ID == 9 || c.ID == 11)).ToList();
            List<Caracteristique> caracsObiwan = listCarac.Where(c => c.Type == ETypeCaracteristique.Jedi && (c.ID == 5 || c.ID == 8)).ToList();

            // Crée la liste des jedis
            // TODO trouver une manière plus élégante de charger les images en relatif

            listJedis.Add(new Jedi(1, "Darth Vador", true, caracsDarthVador, "\\Resources\\Jedis\\darthvador.png"));
            listJedis.Add(new Jedi(2, "Count Dooku", true, null, "\\Resources\\Jedis\\dooku.png"));
            listJedis.Add(new Jedi(3, "Darth Maul", true, caracsDarthMaul, "\\Resources\\Jedis\\darthmaul.png"));
            listJedis.Add(new Jedi(4, "Luke Skywalker", false, caracsLukeS, "\\Resources\\Jedis\\luke.png"));
            listJedis.Add(new Jedi(5, "Yoda", false, caracsYoda, "\\Resources\\Jedis\\yoda.png"));
            listJedis.Add(new Jedi(6, "Qui-Gon Jinn", false, null, "\\Resources\\Jedis\\quigon.png"));
            listJedis.Add(new Jedi(7, "Obi-Wan Kenobi", false, caracsObiwan, "\\Resources\\Jedis\\obiwan.png"));
            listJedis.Add(new Jedi(8, "Emperor Palpatine", true, null, "\\Resources\\Jedis\\palpatine.png"));

            foreach (Jedi j in listJedis)
            {
                m_data.CreateJedi(j);
            }


            List<Stade> listStades = new List<Stade>();

            // Caractéristiques éventuelles des stades
            List<Caracteristique> caracsTatooine = listCarac.Where(s => s.Type == ETypeCaracteristique.Stade && s.ID == 13).ToList();
            List<Caracteristique> caracsHoth = listCarac.Where(s => s.Type == ETypeCaracteristique.Stade && (s.ID == 12 || s.ID == 13)).ToList();
            List<Caracteristique> caracsCoruscant = listCarac.Where(s => s.Type == ETypeCaracteristique.Stade && s.ID == 14).ToList();

            // Crée la liste des stades

            listStades.Add(new Stade(1, "Le Drake", 150, "Jakku", null, "\\Resources\\Stades\\drake.png"));
            listStades.Add(new Stade(2, "Le Sandstorm", 2000, "Tatooine", caracsTatooine, "\\Resources\\Stades\\sandstorm.png"));
            listStades.Add(new Stade(3, "Le Cyberia", 10000, "Hoth", caracsHoth, "\\Resources\\Stades\\cyberia.png"));
            listStades.Add(new Stade(4, "L''Impérial", 110000, "Coruscant", caracsCoruscant, "\\Resources\\Stades\\imperial.png"));

            foreach (Stade s in listStades)
            {
                m_data.CreateStade(s);
            }




            List<Match> listMatchs = new List<Match>();

            // Match sur Jakku
            listMatchs.Add(new Match(1,
                                    listJedis.Where(j => j.ID == 3).First(),
                                    listJedis.Where(j => j.ID == 4).First(),
                                    EPhaseTournoi.QuartFinale,
                                    listStades.Where(s => s.ID == 1).First()));

            // Match sur Tatooine
            listMatchs.Add(new Match(2,
                                    listJedis.Where(j => j.ID == 1).First(),
                                    listJedis.Where(j => j.ID == 2).First(),
                                    EPhaseTournoi.QuartFinale,
                                    listStades.Where(s => s.ID == 2).First()));

            listMatchs.Add(new Match(3,
                                    listJedis.Where(j => j.ID == 5).First(),
                                    listJedis.Where(j => j.ID == 6).First(),
                                    EPhaseTournoi.QuartFinale,
                                    listStades.Where(s => s.ID == 2).First()));

            // Matchs sur Hoth
            listMatchs.Add(new Match(3,
                                    listJedis.Where(j => j.ID == 7).First(),
                                    listJedis.Where(j => j.ID == 8).First(),
                                    EPhaseTournoi.QuartFinale,
                                    listStades.Where(s => s.ID == 3).First()));

            foreach (Match m in listMatchs)
            {
                m_data.CreateMatch(m);
            }

            List<Tournoi> listTournois = new List<Tournoi>();
            listTournois.Add(new Tournoi(1, "Tournoi 1", listMatchs));

            Console.WriteLine("C'est bon !");


        }

        /// <summary>
        /// Fonction de hashage des mots de passe.
        /// </summary>
        /// <param name="data">Chaine de caractères à hasher.</param>
        /// <returns>Chaine de caractères hashée.</returns>
        public string GetSHA256Hash(string data)
        {
            SHA256 mySHA256 = SHA256.Create();
            byte[] hashValue = mySHA256.ComputeHash(Encoding.Default.GetBytes(data + "thisisasalt"));

            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashValue.Length; i++)
            {
                returnValue.Append(hashValue[i].ToString());
            }

            return returnValue.ToString();
        }

        /// <summary>
        /// Sérialize les jedis.
        /// </summary>
        /// <param name="path">Chemin d'enregistrement du fichier.</param>
        public void SerializeJedis(string path)
        {
            // La sérialization peut être placé soit dans BusinessLayer, Presentation ou DataAccessLayer (Jamais dans EntityLayer)
            // Il peut être préférable de le placer dans la couche métier (Business Layer)
            StreamWriter stream = new StreamWriter(path);
            XmlSerializer serializer = new XmlSerializer(typeof(Jedi));
            foreach (Jedi j in m_data.GetAllJedis())
                serializer.Serialize(stream, j);

            stream.Close();
        }

        #endregion
    }
}
