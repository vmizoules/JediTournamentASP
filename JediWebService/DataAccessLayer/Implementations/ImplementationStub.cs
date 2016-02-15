using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Reflection;

namespace DataAccessLayer.Implementations
{
    /// <summary>
    /// Implémentation du stub des données.
    /// </summary>
    class ImplementationStub : Bridge
    {
        /// <summary>
        /// Liste des jedis.
        /// </summary>
        private List<Jedi> m_jedis;
        /// <summary>
        /// Prochain ID de jedi disponible (Equivalent au AUTO_INCREMENT).
        /// </summary>
        private int m_availableJediID;

        /// <summary>
        /// Liste des caractéristiques.
        /// </summary>
        private List<Caracteristique> m_caracs;
        /// <summary>
        /// Prochain ID de caractéristique disponible (Equivalent au AUTO_INCREMENT).
        /// </summary>
        private int m_availableCaracID;

        /// <summary>
        /// Liste des stades.
        /// </summary>
        private List<Stade> m_stades;
        /// <summary>
        /// Prochain ID de stade disponible (Equivalent au AUTO_INCREMENT).
        /// </summary>
        private int m_availableStadeID;

        /// <summary>
        /// Liste des matchs.
        /// </summary>
        private List<Match> m_matchs;
        /// <summary>
        /// Prochain ID de match disponible (Equivalent au AUTO_INCREMENT).
        /// </summary>
        private int m_availableMatchID;

        /// <summary>
        /// Liste des tournois.
        /// </summary>
        private List<Tournoi> m_tournois;
        /// <summary>
        /// Prochain ID de tournoi disponible (Equivalent au AUTO_INCREMENT).
        /// </summary>
        private int m_availableTournoiID;

        /// <summary>
        /// Liste des utilisateurs.
        /// </summary>
        private List<Utilisateur> m_users;

