using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hero.Pages.Users
{
    public class LogoutModel : PageModel
    {
       
        public IActionResult OnGet()
        {
            Program.ClearAll();
           return RedirectToPage("/Index");
        }
    }
}
