using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hero.Data;
using Hero.Entities;

namespace Hero.Pages.Items
{
    public class DeleteModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public DeleteModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Item
                .Include(i => i.Slot).FirstOrDefaultAsync(m => m.ItemId == id);

            if (Item == null)
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

            Item = await _context.Item.FindAsync(id);
            


            if (Item != null)
            {
                List<HeroItem> heroItems = await _context.HeroItem
                            .Where(hi => hi.ItemId.Equals(id))
                            .ToListAsync();
                ISet<Guid> heroesGuid = heroItems.Select(hi => hi.HeroEId).ToHashSet();
                List<HeroE> heroEs = await _context.Hero
                            .Where(h => heroesGuid.Contains(h.HeroEId))
                            .ToListAsync();
                heroEs.ForEach(h =>
                {
                    h.Attack -= Item.Attack;
                    h.Deffence -= Item.Defence;
                    h.Stamina -= Item.Stamina;
                    h.Strength -= Item.Strength;
                    _context.Attach(h).State = EntityState.Modified;
                });


                heroItems.ForEach(hi =>
                {
                    _context.HeroItem.Remove(hi);
                });
                _context.Item.Remove(Item);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
