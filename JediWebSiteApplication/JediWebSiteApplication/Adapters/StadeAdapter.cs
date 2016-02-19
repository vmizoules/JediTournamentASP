using JediWebSiteApplication.Models;
using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Adapters
{
    /// <summary>
    /// Classe d'adaptation des Stades.
    /// </summary>
    public class StadeAdapter
    {
        /// <summary>
        /// Adapte un Stade Contract en Stade Model.
        /// </summary>
        /// <param name="stadeC">Stade Contract à adapter.</param>
        /// <returns>Stade Model.</returns>
        public static StadeModel fromStadeContract(StadeContract stadeC)
        {
            StadeModel s = new StadeModel();
            //s.ID = stadeC.ID; // Maybe change
            s.ID = -1;
            s.Nom = stadeC.Nom;
            s.NbPlaces = stadeC.NbPlaces;
            s.Planete = stadeC.Planete;
            s.Caracteristiques = CaracteristiqueAdapter.fromCaracteristiqueContractList(stadeC.Caracteristiques.ToList());

            return s;
        }

        /// <summary>
        /// Adapte un Stade Model en Stade Contract.
        /// </summary>
        /// <param name="stade">Stade à adapter.</param>
        /// <returns>Stade contract.</returns>
        public static StadeContract fromStadeModel(StadeModel stade)
        {
            StadeContract sc = new StadeContract();
            //sc.ID = stade.ID; // Maybe change
            sc.Nom = stade.Nom;
            sc.NbPlaces = stade.NbPlaces;
            sc.Planete = stade.Planete;
            sc.Caracteristiques = CaracteristiqueAdapter.fromCaracteristiqueModelList(stade.Caracteristiques).ToArray();

            return sc;
        }
    }
}