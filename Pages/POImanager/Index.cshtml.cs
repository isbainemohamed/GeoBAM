using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeoBAM.Data;
using System.Security.Claims;

namespace GeoBAM.Pages.POImanager
{
    public class IndexModel : PageModel
    {
        private readonly GeoBAM.Data.ApplicationDbContext _context;

        public IndexModel(GeoBAM.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        //
        public IList<GeoJSONData> POIsData = new List<GeoJSONData>();
        public string Role { get; set; }
        public async Task OnGetAsync()
        {
            var IsAdmin = User.IsInRole("administrateur");
            var role = User.FindFirst(ClaimTypes.Role).Value;
            Role= User.FindFirst(ClaimTypes.Role).Value;


            if (role != null && role == "administrateur")
            {

                POIsData = await _context.AddedData.ToListAsync();
            }
            else
            {
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
        //
        //public IList<GeoJSONData> GeoJSONData { get;set; }

        /*public async Task OnGetAsync()
        {
            GeoJSONData = await _context.AddedData.ToListAsync();
        }*/
    }
}

