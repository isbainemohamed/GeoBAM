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
    public class MyPointsModel : PageModel
    {
        private  ApplicationDbContext Db;
       
        public string Address { get; set; }

        
        public string Longitude { get; set; }

        
        public string Latitude { get; set; }

       
        public string Type { get; set; }
       
        public string City { get; set; }

        
        public DateTime DatePrelevement { get; set; } 

        EnvironmentVariableTarget query { get; set; }
        
        public string ID_Operateur { get; set; }
        public List<GeometricPoint> Points = new List<GeometricPoint>();


        public MyPointsModel(ApplicationDbContext Db)
        {
            this.Db = Db;

        }

        public async Task OnGetAsync()
        {
            if (ModelState.IsValid)
            {
                var query = from pt in Db.AddedPoints
                            where pt.ID_Operateur == User.FindFirst(ClaimTypes.NameIdentifier).Value
                            select pt;
                foreach( GeometricPoint pt in query)
                {if (pt != null)
                    {
                        Points.Add(pt);
                    }
                }
               /* var identifiant= User.FindFirst(ClaimTypes.NameIdentifier).Value;
                Points = await Db.AddedPoints.Where(f => f.ID_Operateur == identifiant);
                Points = new List<GeometricPoint> { };
                Input.ID_Operateur = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                Points = Db.AddedPoints.Where(f => f.ID_Operateur == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault();
                if (point != null)
                {
                    ModelState.AddModelError(string.Empty, "Le point d'adresse de coordonnées (" + Input.Longitude + "," + Input.Latitude + ") existe déja !");
                }
                else
                {
                    point = new GeometricPoint { Address = Input.Address, City = Input.City, Longitude = Input.Longitude, Latitude = Input.Latitude, Type = Input.Type, ID_Operateur = Input.ID_Operateur, DatePrelevement = Input.DatePrelevement };
                    Db.AddedPoints.Add(point);
                    await Db.SaveChangesAsync();
                    return RedirectToPage("home");
                }
               */
            }
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = await Db.AddedPoints.FindAsync(id);
            if (book == null)
            {
                return NotFound();

            }
            Db.AddedPoints.Remove(book);
            await Db.SaveChangesAsync();

            return RedirectToPage("Ind");
        }


    }
}

