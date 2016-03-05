using JediWebSiteApplication.Models;
using JediWebSiteApplication.WebServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JediWebSiteApplication.Adapters
{
    /// <summary>
    /// Classe d'adaptation des Jedis.
    /// </summary>
    public class JediAdapter
    {
        /// <summary>
        /// Adapte un Jedi Contract en Jedi Model.
        /// </summary>
        /// <param name="jediC">Jedi Contract à adapter.</param>
        /// <returns>Jedi Model.</returns>
        public static JediModel fromJediContract(JediContract jediC)
        {
            JediModel j = new JediModel();
            j.ID = jediC.ID;
            j.Nom = jediC.Nom;
            j.IsSith = jediC.IsSith;

            if (jediC.Caracteristiques == null)
                jediC.Caracteristiques = new CaracteristiqueContract[0];

            j.Caracteristiques = CaracteristiqueAdapter.fromCaracteristiqueContractList(jediC.Caracteristiques.ToList());      

            return j;
        }

        /// <summary>
        /// Adapte une liste de Jedi Contract en une liste de Jedi Model.
        /// </summary>
        /// <param name="jedisC">Liste de Jedi Contract à adapter.</param>
        /// <returns>Liste de Jedi Model.</returns>
        public static List<JediModel> fromJediContractList(List<JediContract> jedisC)
        {
            List<JediModel> listJ = new List<JediModel>();

            foreach (JediContract jc in jedisC)
            {
                listJ.Add(JediAdapter.fromJediContract(jc));
            }

            return listJ;
        }

        /// <summary>
        /// Adapte un Jedi Model en Jedi Contract.
        /// </summary>
        /// <param name="jedi">Jedi à adapter.</param>
        /// <returns>Jedi contract.</returns>
        public static JediContract fromJediModel(JediModel jedi)
        {
            JediContract jc = new JediContract();
            jc.ID = jedi.ID;
            jc.Nom = jedi.Nom;
            jc.IsSith = jedi.IsSith;

            if (jedi.Caracteristiques == null)
                jedi.Caracteristiques = new List<CaracteristiqueModel>();

            jc.Caracteristiques = CaracteristiqueAdapter.fromCaracteristiqueModelList(jedi.Caracteristiques).ToArray();

            return jc;
        }
    }
}