using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace JediService.Models
{
    /// <summary>
    /// Classe de contrat Utilisateur pour le webservice
    /// </summary>
    [DataContract]
    public class UtilisateurContract
    {

        public UtilisateurContract()
            : this ("DefaultName", "DefaultFirstname", "DefaultLogin", "DefaultPassword")
        {
        }

        public UtilisateurContract(string nom, string prenom, string login, string passwd, int points = 0)
        {
            Nom = nom;
            Prenom = prenom;
            Login = login;
            Password = passwd;
            Points = points;
        }

        /// <summary>
        /// Type de la caractéristique (Entité concernée).
        /// </summary>
        [DataMember]
        public string Nom { get; set; }

        /// <summary>
        /// Prénom de l'utilisateur.
        /// </summary>
        [DataMember]
        public string Prenom { get; set; }

        /// <summary>
        /// Login de l'utilisateur.
        /// </summary>
        [DataMember]
        public string Login { get; set; }
        /// <summary>
        /// Mot de passe de l'utilisateur.
        /// </summary>

        [DataMember]
        public string Password { get; set; }

        /// <summary>
        /// Nombre de point de l'utilisateur.
        /// </summary>
        [DataMember]
        public int Points { get; set; }

    }
}