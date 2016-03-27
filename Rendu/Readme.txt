Le dossier JediWebService contient la solution Visual studio contenant les projets liés au web service.
Notamment les classes de l'architecture 4 tiers mis en place au cours des Tps précédents.


Le dossier JediWebSiteApplication contient la solution Visual studio contenant le projet du site web ASP .NET créé au cours des Tps.


Le dossier JediWebServiceTest contient la solution Visual studio avec un projet contenant des tests unitaires pour le web service.
Ces tests sont à réaliser sur le Stub.


Le projet du web service est capable d'utiliser chacune des implémentations d'accès aux données, à savoir le stub 
des données et la base de données Azure. Pour passer de l'un à l'autre il faut changer l'implémentation instanciée dans 
le constructeur du DalManager.


Note : Lorsqu'on utilise l'implémentation Azure il y a cependant une limitation. En effet, il est possible d'affecter un match
déjà utilisé dans un autre tournoi. Ceci est aussi possible avec le stub et fonctionne. Malheureusement, cela ne fonctionne pas
avec Azure du fait de la structure des tables de stockage, celle-ci ne supporte pas l'affectation multiple de match.
Pour tout le reste, tout est semblable.