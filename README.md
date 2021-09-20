# Présentation de GéoBAM

GéoBAM est une application web multi-platforme, interactive et pratique. Elle est dédiée à la géolocalisation des points d'adresses et les stocker dans une base de données interne. Ensuite,les points collectés sont rajoutés à une carte interactive.  

*<h3>PLAN<h3>* 
 1. Outils utilisés
 2. Installations à faire
 3. Ouverture du projet en MS visual studio 2019
 4. Description du code
 5. Déploiment de l'application
 6. Webographie
 7. License 
 
## Outils utilisés
 GéoBAM a été développée en utilisant la framework ASP.NET Core Razor Pages. ASP.NET Core est une infrastructure multiplateforme, à hautes performances et open source pour la création d’applications modernes, basées sur le cloud et connectées à Internet.Cette Framework permet de:
 * Créer des applications et services Web, des applications d'Internet des objets (IOT) et des serveurs principaux mobiles.
 * Utiliser les outils de développement préférés sur Windows, macOS et Linux (multi-plateforme). 
 * Déployer dans le cloud ou localement.
 * Exécutez sur .net Core. 

La technologie Razor a été conçu pour faciliter la conception des pages ASP.NET. Elle introduit une syntaxe de programmation assez facilement compréhensible, qui permet d'insérer du code serveur dans une page Web qui peut également contenir du HTML, du CSS et des scripts JavaScript.

Le moteur Razor est fluide, compact, expressif et s'appuie sur la syntaxe des langages .NET C# et Visual Basic .NET. Il offre la puissance d'ASP.NET pour la création rapide des applications Web fonctionnelles et sophistiquées. 

En plus de ça, on a utilisé la framework <strong>Entity FrameWork</strong> , qui est une technologie <strong>ORM</strong> (Objet-Relational mapping) ayant pour but de faciliter l'accès à une source de données sans  avoir la sensation de travailler avec une base de données. Cela paraît étrange, mais signifie simplement que grâce à cet ORM (Objet-Relationnel Mapping), nous n’allons plus écrire de requêtes, ni créer de tables, etc., via un système de gestion de base de données mais directement manipuler les données dans notre code C#. Cette technologie repose sur les correspondances entre les schémas de la base de données et les classes du programme applicatif (dans notre cas une classe C# representant un objet de la base de données). On pourrait la désigner par là, « comme une couche d'abstraction entre le monde objet et monde relationnel ». 
	
Vu que notre application doit assurer la gestion des points d'adresses, ainsi que l'accès des utilisateurs (opérateurs et administrateurs), il a été nécéssaire de passer par le <strong>modèle CRUD (Create, Read,Update, Delete)</strong> qui permet la gestion des tables de données. Le modèle CRUD permet de générer automatiquement quatre pages Razor ( front-end et back-end) qui servent à manipuler les données d'une table SQL. Pour ce faire, il suffit de lui donner en paramètre le contexte de la base de données, et la classe représentant le modèle ORM de la table. Et on a quatre pages générées automatiquement et qui restent largement modifiables pour toute adaptation du code.
Et finalement, Mysql Server qui sert comme un serveur de base de données.  
L'application GéoBAM utilise le fond cartographique OpenStreetMap, pour pouvoir ajouter et afficher les points d'adresses. cette intégration de cartes se fait à l'aide d'une API javascript appelée <strong>Leaflet<strong>.Leaflet est une bibliothèque JavaScript pour la création de cartes intéractives dans navigateur web ou un environnement mobile. Elle est légère, mais possède toutes les caractéristiques dont la plupart des développeurs ont besoin pour créer des cartes en ligne. Leaflet est conçu avec la simplicité, la performance et la convivialité à l’esprit.

 

