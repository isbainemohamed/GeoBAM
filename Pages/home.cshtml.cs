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


