using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntitiesLayer;
using JediService.Models;

namespace JediService.Adapters
{
    public class StadeAdapter
    {
        public static Stade fromStadeContract(StadeContract stadeC)
        {
            // TODO
            return null;
        }

        public static StadeContract fromStade(Stade stade)
        {
            // create StadeContract
            StadeContract sc = new StadeContract(stade.Nom, stade.NbPlaces, stade.Planete, stade.Image);

            return sc;
        }
    }
}