        /// <summary>
        /// Constructeur.
        /// </summary>
        public ImplementationStub()
        {
            m_jedis = new List<Jedi>();
            m_caracs = new List<Caracteristique>();
            m_stades = new List<Stade>();
            m_matchs = new List<Match>();
            m_users = new List<Utilisateur>();
            m_tournois = new List<Tournoi>();

            // Caracs de Jedis
            m_caracs.Add(new Caracteristique(1, "Force", EDefCaracteristique.Force, ETypeCaracteristique.Jedi, 2));
            m_caracs.Add(new Caracteristique(2, "Force Supérieure", EDefCaracteristique.Force, ETypeCaracteristique.Jedi, 4));
            m_caracs.Add(new Caracteristique(3, "Force Herculéenne", EDefCaracteristique.Force, ETypeCaracteristique.Jedi, 6));
            m_caracs.Add(new Caracteristique(4, "Defense Mineure", EDefCaracteristique.Defense, ETypeCaracteristique.Jedi, 2));
            m_caracs.Add(new Caracteristique(5, "Defense Supérieure", EDefCaracteristique.Defense, ETypeCaracteristique.Jedi, 4));
            m_caracs.Add(new Caracteristique(6, "Le Mur", EDefCaracteristique.Defense, ETypeCaracteristique.Jedi, 6));
            m_caracs.Add(new Caracteristique(7, "Vie", EDefCaracteristique.Sante, ETypeCaracteristique.Jedi, 40));
            m_caracs.Add(new Caracteristique(8, "Vie Supérieure", EDefCaracteristique.Sante, ETypeCaracteristique.Jedi, 51));
            m_caracs.Add(new Caracteristique(9, "Sac à PV", EDefCaracteristique.Sante, ETypeCaracteristique.Jedi, 60));
            m_caracs.Add(new Caracteristique(10, "Unlucky Boy", EDefCaracteristique.Chance, ETypeCaracteristique.Jedi, -7));
            m_caracs.Add(new Caracteristique(11, "Lucky Boy", EDefCaracteristique.Chance, ETypeCaracteristique.Jedi, 7));

            // Caracs de stades
            m_caracs.Add(new Caracteristique(12, "Froid Glaciale", EDefCaracteristique.Defense, ETypeCaracteristique.Stade, -2));
            m_caracs.Add(new Caracteristique(13, "Désert", EDefCaracteristique.Force, ETypeCaracteristique.Stade, -2));
            m_caracs.Add(new Caracteristique(14, "Ovation", EDefCaracteristique.Force, ETypeCaracteristique.Stade, 3));
            m_availableCaracID = 15;

            // Caractéristiques éventuelles des jedis
            List<Caracteristique> caracsDarthVador = m_caracs.Where(c => c.Type == ETypeCaracteristique.Jedi && (c.ID == 2 || c.ID == 7 || c.ID == 11)).ToList();
            List<Caracteristique> caracsDarthMaul = m_caracs.Where(c => c.Type == ETypeCaracteristique.Jedi && (c.ID == 3 || c.ID == 10)).ToList();
            List<Caracteristique> caracsLukeS = m_caracs.Where(c => c.Type == ETypeCaracteristique.Jedi && (c.ID == 2 || c.ID == 4 || c.ID == 8)).ToList();
            List<Caracteristique> caracsYoda = m_caracs.Where(c => c.Type == ETypeCaracteristique.Jedi && (c.ID == 6 || c.ID == 9 || c.ID == 11)).ToList();
            List<Caracteristique> caracsObiwan = m_caracs.Where(c => c.Type == ETypeCaracteristique.Jedi && (c.ID == 5 || c.ID == 8)).ToList();

            // Crée la liste des jedis
            // TODO trouver une manière plus élégante de charger les images en relatif
            m_jedis.Add(new Jedi(1, "Darth Vador", true, caracsDarthVador, "\\Resources\\Jedis\\darthvador.png"));
            m_jedis.Add(new Jedi(2, "Count Dooku", true, null, "\\Resources\\Jedis\\dooku.png"));
            m_jedis.Add(new Jedi(3, "Darth Maul", true, caracsDarthMaul, "\\Resources\\Jedis\\darthmaul.png"));
            m_jedis.Add(new Jedi(4, "Luke Skywalker", false, caracsLukeS, "\\Resources\\Jedis\\luke.png"));
            m_jedis.Add(new Jedi(5, "Yoda", false, caracsYoda, "\\Resources\\Jeu\\yoda.png"));
            m_jedis.Add(new Jedi(6, "Qui-Gon Jinn", false, null, "\\Resources\\Jedis\\quigon.png"));
            m_jedis.Add(new Jedi(7, "Obi-Wan Kenobi", false, caracsObiwan, "\\Resources\\Jedis\\obiwan.png"));
            m_jedis.Add(new Jedi(8, "Emperor Palpatine", true, null, "\\Resources\\Jedis\\palpatine.png"));
            m_availableJediID = 9;

            // Caractéristiques éventuelles des stades
            List<Caracteristique> caracsTatooine = m_caracs.Where(s => s.Type == ETypeCaracteristique.Stade && s.ID == 13).ToList();
            List<Caracteristique> caracsHoth = m_caracs.Where(s => s.Type == ETypeCaracteristique.Stade && (s.ID == 12 || s.ID == 13)).ToList();
            List<Caracteristique> caracsCoruscant = m_caracs.Where(s => s.Type == ETypeCaracteristique.Stade && s.ID == 14).ToList();

            // Crée la liste des stades
            m_stades.Add(new Stade(1, "Le Drake", 150, "Jakku", null, "\\Resources\\Stades\\drake.png"));
            m_stades.Add(new Stade(2, "Le Sandstorm", 2000, "Tatooine", caracsTatooine, "\\Resources\\Stades\\sandstorm.png"));
            m_stades.Add(new Stade(3, "Le Cyberia", 10000, "Hoth", caracsHoth, "\\Resources\\Stades\\cyberia.png"));
            m_stades.Add(new Stade(4, "L'Impérial", 110000, "Coruscant", caracsCoruscant, "\\Resources\\Stades\\imperial.png"));
            m_availableStadeID = 5;

            // Match sur Jakku
            m_matchs.Add(new Match(1,
                                    m_jedis.Where(j => j.ID == 3).First(),
                                    m_jedis.Where(j => j.ID == 4).First(),
                                    EPhaseTournoi.QuartFinale,
                                    m_stades.Where(s => s.ID == 1).First()));

            // Match sur Tatooine
            m_matchs.Add(new Match(2,
                                    m_jedis.Where(j => j.ID == 1).First(),
                                    m_jedis.Where(j => j.ID == 2).First(),
                                    EPhaseTournoi.QuartFinale,
                                    m_stades.Where(s => s.ID == 2).First()));

            m_matchs.Add(new Match(3,
                                    m_jedis.Where(j => j.ID == 5).First(),
                                    m_jedis.Where(j => j.ID == 6).First(),
                                    EPhaseTournoi.QuartFinale,
                                    m_stades.Where(s => s.ID == 2).First()));

            // Matchs sur Hoth
            m_matchs.Add(new Match(4,
                                    m_jedis.Where(j => j.ID == 7).First(),
                                    m_jedis.Where(j => j.ID == 8).First(),
                                    EPhaseTournoi.QuartFinale,
                                    m_stades.Where(s => s.ID == 3).First()));
            m_availableMatchID = 5;

            // Pwds azerty
            CreateUser(new Utilisateur("RABERIN", "Alexandre", "KeRNeLith", "1081252467025311320979120222918467701381901472421615814468203197202184186122941456162"));
            CreateUser(new Utilisateur("PERSCHER", "Marc", "Marc", "1081252467025311320979120222918467701381901472421615814468203197202184186122941456162"));
            CreateUser(new Utilisateur("HUMBERT", "Bastien", "Bastien", "1081252467025311320979120222918467701381901472421615814468203197202184186122941456162"));
            CreateUser(new Utilisateur("BELIN", "Mathieu", "Math", "1081252467025311320979120222918467701381901472421615814468203197202184186122941456162"));
            
            // Pwd : admin
            CreateUser(new Utilisateur("ADMIN", "Admin", "admin", "9122168229210971191938212919884403313824317523613821694180185253055411771149498"));


            m_tournois.Add(new Tournoi(1, "Tournoi 1", new List<Match>(m_matchs)));
            m_availableTournoiID = 2;
        }

