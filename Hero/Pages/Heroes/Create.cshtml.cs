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

namespace Hero.Pages.Heroes
{
    public class CreateModel : PageModel
    {
        private readonly Hero.Data.HeroContext _context;

        public CreateModel(Hero.Data.HeroContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HeroE HeroE { get; set; }

        //public new IList<User> User { get; set; }
        public new User User { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            HeroE.Attack = 1;
            HeroE.Deffence = 1;
            HeroE.Level = 1;
            HeroE.Strength = 1;
            HeroE.Stamina = 1;
            //HeroE.UserId = Program.currUser.UserId;
            _context.Hero.Add(HeroE);
            await _context.SaveChangesAsync();
            IList<HeroE> heroList = await _context.Hero.ToListAsync();

            //HeroE currHero;
            //try
            //{
            //    currHero = heroList.Where(h => h.UserId.Equals(Program.currUser.UserId))
            //   .First();
            //}
            //catch (InvalidOperationException exp)
            //{
            //    Console.WriteLine(exp.Message);
            //    return Page();
            //}




            //
            if (Program.currUser.UserId == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.UserId == Program.currUser.UserId);

            if (User == null)
            {
                return NotFound();
            }
            //


            User.HeroEId = HeroE.HeroEId;
            _context.Attach(User).State = EntityState.Modified;


            await _context.SaveChangesAsync();

            Program.currHero = HeroE;
            Program.currUser.HeroEId = HeroE.HeroEId;
            return RedirectToPage("/Index");
        }
    }
}
