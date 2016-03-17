using System;
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

    #region "Opérations liées aux jedis"

    void IJediWebService.CreateJedi(JediContract jedi)
    {
        Jedi j = JediAdapter.fromJediContract(jedi);
        m_manager.CreateJedi(j);
    }

    void IJediWebService.UpdateJedi(JediContract jedi)
    {
        Jedi j = JediAdapter.fromJediContract(jedi);
        m_manager.UpdateJedi(j);
    }

    void IJediWebService.DeleteJedi(JediContract jedi)
    {
        Jedi j = JediAdapter.fromJediContract(jedi);
        m_manager.DeleteJedi(j);
    }

    List<CaracteristiqueContract> IJediWebService.GetCaracteristiques(int jediID)
    {
        Jedi jedi = m_manager.GetJediByID(jediID);
        if (jedi != null)
            return CaracteristiqueAdapter.fromCaracteristiqueList(jedi.Caracteristiques);
        else
            return null;
    }

    JediContract IJediWebService.GetJediById(int jediID)
    {
        return JediAdapter.fromJedi(m_manager.GetJediByID(jediID));
    }

    List<JediContract> IJediWebService.GetJedis()
    {
        List<JediContract> listC = new List<JediContract>();
        List<Jedi> list = m_manager.GetAllJedis();

        foreach (Jedi j in list)
        {
            listC.Add(JediAdapter.fromJedi(j));
        }

        return listC;
    }

    #endregion
    #region "Opérations liées aux stades"

    void IJediWebService.CreateStade(StadeContract stade)
    {
        Stade s = StadeAdapter.fromStadeContract(stade);
        m_manager.CreateStade(s);
    }

    void IJediWebService.UpdateStade(StadeContract stade)
    {
        Stade s = StadeAdapter.fromStadeContract(stade);
        m_manager.UpdateStade(s);
    }

    void IJediWebService.DeleteStade(StadeContract stade)
    {
        Stade s = StadeAdapter.fromStadeContract(stade);
        m_manager.DeleteStade(s);
    }

    StadeContract IJediWebService.GetStadeById(int stadeID)
    {
        return StadeAdapter.fromStade(m_manager.GetStadeByID(stadeID));
    }

    List<StadeContract> IJediWebService.GetStades()
    {
        List<StadeContract> listC = new List<StadeContract>();
        List<Stade> list = m_manager.GetAllStades();

        foreach (Stade s in list)
        {
            listC.Add(StadeAdapter.fromStade(s));
        }

        return listC;
    }

    #endregion
    #region "Opérations liées aux matchs"

    void IJediWebService.CreateMatch(MatchContract match)
    {
        Match m = MatchAdapter.fromMatchContract(match);
        m_manager.CreateMatch(m);
    }

    void IJediWebService.UpdateMatch(MatchContract match)
    {
        Match m = MatchAdapter.fromMatchContract(match);
        m_manager.UpdateMatch(m);
    }

    void IJediWebService.DeleteMatch(MatchContract match)
    {
        Match m = MatchAdapter.fromMatchContract(match);
        m_manager.DeleteMatch(m);
    }

    MatchContract IJediWebService.GetMatchById(int matchID)
    {
        return MatchAdapter.fromMatch(m_manager.GetMatchByID(matchID));
    }

    List<MatchContract> IJediWebService.GetMatchs()
    {
        List<MatchContract> listC = new List<MatchContract>();
        List<Match> list = m_manager.GetAllMatchs();

        foreach (Match m in list)
        {
            listC.Add(MatchAdapter.fromMatch(m));
        }

        return listC;
    }

    int IJediWebService.ComputeMatchResult(MatchContract match)
    {
        return m_manager.ComputeMatchResult(MatchAdapter.fromMatchContract(match));
    }

    #endregion
    #region "Opérations liées aux tournois"

    void IJediWebService.CreateTournoi(TournoiContract tournoi)
    {
        Tournoi t = TournoiAdapter.fromTournoiContract(tournoi);
        m_manager.CreateTournoi(t);
    }

    void IJediWebService.UpdateTournoi(TournoiContract tournoi)
    {
        Tournoi t = TournoiAdapter.fromTournoiContract(tournoi);
        m_manager.UpdateTournoi(t);
    }

    void IJediWebService.DeleteTournoi(TournoiContract tournoi)
    {
        Tournoi t = TournoiAdapter.fromTournoiContract(tournoi);
        m_manager.DeleteTournoi(t);
    }

    List<TournoiContract> IJediWebService.GetTournois()
    {
        List<TournoiContract> listC = new List<TournoiContract>();
        List<Tournoi> list = m_manager.GetAllTournois();

        foreach (Tournoi t in list)
        {
            listC.Add(TournoiAdapter.fromTournoi(t));
        }

        return listC;
    }

    #endregion
    #region "Opérations liées aux utilisateurs"

    void IJediWebService.CreateUtilisateur(UtilisateurContract utilisateur)
    {
        Utilisateur user = UtilisateurAdapter.fromUtilisateurContract(utilisateur);
        m_manager.CreateUser(user);
    }

    UtilisateurContract IJediWebService.CheckLoginPassword(string login, string passwd)
    {
        Utilisateur user = m_manager.CheckLoginPassword(login, passwd);
        UtilisateurContract uc = UtilisateurAdapter.fromUtilisateur(user);

        return uc;
    }

    #endregion
}
