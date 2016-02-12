using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using JediService;
using JediService.Models;

public class JediWebService : IJediWebService
{
    void IJediWebService.CreateJedi(JediContract jedi)
    {
        throw new NotImplementedException();
    }

    List<CategorieContract> IJediWebService.GetCategories(JediContract jedi)
    {
        throw new NotImplementedException();
    }

    List<JediContract> IJediWebService.GetJedis()
    {
        throw new NotImplementedException();
    }

    List<MatchContract> IJediWebService.GetMatchs()
    {
        throw new NotImplementedException();
    }

    List<StadeContract> IJediWebService.GetStades()
    {
        throw new NotImplementedException();
    }

    List<TournoiContract> IJediWebService.GetTournois()
    {
        throw new NotImplementedException();
    }
}
