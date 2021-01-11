using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hero.Data;
using Hero.Entities;

namespace Hero.Pages.HeroItems
{
    public class DetailsModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public DetailsModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
