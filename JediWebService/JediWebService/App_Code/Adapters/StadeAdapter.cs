using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntitiesLayer;
using JediService.Models;

namespace JediService.Adapters
{
    /// <summary>
    /// Classe d'adaptation des Stades.
    /// </summary>
    public class StadeAdapter
    {
        /// <summary>
        /// Adapte un Stade Contract en Stade.
        /// </summary>
        /// <param name="stadeC">Stade Contract à adapter.</param>
        /// <returns>Stade.</returns>
        public static Stade fromStadeContract(StadeContract stadeC)
        {
            Stade s = new Stade(stadeC.ID,
                                stadeC.Nom,
                                stadeC.NbPlaces,
                                stadeC.Planete,
                                CaracteristiqueAdapter.fromCaracteristiqueContractList(stadeC.Caracteristiques),
                                "");

            return s;
        }

        /// <summary>
        /// Adapte un Stade en Stade Contract.
        /// </summary>
        /// <param name="stade">Stade à adapter.</param>
        /// <returns>Stade contract.</returns>
        public static StadeContract fromStade(Stade stade)
        {
            StadeContract sc = new StadeContract(   stade.ID,
                                                    stade.Nom, 
                                                    stade.NbPlaces,
                                                    stade.Planete,
                                                    CaracteristiqueAdapter.fromCaracteristiqueList(stade.Caracteristiques));
            return sc;
        }
    }
}