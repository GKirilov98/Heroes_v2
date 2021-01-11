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
    public class IndexModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public IndexModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        public IList<HeroE> HeroE { get;set; }

        public async Task OnGetAsync()
        {
            HeroE = await _context.Hero.ToListAsync();
        }
    }
}
