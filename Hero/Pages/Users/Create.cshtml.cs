using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hero.Data;
using Hero.Entities;

namespace Hero.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public CreateModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public new User User { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            string username = Request.Form["Username"];  
            string email = Request.Form["Email"];  
            string password = Request.Form["Password"];  
            string confirmPass = Request.Form["confirmPassword"];  

            if (!ModelState.IsValid || !password.Equals(confirmPass))
            {
                return Page();
            }

            User.Username = username;
            User.Email = email;
            User.Password = password;

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Login");
        }
    }
}
