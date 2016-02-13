using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntitiesLayer;
using JediService.Models;

namespace JediService.Adapters
{
    public class MatchAdapter
    {
        public static Match fromMatchContract(MatchContract matchC)
        {
            // TODO
            return null;
        }

        public static MatchContract fromMatch(Match match)
        {
            // prepare values
            JediContract jc1 = JediAdapter.fromJedi(match.Jedi1);
            JediContract jc2 = JediAdapter.fromJedi(match.Jedi2);
            StadeContract sc = StadeAdapter.fromStade(match.Stade);

            // create MatchContract
            MatchContract mc = new MatchContract(jc1, jc2, sc);

            return mc;
        }
    }
}