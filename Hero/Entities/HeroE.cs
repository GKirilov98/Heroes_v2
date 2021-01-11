using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.Entities
{
    public class HeroE
    {
        public Guid HeroEId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Level { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Attack { get; set; }
        public int Deffence { get; set; }
        public List<HeroItem> Inventory { get; set; }

        //public Guid UserId { get; set; }
        //public User User { get; set; }
    }

    public enum Gender
    {
        Male, Female
    }
}
