using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hero.Entities;

namespace Hero.Data
{
    public class HeroContext : DbContext
    {
        public HeroContext (DbContextOptions<HeroContext> options)
            : base(options)
        {
        }

        public DbSet<Hero.Entities.User> User { get; set; }
        public DbSet<Hero.Entities.Slot> Slot { get; set; }

        public DbSet<Hero.Entities.HeroE> Hero { get; set; }
        public DbSet<Hero.Entities.HeroItem> HeroItem { get; set; }

        public DbSet<Hero.Entities.Item> Item { get; set; }
    }
}
