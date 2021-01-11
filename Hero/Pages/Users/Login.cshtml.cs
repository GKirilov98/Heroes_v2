using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hero.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
namespace Hero.Pages.Users
{
    public class LoginModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public LoginModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }
        public new IList<User> User { get; set; }
        public new IList<HeroE> heroEs { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            string username = Request.Form["Username"];
            string password = Request.Form["Password"];

            if (!ModelState.IsValid)
            {
                return Page();
            }

            User = await _context.User.ToListAsync();
            User currUser;
            try
            {
                currUser = User.Where(u => u.Username.ToLower().Equals(username.ToLower()) && u.Password.Equals(password))
               .First();
            } catch (InvalidOperationException exp)
            {
                Console.WriteLine(exp.Message);
                currUser = null;
                return Page();
            }

            if (currUser.HeroEId != null)
            {
                heroEs = await _context.Hero.ToListAsync();
                HeroE currHero;
                try
                {
                    currHero = heroEs.Where(h => h.HeroEId.Equals(currUser.HeroEId))
                   .First();
                }
                catch (InvalidOperationException exp)
                {
                    Console.WriteLine(exp.Message);
                    currUser = null;
                    return Page();
                }

                Program.currHero = currUser.HeroE;
            }

            Program.currUser = currUser;
            return RedirectToPage("/Index");
        }
    }
}
