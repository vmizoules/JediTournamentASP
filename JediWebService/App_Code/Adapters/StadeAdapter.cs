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
        /// Adapte un Stade en Stade Contract.
        /// </summary>
        /// <param name="stadeC">Stade à adapter.</param>
        /// <returns>Stade.</returns>
        public static Stade fromStadeContract(StadeContract stadeC)
        {
            Stade s = new Stade();
            s.Nom = stadeC.Nom;
            s.NbPlaces = stadeC.NbPlaces;
            s.Planete = stadeC.Planete;

            return s;
        }

        /// <summary>
        /// Adapte un Stade en Stade Contract.
        /// </summary>
        /// <param name="stade">Stade à adapter.</param>
        /// <returns>Stade contract.</returns>
        public static StadeContract fromStade(Stade stade)
        {
            StadeContract sc = new StadeContract(stade.Nom, stade.NbPlaces, stade.Planete);
            return sc;
        }
    }
}