## Installations à faire
* <h2>Microsoft Visual studio 2019 :<h2>
 Pour pouvoir travailler avec .NET généralement , il est conseillé d'utiliser <strong>Microsoft Visual Studio</strong>, qui est une suite de logiciels de développement  pour Windows et mac OS conçue par Microsoft. La dernière version s'appelle Visual Studio 2019.Visual Studio est un ensemble complet d'outils de développement permettant de générer des applications web ASP.NET, des services web XML, des applications bureautiques et des applications mobiles.
  [ le télécharger ici](https://visualstudio.microsoft.com/fr/vs/).
* <h2>Microsoft SQL Server 2019 :<h2>
 Pour avoir un serveur de base de données sur notre machine, on doit installer  SQL server 2019.[Cliquez ici pour le télécharger](https://www.microsoft.com/en-us/sql-server/sql-server-downloads). 

## Ouverture du projet en MS visual studio 2019
Après avoir installer Ms Visual studio et Ms Sql Server. Il est temps d'importer le projet sur notre machine:
Le repository github contient le code complet du projet. Et donc il suffit de le télécharger en format zip. puis le décompresser.
Ensuite, vous  devez  préparer le serveur de données en créant la base de données GeoBAMDB sur le serveur local MS SQL server.
Ouvrez Le SQL SERVER MANAGEMENT STUDIO SSMS, Dans *l' Explorateur d'objets* (Object solution) , connectez-vous à une instance du Moteur de base de données          SQL Server et développez-la. Cliquez avec le bouton droit sur *Databases*(Bases de données) et sélectionnez *Restore database* (Restaurer la base de données).
Dans la page *General* (Général): séléctionnez *Device* puis cliquez sur les trois points à droite, une fenetre s'affichera comme suit:
	
![screen](https://github.com/isbainemohamed/GeoBAM/blob/master/image3.png).
	
Cliquez sur -Add- et spécifiez l'emplacement du fichier GeoBAMDB.bak :
	
![screen](https://github.com/isbainemohamed/GeoBAM/blob/master/image4.png)  
	
Cliqyze sur Ok. Après, le nom de la base de données est automatiquement généré ( à ne pas changer) et finalement cliquez sur OK. 
Maintenant, la base de données est prete à utiliser.
Ouvrez maintenant le MS VS 2019 :
Une écran comme la suivante s'affichera, puis séléctionnez l'option : Open a project or a solution
	
![screen](https://github.com/isbainemohamed/GeoBAM/blob/master/image5.png) 

Ensuite, spécifier l'emplacement du fichier GeoBAM.sln comme suit:
	
![screen](https://github.com/isbainemohamed/GeoBAM/blob/master/image6.png) 
	
le projet s'ouvre automatiquement, et vous pouvez directement lancer l'application sur votre machine (Serveur IIS). 
![screen](https://github.com/isbainemohamed/GeoBAM/blob/master/image2.png) 
## Description du code
 Après avoir deployer le projet localement, il est temps de décrire le code et l'expliquer.
 
 On commence par décrire l'arborescence du projet.
 ### Description de l'arborescence du projet: 'solution Explorer'
 ![screen](https://github.com/isbainemohamed/testtt/blob/main/solution%20explorer.png)
 
	Lorsque on ouvre le projet, on trouve un bloque qui s'intitule 'Solution Explorer'. 
Ce bloc contient l'ensemble des fichiers du projets.
	
  * Premièrement,On trouve 'Dependencies' qui contient l'ensemble des packages, analyseurs, frameworks utilisées dans le projet.
	
  * Puis on trouve 'Properties' qui contient le fichier lunchSettings.json, ce fichier sert à decrire la manère avec laquelle le projet démarrera, l'environement de travail et d'autres informations nécéssaires au démarrage.
	
  * Ensuite 'wwwroot' qui contient l'ensemble des fichiers statiques du site ( css, javascript, images , bibliothèque Bootstrap 4 )
  * En plus de 'data' qui est un dossier contenant  3 fichiers:
	
	 - *ApplicationDbContext*: qui assure la connexion aventre le serveur de  base de données et les classes de models de données qu'on expliquera par la suite.
	
	 - *GeoJSONData.cs*: est une classe en C#, qui represente le modele de données, elle constitue l'image de la structure de la table POIsData contenant les données collectées.
	 - *User.cs* represente la classe modèle pour la table des utilisateurs.
	
  * Le dossier 'Migrations'  contient l'historique des operations de mise à ajour, création... effectuées par la framework  'Entity Framework'.
	
  * Le dossier 'Pages'. contient l'ensembles des pages du site. chaque page est composée d'un fichier *.cshtml* représentant le front-end et un fichier *.cshtml.cs* qui représente le back-end.
	ce dossier contient: 
	- Un sous-dossier 'POImanager', qui contient l'ensemble des pages dédiées à la gestion des Points d'adresses ( Création, suppression, modification, et lecture). ces pages sont générés automatiquement en utilisant le modèle CRUD, qui prend en parametre la ApplicayionDbContext et la classe modele des données. ces pages sont largement modfiées pour répondre à nos besoins.
	
	- le sous-dossier 'UserManager' qui est la meme chose pour la gestion des utilisateurs.
	- le sous-dossier 'shared' ui contient le code cshtml commun à plusieures pages. Au lieu de l'écrire à chaque fois dans une page, il suffit de le mettre dans 'shared' . ce qui permet d'optimiser la mémoire et l'effort.
	- La page 'Error' repésente la page d'erreur.
	- La page 'home' contient le code de la page d'ajout d'un point.
	- La page 'Index' est la première page qui se charge au début du debugage.
	- La page 'login' est la page de connexion de l'utilisateur.
	- La page 'Logout' est la page de deconnexion.
	- La 'Privacy' contient les conditions d'utilisation et les politiques du site.
	- Le fichier 'AppSettings.json' est un fichier de configuration de l'application, contenant la *connexion String* (chaine de connexion) qui est une chaîne 	   qui spécifie des informations sur une source de données et les moyens de s'y connecter avec les bases de données...
	- La classe 'Program.cs' : est le point de demarrage de l'application , parmi ses roles ; instancier le IWebHost qui heberge l'application.
	- La classe 'Startup.cs' est une classe qui est appelé directement apres Program.cs, elle permet de déclarer les services qu'utilisera l'application.

	### Explication du code:
La première étape à faire était de configurer les services dont on aura besoin dans l'application, ceci est fait dans le fichier Startup.cs:
	



```csharp
//Declaration des directives
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;


namespace GeoBAM
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //On ajoute le service RazorPages pour pouvoir travailler avec le moteur Razor
            services.AddRazorPages();
            //On ajoute les services de Session.
            services.AddSession();

            services.AddMvc();

            //Injection du DbContext

            services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        Configuration.GetConnectionString("DefaultConnection")));

            /// Ajout des services d'authentifications avec Cookies.
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie("Cookies", options =>
    {
        options.LoginPath = "/Account/Login";
        options.LogoutPath = "/Account/Logout";
        options.AccessDeniedPath = "/Account/AccessDenied";
        options.ReturnUrlParameter = "ReturnUrl";
    });
           
            
            
        }

       

       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
           
            //Ajout de UseMvc pour pouvoir utiliser le modèle MVC(Model View Controller).
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            
            //Ajout de UseSession pour utiliser les services de gestion des sessions
            app.UseSession();

            
            


```


La deuxième étape consiste à créer les classes modèles de données: ce sont des classes C# qui définissent un objet ayant les propriétés des données d'une table Sql
	ceci permet de créer une table sql directement à l'aide de la framework 'Entity framwork'. ainsi, faire des opérations d'ajout, suppression et modification sur la table sql , sans avoir besoin d'écrire des requetes sql:
	
	
	
	
```csharp
//Declaration des directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace GeoBAM.Data
{
    public class GeoJSONData
    {
        [Key]  // On ajoute l'attribut Key pour désigner la clé primaire (pointID)
	
	//identifiant unique du POI !
        public int pointID { get; set; } 
	
	//Type du POI ( point, ligne, polygone, rectangle, cercle ..)
        public string DataType { get; set; }
	
	// Adresse complète
        public string Address { get; set; }   
	
	//Pour indiquer la ville !
        public string City { get; set; }                
        
        //Indiquer le code postal
	public string PostalCode { get; set; }          
        
	 // Les données GeoJSON, seront stockées ici 
	//( NB: la taille maximale du NVVARCHAR(MAX) peut atteindre 2GO, qui est donc largement suffisant pour stocker ses données)
	public string GeoJSONdata { get; set; }        

        //Pour préciser le type du POI (administration, local, terrain , agence ...)
	public string Type { get; set; }                
        
	//Date de prélévement du POI
	public DateTime DatePrelevement { get; set; }   
        
	//L'identifiant de l'operateur ayant effectué le prélèvement
	public string ID_Operateur { get; set; }        
    }
}


            
            


```
	
	
	
	
	

	
	
De la meme maniére, on crée un modèle de données pour la table des utilisateurs:
	
	
	
	
```csharp
//Declaration des directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace GeoBAM.Data
{
    public class User
    {
        [Key]		//Pour définir la clé primaire
        
	//Identifiant unique de l'utilisateur
	public int Id { get; set; }             
        
	//Prénom de l'utilisateur ( correspond à la colonne FirstName dans la table Users)
	public string FirstName { get; set; }   
        
	//Nom de l'utilisateur ( correspond à la colonne LasttName dans la table Users)
	public string LastName { get; set; }        

        //Email de l'utilisateur ( correspond à la colonne Email dans la table Users)
	public string Email { get; set; }       
        
	 //Mot de passe de l'utilisateur ( correspond à la colonne Password dans la table Users)
	public string Password { get; set; }       
        
	//role de l'utilisateur ( correspond à la colonne Role dans la table Users) 
	public string Role { get; set; }               
    }
}


            
            


```
	
	
	
Ensuite, on crée le context de base de données (DataBase context):
	
		
	
	
	
	

	
	

	
	
	
	
```csharp
//Declaration des directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeoBAM.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Constructeur de la classe 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Déclaration des tables avec lesquelles  la connexion sera établie
	
        public DbSet<User> Users { get; set; }
        
        
        public DbSet<GeoJSONData> AddedData { get; set; }
    }
}

            
            


```
	
	
Maintenant, tout est pret pour créer la base de données. Il suffit d'ouvrir la console de commande 'Package manager Console' et executer la commande:
	
	
	update-database
	
C'est une commande de la framework 'Entity Framework'. elle utilise l'approche *code first*. Cette approche signifie qu'on crée le modèle de données premièrement puis on génère les tables de données. et c'est exactement ce que cette commande fait. elle crée les deux tables Users et AddedData.
Maintenant si on ouvre le serveur MS Sql Server 2019, on trouvera les deux tables crées. Ce qui signifie que tout marche bien!

Maintenant, on passe au code des pages web:
On commence par le dossier POImanager, qui se constitue de 5 pages web: Index , Create, Edit, Update et Details.
* La page 'POImanager/Index' :
  - 'Index.cshtml' : cette page affiche les POi collectés dans une carte Leaflet, ainsi que dans un tableau avec plusieures actions (Modifier, supprimer, détails)
	
	
	
	```html
		@page
		@model GeoBAM.Pages.POImanager.IndexModel

		

		<h1>Mes points</h1>

		<p>
			<!--Boutton pour nous renvoyer vers la page d'ajout-->
		    <a asp-page="/home">Ajouter un Point</a>
		</p>
		<head>
			<!--Appel aux fichiers Css nécéssaires pour afficher la carte Laflet-->
		    <link rel="stylesheet" href="https://unpkg.com/leaflet@1.3.1/dist/leaflet.css" integrity="sha512-Rksm5RenBEKSKFjgI3a41vrjkw4EVPlJ3+OiI65vTjIdo9brlAacEuKOiQ5OFh7cOI1bkDwLqdLw3Zg0cRJAAQ==" crossorigin="" />
		    <link rel="stylesheet" type="text/css" href="https://unpkg.com/leaflet.markercluster@1.3.0/dist/MarkerCluster.css" />
		    <link rel="stylesheet" type="text/css" href="https://unpkg.com/leaflet.markercluster@1.3.0/dist/MarkerCluster.Default.css" />

		</head>

		<!-- Fichiers Javascript -->
		<script src="https://unpkg.com/leaflet@1.3.1/dist/leaflet.js" 								 integrity="sha512-/Nsx9X4HebavoBvEBuyp3I7od5tA0UzAxs+j83KgC8PU0kgB4XiK4Lfe4y4cgBtaRJQEIFCW+oC506aPT2L1zw==" crossorigin=""></script>
		<script type='text/javascript' src='https://unpkg.com/leaflet.markercluster@1.3.0/dist/leaflet.markercluster.js'></script>

		<!--On Ajoute un container div pour afficher la carte NB : la carte DOIT avoir une hauteur sinon elle n'apparaît pas */-->


		<div id="mapid" style="height:500px;">
		    <!-- Ici d'affichera la carte-->
		</div>

		<script>



		    //importation des données dans une variable POIs. Pour pouvoir les traiter par la suite!
			//ces données sont fournis par le backend de la page( IndexModel).
		    var POIs = @Json.Serialize(Model.POIsData);
		    //initialisation de la carte! on définit la vue par défault sur les coordonées du maroc!
		    var map = L.map("mapid").setView([31.62,-7.99], 12),
			tiles = L.tileLayer("http://{s}.tile.osm.org/{z}/{x}/{y}.png", {
			    attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'
			}).addTo(map),
			markerClusterLayer = L.markerClusterGroup().addTo(map);

		    ;
		    // Creation d'un nouveau type de vecteur avec les méthodes getLatLng et setLatLng .
				//Cette operation est nécéssaire pour qu'on puisse regrouper les polygons, cercles, rectangles et marqueurs dans un seul Clusterer
		    //Pour Les cercles:

		    L.CircleClusterable = L.Circle.extend({

			getLatLng: function () {
			    return this._latlng;
			},

			// dummy method.
			setLatLng: function () { }
		    });

		    //Pour les rectangles:
		    //  Creation d'un noubeau type de vecteur avec les méthodes getLatLng et setLatLng ..

		    L.RectangleClusterable = L.Rectangle.extend({
			_originalInitialize: L.Rectangle.prototype.initialize,

			initialize: function (bounds, options) {
			    this._originalInitialize(bounds, options);
			    this._latlng = this.getBounds().getCenter(); // On définit le centre du rectangle!
			},

			getLatLng: function () {
			    return this._latlng;
			},

			// dummy method.
			setLatLng: function () { }
		    });
		    ///fin
		    //for plygons
		    L.Polygon.addInitHook(function () {
			this._latlng = this._bounds.getCenter();
		    });

		    // Fournit les latlngs au markerCluster pour pouvoir regrouper les polygons aussi.
		    L.Polygon.include({
			getLatLng: function () {
			    return this._latlng;
			},
			setLatLng: function () { } 
		    });
		    //fin
		    //Parcours de la variable POIs et ajout des elements à la carte:
		    //Pour cela on écrit la fonction getCoordinates, qui permet de:
			    //: Déterminer le type de l'objet passé en parametre(POlygon, cercle, rectangle, marqueur)
			    //: Extraire les coordonnées depuis les données geoJSON associés
			    //: Inverser l'ordre des coordonnées: Dans le fihcier geoJSON, on avait la convention [longitude, latitude], mais pour appeler L.marker.. on aura besoin de [latitude,longitude]!
			    //: Ajouter l'objet au markerClustrer!
		    //Cette fonction prend en parametre: l'oobjet de type POI, et un markerCusterLayer!
		    function getCoordinates(poi, markerClusterLayer) {
			//On déclare les variables (type, proprietés; et coordonnés)
			var Type;
			var properties;
			var coords = [];    //coordonnées extraites
			var Coordinates = []; //coordonnées modifiées
			 //On ectracte les données geoJSON de l'objet poi
			var data = poi.geoJSONdata;
			//On parcours la variable data pour en extraire un objet JSON utilisable!
			var geojsondata = JSON.parse(data);
			 //Un petit test selon la structure des données geoJSON
			if (geojsondata.features == undefined) {
			    Type = geojsondata.geometry.type;
			    coords = geojsondata.geometry.coordinates;
			    properties = geojsondata.properties;
			}
			else {
			    Type = geojsondata.features[0].geometry.type;
			    coords = geojsondata.features[0].geometry.coordinates;
			    properties = geojsondata.features[0].properties;
			}

			var length = coords.length;
			if (Type == 'Polygon' && length == 1 && coords[0].length > 0) {
			    for (var i = 0; i < coords[0].length; i++) {
				var lng = coords[0][i][0];
				var lat = coords[0][i][1];
				console.log(lng);
				Coordinates.push([lat, lng]);

			    }
			    //On est devant un polygon:
			    new L.Polygon(Coordinates).addTo(markerClusterLayer).bindPopup("<p>" + poi.address + "</p>  <p>" + poi.city + "</p>  <p>" + poi.postalCode + "</p>  <p>" + poi.type + "</p> ");

			}
			if (Type == 'Point' && length == 2) {
			    if (properties.radius != undefined) {
				var lng = coords[0];
				var lat = coords[1];
				var radius = properties.radius;
				Coordinates = [lat, lng, radius];
				//On es devant un cercle:
				new L.CircleClusterable([Coordinates[0], Coordinates[1]], Coordinates[2]).addTo(markerClusterLayer).bindPopup("<p>" + poi.address + "</p>  <p>" + poi.city + "</p>  <p>" + poi.postalCode + "</p>  <p>" + poi.type + "</p> ");
			    }
			    else {
				var lng = coords[0];
				var lat = coords[1];

				Coordinates = [lat, lng];
				//On est devant un point simple:
				new L.marker(Coordinates).addTo(markerClusterLayer).bindPopup("<p>" + poi.address + "</p>  <p>" + poi.city + "</p>  <p>" + poi.postalCode + "</p>  <p>" + poi.type + "</p> ");

			    }
			}


		    }

		    //On fait une boucle pour parcourir POIs:
		    for (poi in POIs) {
			//On appelle a fonction décrite ci-dessus, en lui passant en parametre l'objet courant et le markerClusterLayer
			getCoordinates(POIs[poi], markerClusterLayer);
		    }


		</script>

		<!--fin du script Javascript -->
		
		<!--Tableau pour l'affichage des points-->

		<table class="table">
		    <thead> <!--On définie les titres des colonnes-->
			<tr>
			    <th>
				Numéro
			    </th>
			    <th>
				Type de donnée
			    </th>
			    <th>
				Adresse
			    </th>
			    <th>
				Ville
			    </th>
			    <th>
				Code Postal
			    </th>

			    <th>
				Catégorie
			    </th>

			    <th>Actions</th>
			</tr>
		    </thead>
		    <tbody> <!-- on définit le contenu du tableau en parcourant l'objet fournit par le backend POIsData-->
			@foreach (var item in Model.POIsData)
			{	<!-- On incrémente le counter pour afficher le numéro du point-->
			    counter++;
			    <tr>
				<td>
				    @Html.DisplayFor(modelItem => counter)
				</td>
				<td>
				    @Html.DisplayFor(modelItem => item.DataType)
				</td>
				<td>
				    @Html.DisplayFor(modelItem => item.Address)
				</td>
				<td>
				    @Html.DisplayFor(modelItem => item.City)
				</td>
				<td>
				    @Html.DisplayFor(modelItem => item.PostalCode)
				</td>

				<td>
				    @Html.DisplayFor(modelItem => item.Type)
				</td>

				<td>
					<!-- On ajoute des bouttons pour nous rediriger vers les pages de Modification, Suppression et détails.-->
					<!-- il est à noter que 'asp-route-id' permet d'envoyer l'id du point courant vers la page suivante-->
				    <a asp-page="./Edit" asp-route-id="@item.pointID">Modifier</a> |
				    <a asp-page="./Details" asp-route-id="@item.pointID">Détails</a> |
				    <a asp-page="./Delete" asp-route-id="@item.pointID">Supprimer</a>
				</td>
			    </tr>
			}
		    </tbody>
		</table>

	```
			
 - 'Index.cshtml.cs': représente le backend 
			
	```csharp
			//On déclare les directives
			using System;
			using System.Collections.Generic;
			using System.Linq;
			using System.Threading.Tasks;
			using Microsoft.AspNetCore.Mvc;
			using Microsoft.AspNetCore.Mvc.RazorPages;
			using Microsoft.EntityFrameworkCore;
			using GeoBAM.Data;
			using System.Security.Claims;

			using System.ComponentModel.DataAnnotations;
			using System.ComponentModel.DataAnnotations.Schema;
			using System.Web;

			using Microsoft.AspNetCore.Authentication;
			using Microsoft.AspNetCore.Authorization;

			namespace GeoBAM.Pages.POImanager
			{
			    //On ajoute l'attribut pour restreindre l'accès. cette page ne sera accessible qu'après l'authentification
				[Authorize]
			    public class IndexModel : PageModel
			    {
				//On appelle le context de base de données, puisque on a affaire à des échange avec la base de données.
				private readonly GeoBAM.Data.ApplicationDbContext _context;

				//Constructeur du model de la page
				public IndexModel(GeoBAM.Data.ApplicationDbContext context)
				{
				    _context = context;
				}
				// déclaration d'une liste de type GeoJSONData, qui servira à contenir les données ectraites de la bd.
				public IList<GeoJSONData> POIsData = new List<GeoJSONData>();
			
				//Variable pour stocker le role de l'utilisateur courant
				public string Role { get; set; }
				public async Task OnGetAsync()
				{
				    //On extrait le role de l'utilisateur
				    var IsAdmin = User.IsInRole("administrateur");
				    var role = User.FindFirst(ClaimTypes.Role).Value;
				    Role= User.FindFirst(ClaimTypes.Role).Value;

					//Parmi les exigences sur cette page:
						//Si l'utilisateur est un administrateur: on extrait tous les données de la bases et on les affiche
						//Si l'utilisateur est un operateur: on extrait que les points qu'il a jouté.
				    if (role != null && role == "administrateur")
				    {
					//On est devant un administrateur, donc on extrait toutes les données à travers le contexte de données.
					//Comme il est claie, on pas écrit du code sql, tout est géré automatiquement
					POIsData = await _context.AddedData.ToListAsync();
				    }
				    else
				    {
					//On est devant un operateur
					//On extrait les points dont l'ID_operateur correspond à l'identifiant de l'utilisateur courant
					var query = from pt in _context.AddedData
						    where pt.ID_Operateur == User.FindFirst(ClaimTypes.NameIdentifier).Value
						    select pt;
					foreach (GeoJSONData pt in query)
					{
					    if (pt != null)
					    {
						POIsData.Add(pt);
					    }


					}
				    }
				}
				
			    }
			}


			
	```
	

* La page 'POImanager/Create' :
  - 'Create.cshtml' : cette page permet de créer un nouveau POI, en remplissant un formulaire.  
   
	```html
		@page
		@model GeoBAM.Pages.POImanager.CreateModel
		@using System.Security.Claims;

		@{
		    //récupération des données envoyer de la page 'Ajouter un point'
		    var longitudee = Request.Form["longitude"];

		    var latitudee = Request.Form["latitude"];

		    var GeoJsonData = Request.Form["GeoJson"];  
		}
		<h1>@ViewData["Title"]</h1>



		<body>
		    <!-- formulaire pour la saisie des informations sur le POI-->
		    <div class="row">
			<div class="col-md-4">
			    <form asp-route-returnUrl="@Model.ReturnUrl" method="post">
				<h4>Ajouter un nouveau point </h4>
				<hr />


				<div class="form-group">
				    <label asp-for="Input.Address">Adresse</label>
				    <input asp-for="Input.Address" class="form-control" />
				    <span asp-validation-for="Input.Address" class="text-danger"></span>
				</div>
				<div class="form-group">
				    <label asp-for="Input.City">Ville</label>
				    <input asp-for="Input.City" class="form-control" />
				    <span asp-validation-for="Input.City" class="text-danger"></span>
				</div>
				<div class="form-group">
				    <label asp-for="Input.PostalCode">Code Postal</label>
				    <input asp-for="Input.PostalCode" class="form-control" />
				    <span asp-validation-for="Input.PostalCode" class="text-danger"></span>
				</div>

				<div class="form-group">
				    <label asp-for="Input.Datatype"></label>
				    <input asp-for="Input.Datatype" id="longitude" class="form-control" />
				    <span asp-validation-for="Input.Datatype" class="text-danger"></span>
				</div>
				<div class="form-group">
				    <label asp-for="Input.GeoJSONdata" hidden></label>
					<!--On définie le contenu du champs GeoJSONdata par les données envoyésde la page /home, et on le cache -->
					
				    <input asp-for="Input.GeoJSONdata" hidden value="@GeoJsonData" class="form-control" />
				    <span asp-validation-for="Input.GeoJSONdata" class="text-danger"></span>
				</div>
				<div class="form-group">
				    <label asp-for="Input.Type">Catégorie</label>
				    <input asp-for="Input.Type" class="form-control" />
				    <span asp-validation-for="Input.Type" class="text-danger"></span>
				</div>



				<button type="submit" class="btn btn-success">Ajouter</button>
			    </form>
			</div>
		    </div>
		</body>

	```

  - 'Create.cshtml.cs' est le fichier backend, responsable de l'ajout des données,entrées par l'utilisateur, à la table AddedData.
			
	```csharp
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Threading.Tasks;
		using Microsoft.AspNetCore.Mvc;
		using Microsoft.AspNetCore.Identity;
		using Microsoft.AspNetCore.Mvc.RazorPages;
		using GeoBAM.Data;
		using System;
		using System.ComponentModel.DataAnnotations;
		using System.ComponentModel.DataAnnotations.Schema;
		using System.Web;

		using System.ComponentModel.DataAnnotations;


		using Microsoft.AspNetCore.Authentication;
		using Microsoft.AspNetCore.Authorization;
		using System.Security.Claims;

		namespace GeoBAM.Pages.POImanager
		{
		    //On ajoute l'attribut auhtorize, pour ne permettre l'accès qu'après authentification.
			[Authorize]
		    public class CreateModel : PageModel
		    {

			//On crée une instance de ApplicationDbContext qui va assurer la connexion avec la base de donées
			private readonly ApplicationDbContext Db;

			//Constructeur de la classe 
			public CreateModel(ApplicationDbContext Db)
			{
			    this.Db = Db;

			}



			[BindProperty]
			
			//On ajoute une instance de la classe InpuModel, qu'on déclarera par la suite
			public InputModel Input { get; set; }

			public string ReturnUrl { get; set; }

			public IList<AuthenticationScheme> ExternalLogins { get; set; }

			//Création du modèle Input, pour pouvoir récupérer les données saisies dans le form!
			public class InputModel
			{
				//On déclare les propriétes de la classe qui correspondent exactement au champs de saisie dans le formulaire
				//L'attribut Required signifie que cette propriété est nécéssaire pour la valiation du formulaire
			    [Required]  
			    [StringLength(1000000000, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
			    [Display(Name = "DataType ")]
			    public string Datatype { get; set; }

			    [Required]
			    [StringLength(1000000000, ErrorMessage = "L'adresse ne peut pas etre vide.", MinimumLength = 1)]
			    [Display(Name = "Adresse ")]
			    public string Address { get; set; }
			    [Required]
			    [StringLength(1000000000, ErrorMessage = "Le nom de la ville ne peut pas etre vide.", MinimumLength = 1)]
			    [Display(Name = "City ")]
			    public string City { get; set; }
			    [Required]
			    [StringLength(1000000000, ErrorMessage = "Le code postal ne peut pas etre vide", MinimumLength = 1)]
			    [Display(Name = "PostalCode ")]
			    public string PostalCode { get; set; }
			    [Required]
			    [StringLength(1000000000, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
			    [Display(Name = "GeoJSONdata ")]
			    public string GeoJSONdata { get; set; }





			    [Required]
			    [StringLength(100000000, ErrorMessage = "la catégorie ne peut pas etre vide.", MinimumLength = 1)]

			    [Display(Name = "Type")]
			    public string Type { get; set; }


			    [Required]
			    [DataType(DataType.DateTime)]
			    [DisplayFormat(DataFormatString = "yyyy/MM/dd HH:mm:ss", ApplyFormatInEditMode = true)]
			    public DateTime DatePrelevement { get; set; } = DateTime.Now;


			    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]

			    [Display(Name = "ID_Operateur")]
			    public string ID_Operateur { get; set; }


			}


			public async Task OnGetAsync(string returnUrl = null)
			{
			    ReturnUrl = returnUrl;
			}

			public async Task<IActionResult> OnPostAsync(string returnUrl = null)
			{
			    returnUrl ??= Url.Content("~/");
				//Si le modèle est valide:
			    if (ModelState.IsValid)
			    {
				//Si le modele est valide :
				//On associe à la propriété ID_Operateur , l"Id de la session courante!
				Input.ID_Operateur = User.FindFirst(ClaimTypes.NameIdentifier).Value;
				//On cherche dans la table Addeddata, si on a deja un POI ayant les memes données GeoJSON
				var point = Db.AddedData.Where(f => f.GeoJSONdata == Input.GeoJSONdata).FirstOrDefault();
				//Si Oui, Alors on affiche l'erreur suivante
				if (point != null)
				{
				    ModelState.AddModelError(string.Empty, "Le " + Input.Datatype + " d'adresse  existe déja !");
				}
				//Sinon, on associe les valeurs des champs ) un objet poit et on l'ajoute à la table AddedData
				else
				{
				    point = new GeoJSONData { Address = Input.Address, City = Input.City, DataType = Input.Datatype, PostalCode = Input.PostalCode, Type = Input.Type, GeoJSONdata = Input.GeoJSONdata, ID_Operateur = Input.ID_Operateur, DatePrelevement = Input.DatePrelevement };
				    Db.AddedData.Add(point);
				    await Db.SaveChangesAsync();
				    //On redirige l'utilisateur vers la page Points Ajoutés
				    return RedirectToPage("/index");
				}

			    }

			    return Page();
			}
		    }
		}
	```
			
	
- La page 'POI/manager/Edit': est une page chargée de modifier un point de la table.
  - 'Edit.cshtml' permet d'afficher un formulaire, pour que l'utilisateur puisse mettre à jour les données.

	```html
				@page
		@model GeoBAM.Pages.POImanager.EditModel

		@{  //Titre de la page
		    ViewData["Title"] = "Modifier un point";
		}

		<h1>Modifier</h1>

		<h4>GeoJSONData</h4>
		<hr />
		<!--On ajoute un formulaire pour effectuer des modifications-->
		<div class="row">
		    <div class="col-md-4">
			<form method="post">
			    <div asp-validation-summary="ModelOnly" class="text-danger"></div>
			    <input type="hidden" asp-for="GeoJSONData.pointID" />
			    <div class="form-group">
				<label asp-for="GeoJSONData.DataType" class="control-label"></label>
				<input asp-for="GeoJSONData.DataType" class="form-control" />
				<span asp-validation-for="GeoJSONData.DataType" class="text-danger"></span>
			    </div>
			    <div class="form-group">
				<label asp-for="GeoJSONData.Address" class="control-label"></label>
				<input asp-for="GeoJSONData.Address" class="form-control" />
				<span asp-validation-for="GeoJSONData.Address" class="text-danger"></span>
			    </div>
			    <div class="form-group">
				<label asp-for="GeoJSONData.City" class="control-label"></label>
				<input asp-for="GeoJSONData.City" class="form-control" />
				<span asp-validation-for="GeoJSONData.City" class="text-danger"></span>
			    </div>
			    <div class="form-group">
				<label asp-for="GeoJSONData.PostalCode" class="control-label"></label>
				<input asp-for="GeoJSONData.PostalCode" class="form-control" />
				<span asp-validation-for="GeoJSONData.PostalCode" class="text-danger"></span>
			    </div>
			    <div class="form-group">
				<label asp-for="GeoJSONData.GeoJSONdata" class="control-label"></label>
				<input asp-for="GeoJSONData.GeoJSONdata" class="form-control" />
				<span asp-validation-for="GeoJSONData.GeoJSONdata" class="text-danger"></span>
			    </div>
			    <div class="form-group">
				<label asp-for="GeoJSONData.Type" class="control-label"></label>
				<input asp-for="GeoJSONData.Type" class="form-control" />
				<span asp-validation-for="GeoJSONData.Type" class="text-danger"></span>
			    </div>
			    <div class="form-group">
				<label asp-for="GeoJSONData.DatePrelevement" class="control-label"></label>
				<input asp-for="GeoJSONData.DatePrelevement" class="form-control" />
				<span asp-validation-for="GeoJSONData.DatePrelevement" class="text-danger"></span>
			    </div>
			    <div class="form-group">
				<label asp-for="GeoJSONData.ID_Operateur" class="control-label"></label>
				<input asp-for="GeoJSONData.ID_Operateur" class="form-control" />
				<span asp-validation-for="GeoJSONData.ID_Operateur" class="text-danger"></span>
			    </div>
			    <div class="form-group">
				<input type="submit" value="Enregistrer" class="btn btn-primary" />
			    </div>
			</form>
		    </div>
		</div>

		<div>
		    <a asp-page="./Index">Back to List</a>
		</div>

		@section Scripts {
		    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
		}

	```
			
 - 'Edit.cshtml.cs', est le backend qui doit prendre les données saisies et mettre à jour le point dans la table.
			
	```csharp
			using System;
			using System.Collections.Generic;
			using System.Linq;
			using System.Threading.Tasks;
			using Microsoft.AspNetCore.Mvc;
			using Microsoft.AspNetCore.Mvc.RazorPages;
			using Microsoft.AspNetCore.Mvc.Rendering;
			using Microsoft.EntityFrameworkCore;
			using GeoBAM.Data;

			using System.ComponentModel.DataAnnotations;
			using System.ComponentModel.DataAnnotations.Schema;
			using System.Web;

			using Microsoft.AspNetCore.Authentication;
			using Microsoft.AspNetCore.Authorization;

			namespace GeoBAM.Pages.POImanager
			{
			    [Authorize] //pour restreindre l'accès.
			    public class EditModel : PageModel
			    {
				//appel au context de données, pour pouvoir communiquer avec la base de données
				private readonly GeoBAM.Data.ApplicationDbContext _context;

				public EditModel(GeoBAM.Data.ApplicationDbContext context)
				{
				    _context = context;
				}

				[BindProperty]
				public GeoJSONData GeoJSONData { get; set; }

				public async Task<IActionResult> OnGetAsync(int? id)
				{
					//Si l'id du point séléctionné est null, on retourne une erreur NotFound.
				    if (id == null)
				    {
					return NotFound();
				    }
				//Si le point n'existe pas dans la table. on retourne une erreur
				    GeoJSONData = await _context.AddedData.FirstOrDefaultAsync(m => m.pointID == id);

				    if (GeoJSONData == null)
				    {
					return NotFound();
				    }
				    return Page();
				}
				//Si tout va bien ( le point existe et l'id est non null)
				
				public async Task<IActionResult> OnPostAsync()
				{	//Si le modèle est valide
				    if (!ModelState.IsValid)
				    {
					return Page();
				    }
					//On modéfie les données du pioint
				    _context.Attach(GeoJSONData).State = EntityState.Modified;

				    try
				    {
					//On enregistre les changement
					await _context.SaveChangesAsync();
				    }
				    catch (DbUpdateConcurrencyException)
				    {
					if (!GeoJSONDataExists(GeoJSONData.pointID))
					{
					    return NotFound();
					}
					else
					{
					    throw;
					}
				    }
				// On redirige l'uilisateur vers la page POImanager/Index
				    return RedirectToPage("./Index");
				}

				private bool GeoJSONDataExists(int id)
				{
				    return _context.AddedData.Any(e => e.pointID == id);
				}
			    }
			}

	```
De la meme facon pour les pages 'POImanager/Delete' et 'POImanager/Details'.
Concernant le dossier *Pages/UserManager* , il est aussi généré à l'aide du modèle CRUD. et donc il a la meme architecture que POImanager.ce qui change c'est le modèle de donnée, pour qui'il puisse comuuniquer avec la table Users.
- La pages 'home' est la page d'ajout d'un point. Elle contient une Carte Leaflet ( En savoir plus dans la partie Outils utilisés), dont l'utlisateur déssine un polygone, un rectangle, un cercle oubien un marqueur simple. Ainsi, il peut afficher sa position courante dans la carte.  
			
			
	```html
			@page
			@model GeoBAM.Pages.homeModel
			@{
			    ViewData["Title"] = "Ajouter un point";
			}

			@{
			    if (User.Identity.IsAuthenticated)
			    { <!--Si l'utilisateur est connecté, on affiche ceci -->
				<!--On importe les pages css et les script js Leaflet nécéssaire pour la carte -->
				<link rel="stylesheet" href="https://unpkg.com/leaflet@1.5.1/dist/leaflet.css" integrity="sha512-xwE/Az9zrjBIphAcBb3F6JVqxf46+CDLwfLMHloNu6KEQCAWi6HcDUbeOfBIptF7tcCzusKFjFw2yuvEpDL9wQ==" crossorigin="" />
				<link rel="stylesheet" href="https://unpkg.com/leaflet.markercluster@1.4.1/dist/MarkerCluster.css">
				<link rel="stylesheet" href="~/css/leaflet-geoman.css" />
				<script src="https://unpkg.com/leaflet@1.3.1/dist/leaflet.js" integrity="sha512-/Nsx9X4HebavoBvEBuyp3I7od5tA0UzAxs+j83KgC8PU0kgB4XiK4Lfe4y4cgBtaRJQEIFCW+oC506aPT2L1zw==" crossorigin=""></script>
				<script type='text/javascript' src='https://unpkg.com/leaflet.markercluster@1.3.0/dist/leaflet.markercluster.js'></script>
				<script src="~/js/leaflet-geoman.min.js"></script>
				<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/leaflet.draw/0.4.2/leaflet.draw.css" />
				<script src="https://cdnjs.cloudflare.com/ajax/libs/leaflet.draw/0.4.2/leaflet.draw.js"></script>
				<link rel="stylesheet" href="https://unpkg.com/leaflet.markercluster@1.4.1/dist/MarkerCluster.Default.css">

				<!--Un boutton Ma Position, dont l'action ONCLICK execute la focntion getLocation()-->
				<button type="button" class="btn btn-dark" onclick="getLocation()">Ma position</button>

				<!--On crée un container Div, qui servira à contenir la carte (NB: cette création doit etre avant le code js) -->
				<div id="map" style="height:400px;"></div>

				<!--On écrit le script javascript pour la gestion de la carte  -->
				<script>
				    // Déclaration d'une variable map, pour pouvoir initialiser notre carte!
				    var map = L.map('map').setView([31.79230, -7.08016], 12);  //SetView sert à définir la vue initiale
				    L.tileLayer('http://{s}.tile.osm.org/{z}/{x}/{y}.png', {
					attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'
				    }).addTo(map);
				    // FeatureGroup pour stocker les couches modifiables !
				    var drawnItems = new L.FeatureGroup();
				    map.addLayer(drawnItems);
				    var drawControl = new L.Control.Draw({
					edit: {
					    featureGroup: drawnItems
					}
				    });
				    map.addControl(drawControl);


				    // Ajouter le schéma tracé à la couche de la carte!
				    map.on('draw:created', function (event) {
					var type = event.layerType,
					    layer = event.layer;
					var layer = event.layer,
					    feature = layer.feature = layer.feature || {};
					feature.type = feature.type || "Feature";
					var props = feature.properties = feature.properties || {};
					drawnItems.addLayer(layer);
					if (type == 'Point') {
					    // Les actions spécéfiques à un marqueurs
					    // On l'ajoute à la table AddedPoints!

					    var lat = layer.getLatLng().lat;
					    var lng = layer.getLatLng().lng;
					    //on ajoute une popup !
					    layer.bindPopup("<p>" + lat + "," + lng + "</p>").openPopup();

					    document.getElementById("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());

					}
					if (type == 'Polygon') {
					    // La meme chose pour un polygone
					    console.log(JSON.stringify(drawnItems.toGeoJSON()));
					    document.getElementById("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());

					}
					if (type == 'circlemarker') {
					    // La meme chose pour un cercle
					    console.log(JSON.stringify(drawnItems.toGeoJSON()));
					    document.getElementById("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());
					    var lat = layer.getLatLng().lat;
					    var lng = layer.getLatLng().lng;
					    //on ajoute une popup !
					    layer.bindPopup("<p>" + lat + "," + lng + "</p>").openPopup();

					}

					drawnItems.addLayer(layer);
					map.addLayer(layer);
					document.getElementById("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());
					console.log("type de donne:" + type);
				    });

				    //On spécifie les actions à faire lorsque un nouveau objet est dessiné!
				    map.on(L.Draw.Event.CREATED, function (e) {
					var type = e.layerType,
					    layer = e.layer;
					drawnItems.addLayer(layer);
					if (type == 'marker') {
					    // Les actions spécéfiques à un marqueurs


					    document.getElementById("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());
					    document.getElementById("DataType").value = 'Point';
					}
					if (type == 'polygon') {
					    // La meme chose pour un polygone
					    console.log(JSON.stringify(drawnItems.toGeoJSON()));
					    document.getElementById("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());
					    document.getElementById("DataType").value = 'Polygone';

					}
					if (layer instanceof L.Circle) {
					    // La meme chose pour un cercle
					    const json = layer.toGeoJSON();


					    json.properties.radius = layer.getRadius();


					    document.getElementById("geoJson").value = JSON.stringify(json);
					    document.getElementById("DataType").value = 'Cercle';

					}
					if (type == 'rectangle') {
					    // La meme chose pour un rectangle

					    document.getElementById("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());
					    document.getElementById("DataType").value = 'Rectangle';
					}
					// On ajoute le layer à la carte
					map.addLayer(layer);
					document.getElementById("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());

				    });

				    map.on('draw:edited', function (e) {
					var layers = e.layers;
					layers.eachLayer(function (layer) {
					    //Actions spécéfiques apès modification d'un layer!
					});
				    });

				    //On définit la fonction getLocation
				    function getLocation() {
					if (navigator.geolocation) {
					    navigator.geolocation.getCurrentPosition(showPosition);
					} else {
					    Alert("Le service de Géolocalisation n'est pas disponible sur ce navigateur");
					}

				    }
				    function showPosition(position) {


					// on change la vue dans la carte en passant en paramètre les coordonnées de l'utilisateur!
					map.setView([position.coords.latitude, position.coords.longitude], 16),
					    marker = L.marker([position.coords.latitude, position.coords.longitude]).addTo(map),
					    marker.bindPopup("<p>Vous etes là!</p> <p>" + position.coords.latitude + "," + position.coords.longitude + "</p>");
					//On prepare les données de localisation pour les envoyer vers la page d'Ajout!
					document.getElementById("geoJson").value = JSON.stringify(marker.toGeoJSON());
					document.getElementById("DataType").value = 'Point';



				    }


				</script>
				<!-- Code ) supprimer-->
				<!--<div id="mapid" style="width: 800px; height: 600px; border: 1px solid #ccc"></div>

				<script>
				    var osmUrl = 'http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
					osmAttrib = '&copy; <a href="http://openstreetmap.org/copyright">OpenStreetMap</a> contributors',
					osm = L.tileLayer(osmUrl, { maxZoom: 18, attribution: osmAttrib }),
					mapid = new L.Map('mapid', { center: new L.LatLng(51.505, -0.04), zoom: 13 }),
					drawnItems = L.featureGroup().addTo(mapid);
				    L.control.layers({
					'osm': osm.addTo(mapid),
					"google": L.tileLayer('http://www.google.cn/maps/vt?lyrs=s@189&gl=cn&x={x}&y={y}&z={z}', {
					    attribution: 'google'
					})
				    }, { 'drawlayer': drawnItems }, { position: 'topleft', collapsed: false }).addTo(mapid);
				    mapid.addControl(new L.Control.Draw({
					edit: {
					    featureGroup: drawnItems,
					    poly: {
						allowIntersection: true
					    }
					},
					draw: {
					    polygon: {
						allowIntersection: true,
						showArea: true
					    }
					}
				    }));

				    mapid.on(L.Draw.Event.CREATED, function (event) {
					var layer = event.layer;
					var type = event.layerType,
					    layer = event.layer;
					if (type == 'marker') {
					    // Les actions spécéfiques à un marqueurs
					    // On l'ajoute à la table AddedPoints!
					    console.log(JSON.stringify(drawnItems.toGeoJSON()));
					    var lat = e.latlng.lat;
					    var lng = e.latlng.lng;
					    document.getElementById("latitude1").value = lat;
					    document.getElementById("longitude1").value = lng;
					    document.getElementById("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());

					}
					if (type == 'polygon') {
					    // La meme chose pour un polygone
					    console.log(JSON.stringify(drawnItems.toGeoJSON()));
					    document.getElementbyId("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());

					}
					if (type == 'circle') {
					    // La meme chose pour un cercle
					    console.log(JSON.stringify(drawnItems.toGeoJSON()));
					    document.getElementById("geoJson").value = JSON.stringify(drawnItems.toGeoJSON());

					}
					drawnItems.addLayer(layer);
				    });

				</script> -->
				<!--fin-->
				<span asp-validation-for="Input.DataType" class="text-danger"></span>
				<span asp-validation-for="Input.geoJson" class="text-danger"></span>

				<div class="btn-toolbar" role="toolbar" aria-label="Toolbar with button groups">

				    <!-- On ajoute ce formulalre caché pour envoyer les données vers la page d'ajout'-->
				    <form method="post">

					<input asp-for="Input.DataType" class="form-control" hidden name="DataType" id="DataType" />

					<input asp-for="Input.geoJson" class="form-control" hidden name="geoJson" id="geoJson" />

					<input type="submit" class="btn btn-success" style="font-size:13px; background-color:limegreen;" value="Ajouter" name="Ajouter à la base de données" asp-page="/POImanager/Create">
					<!-- <input type="submit" class="btn btn-primary" value="Ajouter" name="Ajouter à la base de données" asp-page="/AddPoint"> -->
				    </form>
				</div>

			    }
			    else
			    { <!-- Si l'utilisateur n'est pas connecté, on lui demande de se connecter d'abord ! -->
				<p>Connectez-vous d'abord pour accèdez à cette page</p>
				<a class="nav-link text-dark" asp-area="" asp-page="/Index">Revenir à l'Acceuil</a>
			    }
			}



	```	
			
 - 'home.cshtml.cs' est le backend, qui est reposnable de l'envoie des données geoJSON vers la page 'POImanager/Create'.  
			
			
```csharp
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Threading.Tasks;
		using Microsoft.AspNetCore.Mvc;
		using Microsoft.AspNetCore.Mvc.RazorPages;

		using GeoBAM.Data;

		using System.ComponentModel.DataAnnotations;
		using System.ComponentModel.DataAnnotations.Schema;
		using System.Web;

		using Microsoft.AspNetCore.Authentication;
		using Microsoft.AspNetCore.Authorization;
		using System.Security.Claims;



		namespace GeoBAM.Pages
		{
		    // On ajoute Authorize pour securiser l'acces à cette page (home)
		    [Authorize]
		    public class homeModel : PageModel
		    {
			[BindProperty]
			public InputModel Input { get; set; }
			public class InputModel
			{
			    [Required]
			    [StringLength(1000, ErrorMessage = "Vous ne pouvez pas ajouter un point vide, prière de séléctionner un Point", MinimumLength = 1)]
			    [Display(Name = "DataType ")]
			    public string DataType { get; set; }



			    public string latitude { get; set; }
			    [Required]
			    [StringLength(100000000, ErrorMessage = "Vous ne pouvez pas ajouter un point vide, prière de séléctionner un Point.", MinimumLength = 1)]
			    [Display(Name = "geoJson ")]

			    public string geoJson { get; set; }
			}

			public void OnGet()
			{
			}



			}
		    }





```
			
- La page 'Index' est la première page qui se charge. Elle doit afficher un contenu adaptif. Lorsque l'utilisateur n'est pas connecté, on lui affiche un boutton  
  qui le redirige vers la page de connexion, sinon on lui affich un menu de navigation.
  - 'Index.cshtml'  
			
	```html
			@page
			@model IndexModel

			@{
			    ViewData["Title"] = "Acceuil";
			//On élimine la partie de html commune à toutes les pages, vu qu'on veut pas afficher la barre de menu.
			    Layout = null;
			}



			<!------ Include the above in your HEAD tag ---------->


			<!DOCTYPE html>
			<html lang="en">
			<head>
				<!--Appel au bootsratp-->
			    <meta charset="utf-8" />
			    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
			    <title>@ViewData["Title"] - GeoBAM</title>
			    <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
			    <link rel="stylesheet" href="~/css/site.css" />
			    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">

			    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
			    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
			</head>
			<body>
			    <!-- On ajoute une barre de navigation avec logo BAM -->
			    <nav class="navbar navbar-light bg-light">
				<a class="navbar-brand" href="#">
				    <img src="~/lib/geoBAMlogo.png" width="30" height="30" class="d-inline-block align-top" alt="">
				    GéoBAM
				</a>
			    </nav>

			    @{
					//Si l'utilisateur est connecté!
				if (User.Identity.IsAuthenticated)
				{
				<div class="container col-5 col col-sm-6 align-self-center">

				    <h4 style="text-align:center; width:100%; margin-bottom:10%;">Acceuil</h4>

				    <a class="btn  btn-dark " style="width:100%;" role="button" asp-page="/home">Ajouter un point</a>
				    <a class="btn  btn-dark " style="width:100%; margin-top:5%; " role="button" asp-page="/POImanager/Index">Voir mes points</a>
				    @foreach( var claim in User.Claims)
				    {//Si l'utilisateur est un administrateur, on ajout le boutton "Gérer les utilisateurs au menu 
					if (claim.Value == "administrateur") {
					<a class="btn  btn-dark " style="width: 100%; margin-top: 5%; " role="button" asp-page="/UserManager/Index">Gérer les utilisateurs</a>
					}
				    }
				    <a class="btn  btn-danger " style="width: 100%; margin-top: 5%; " role="button" asp-page="/Logout">Logout</a>

				</div>
				}
				else
				{//Si l'utilisateur n'est pas connecté, on lui demande de se connecter.
				    <div class="container col-5 col col-sm-6 align-self-center">

					<a class="nav-link text-dark" asp-area="" asp-page="/login">
					    <a class="btn  btn-success " style="width:100%; " role="button" asp-page="/login"> Se connnecter </a>

					</a>

				    </div>
				}
			    }




			</body>
			<footer class="border-top footer text-muted">
			    <div class="container">
				&copy; 2021 - GéoBAM - <a asp-area="" asp-page="/Privacy">Confidentialité</a>
			    </div>
			</footer>
			</html>


	```		
- La page 'Login' est la page de connexion, qui prend les données saisies (email, mot de passe) et cherche dans la table Users. Si les coordonées sont correctes on laisse passer vers la page d'acceuil.
  - 'login.cshtml':  

	```html
		@page
		@model LoginModel

		@{
		    ViewData["Title"] = "Se connecter";
			//On élimine la partie de html commune à toutes les pages, vu qu'on veut pas afficher la barre de menu.
		    Layout = null;
		}



		<!------ Include the above in your HEAD tag ---------->


		<!DOCTYPE html>
		<html lang="en">
		<head>
		    <meta charset="utf-8" />
		    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
		    <title>@ViewData["Title"] - GeoBAM</title>
		    <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
		    <link rel="stylesheet" href="~/css/site.css" />
		    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">

		    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
		    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
		</head>
		<body>
		    <!-- Image and text -->
		    <nav class="navbar navbar-light bg-light">
			<a class="navbar-brand" href="#">
			    <img src="~/lib/geoBAMlogo.png" width="30" height="30" class="d-inline-block align-top" alt="">
			    GéoBAM
			</a>
		    </nav>



		    <div class="wrapper fadeInDown">
			<div id="formContent">
			    <!-- Tabs Titles -->
			    <!-- Icon -->
			    <div class="fadeIn first">
				<img src="~/lib/person-circle.svg" id="Usericon" alt="User Icon" />
			    </div>

			    <!-- Formulaire de connexion -->

			    <div class="row">
				<div class="container col-5 col col-sm-6 align-self-center">
				    <section>
					<form id="account" method="post">
					    <h4>Utilisez vos coordonnées pour se connecter</h4>
					    <hr />
					    <div asp-validation-summary="All" class="text-danger"></div>
					    <div class="form-group">
						<label asp-for="Input.Email">Email</label>
						<input asp-for="Input.Email" class="form-control" />
						<span asp-validation-for="Input.Email" class="text-danger"></span>
					    </div>
					    <div class="form-group">
						<label asp-for="Input.Password">Mot de Passe</label>
						<input asp-for="Input.Password" class="form-control" />
						<span asp-validation-for="Input.Password" class="text-danger"></span>
					    </div>
					    <div class="form-group">
						<button type="submit" style="width: 100%;  " class="btn btn-success">Se connecter</button>
					    </div>
					</form>
				    </section>
				</div>
			    </div>


			    <!-- Mot de passe oublié : actuellement cette fonctionnalité n'est pas disponible-->
			    <div id="formFooter">
				<a class="underlineHover" >Mot de passe oublié?</a>
			    </div>

			</div>
		    </div>
		</body>
		<footer class="border-top footer text-muted">
		    <div class="container">
			&copy; 2021 - GéoBAM - <a asp-area="" asp-page="/Privacy">Confidentialité</a>
		    </div>
		</footer>
		</html>
	
	```

 -'Login.cshml.cs' est le backend qui est chargé de vérifier la correspondance entre les coordonées saisies et la table Users.  
			
			
```csharp
		using Microsoft.AspNetCore.Mvc;
		using Microsoft.AspNetCore.Mvc.RazorPages;
		using Microsoft.Extensions.Logging;
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Threading.Tasks;
		using Microsoft.AspNetCore.Http;

		using System.ComponentModel.DataAnnotations;
		using GeoBAM.Data;

		using Microsoft.AspNetCore.Authentication;
		using Microsoft.AspNetCore.Mvc;
		using Microsoft.AspNetCore.Authorization;
		using Microsoft.AspNetCore.Identity;
		using System.Threading.Tasks;
		using System.Security.Claims;
		using Identity.Email;
		using System.ComponentModel.DataAnnotations;

		using System.Security.Claims;
		using Microsoft.AspNetCore.Authentication.Cookies;
		using Microsoft.AspNetCore.Authorization;
		using Microsoft.AspNetCore.Identity;

		namespace GeoBAM.Pages
		{
		    [AllowAnonymous] //La page de connexion est accessible avant authentification, chose qui est naturelle.
		    public class LoginModel : PageModel
		    {
			private readonly ILogger<IndexModel> _logger;

			//on appelle le contexte de données, puisque on aura un échange avec la base de données
			private readonly ApplicationDbContext Db;




			//constructeur du model
			public LoginModel(ApplicationDbContext Db)
			{
			    this.Db = Db;

			}
			
			//On ajoute une instance de la classe InpuModel. qu'on détaiilera par la suite
			[BindProperty]
			public InputModel Input { get; set; }

			public string ReturnUrl { get; set; }
		
			/la classe InputModel pour pouvoir lire les données saisies.
			public class InputModel
			{
			    [Required]
			    [EmailAddress]
			    public string Email { get; set; }

			    [Required]
			    [DataType(DataType.Password)]
			    public string Password { get; set; }


			}

			public async Task OnGetAsync(string returnUrl = null)
			{
			    returnUrl ??= Url.Content("~/");
			    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

			    ReturnUrl = returnUrl;
			}

			public async Task<IActionResult> OnPostAsync(string returnUrl = null)
			{
			    returnUrl ??= Url.Content("~/");
			// Si le modèle est valide.
			    if (ModelState.IsValid)
			    {	//on cherche l'utilisateur dans la table ayant l'adresse et le mot de passe saisis.
				var user = Db.Users.Where(f => f.Email == Input.Email && f.Password == Input.Password).FirstOrDefault();
				//S'il n'existe pas On  retourne un message d'erreur
				if (user == null)
				{
				    ModelState.AddModelError(string.Empty, "Email oubien mot de passe incorrect");
				    return Page();
				}
				//Sinon on se connecte et on crée une session
				var claims = new List<Claim>
				{
				    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
				    new Claim(ClaimTypes.Name, user.Email),
				    new Claim(ClaimTypes.Role, user.Role),
				    new Claim("UserDefined", "whatever"),
				};

				var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				var principal = new ClaimsPrincipal(identity);

				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
					principal,
					new AuthenticationProperties { IsPersistent = true });



				return LocalRedirect(returnUrl);
			    }

			    return Page();
			}


		    }
		}
	
```
- Et finalement la page Logout, qui permet à l'utilisateur de se déconnecter.
 -'Logout.cshtml':

	```html
		@page
		@model GeoBAM.Pages.LogoutModel
		@{      if(!User.Identity.IsAuthenticated){
			//Si l'utilisateur a été déja deconnecté , on affiche plus la barre de navigation.
			Layout = null;
			ViewData["Title"] = "Se déconnecter";
		    }
		    ViewData["Title"] = "Redirigé vers l'Acceuil";
		}
		<header>
		    <h1>@ViewData["Se déconnecter"]</h1>
		    @{
			if (User.Identity.IsAuthenticated)
			{//Si l'utilisateur est encore connecté on affiche un lien pour se deconnecter
			    <form class="form-inline" asp-area="Identity" asp-page="/Account/Logout" asp-route-returnUrl="@Url.Page("/", new { area = "" })" method="post">
				<button type="submit" class="nav-link btn btn-link text-dark">Cliquez ici pour se déconnecter</button>
			    </form>
			    <table class="table table-sm">
				@foreach (var claim in User.Claims)
				{
				    <tr>
					<td>@claim.Type</td>
					<td>@claim.Value</td>

				    </tr>
				}
			    </table>
			}
			else
			{ //S'il est deja deconnecté on lui demande de revenir vers l'acceuil (Index).
			    <p>Vous vous etes déconnecté avec succès! </p>
			    <a class="nav-link text-dark" asp-area="" asp-page="/Index">Revenir à l'Acceuil</a>
			}
		    }

		</header>
	
			
	```
  -'Logout.cshtml.cs' est responsable de la terminaison de la session courante:
```csharp
			using System;
			using System.Collections.Generic;
			using System.Linq;
			using System.Threading.Tasks;
			using Microsoft.AspNetCore.Authentication;
			using Microsoft.AspNetCore.Authentication.Cookies;
			using Microsoft.AspNetCore.Authorization;
			using Microsoft.AspNetCore.Identity;
			using Microsoft.AspNetCore.Mvc;
			using Microsoft.AspNetCore.Mvc.RazorPages;
			using Microsoft.Extensions.Logging;

			namespace GeoBAM.Pages
			{
			    [AllowAnonymous]
			    public class LogoutModel : PageModel
			    {


				public LogoutModel(ILogger<LogoutModel> logger)
				{

				}

				public void OnGet()
				{
				}

				public async Task<IActionResult> OnPost(string returnUrl = null)
				{
			//On désactive la session.
				    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
				    if (returnUrl != null)
				    {
					return LocalRedirect(returnUrl);
				    }
				    else
				    {
					return RedirectToPage();
				    }
				}
			    }
			}

```

			
## Déploiment de l'application:
Pour déployer l'application GéoBAM sur un serveur prenant en charge ASP.NET, il suffit de suivre les étapes suivante: 
### Etape 1:  Préparer une base de données:
La préparation d'une base de données est primordial. Vous devez créer une base de doonées en s'apppuyant sur le fichier de backup GeoBAMDB.bak dont on a parlé précédemment.
Ensuite il faut générer la chaine de connexion spécifique à cette base de données pour pouvoir lier le projet avec cette DB.

### Etape2: 
 Ouvrir MS VS 2019, allez vers *Solution Explorer* et cliquez droit sur GeoBAM: cliquez sur *Publish* 
			
![screen](https://github.com/isbainemohamed/GeoBAM/blob/master/image7.gif).

Ensuite, il suffit de choisir le mode d'hébergement.Dans notre cas, on choisira un serveur ftp: 
Une nouvelle fenetre s'ouvre comme suit: 
![screen](https://github.com/isbainemohamed/GeoBAM/blob/master/publish%20ftp.png).
			
Il suffit de remplir des informations sur le serveur d'accueil et cliquer sur *save*: 
à ce moment là, on doit assurer la connexion avec la nouvelle base de données sur le serveur. Cette opération consiste à passer en parametre la chaine de connexion dont on a parlé durant l'étape1: 
			
![screen](https://github.com/isbainemohamed/GeoBAM/blob/master/pulis%20connection%20string.png). 
 Et finalement, il est temps de publier le site web en cliquant sur publish: 

 Notre site maintenant est bien hébérgé !
			
## webographie
* StackOverflow
* Github/Leaflet
* CsharpCorner
* Learn Razor Pages
* Documentation officielle de microsoft





## License
<h1>GéoBAM-2021<h1>
