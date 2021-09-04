using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace GeoBAM.Data
{
    public class GeoJSONData
    {
        [Key]
        public int pointID { get; set; }                    //identifiant unique du POI !
        public string DataType { get; set; }                //Type du POI ( point, ligne, polygone, rectangle, cercle ..)
        public string Address { get; set; }                // Adresse complète
        public string City { get; set; }                //Pour indiquer la ville !
        
        public string PostalCode { get; set; }          //Indiquer le code postal
        public string GeoJSONdata { get; set; }         // Les données GeoJSON, seront stockées ici ( NB: la taille maximale du NVVARCHAR(MAX) peut atteindre 2GO, qui est donc largement suffisant pour stocker ses données)

        public string Type { get; set; }                //Pour préciser le type du POI (administration, local, terrain , agence ...)
        public DateTime DatePrelevement { get; set; }   //Date de prélévement du POI
        public string ID_Operateur { get; set; }        //L'identifiant de l'operateur ayant effectué le prélèvement

    }
}
