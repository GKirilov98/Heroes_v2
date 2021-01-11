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
    public class DetailsModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public DetailsModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        public ISet<String> Slots { get; set; }
        public HeroE Hero { get; set; }
        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hero = await _context.Hero
                .Where(h => h.HeroEId.Equals(id))
                .FirstAsync();

            if (Hero == null)
            {
                return NotFound();
            }

            ISet<String> usedSlots = new HashSet<String>();
            var usedItems = await _context.HeroItem
                .Where(hi => hi.HeroEId.Equals(Hero.HeroEId))
                .Include(i => i.Item)
                .ThenInclude(i => i.Slot)
                .ToListAsync();

            foreach (var hi in usedItems)
            {
                usedSlots.Add(hi.Item.Slot.Name.ToLower());
            }

            Slots = usedSlots;
            return Page();
        }
    }
}
