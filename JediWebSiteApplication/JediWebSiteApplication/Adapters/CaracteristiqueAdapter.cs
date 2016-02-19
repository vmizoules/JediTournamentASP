using JediWebSiteApplication.Models;
using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Adapters
{
    /// <summary>
    /// Classe d'adaptation des Caractéristiques.
    /// </summary>
    public class CaracteristiqueAdapter
    {
        /// <summary>
        /// Adapte une EDefCaracteristique Contract en EDefCaracteristique Model.
        /// </summary>
        /// <param name="defC">EDefCaracteristique Contract à adapter.</param>
        /// <returns>EDefCaracteristique Model.</returns>
        public static EDefCaracteristiqueModel fromDefCaracteristiqueContract(EDefCaracteristiqueContract defC)
        {
            switch (defC)
            {
                case EDefCaracteristiqueContract.Chance:
                    return EDefCaracteristiqueModel.Chance;
                case EDefCaracteristiqueContract.Defense:
                    return EDefCaracteristiqueModel.Defense;
                case EDefCaracteristiqueContract.Force:
                    return EDefCaracteristiqueModel.Force;
                case EDefCaracteristiqueContract.Sante:
                    return EDefCaracteristiqueModel.Sante;
                default:
                    return EDefCaracteristiqueModel.Chance;
            }
        }

        /// <summary>
        /// Adapte un EDefCaracteristique Model en EDefCaracteristique Contract.
        /// </summary>
        /// <param name="def">EDefCaracteristique à adapter.</param>
        /// <returns>EDefCaracteristique contract.</returns>
        public static EDefCaracteristiqueContract fromDefCaracteristiqueModel(EDefCaracteristiqueModel def)
        {
            switch (def)
            {
                case EDefCaracteristiqueModel.Chance:
                    return EDefCaracteristiqueContract.Chance;
                case EDefCaracteristiqueModel.Defense:
                    return EDefCaracteristiqueContract.Defense;
                case EDefCaracteristiqueModel.Force:
                    return EDefCaracteristiqueContract.Force;
                case EDefCaracteristiqueModel.Sante:
                    return EDefCaracteristiqueContract.Sante;
                default:
                    return EDefCaracteristiqueContract.Chance;
            }
        }

        /// <summary>
        /// Adapte une ETypeCaracteristique Contract en ETypeCaracteristique Model.
        /// </summary>
        /// <param name="typeC">ETypeCaracteristique Contract à adapter.</param>
        /// <returns>ETypeCaracteristique Model.</returns>
        public static ETypeCaracteristiqueModel fromTypeCaracteristiqueContract(ETypeCaracteristiqueContract typeC)
        {
            switch (typeC)
            {
                case ETypeCaracteristiqueContract.Jedi:
                    return ETypeCaracteristiqueModel.Jedi;
                case ETypeCaracteristiqueContract.Stade:
                    return ETypeCaracteristiqueModel.Stade;
                default:
                    return ETypeCaracteristiqueModel.Jedi;
            }
        }

        /// <summary>
        /// Adapte un ETypeCaracteristique Model en ETypeCaracteristique Contract.
        /// </summary>
        /// <param name="type">ETypeCaracteristique Model à adapter.</param>
        /// <returns>ETypeCaracteristique contract.</returns>
        public static ETypeCaracteristiqueContract fromTypeCaracteristiqueModel(ETypeCaracteristiqueModel type)
        {
            switch (type)
            {
                case ETypeCaracteristiqueModel.Jedi:
                    return ETypeCaracteristiqueContract.Jedi;
                case ETypeCaracteristiqueModel.Stade:
                    return ETypeCaracteristiqueContract.Stade;
                default:
                    return ETypeCaracteristiqueContract.Jedi;
            }
        }

        /// <summary>
        /// Adapte une Caractéristique Model en Caractéristique Contract.
        /// </summary>
        /// <param name="caracC">Caractéristique à adapter.</param>
        /// <returns>Caractéristique Model.</returns>
        public static CaracteristiqueModel fromCaracteristiqueContract(CaracteristiqueContract caracC)
        {
            return new CaracteristiqueModel(/*caracC.ID */ -1, // Maybe change
                                            caracC.Nom,
                                            caracC.Definition,
                                            caracC.Type,
                                            caracC.Valeur);
        }

        /// <summary>
        /// Adapte une liste de Caractéristique Contract en une liste de Caractéristique Model.
        /// </summary>
        /// <param name="caracsC">Liste de Caractéristique Contract à adapter.</param>
        /// <returns>Liste de Caractéristique Model.</returns>
        public static List<CaracteristiqueModel> fromCaracteristiqueContractList(List<CaracteristiqueContract> caracsC)
        {
            if (caracsC == null)
                return null;

            List<CaracteristiqueModel> listC = new List<CaracteristiqueModel>();

            foreach (CaracteristiqueContract cc in caracsC)
            {
                listC.Add(CaracteristiqueAdapter.fromCaracteristiqueContract(cc));
            }

            return listC;
        }

        /// <summary>
        /// Adapte un Caractéristique Model en Caractéristique Contract.
        /// </summary>
        /// <param name="carac">Caractéristique à adapter.</param>
        /// <returns>Caractéristique contract.</returns>
        public static CaracteristiqueContract fromCaracteristiqueModel(CaracteristiqueModel carac)
        {
            CaracteristiqueContract cc = new CaracteristiqueContract();
            //cc.ID = carac.ID; // Maybe 
            cc.Nom = carac.Nom;
            cc.Definition = CaracteristiqueAdapter.fromDefCaracteristiqueModel(carac.Definition);
            cc.Type = CaracteristiqueAdapter.fromTypeCaracteristiqueModel(carac.Type);
            cc.Valeur = carac.Valeur;

            return cc;
        }

        /// <summary>
        /// Adapte une liste de Caracteristique Model en une liste de Caracteristique Contract.
        /// </summary>
        /// <param name="caracs">Liste de Caracteristique à adapter.</param>
        /// <returns>Liste de Caracteristique Contract.</returns>
        public static List<CaracteristiqueContract> fromCaracteristiqueModelList(List<CaracteristiqueModel> caracs)
        {
            if (caracs == null)
                return null;

            List<CaracteristiqueContract> listCC = new List<CaracteristiqueContract>();

            foreach (CaracteristiqueModel c in caracs)
            {
                listCC.Add(CaracteristiqueAdapter.fromCaracteristiqueModel(c));
            }

            return listCC;
        }
    }
}