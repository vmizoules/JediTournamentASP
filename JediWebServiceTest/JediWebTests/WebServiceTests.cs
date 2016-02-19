using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JediWebApplication.JediWebService;
using System.Collections.Generic;

namespace JediWebApplication
{
    [TestClass]
    public class WebServiceTests
    {
        [TestMethod]
        public void TestGetAllJedis()
        {
            JediWebServiceClient client = new JediWebServiceClient();

            // Test les jedis retournées par le web service
            JediContract[] jedis = client.GetJedis();
            Assert.IsNotNull(jedis);
            Assert.IsTrue(jedis.Length >= 8);

            int index = 0;
            // Jedi Darth Vador
            Assert.AreEqual(jedis[index].Nom, "Darth Vador");
            Assert.AreEqual(jedis[index].IsSith, true);
            Assert.IsNotNull(jedis[index++].Caracteristiques);

            // Jedi Count Dooku
            Assert.AreEqual(jedis[index].Nom, "Count Dooku");
            Assert.AreEqual(jedis[index].IsSith, true);
            Assert.IsNull(jedis[index++].Caracteristiques);

            // Jedi Darth Maul
            Assert.AreEqual(jedis[index].Nom, "Darth Maul");
            Assert.AreEqual(jedis[index].IsSith, true);
            Assert.IsNotNull(jedis[index++].Caracteristiques);

            // Jedi Luke Skywalker
            Assert.AreEqual(jedis[index].Nom, "Luke Skywalker");
            Assert.AreEqual(jedis[index].IsSith, false);
            Assert.IsNotNull(jedis[index++].Caracteristiques);

            // Jedi Yoda
            Assert.AreEqual(jedis[index].Nom, "Yoda");
            Assert.AreEqual(jedis[index].IsSith, false);
            Assert.IsNotNull(jedis[index++].Caracteristiques);

            // Jedi Qui-Gon Jinn
            Assert.AreEqual(jedis[index].Nom, "Qui-Gon Jinn");
            Assert.AreEqual(jedis[index].IsSith, false);
            Assert.IsNull(jedis[index++].Caracteristiques);

            // Jedi Obi-Wan Kenobi
            Assert.AreEqual(jedis[index].Nom, "Obi-Wan Kenobi");
            Assert.AreEqual(jedis[index].IsSith, false);
            Assert.IsNotNull(jedis[index++].Caracteristiques);

            // Jedi Emperor Palpatine
            Assert.AreEqual(jedis[index].Nom, "Emperor Palpatine");
            Assert.AreEqual(jedis[index].IsSith, true);
            Assert.IsNull(jedis[index++].Caracteristiques);
        }

        [TestMethod]
        public void TestCreateJedi()
        {
            JediWebServiceClient client = new JediWebServiceClient();

            JediContract[] jedisBegin = client.GetJedis();
            Assert.IsNotNull(jedisBegin);

            // Test de création de jedi
            JediContract jedi1 = new JediContract();
            jedi1.Nom = "Test_1";
            jedi1.IsSith = false;

            CaracteristiqueContract[] caracs1 = new CaracteristiqueContract[1];
            caracs1[0] = new CaracteristiqueContract();
            jedi1.Caracteristiques = caracs1;
            client.CreateJedi(jedi1);

            // Vérifie que le jedi a bien été créé
            JediContract[] jedisMid = client.GetJedis();
            Assert.IsNotNull(jedisMid);
            Assert.AreEqual(jedisBegin.Length + 1, jedisMid.Length);

            int index = jedisMid.Length - 1;
            // Test du jedi ajouté
            Assert.AreEqual(jedisMid[index].Nom, "Test_1");
            Assert.AreEqual(jedisMid[index].IsSith, false);
            Assert.IsNotNull(jedisMid[index].Caracteristiques);
            Assert.AreEqual(jedisMid[index++].Caracteristiques.Length, 1);

            // Test de création de jedi
            JediContract jedi2 = new JediContract();
            jedi2.Nom = "Test_2";
            jedi2.IsSith = true;
            client.CreateJedi(jedi2);

            // Vérifie que le jedi a bien été créé
            JediContract[] jedisEnd = client.GetJedis();
            Assert.IsNotNull(jedisEnd);
            Assert.AreEqual(jedisMid.Length + 1, jedisEnd.Length);

            // Test du jedi ajouté
            Assert.AreEqual(jedisEnd[index].Nom, "Test_2");
            Assert.AreEqual(jedisEnd[index].IsSith, true);
            Assert.IsNull(jedisEnd[index++].Caracteristiques);
        }

        [TestMethod]
        public void TestGetCaracsFromJedi()
        {
            JediWebServiceClient client = new JediWebServiceClient();

            JediContract[] jedis = client.GetJedis();

            // Test get carac de jedi du web service
            if (jedis.Length > 0)
            {
                // Jedi Darth Vador
                CaracteristiqueContract[] caracs0 = client.GetCaracteristiques(jedis[0]);
                Assert.IsNotNull(caracs0);
                Assert.AreEqual(caracs0.Length, 3);

                // Jedi Count Dooku
                CaracteristiqueContract[] caracs1 = client.GetCaracteristiques(jedis[1]);
                Assert.IsNull(caracs1);

                // Nouveau Jedi
                JediContract newJedi1 = new JediContract();
                newJedi1.Nom = "Test 1";
                newJedi1.IsSith = false;
                CaracteristiqueContract[] caracs = new CaracteristiqueContract[1];
                caracs[0] = new CaracteristiqueContract();
                newJedi1.Caracteristiques = caracs;

                CaracteristiqueContract[] caracs3 = client.GetCaracteristiques(newJedi1);
                Assert.IsNotNull(caracs3);
                Assert.AreEqual(caracs3.Length, 1);

                // Nouveau Jedi 2
                JediContract newJedi2 = new JediContract();
                newJedi2.Nom = "Test 2";
                newJedi2.IsSith = false;

                CaracteristiqueContract[] caracs4 = client.GetCaracteristiques(newJedi2);
                Assert.IsNull(caracs4);
            }
        }

