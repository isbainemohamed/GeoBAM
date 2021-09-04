using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GeoBAM.Data;

namespace GeoBAM.Pages.Management
{
    public class CreateModel : PageModel
    {
        private readonly GeoBAM.Data.ApplicationDbContext _context;

        public CreateModel(GeoBAM.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GeometricPoint GeometricPoint { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AddedPoints.Add(GeometricPoint);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
