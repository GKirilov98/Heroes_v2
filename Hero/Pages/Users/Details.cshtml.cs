using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hero.Data;
using Hero.Entities;

namespace Hero.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public DetailsModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User
                .Include(u=> u.HeroE)
                .FirstOrDefaultAsync(m => m.UserId == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
