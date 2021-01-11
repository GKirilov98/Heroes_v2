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
    public class IndexModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public IndexModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get; set; }
        public IList<Item> BuyedHeroItems { get; set; }
        public IQueryable<HeroItem> usedItems { get; set; }
        public async Task OnGetAsync()
        {
            Item = await _context.Item
                .Include(i => i.Slot)
                .ToListAsync();

            ISet<String> usedSlots = new HashSet<String>();
            usedItems = _context.HeroItem
                .Where(hi => hi.HeroEId.Equals(Program.currHero.HeroEId));

            foreach (var hi in usedItems)
            {
                usedSlots.Add(hi.Item.Slot.Name);
            }

            HashSet<Guid> usedItemsId = usedItems.Select(hi => hi.ItemId).ToHashSet();

            BuyedHeroItems = Item
                .Where(i => usedSlots.Contains(i.Slot.Name) || usedItemsId.Contains(i.ItemId))
                .ToList();
        }


        [BindProperty]
        public new HeroItem HeroItem { get; set; }
        public HeroE HeroE { get; set; }
        public async Task<IActionResult> OnPostAsync(Guid? id)
        {

            HeroE = await _context.Hero.FirstOrDefaultAsync(m => m.HeroEId == Program.currHero.HeroEId);
            try
            {
                Guid itemId = Guid.Parse(Request.Form["buyItem"]);
                HeroItem.ItemId = itemId;
                HeroItem.HeroEId = Program.currHero.HeroEId;
                _context.HeroItem.Add(HeroItem);

                Item item = await _context.Item.FirstOrDefaultAsync(i => i.ItemId == itemId);
                HeroE.Stamina += item.Stamina;
                HeroE.Strength += item.Strength;
                HeroE.Attack += item.Attack;
                HeroE.Deffence += item.Defence;
            }
            catch (ArgumentNullException)
            {
                Guid heroItemId = Guid.Parse(Request.Form["sellItem"]);
                var HeroItemDelete = await _context.HeroItem.FindAsync(heroItemId);
                Item item = await _context.Item.FirstOrDefaultAsync(i => i.ItemId == HeroItemDelete.ItemId);
                HeroE.Stamina -= item.Stamina;
                HeroE.Strength -= item.Strength;
                HeroE.Attack -= item.Attack;
                HeroE.Deffence -= item.Defence;
                if (HeroItemDelete != null)
                {
                    _context.HeroItem.Remove(HeroItemDelete);
                }
            }

            _context.Attach(HeroE).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            Program.currHero = HeroE;
            return RedirectToPage("./Index");
        }
    }
}
