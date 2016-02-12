﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using JediService;
using JediService.Adapters;
using JediService.Models;
using EntitiesLayer;
using BusinessLayer;

public class JediWebService : IJediWebService
{
    /// <summary>
    /// Business Layer.
    /// </summary>
    private JediBusinessManager m_manager;

    /// <summary>
    /// Constructeur.
    /// </summary>
    public JediWebService()
    {
        m_manager = new JediBusinessManager();
    }

    // Implémentation de l'interface
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
        List<JediContract> listC = new List<JediContract>();
        List<Jedi> list = m_manager.getAllJedis();

        foreach (Jedi j in list)
        {
            listC.Add(JediAdapter.fromJedi(j));
        }

        return listC;
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
