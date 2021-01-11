using Hero.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.Pages
{
    public class IndexModel : PageModel
    {
        
        private readonly Hero.Data.HeroContext _context;
        public IndexModel( Hero.Data.HeroContext context)
        {
            _context = context;
            
        }

        public IList<HeroE> Heroes { get; set; }
        public  void OnGet()
        {
            if (Program.currHero != null)
            {
                Heroes =  _context.Hero
                    .Where(h => !h.HeroEId.Equals(Program.currHero.HeroEId))
                    .ToList();
                Console.WriteLine();
            }
        }
    }
}
