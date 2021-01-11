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

namespace Hero.Pages.HeroItems
{
    public class EditModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public EditModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HeroItem HeroItem { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HeroItem = await _context.HeroItem
                .Include(h => h.HeroE)
                .Include(h => h.Item).FirstOrDefaultAsync(m => m.HeroItemId == id);

            if (HeroItem == null)
            {
                return NotFound();
            }
           ViewData["HeroEId"] = new SelectList(_context.Hero, "HeroEId", "HeroEId");
           ViewData["ItemId"] = new SelectList(_context.Item, "ItemId", "ItemId");
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

            _context.Attach(HeroItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeroItemExists(HeroItem.HeroItemId))
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

        private bool HeroItemExists(Guid id)
        {
            return _context.HeroItem.Any(e => e.HeroItemId == id);
        }
    }
}
