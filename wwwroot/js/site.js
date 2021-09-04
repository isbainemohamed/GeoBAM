/*
        //On déclare deux variables globales Longitude et Latitude:
var longitude;
var latitude;
sessionStorage.setItem("latitude", latitude);
sessionStorage.setItem("longitude", longitude);
    
var villes = {
    "Paris": { "lat": 48.852969, "lon": 2.349903 },
    "Brest": { "lat": 48.383, "lon": -4.500 },
    "Quimper": { "lat": 48.000, "lon": -4.100 },
    "Bayonne": { "lat": 43.500, "lon": -1.467 }
};
var tableauMarqueurs = [];

// On initialise la carte
var carte = L.map('maCarte').setView([48.852969, 2.349903], 13);

// On charge les "tuiles"
L.tileLayer('https://{s}.tile.openstreetmap.fr/osmfr/{z}/{x}/{y}.png', {
    // Il est toujours bien de laisser le lien vers la source des données
    attribution: 'données © <a href="//osm.org/copyright">OpenStreetMap</a>/ODbL - rendu <a href="//openstreetmap.fr">OSM France</a>',
    minZoom: 1,
    maxZoom: 20
}).addTo(carte);

var marqueurs = L.markerClusterGroup();

// On personnalise le marqueur
var icone = L.icon({
    iconUrl: "images/icone.png",
    iconSize: [50, 50],
    iconAnchor: [25, 50],
    popupAnchor: [0, -50]
})

// On parcourt les différentes villes
for (ville in villes) {
    // On crée le marqueur et on lui attribue une popup
    var marqueur = L.marker([villes[ville].lat, villes[ville].lon], { icon: icone }); //.addTo(carte); Inutile lors de l'utilisation des clusters
    marqueur.bindPopup("<p>" + ville + "</p>");
    marqueurs.addLayer(marqueur); // On ajoute le marqueur au groupe

    // On ajoute le marqueur au tableau
    tableauMarqueurs.push(marqueur);
}
// On regroupe les marqueurs dans un groupe Leaflet
var groupe = new L.featureGroup(tableauMarqueurs);

// On adapte le zoom au groupe
carte.fitBounds(groupe.getBounds().pad(0.5));

carte.addLayer(marqueurs);

var x = document.getElementById("demo");
var input = document.getElementById("test");
var lonng = document.getElementById("longitude1");
var latt = document.getElementById("latitude1");
function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition);
    } else {
        x.innerHTML = "Le service de Géolocalisation n'est pas deisponible sur ce navigateur";
    }
    document.getElementById("AjoutPoint").disabled = false;
}
function showPosition(position) {
    x.innerHTML = "Latitude: " + position.coords.latitude +
        "<br>Longitude: " + position.coords.longitude;
   
    // on change la vue dans la carte en passant en paramètre les coordonnées de l'utilisateur!
     carte.setView([position.coords.latitude, position.coords.longitude], 16),
        marker = L.marker([position.coords.latitude, position.coords.longitude]).addTo(carte),
        marker.bindPopup("<p>Vous etes là!</p>");
    //On prepare les données de localisation pour les envoyer vers la page d'Ajout!
    
    lonng.value = position.coords.longitude;
    latt.value = position.coords.latitude;


    var marker = null;
        carte.on('click', function (e) {
            if (marker !== null) {
                map.removeLayer(marker);
            }
            var coord = e.latlng;
            var lat = coord.lat;
            var lng = coord.lng;
            marker = L.marker([lat, lng]).addTo(carte);
            marker.bindPopup("<p>Your ID is " + lat + "<br>" + lng + "</p>").openPopup();
            document.getElementById("longitude1").value = lng;
            document.getElementById("latitude1").value = lat;

            console.log("You clicked the map at latitude: " + lat + " and longitude: " + lng);
        });

    L.circle(marker.getLatLng(), {
        color: 'red',
        fillColor: '#f03',
        fillOpacity: 0.2,
        radius: radiusInKm * 1000
    }).addTo(carte);
    
}

//





  */