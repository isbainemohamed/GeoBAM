using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GeoBAM.Data;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace GeoBAM.Pages.UserManager
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly GeoBAM.Data.ApplicationDbContext _context;

        public DetailsModel(GeoBAM.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
