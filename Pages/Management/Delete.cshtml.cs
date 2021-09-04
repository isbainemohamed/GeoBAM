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
    public class DeleteModel : PageModel
    {
        private readonly GeoBAM.Data.ApplicationDbContext _context;

        public DeleteModel(GeoBAM.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GeometricPoint = await _context.AddedPoints.FindAsync(id);

            if (GeometricPoint != null)
            {
                _context.AddedPoints.Remove(GeometricPoint);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
