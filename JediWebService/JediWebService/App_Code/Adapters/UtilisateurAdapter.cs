using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntitiesLayer;
using JediService.Models;

/// <summary>
/// Description résumée de UtilisateurAdapter
/// </summary>
public class UtilisateurAdapter
{
	public static Utilisateur fromUtilisateurContract(UtilisateurContract userC)
    {
        if(userC == null) {
            return null;
        }

        Utilisateur user = new Utilisateur(
                userC.Nom,
                userC.Prenom,
                userC.Login,
                userC.Password,
                userC.Points
            );

        return user;
    }

    public static UtilisateurContract fromUtilisateur(Utilisateur user)
    {
        if (user == null)
        {
            return null;
        }

        UtilisateurContract userC = new UtilisateurContract(
                user.Nom,
                user.Prenom,
                user.Login,
                user.Password,
                user.Points
            );

        return userC;
    }
}