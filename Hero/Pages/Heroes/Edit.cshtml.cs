using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hero.Data;
using Hero.Entities;

namespace Hero.Pages.Heroes
{
    public class EditModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public EditModel(Hero.Data.HeroContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HeroE).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeroEExists(HeroE.HeroEId))
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

        private bool HeroEExists(Guid id)
        {
            return _context.Hero.Any(e => e.HeroEId == id);
        }
    }
}
