using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hero.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Hero.Pages.Heroes
{
    public class FightModel : PageModel
    {

        private readonly Hero.Data.HeroContext _context;

        public FightModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        public HeroE attackHero { get; set; }
        public HeroE deffenceHero { get; set; }
        public int attackerPoints = 0;
        public int deffenderPoints = 0;

        public String winner { get; set; }
        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || Program.currHero == null)
            {
                return NotFound();
            }

            attackHero = await _context.Hero.FirstOrDefaultAsync(m => m.HeroEId == Program.currHero.HeroEId);
            deffenceHero = await _context.Hero.FirstOrDefaultAsync(m => m.HeroEId == id);


            attackerPoints = (attackHero.Attack + attackHero.Strength * 4);
            deffenderPoints = (deffenceHero.Deffence + deffenceHero.Stamina * 2);
            int figth = attackerPoints - deffenderPoints ;
            if (figth > 0)
            {
                attackHero.Level++;
                attackHero.Stamina += 5;
                attackHero.Strength += 5;
                _context.Attach(attackHero).State = EntityState.Modified;
                winner = attackHero.Name + " - winner";
                Program.currHero = attackHero;
            }
            else if (figth < 0)
            {
                deffenceHero.Level++;
                deffenceHero.Stamina += 5;
                deffenceHero.Strength += 5;
                _context.Attach(deffenceHero).State = EntityState.Modified;
                winner = deffenceHero.Name + " - winner";
            }
            else
            {
                winner = "DRAW";
            }

            await _context.SaveChangesAsync();
            return Page();
        }

    }
}
