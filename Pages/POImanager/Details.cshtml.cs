using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeoBAM.Data;

namespace GeoBAM.Pages.POImanager
{
    public class DetailsModel : PageModel
    {
        private readonly GeoBAM.Data.ApplicationDbContext _context;

        public DetailsModel(GeoBAM.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public GeoJSONData GeoJSONData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GeoJSONData = await _context.AddedData.FirstOrDefaultAsync(m => m.pointID == id);

            if (GeoJSONData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
