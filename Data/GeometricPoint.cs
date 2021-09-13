using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GeoBAM.Data
{

    public class GeometricPoint
    {
        [Key]
        public int pointID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public string Type { get; set; }
        public DateTime DatePrelevement { get; set; }
        public string ID_Operateur { get; set; }
        
    }
}
