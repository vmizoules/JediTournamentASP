Le dossier JediWebService contient la solution Visual studio contenant les projets li�s au web service.
Notamment les classes de l'architecture 4 tiers mis en place au cours des Tps pr�c�dents.


Le dossier JediWebSiteApplication contient la solution Visual studio contenant le projet du site web ASP .NET cr�� au cours des Tps.


Le dossier JediWebServiceTest contient la solution Visual studio avec un projet contenant des tests unitaires pour le web service.
Ces tests sont � r�aliser sur le Stub.


Le projet du web service est capable d'utiliser chacune des impl�mentations d'acc�s aux donn�es, � savoir le stub 
des donn�es et la base de donn�es Azure. Pour passer de l'un � l'autre il faut changer l'impl�mentation instanci�e dans 
le constructeur du DalManager.


Note : Lorsqu'on utilise l'impl�mentation Azure il y a cependant une limitation. En effet, il est possible d'affecter un match
d�j� utilis� dans un autre tournoi. Ceci est aussi possible avec le stub et fonctionne. Malheureusement, cela ne fonctionne pas
avec Azure du fait de la structure des tables de stockage, celle-ci ne supporte pas l'affectation multiple de match.
Pour tout le reste, tout est semblable.