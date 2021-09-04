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
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        //Création du modèle Input, pour pouvoir récupérer les données saisies dans le form!
        public class InputModel
        {

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
