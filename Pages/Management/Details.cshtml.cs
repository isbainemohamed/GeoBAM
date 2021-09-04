using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeoBAM.Data;

namespace GeoBAM.Pages.Management
{
    public class DetailsModel : PageModel
    {
        private readonly GeoBAM.Data.ApplicationDbContext _context;

        public DetailsModel(GeoBAM.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public GeometricPoint GeometricPoint { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GeometricPoint = await _context.AddedPoints.FirstOrDefaultAsync(m => m.pointID == id);

            if (GeometricPoint == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
