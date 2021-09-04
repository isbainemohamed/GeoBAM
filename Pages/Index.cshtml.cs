using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using System.ComponentModel.DataAnnotations;
using GeoBAM.Data;

using Microsoft.AspNetCore.Authentication;


using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace GeoBAM.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        

        public void OnGet()
        {
            
        }



    }
}
