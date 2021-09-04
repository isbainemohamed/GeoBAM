using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeoBAM.Data;

namespace GeoBAM.Pages.Management
{
    public class EditModel : PageModel
    {
        private readonly GeoBAM.Data.ApplicationDbContext _context;

        public EditModel(GeoBAM.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GeometricPoint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeometricPointExists(GeometricPoint.pointID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GeometricPointExists(int id)
        {
            return _context.AddedPoints.Any(e => e.pointID == id);
        }
    }
}
