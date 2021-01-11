using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hero.Data;
using Hero.Entities;

namespace Hero.Pages.Heroes
{
    public class DeleteModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public DeleteModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HeroE HeroE { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeroE = await _context.Hero.FirstOrDefaultAsync(m => m.HeroEId == id);

            if (HeroE == null)
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

            HeroE = await _context.Hero.FindAsync(id);

            if (HeroE != null)
            {
                User user = await _context.User
                    .Where(u => u.HeroEId.Equals(HeroE.HeroEId))
                    .FirstOrDefaultAsync();
                user.HeroEId = null;
                _context.Attach(user).State = EntityState.Modified;
                _context.Hero.Remove(HeroE);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
