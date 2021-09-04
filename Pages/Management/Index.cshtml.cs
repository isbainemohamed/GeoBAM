using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeoBAM.Data;
using System.Security.Claims;

namespace GeoBAM.Pages.Management
{
    public class IndexModel : PageModel
    {
        private readonly GeoBAM.Data.ApplicationDbContext _context;

        public IndexModel(GeoBAM.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        
        //public IList<GeometricPoint> GeometricPoint { get; set; }
        public IList<GeometricPoint> GeometricPoint = new List<GeometricPoint>();
        public async Task OnGetAsync()
        {
            var IsAdmin = User.IsInRole("administrateur");
            var role = User.FindFirst(ClaimTypes.Role).Value;

            
                if (role != null && role == "administrateur")
                {

                    GeometricPoint = await _context.AddedPoints.ToListAsync();
                }
                else
                {
                    var query = from pt in _context.AddedPoints
                                where pt.ID_Operateur == User.FindFirst(ClaimTypes.NameIdentifier).Value
                                select pt;
                    foreach (GeometricPoint pt in query)
                    {
                        if (pt != null)
                        {
                            GeometricPoint.Add(pt);
                        }


                    }
                }
            }
                }
            }
        
   
