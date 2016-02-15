using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntitiesLayer;
using JediService.Models;

namespace JediService.Adapters
{
    /// <summary>
    /// Classe d'adaptation des Caractéristiques.
    /// </summary>
    public class CaracteristiqueAdapter
    {
        /// <summary>
        /// Adapte une EDefCaracteristique Contract en EDefCaracteristique.
        /// </summary>
        /// <param name="defC">EDefCaracteristique Contract à adapter.</param>
        /// <returns>EDefCaracteristique.</returns>
        public static EDefCaracteristique fromDefCaracteristiqueContract(EDefCaracteristiqueContract defC)
        {
            switch (defC)
            {
                case EDefCaracteristiqueContract.Chance:
                    return EDefCaracteristique.Chance;
                case EDefCaracteristiqueContract.Defense:
                    return EDefCaracteristique.Defense;
                case EDefCaracteristiqueContract.Force:
                    return EDefCaracteristique.Force;
                case EDefCaracteristiqueContract.Sante:
                    return EDefCaracteristique.Sante;
                default:
                    return EDefCaracteristique.Chance;
            }
        }

        /// <summary>
        /// Adapte un EDefCaracteristique en EDefCaracteristique Contract.
        /// </summary>
        /// <param name="def">EDefCaracteristique à adapter.</param>
        /// <returns>EDefCaracteristique contract.</returns>
        public static EDefCaracteristiqueContract fromDefCaracteristique(EDefCaracteristique def)
        {
            switch (def)
            {
                case EDefCaracteristique.Chance:
                    return EDefCaracteristiqueContract.Chance;
                case EDefCaracteristique.Defense:
                    return EDefCaracteristiqueContract.Defense;
                case EDefCaracteristique.Force:
                    return EDefCaracteristiqueContract.Force;
                case EDefCaracteristique.Sante:
                    return EDefCaracteristiqueContract.Sante;
                default:
                    return EDefCaracteristiqueContract.Chance;
            }
        }

        /// <summary>
        /// Adapte une ETypeCaracteristique Contract en ETypeCaracteristique.
        /// </summary>
        /// <param name="typeC">ETypeCaracteristique Contract à adapter.</param>
        /// <returns>ETypeCaracteristique.</returns>
        public static ETypeCaracteristique fromTypeCaracteristiqueContract(ETypeCaracteristiqueContract typeC)
        {
            switch (typeC)
            {
                case ETypeCaracteristiqueContract.Jedi:
                    return ETypeCaracteristique.Jedi;
                case ETypeCaracteristiqueContract.Stade:
                    return ETypeCaracteristique.Stade;
                default:
                    return ETypeCaracteristique.Jedi;
            }
        }

        /// <summary>
        /// Adapte un ETypeCaracteristique en ETypeCaracteristique Contract.
        /// </summary>
        /// <param name="type">ETypeCaracteristique à adapter.</param>
        /// <returns>ETypeCaracteristique contract.</returns>
        public static ETypeCaracteristiqueContract fromTypeCaracteristique(ETypeCaracteristique type)
        {
            switch (type)
            {
                case ETypeCaracteristique.Jedi:
                    return ETypeCaracteristiqueContract.Jedi;
                case ETypeCaracteristique.Stade:
                    return ETypeCaracteristiqueContract.Stade;
                default:
                    return ETypeCaracteristiqueContract.Jedi;
            }
        }

        /// <summary>
        /// Adapte une Caractéristique en Caractéristique Contract.
        /// </summary>
        /// <param name="caracC">Caractéristique à adapter.</param>
        /// <returns>Caractéristique.</returns>
        public static Caracteristique fromCaracteristiqueContract(CaracteristiqueContract caracC)
        {
            Caracteristique c = new Caracteristique();
            c.Nom = caracC.Nom;
            c.Definition = CaracteristiqueAdapter.fromDefCaracteristiqueContract(caracC.Definition);
            c.Type = CaracteristiqueAdapter.fromTypeCaracteristiqueContract(caracC.Type);
            c.Valeur = caracC.Valeur;

            return c;
        }

        /// <summary>
        /// Adapte une liste de Caractéristique Contract en une liste de Caractéristique.
        /// </summary>
        /// <param name="caracsC">Liste de Caractéristique Contract à adapter.</param>
        /// <returns>Liste de Caractéristique.</returns>
        public static List<Caracteristique> fromCaracteristiqueContractList(List<CaracteristiqueContract> caracsC)
        {
            List<Caracteristique> listC = new List<Caracteristique>();

            foreach (CaracteristiqueContract cc in caracsC)
            {
                listC.Add(CaracteristiqueAdapter.fromCaracteristiqueContract(cc));
            }

            return listC;
        }

        /// <summary>
        /// Adapte un Caractéristique en Caractéristique Contract.
        /// </summary>
        /// <param name="carac">Caractéristique à adapter.</param>
        /// <returns>Caractéristique contract.</returns>
        public static CaracteristiqueContract fromCaracteristique(Caracteristique carac)
        {
            // Crée le MatchContract
            CaracteristiqueContract cc = new CaracteristiqueContract(   carac.Nom,
                                                                        CaracteristiqueAdapter.fromDefCaracteristique(carac.Definition),
                                                                        CaracteristiqueAdapter.fromTypeCaracteristique(carac.Type),
                                                                        carac.Valeur);
            return cc;
        }

        /// <summary>
        /// Adapte une liste de Caracteristique en une liste de Caracteristique Contract.
        /// </summary>
        /// <param name="caracs">Liste de Caracteristique à adapter.</param>
        /// <returns>Liste de Caracteristique Contract.</returns>
        public static List<CaracteristiqueContract> fromCaracteristiqueList(List<Caracteristique> caracs)
        {
            List<CaracteristiqueContract> listCC = new List<CaracteristiqueContract>();

            foreach (Caracteristique c in caracs)
            {
                listCC.Add(CaracteristiqueAdapter.fromCaracteristique(c));
            }

            return listCC;
        }
    }
}