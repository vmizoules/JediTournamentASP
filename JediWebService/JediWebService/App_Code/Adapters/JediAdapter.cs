using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntitiesLayer;
using JediService.Models;

namespace JediService.Adapters
{
    /// <summary>
    /// Classe d'adaptation des Jedis.
    /// </summary>
    public class JediAdapter
    {
        /// <summary>
        /// Adapte un Jedi Contract en Jedi.
        /// </summary>
        /// <param name="jediC">Jedi Contract à adapter.</param>
        /// <returns>Jedi.</returns>
        public static Jedi fromJediContract(JediContract jediC)
        {
            Jedi j = new Jedi(  jediC.ID, 
                                jediC.Nom, 
                                jediC.IsSith, 
                                CaracteristiqueAdapter.fromCaracteristiqueContractList(jediC.Caracteristiques), 
                                "");
            return j;
        }

        /// <summary>
        /// Adapte un Jedi en Jedi Contract.
        /// </summary>
        /// <param name="jedi">Jedi à adapter.</param>
        /// <returns>Jedi contract.</returns>
        public static JediContract fromJedi(Jedi jedi)
        {
            JediContract jc = new JediContract( jedi.ID,
                                                jedi.IsSith, 
                                                jedi.Nom, 
                                                CaracteristiqueAdapter.fromCaracteristiqueList(jedi.Caracteristiques));
            return jc;
        }
    }
}