        #region "Liés aux Jedis"
        public List<Jedi> GetAllJedis()
        {
            return m_jedis;
        }

        public void CreateJedi(Jedi jedi)
        {
            jedi.ID = m_availableJediID++;
            m_jedis.Add(jedi);
        }

        public void UpdateJedi(Jedi jedi)
        {
            int index = m_jedis.FindIndex(j => j.ID == jedi.ID);
            if (index >= 0)
                m_jedis[index] = jedi;
            // Ne devrai jamais arriver
            else
                m_jedis.Add(jedi);
        }

        public void DeleteJedi(Jedi jedi)
        {
            m_jedis.Remove(jedi);
        }

        #endregion

        #region "Liés aux Stades"
        public List<Stade> GetAllStades()
        {
            return m_stades;
        }

        public void CreateStade(Stade stade)
        {
            stade.ID = m_availableStadeID++;
            m_stades.Add(stade);
        }

        public void UpdateStade(Stade stade)
        {
            int index = m_stades.FindIndex(s => s.ID == stade.ID);
            if (index >= 0)
                m_stades[index] = stade;
            // Ne devrai jamais arriver
            else
                m_stades.Add(stade);
        }

        public void DeleteStade(Stade stade)
        {
            foreach (Match m in m_matchs.Where(m => m.Stade == stade).ToList())
            {
                DeleteMatch(m);
            }
            m_stades.Remove(stade);
        }

        #endregion

        #region "Liés aux Matchs"