        [TestMethod]
        public void TestGetAllStades()
        {
            JediWebServiceClient client = new JediWebServiceClient();

            // Test les stades retournées par le web service
            StadeContract[] stades = client.GetStades();
            Assert.IsNotNull(stades);
            Assert.AreEqual(stades.Length, 4);

            int index = 0;
            // Stade Le Drake
            Assert.AreEqual(stades[index].Nom, "Le Drake");
            Assert.AreEqual(stades[index].Planete, "Jakku");
            Assert.AreEqual(stades[index].NbPlaces, 150);
            Assert.IsNull(stades[index++].Caracteristiques);

            // Stade Le Sandstorm
            Assert.AreEqual(stades[index].Nom, "Le Sandstorm");
            Assert.AreEqual(stades[index].Planete, "Tatooine");
            Assert.AreEqual(stades[index].NbPlaces, 2000);
            Assert.IsNotNull(stades[index++].Caracteristiques);

            // Stade Le Cyberia
            Assert.AreEqual(stades[index].Nom, "Le Cyberia");
            Assert.AreEqual(stades[index].Planete, "Hoth");
            Assert.AreEqual(stades[index].NbPlaces, 10000);
            Assert.IsNotNull(stades[index++].Caracteristiques);

            // Stade L'Impérial
            Assert.AreEqual(stades[index].Nom, "L'Impérial");
            Assert.AreEqual(stades[index].Planete, "Coruscant");
            Assert.AreEqual(stades[index].NbPlaces, 110000);
            Assert.IsNotNull(stades[index++].Caracteristiques);
        }

        [TestMethod]
        public void TestGetAllMatchs()
        {
            JediWebServiceClient client = new JediWebServiceClient();

            // Test les matchs retournées par le web service
            MatchContract[] matchs = client.GetMatchs();
            Assert.IsNotNull(matchs);
            Assert.AreEqual(matchs.Length, 4);

            int index = 0;
            // Match 1
            Assert.AreEqual(matchs[index].IdVainqueur, -1);
            Assert.IsNotNull(matchs[index].Jedi1);
            Assert.AreEqual(matchs[index].Jedi1.Nom, "Darth Maul");
            Assert.IsNotNull(matchs[index].Jedi2);
            Assert.AreEqual(matchs[index].Jedi2.Nom, "Luke Skywalker");
            Assert.AreEqual(matchs[index].PhaseTournoi, EPhaseTournoiContract.QuartFinale);
            Assert.IsNotNull(matchs[index].Stade);
            Assert.AreEqual(matchs[index++].Stade.Nom, "Le Drake");

            // Match 2
            Assert.AreEqual(matchs[index].IdVainqueur, -1);
            Assert.IsNotNull(matchs[index].Jedi1);
            Assert.AreEqual(matchs[index].Jedi1.Nom, "Darth Vador");
            Assert.IsNotNull(matchs[index].Jedi2);
            Assert.AreEqual(matchs[index].Jedi2.Nom, "Count Dooku");
            Assert.AreEqual(matchs[index].PhaseTournoi, EPhaseTournoiContract.QuartFinale);
            Assert.IsNotNull(matchs[index].Stade);
            Assert.AreEqual(matchs[index++].Stade.Nom, "Le Sandstorm");

            // Match 3
            Assert.AreEqual(matchs[index].IdVainqueur, -1);
            Assert.IsNotNull(matchs[index].Jedi1);
            Assert.AreEqual(matchs[index].Jedi1.Nom, "Yoda");
            Assert.IsNotNull(matchs[index].Jedi2);
            Assert.AreEqual(matchs[index].Jedi2.Nom, "Qui-Gon Jinn");
            Assert.AreEqual(matchs[index].PhaseTournoi, EPhaseTournoiContract.QuartFinale);
            Assert.IsNotNull(matchs[index].Stade);
            Assert.AreEqual(matchs[index++].Stade.Nom, "Le Sandstorm");

            // Match 4
            Assert.AreEqual(matchs[index].IdVainqueur, -1);
            Assert.IsNotNull(matchs[index].Jedi1);
            Assert.AreEqual(matchs[index].Jedi1.Nom, "Obi-Wan Kenobi");
            Assert.IsNotNull(matchs[index].Jedi2);
            Assert.AreEqual(matchs[index].Jedi2.Nom, "Emperor Palpatine");
            Assert.AreEqual(matchs[index].PhaseTournoi, EPhaseTournoiContract.QuartFinale);
            Assert.IsNotNull(matchs[index].Stade);
            Assert.AreEqual(matchs[index++].Stade.Nom, "Le Cyberia");
        }

        [TestMethod]
        public void TestGetAllTournois()
        {
            JediWebServiceClient client = new JediWebServiceClient();

            // Test les tournois retournées par le web service
            TournoiContract[] tournois = client.GetTournois();
            Assert.IsNotNull(tournois);
            Assert.AreEqual(tournois.Length, 1);

            int index = 0;
            // Tournoi
            Assert.AreEqual(tournois[index].Nom, "Tournoi 1");
            Assert.IsNotNull(tournois[index].Matchs);
            Assert.AreEqual(tournois[index].Matchs.Length, 4);
        }
    }
}
