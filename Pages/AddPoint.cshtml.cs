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

namespace GeoBAM.Pages
{
    public class AddPointModel : PageModel
    {
        

        private readonly ApplicationDbContext Db;

        public AddPointModel(ApplicationDbContext Db)
        {
            this.Db = Db;
            
        }
       


        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {

            
            [Required]
            [StringLength(1000, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
            [Display(Name = "Adress ")]
            public string Address { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
            
            [Display(Name = "Longitude")]
            public string Longitude { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]

            [Display(Name = "Latitude")]
            public string Latitude { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]

            [Display(Name = "Type")]
            public string Type { get; set; }
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]

            [Display(Name = "City")]
            public string City { get; set; }

            [Required]
            [DataType(DataType.DateTime)]
            [DisplayFormat(DataFormatString ="yyyy/MM/dd HH:mm:ss", ApplyFormatInEditMode =true)]
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

            if (ModelState.IsValid)
            {
                Input.ID_Operateur= User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var point = Db.AddedPoints.Where(f => f.Longitude == Input.Longitude && f.Latitude == Input.Latitude).FirstOrDefault();
                if (point != null)
                {
                    ModelState.AddModelError(string.Empty, "Le point d'adresse de coordonnées ("+Input.Longitude +","+Input.Latitude+") existe déja !");
                }
                else
                {
                    point = new GeometricPoint {  Address=Input.Address,City=Input.City, Longitude=Input.Longitude, Latitude=Input.Latitude, Type=Input.Type,ID_Operateur =Input.ID_Operateur, DatePrelevement=Input.DatePrelevement };
                    Db.AddedPoints.Add(point);
                    await Db.SaveChangesAsync();
                    return RedirectToPage("home");
                }

            }

            return Page();
        }
    }
}
