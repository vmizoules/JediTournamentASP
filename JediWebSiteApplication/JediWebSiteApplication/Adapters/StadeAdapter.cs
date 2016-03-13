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
            if (stadeC == null)
                return null;

            StadeModel s = new StadeModel();
            s.ID = stadeC.ID;
            s.Nom = stadeC.Nom;
            s.NbPlaces = stadeC.NbPlaces;
            s.Planete = stadeC.Planete;

            if (stadeC.Caracteristiques == null)
                stadeC.Caracteristiques = new CaracteristiqueContract[0];

            s.Caracteristiques = CaracteristiqueAdapter.fromCaracteristiqueContractList(stadeC.Caracteristiques.ToList());

            return s;
        }

        /// <summary>
        /// Adapte une liste de Stade Contract en une liste de Stade Model.
        /// </summary>
        /// <param name="stadesC">Liste de Stade Contract à adapter.</param>
        /// <returns>Liste de Stade Model.</returns>
        public static List<StadeModel> fromStadeContractList(List<StadeContract> stadesC)
        {
            List<StadeModel> listS = new List<StadeModel>();

            foreach (StadeContract sc in stadesC)
            {
                listS.Add(StadeAdapter.fromStadeContract(sc));
            }

            return listS;
        }

        /// <summary>
        /// Adapte un Stade Model en Stade Contract.
        /// </summary>
        /// <param name="stade">Stade à adapter.</param>
        /// <returns>Stade contract.</returns>
        public static StadeContract fromStadeModel(StadeModel stade)
        {
            if (stade == null)
                return null;

            StadeContract sc = new StadeContract();
            sc.ID = stade.ID;
            sc.Nom = stade.Nom;
            sc.NbPlaces = stade.NbPlaces;
            sc.Planete = stade.Planete;

            if (stade.Caracteristiques == null)
                stade.Caracteristiques = new List<CaracteristiqueModel>();

            sc.Caracteristiques = CaracteristiqueAdapter.fromCaracteristiqueModelList(stade.Caracteristiques).ToArray();

            return sc;
        }
    }
}