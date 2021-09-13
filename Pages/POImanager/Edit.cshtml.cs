using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeoBAM.Data;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace GeoBAM.Pages.POImanager
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly GeoBAM.Data.ApplicationDbContext _context;

        public EditModel(GeoBAM.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GeoJSONData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeoJSONDataExists(GeoJSONData.pointID))
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

        private bool GeoJSONDataExists(int id)
        {
            return _context.AddedData.Any(e => e.pointID == id);
        }
    }
}
