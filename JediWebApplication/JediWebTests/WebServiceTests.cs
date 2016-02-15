using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JediWebApplication.JediWebService;

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
            Assert.AreEqual(jedis.Length, 8);

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
    }
}
