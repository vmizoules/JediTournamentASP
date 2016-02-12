using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using JediService.Models;

namespace JediService
{
    public class JediService : IJediService
    {
        void IJediService.CreateJedi(JediContract jedi)
        {
            throw new NotImplementedException();
        }

        List<CategorieContract> IJediService.GetCategories(JediContract jedi)
        {
            throw new NotImplementedException();
        }

        List<JediContract> IJediService.GetJedis()
        {
            throw new NotImplementedException();
        }

        List<MatchContract> IJediService.GetMatchs()
        {
            throw new NotImplementedException();
        }

        List<StadeContract> IJediService.GetStades()
        {
            throw new NotImplementedException();
        }

        List<TournoiContract> IJediService.GetTournois()
        {
            throw new NotImplementedException();
        }
    }
}
