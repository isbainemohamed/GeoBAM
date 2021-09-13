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
    // On ajoute Authorize pour securiser l'acces à cette page (/Usermanager/Index)
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly GeoBAM.Data.ApplicationDbContext _context;

        public IndexModel(GeoBAM.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }

    }
}