        public List<Match> GetAllMatchs()
        {
            return m_matchs;
        }

        public void CreateMatch(Match match)
        {
            match.ID = m_availableMatchID++;
            m_matchs.Add(match);
        }

        public void UpdateMatch(Match match)
        {
            int index = m_matchs.FindIndex(m => m.ID == match.ID);
            if (index >= 0)
                m_matchs[index] = match;
            // Ne devrai jamais arriver
            else
                m_matchs.Add(match);
        }

        public void DeleteMatch(Match match)
        {
            foreach (Tournoi t in m_tournois.Where(t => t.Matchs.Contains(match)).ToList())
            {
                m_tournois.Remove(t);
            }

            m_matchs.Remove(match);
        }

        #endregion

        #region "Liés aux Tournois"

        public Tournoi GetTournoi(int id)
        {
            return m_tournois.ElementAt(id);
        }

        public List<Tournoi> GetGoodTournois()
        {
            List<Tournoi> tmp = new List<Tournoi>();

            foreach (Tournoi t in GetAllTournois())
            {
                if (t.Matchs.Count == 4)
                {
                    tmp.Add(t);
                }
            }

            return tmp;
        }

        public List<Tournoi> GetAllTournois()
        {
            // WARNING : tout est pointeur en C#
            // Clone la liste de tournoi 
            // (nécessaire dans le stub car sinon les modifications non désirées 
            // pour la sauvegarde sont quand même appliquées)
            List<Tournoi> list = new List<Tournoi>();
            foreach (Tournoi t in m_tournois)
            {
                Tournoi tbis = new Tournoi(t.ID, t.Nom, new List<Match>(t.Matchs));
                list.Add(tbis);
            }

            return list;
        }

        public void CreateTournoi(Tournoi tournoi)
        {
            m_tournois.Add(tournoi);
            m_availableTournoiID++;
        }

        public void UpdateTournoi(Tournoi tournoi)
        {
            int index = m_tournois.FindIndex(t => t.ID == tournoi.ID);
            if (index >= 0)
                m_tournois[index] = tournoi;
            // Ne devrai jamais arriver
            else
                m_tournois.Add(tournoi);
        }

        public void DeleteTournoi(Tournoi tournoi)
        {
            m_tournois.Remove(tournoi);
        }

        #endregion

        #region "Liés aux Caractéristiques"

        public List<Caracteristique> GetAllCaracs()
        {
            return m_caracs;
        }

        public List<Caracteristique> GetAllJediCaracs()
        {
            return m_caracs.Where(c => c.Type == ETypeCaracteristique.Jedi).ToList();
        }

        public List<Caracteristique> GetAllStadeCaracs()
        {
            return m_caracs.Where(c => c.Type == ETypeCaracteristique.Stade).ToList();
        }

        public void CreateCarac(Caracteristique carac)
        {
            carac.ID = m_availableCaracID++;
            m_caracs.Add(carac);
        }

        public void UpdateCarac(Caracteristique carac)
        {
            int index = m_caracs.FindIndex(c => c.ID == carac.ID);
            if (index >= 0)
                m_caracs[index] = carac;
            // Ne devrai jamais arriver
            else
                m_caracs.Add(carac);
        }

        public void DeleteCarac(Caracteristique carac)
        {
            m_caracs.Remove(carac);
        }

        #endregion

        #region "Liés aux Users"

        public Utilisateur GetUtilisateurByLogin(string login)
        {
            return m_users.Where(u => u.Login == login).FirstOrDefault();
        }

        public void CreateUser(Utilisateur user)
        {
            m_users.Add(user);
        }

        public void UpdateUser(Utilisateur user)
        {
            int index = m_users.FindIndex(u => u.Nom == user.Nom);
            if (index >= 0)
                m_users[index] = user;
            // Ne devrai jamais arriver
            else
                m_users.Add(user);
        }

        public void DeleteUser(Utilisateur user)
        {
            m_users.Remove(user);
        }

        #endregion
    }
}
