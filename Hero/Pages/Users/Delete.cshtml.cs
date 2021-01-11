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
    public class DeleteModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public DeleteModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        [BindProperty]
        public new User User { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.UserId == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FindAsync(id);

            if (User != null)
            {
                HeroE hero = await _context.Hero
                    .Where(h => h.HeroEId.Equals(User.HeroEId))
                    .FirstAsync();
                if (hero != null)
                {
                    List<HeroItem> heroItems = await _context.HeroItem
                            .Where(hi => hi.HeroEId.Equals(hero.HeroEId))
                            .ToListAsync();
                    heroItems.ForEach(hi =>
                    {
                        _context.HeroItem.Remove(hi);
                    });

                    _context.Hero.Remove(hero);
                }

                _context.User.Remove(User);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
