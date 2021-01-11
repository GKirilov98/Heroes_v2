using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hero.Data;
using Hero.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hero.Pages.Items
{
    public class CreateModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public CreateModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Item Item { get; set; }
        public new IList<Slot> slots { get; set; }
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            String slotName = Request.Form["slot"];
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            slots = await _context.Slot.ToListAsync();
            Slot currSlot;
            try
            {
                currSlot = slots.Where(s => s.Name.Equals(slotName))
               .First();
            }
            catch (InvalidOperationException )
            {
                return Page();
            }

            Item.SlotId = currSlot.SlotId;
            _context.Item.Add(Item);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
